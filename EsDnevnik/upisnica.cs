using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EsDnevnik
{
    public partial class upisnica : Form
    {

        DataTable tabela;

        public upisnica()
        {
            InitializeComponent();
        }

        private void popuni_god()
        {
            SqlConnection veza = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from skolska_godina", veza);
            DataTable dtgodina = new DataTable();
            adapter.Fill(dtgodina);
            cmb_god.DataSource = dtgodina;
            cmb_god.ValueMember = "id";
            cmb_god.DisplayMember = "naziv";
            cmb_god.SelectedValue = 2;
        }

        private void popuni_odlj()
        {
            string godina = cmb_god.SelectedValue.ToString();
            SqlConnection veza = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select id,str(razred) + '-' + indeks as naziv from odeljenje Where godina_id =" + godina, veza);
            DataTable dtodlj = new DataTable();
            adapter.Fill(dtodlj);
            cmb_odelj.DataSource = dtodlj;
            cmb_odelj.ValueMember = "id";
            cmb_odelj.DisplayMember = "naziv";
         
        }

        private void popuni_uce()
        {
            
            SqlConnection veza = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select id, ime + prezime as naziv from osoba where uloga = 1", veza);
            DataTable dtuce = new DataTable();
            adapter.Fill(dtuce);
            cmb_uce.DataSource = dtuce;
            cmb_uce.ValueMember = "id";
            cmb_uce.DisplayMember = "naziv";

        }
        private void grid_populate()
        {
            SqlConnection veza = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("Select upisnica.id as id, ime + prezime as naziv, osoba.id as ucenik from upisnica join osoba on osoba_id = osoba.id where odeljenje_id = " + cmb_odelj.SelectedValue.ToString() , veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.Columns["ucenik"].Visible = false;
           
        }



        private void upisnica_Load(object sender, EventArgs e)
        {
            popuni_god();
            popuni_odlj();
            cmb_odelj.SelectedIndex = -1;
            cmb_uce.Enabled = false;
            textBox1.Enabled = false;

        }

        private void cmb_god_SelectedValueChanged(object sender, EventArgs e)
        {

            if(cmb_god.IsHandleCreated && cmb_god.Focused)
            {
                popuni_odlj();
                cmb_odelj.SelectedIndex = -1;
                
                while(dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);

                }
                textBox1.Text = "";


                cmb_uce.SelectedIndex = -1;
                cmb_uce.Enabled = false;

            }
            
        }

        private void cmb_odelj_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_odelj.IsHandleCreated && cmb_odelj.Focused)
            {
                popuni_uce();
                cmb_uce.Enabled = true;
                grid_populate();

            }

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int broj_sloga = dataGridView1.CurrentRow.Index;

                if (tabela.Rows.Count != 0 && broj_sloga >= 0)
                {
                    cmb_uce.SelectedValue = dataGridView1.Rows[broj_sloga].Cells["ucenik"].Value.ToString();
                    textBox1.Text = dataGridView1.Rows[broj_sloga].Cells["id"].Value.ToString();
                }

            }

            
        }

        private void btn_izmeni_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE upisnica SET");
            naredba.Append(" osoba_id = '" + cmb_uce.SelectedValue.ToString() + "' ");
            naredba.Append(" WHERE id = " + textBox1.Text);
            SqlConnection veza = Connection.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                grid_populate();

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
                throw;
            }

        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("insert into upisnica(odeljenje_id, osoba_id) VALUES(' ");
            naredba.Append(cmb_odelj.SelectedValue.ToString() + "','");
            naredba.Append(cmb_uce.SelectedValue.ToString() + "')");
            SqlConnection veza = Connection.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                grid_populate();

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
                throw;
            }
        }

        private void btn_izbrisi_Click(object sender, EventArgs e)
        {
            string naredba = "delete from upisnica where id = " + textBox1.Text;
            SqlConnection veza = Connection.Connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                grid_populate();

            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
                throw;
            }

        }
    }
}
