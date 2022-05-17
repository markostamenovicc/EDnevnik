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
    public partial class Sifarnik : Form
    {
        DataTable tabela;
        SqlDataAdapter adapter;
        string ime_tabele;
        public Sifarnik(string tabela)
        {
            ime_tabele = tabela;
            InitializeComponent();
        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM " + ime_tabele, Connection.Connect());
            tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.Columns["id"].ReadOnly = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DataTable changed = tabela.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (changed != null)
            {
                adapter.Update(changed);
            }
            this.Close();
        }
    }
}
