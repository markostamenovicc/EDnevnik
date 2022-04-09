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
    public partial class Raspodela : Form
    {
        DataTable raspodela_table;
        int rb = 0;

        public Raspodela()
        {
            InitializeComponent();
        }

        private void Load_data()
        {
            SqlConnection conn = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM raspodela", conn);
            raspodela_table = new DataTable();
            adapter.Fill(raspodela_table);
        }

        private void Raspodela_Load(object sender, EventArgs e)
        {
            Load_data();
            ComboChange();
        }

        private void ComboChange()
        {
            SqlConnection conn = Connection.Connect();
            SqlDataAdapter adapter;
            
            DataTable nastavnik, godina, predmet, odeljenje;
            adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", conn);
            godina = new DataTable();
            adapter.Fill(godina);

            nastavnik = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, ime + prezime as naziv FROM osoba WHERE uloga = 2", conn);
            adapter.Fill(nastavnik);

            odeljenje = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, STR(razred) + '-' + indeks as naziv FROM odeljenje", conn);
            adapter.Fill(odeljenje);

            predmet = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, naziv FROM predmet", conn);
            adapter.Fill(predmet);

            cmb_nastavnik.DataSource = nastavnik;
            cmb_nastavnik.ValueMember = "id";
            cmb_nastavnik.DisplayMember = "naziv";
                      


            cmb_godina.DataSource = godina;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";



            cmb_odeljenje.DataSource = odeljenje;
            cmb_odeljenje.ValueMember = "id";
            cmb_odeljenje.DisplayMember = "naziv";
            


            cmb_predmet.DataSource = predmet;
            cmb_predmet.ValueMember = "id";
            cmb_predmet.DisplayMember = "naziv";
            

            textBox1.Text = raspodela_table.Rows[rb]["id"].ToString();

            if (raspodela_table.Rows.Count == 0)
            {
                cmb_predmet.SelectedValue = -1;
                cmb_odeljenje.SelectedValue = 1;
                cmb_godina.SelectedValue = -1;
                cmb_nastavnik.SelectedValue = -1;


            }
            {
                cmb_predmet.SelectedValue = raspodela_table.Rows[rb]["predmet_id"];
                cmb_odeljenje.SelectedValue = raspodela_table.Rows[rb]["odeljenje_id"];
                cmb_godina.SelectedValue = raspodela_table.Rows[rb]["godina_id"];
                cmb_nastavnik.SelectedValue = raspodela_table.Rows[rb]["nastavnik_id"];
            }
            if (rb == 0)
            {
                btn_first.Enabled = false;
                btn_prev.Enabled = false;
            }
            else
            {
                btn_first.Enabled = true;
                btn_prev.Enabled = true;
            }
            if (rb == raspodela_table.Rows.Count - 1)
            {
                btn_last.Enabled = false;
                btn_next.Enabled = false;
            }
            else
            {
                btn_last.Enabled = true;
                btn_next.Enabled = true;
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            rb = 0;
            ComboChange();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            rb--;
            ComboChange();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            rb++; 
            ComboChange();

        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            rb = raspodela_table.Rows.Count - 1; ;
            ComboChange();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string command = "DELETE FROM raspodela WHERE id = " + textBox1.Text;

            SqlConnection connection = Connection.Connect();
            SqlCommand cmd = new SqlCommand(command.ToString(), connection);
            Boolean brisano = false;
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                brisano = true;
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            if (brisano)
            {
                Load_data();
                if (rb > 0)
                    rb--;
                ComboChange();
            }
            Load_data();
            rb = raspodela_table.Rows.Count - 1;
            ComboChange();
        }

        private void btn_chng_Click(object sender, EventArgs e)
        {
            StringBuilder cmd = new StringBuilder("UPDATE raspodela SET ");
            cmd.Append("godina_id = '" + cmb_godina.SelectedValue + "', ");
            cmd.Append("nastavnik_id = '" +cmb_nastavnik.SelectedValue + "', ");
            cmd.Append("predmet_id = '" + cmb_predmet.SelectedValue + "', ");
            cmd.Append("odeljenje_id = '" + cmb_odeljenje.SelectedValue + "' ");
            cmd.Append("WHERE id = " + textBox1.Text);

            SqlConnection connection = Connection.Connect();
            SqlCommand command = new SqlCommand(cmd.ToString(), connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            Load_data();
            ComboChange();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            StringBuilder cmd = new StringBuilder("INSERT INTO raspodela (godina_id, nastavnik_id, predmet_id, odeljenje_id) VALUES('");
            cmd.Append(cmb_godina.SelectedValue + "', '");
            cmd.Append(cmb_nastavnik.SelectedValue + "', '");
            cmd.Append(cmb_predmet.SelectedValue + "', '");
            cmd.Append(cmb_odeljenje.SelectedValue + "')");

            SqlConnection connection = Connection.Connect();
            SqlCommand command = new SqlCommand(cmd.ToString(), connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            Load_data();
            rb = raspodela_table.Rows.Count - 1;
            ComboChange();
        }
    }
}
