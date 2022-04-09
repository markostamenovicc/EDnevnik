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
            string user = Program.user_ime + " " + Program.user_prezime;
            login_name.Text = user;
        }

        private void btn_osobeForm_Click(object sender, EventArgs e)
        {
            Osoba form_osoba = new Osoba();
            form_osoba.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            btn_smerovi.Enabled = false;
            btn_skgod.Enabled = false;
            btn_predmeti.Enabled = false;
            btn_osobe.Enabled = false;
            btn_smerovi.Visible = false;
            btn_skgod.Visible = false;
            btn_predmeti.Visible = false;
            btn_osobe.Visible = false;
        }

        private void btn_tabelaBez_Click(object sender, EventArgs e)
        {
            btn_smerovi.Enabled = true;
            btn_skgod.Enabled = true;
            btn_predmeti.Enabled = true;
            btn_osobe.Enabled = true;
            btn_smerovi.Visible = true;
            btn_skgod.Visible = true;
            btn_predmeti.Visible = true;
            btn_osobe.Visible = true;
        }

        private void btn_smerovi_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("smer");
            frm_sifarnik.Show();
        }

        private void btn_skgod_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Skolska_godina");
            frm_sifarnik.Show();
        }

        private void btn_predmeti_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Predmet");
            frm_sifarnik.Show();
        }

        private void btn_osobe_Click(object sender, EventArgs e)
        {
            Sifarnik frm_sifarnik = new Sifarnik("Osoba");
            frm_sifarnik.Show();
        }

        private void btn_RaspodelaForm_Click(object sender, EventArgs e)
        {
            Raspodela frm_raspodela = new Raspodela();
            frm_raspodela.Show();
        }
    }
}
