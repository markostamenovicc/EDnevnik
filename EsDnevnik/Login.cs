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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Unesite ime i password");
                return;
            }
            else
            {
                try
                {
                    SqlConnection conn = Connection.Connect();
                    SqlCommand comm = new SqlCommand("SELECT * FROM osoba WHERE email=@username", conn);
                    comm.Parameters.AddWithValue("@username", txt_name.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(comm);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    int num = table.Rows.Count;
                    if(num == 1)
                    {
                        if (String.Compare(table.Rows[0]["pass"].ToString(), txt_pass.Text) == 0)
                        {
                            MessageBox.Show("Login successful!");
                            this.Hide();
                            Menu form_meni = new Menu();
                            form_meni.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojece ime");
                    }

                }
                catch(Exception greska)
                {
                    MessageBox.Show("Greska");
                }
            }
        }
    }
}
