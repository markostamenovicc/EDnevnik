using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EsDnevnik
{
    public partial class Osoba : Form
    {
        int rb = 0;
        DataTable table;
        public Osoba()
        {
            InitializeComponent();
        }

        private void load_Data()
        {
            SqlConnection connetion = Connection.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba", connetion);
            table = new DataTable();
            adapter.Fill(table);
        }

        private void text_Load()
        {
            if(table.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_adresa.Text = "";
                txt_jmbg.Text = "";
                txt_email.Text = "";
                txt_pass.Text = "";
                txt_uloga.Text = "";
                btn_delete.Enabled = false;
            }
            else
            {
                txt_id.Text = table.Rows[rb]["id"].ToString();
                txt_ime.Text = table.Rows[rb]["ime"].ToString();
                txt_prezime.Text = table.Rows[rb]["prezime"].ToString();
                txt_adresa.Text = table.Rows[rb]["adresa"].ToString();
                txt_jmbg.Text = table.Rows[rb]["jmbg"].ToString();
                txt_email.Text = table.Rows[rb]["email"].ToString();
                txt_pass.Text = table.Rows[rb]["pass"].ToString();
                txt_uloga.Text = table.Rows[rb]["uloga"].ToString();
                btn_delete.Enabled = true;
            }

            if(rb == 0)
            {
                btn_first.Enabled = false;
                btn_prev.Enabled = false;
            }
            else
            {
                btn_first.Enabled = true;
                btn_prev.Enabled = true;
            }

            if (rb == table.Rows.Count - 1)
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

        private void Osoba_Load(object sender, EventArgs e)
        {
            load_Data();
            text_Load();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            rb = 0;
            text_Load();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            rb--;
            text_Load();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            rb++;
            text_Load();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            rb = table.Rows.Count - 1;
            text_Load();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            StringBuilder command = new StringBuilder("INSERT INTO osoba (ime, prezime, adresa, jmbg, email, pass, uloga) VALUES('");
            command.Append(txt_ime.Text + "', '");
            command.Append(txt_prezime.Text + "', '");
            command.Append(txt_adresa.Text + "', '");
            command.Append(txt_jmbg.Text + "', '");
            command.Append(txt_email.Text + "', '");
            command.Append(txt_pass.Text + "', '");
            command.Append(txt_uloga.Text + "')");
            SqlConnection connection = Connection.Connect();
            SqlCommand cmd = new SqlCommand(command.ToString(), connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            load_Data();
            rb = table.Rows.Count - 1;
            text_Load();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            // UPDATE osoba SET ime = 'Marko', prezime = 'Peric', adresa = 'Studenac 8', jmbg = '123451352315', email = 'marko@gmail.com', pass = '121231', uloga = '1'
            // WHERE id = 3
            StringBuilder cmd = new StringBuilder("UPDATE Osoba SET ");
            cmd.Append("ime = '" + txt_ime.Text + "', ");
            cmd.Append("prezime = '" + txt_prezime.Text + "', ");
            cmd.Append("adresa = '" + txt_adresa.Text + "', ");
            cmd.Append("jmbg = '" + txt_jmbg.Text + "', ");
            cmd.Append("email = '" + txt_email.Text + "', ");
            cmd.Append("pass = '" + txt_pass.Text + "', ");
            cmd.Append("uloga = '" + txt_uloga.Text + "' ");
            cmd.Append("WHERE id = " + txt_id.Text);

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
            load_Data();
            rb = table.Rows.Count - 1;
            text_Load();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string command = "DELETE FROM Osoba WHERE id = " + txt_id.Text;

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
                load_Data();
                if (rb > 0)
                    rb--;
                text_Load();
            }
            load_Data();
            rb = table.Rows.Count - 1;
            text_Load();
        }
    }
}
