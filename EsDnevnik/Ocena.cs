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
    public partial class Ocena : Form
    {

        DataTable dt_ocena;
        public Ocena()
        {
            InitializeComponent();
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            cmb_godinaPopulate();
            cmb_predmet.Enabled = false;
            cmb_odeljenje.Enabled = false;
            cmb_ucenik.Enabled = false;
            cmb_ocena.Items.Add(1);
            cmb_ocena.Items.Add(2);
            cmb_ocena.Items.Add(3);
            cmb_ocena.Items.Add(4);
            cmb_ocena.Items.Add(5);
            cmb_ocena.Enabled = false;
            cmb_profesorPopulate();
        }

        private void cmb_godinaPopulate()
        {
            SqlConnection veza = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable dt_godina = new DataTable();
            adapter.Fill(dt_godina);
            cmb_godina.DataSource = dt_godina;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = 2;
        }
        private void cmb_godina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_godina.IsHandleCreated && cmb_godina.Focused)
            {
                cmb_profesorPopulate();
            }
        }

        private void cmb_profesorPopulate()
        {
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT osoba.id AS id, ime + ' ' + prezime AS naziv FROM osoba");
            naredba.Append(" JOIN raspodela ON osoba.id = nastavnik_id ");
            naredba.Append(" WHERE godina_id = " + cmb_godina.SelectedValue.ToString());
            //txt_command.Text = naredba.ToString();
            SqlConnection veza = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_profesor = new DataTable();
            adapter.Fill(dt_profesor);
            cmb_profesor.DataSource = dt_profesor;
            cmb_profesor.ValueMember = "id";
            cmb_profesor.DisplayMember = "naziv";
            cmb_profesor.SelectedValue = -1;
        }

        private void cmb_profesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_profesor.IsHandleCreated && cmb_profesor.Focused)
            {
                cmb_predmetPopulate();
                cmb_predmet.Enabled = true;

                cmb_odeljenje.SelectedValue = -1;
                cmb_odeljenje.Enabled = false;

                cmb_ucenik.SelectedValue = -1;
                cmb_ucenik.Enabled = false;

                cmb_ocena.SelectedValue = -1;
                cmb_ocena.Enabled = false;

                dt_ocena = new DataTable();
                Grid_ocene.DataSource = dt_ocena;
                
            }
        }

        private void cmb_predmetPopulate()
        {
            
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT predmet.id AS id, naziv FROM predmet ");
            naredba.Append(" JOIN raspodela ON predmet.id = predmet_id ");
            naredba.Append(" WHERE godina_id = " + cmb_godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_profesor.SelectedValue.ToString());
            //txt_command.Text = naredba.ToString();
            SqlConnection veza = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_predmet = new DataTable();
            adapter.Fill(dt_predmet);
            cmb_predmet.DataSource = dt_predmet;
            cmb_predmet.ValueMember = "id";
            cmb_predmet.DisplayMember = "naziv";
            cmb_predmet.SelectedIndex = -1;
        }

        private void cmb_predmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_predmet.IsHandleCreated && cmb_predmet.Focused)
            {
                cmb_odeljenjePopulate();
                cmb_odeljenje.Enabled = true;
                cmb_odeljenje.SelectedIndex = -1;

                cmb_ucenik.SelectedValue = -1;
                cmb_ucenik.Enabled = false;

                cmb_ocena.SelectedValue = -1;
                cmb_ocena.Enabled = false;

                dt_ocena = new DataTable();
                Grid_ocene.DataSource = dt_ocena;
            }
        }

        private void cmb_odeljenjePopulate()
        {
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT odeljenje.id AS id, STR(razred) + '-' + indeks AS naziv FROM odeljenje");
            naredba.Append(" JOIN raspodela ON odeljenje.id = odeljenje_id ");
            naredba.Append(" WHERE raspodela.godina_id = " + cmb_godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cmb_predmet.SelectedValue.ToString());
            SqlConnection veza = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_odeljenje = new DataTable();
            adapter.Fill(dt_odeljenje);
            cmb_odeljenje.DataSource = dt_odeljenje;
            cmb_odeljenje.ValueMember = "id";
            cmb_odeljenje.DisplayMember = "naziv";
        }

        private void cmb_odeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_odeljenje.IsHandleCreated && cmb_odeljenje.Focused)
            {
                cmb_ucenikPopulate();
                gridPopulate();
                cmb_ucenik.Enabled = true;
                cmb_ocena.Enabled = true;
                UcenikOcenaIdSet(0);


            }
        }

        private void cmb_ucenikPopulate()
        {
            StringBuilder naredba = new StringBuilder("SELECT osoba.id AS id, ime + ' ' + prezime as naziv FROM osoba ");
            naredba.Append(" JOIN upisnica ON osoba.id = osoba_id ");
            naredba.Append(" WHERE upisnica.odeljenje_id = " + cmb_odeljenje.SelectedValue.ToString());
            SqlConnection veza = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_ucenik = new DataTable();
            adapter.Fill(dt_ucenik);
            cmb_ucenik.DataSource = dt_ucenik;
            cmb_ucenik.ValueMember = "id";
            cmb_ucenik.DisplayMember = "naziv";
            cmb_ucenik.SelectedIndex = -1;

        }

        private void gridPopulate()
        {
            StringBuilder naredba = new StringBuilder("SELECT ocena.id AS id, ime + ' ' + prezime AS naziv, ocena, ucenik_id, datum FROM osoba ");
            naredba.Append(" JOIN ocena ON osoba.id = ucenik_id ");
            naredba.Append(" JOIN raspodela ON raspodela_id = raspodela.id ");
            naredba.Append(" WHERE raspodela_id = ");
            naredba.Append(" (SELECT id FROM raspodela WHERE godina_id = " + cmb_godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cmb_predmet.SelectedValue.ToString());
            naredba.Append(" AND odeljenje_id = " + cmb_odeljenje.SelectedValue.ToString() + ") ");
            //txt_command.Text = naredba.ToString();
            SqlConnection veza = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            dt_ocena = new DataTable();
            adapter.Fill(dt_ocena);
            Grid_ocene.DataSource = dt_ocena;
            Grid_ocene.AllowUserToAddRows = false;
            Grid_ocene.Columns["ucenik_id"].Visible = false;
        }

        private void Grid_ocene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                UcenikOcenaIdSet(e.RowIndex);
            }
        }

        private void UcenikOcenaIdSet(int br)
        {
            cmb_ucenik.SelectedValue = dt_ocena.Rows[br]["ucenik_id"];
            cmb_ocena.SelectedItem = dt_ocena.Rows[br]["ocena"];
            txt_ID.Text = dt_ocena.Rows[br]["id"].ToString();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            // INSERT 
            StringBuilder naredba = new StringBuilder("SELECT id FROM raspodela ");
            naredba.Append(" WHERE godina_id = " + cmb_godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cmb_predmet.SelectedValue.ToString());
            naredba.Append(" AND odeljenje_id = " + cmb_odeljenje.SelectedValue.ToString());
            SqlConnection veza = Connection.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            int id_raspodele = 0;
            try
            {
                veza.Open();
                id_raspodele = (int) komanda.ExecuteScalar();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.Message);
            }

            if(id_raspodele > 0)
            {
                naredba = new StringBuilder("INSERT INTO ocena (datum, raspodela_id, ucenik_id, ocena) VALUES('");
                DateTime datum = dateTime.Value;
                naredba.Append(datum.ToString("yyyy-MM-dd") + "', '");
                naredba.Append(id_raspodele.ToString() + "', '");
                naredba.Append(cmb_ucenik.SelectedValue.ToString() + "', '");
                naredba.Append(cmb_ocena.SelectedItem.ToString() + "')");
                komanda = new SqlCommand(naredba.ToString(), veza);
                txt_command.Text = naredba.ToString();
                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch(Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }

            }
            gridPopulate();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txt_ID.Text) > 0)
            {
                DateTime datum = dateTime.Value;
                StringBuilder naredba = new StringBuilder("UPDATE ocena SET ");
                naredba.Append(" ucenik_id = '" + cmb_ucenik.SelectedValue.ToString() + "', ");
                naredba.Append(" ocena = '" + cmb_ocena.SelectedItem.ToString() + "', ");
                naredba.Append(" datum = '" + datum.ToString("yyyy-MM-dd") + "' ");
                naredba.Append(" WHERE id = " + txt_ID.Text);
                SqlConnection veza = Connection.Connect();
                SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);

                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
            gridPopulate();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_ID.Text) > 0)
            {
                string naredba = "DELETE FROM ocena WHERE id = " + txt_ID.Text;
                SqlConnection veza = Connection.Connect();
                SqlCommand komanda = new SqlCommand(naredba, veza);
                try
                {
                    veza.Open();
                    komanda.ExecuteNonQuery();
                    veza.Close();
                    gridPopulate();
                    UcenikOcenaIdSet(0);
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
