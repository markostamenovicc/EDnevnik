using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EsDnevnik
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_osobeForm_Click(object sender, EventArgs e)
        {
            Osoba form_osoba = new Osoba();
            form_osoba.Show();
        }
    }
}
