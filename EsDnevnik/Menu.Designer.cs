
namespace EsDnevnik
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_osobeForm = new System.Windows.Forms.Button();
            this.login_name = new System.Windows.Forms.Label();
            this.btn_RaspodelaForm = new System.Windows.Forms.Button();
            this.btn_tabelaBez = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_smerovi = new System.Windows.Forms.Button();
            this.btn_skgod = new System.Windows.Forms.Button();
            this.btn_predmeti = new System.Windows.Forms.Button();
            this.btn_osobe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_osobeForm
            // 
            this.btn_osobeForm.Location = new System.Drawing.Point(12, 12);
            this.btn_osobeForm.Name = "btn_osobeForm";
            this.btn_osobeForm.Size = new System.Drawing.Size(93, 30);
            this.btn_osobeForm.TabIndex = 0;
            this.btn_osobeForm.Text = "Osobe";
            this.btn_osobeForm.UseVisualStyleBackColor = true;
            this.btn_osobeForm.Click += new System.EventHandler(this.btn_osobeForm_Click);
            // 
            // login_name
            // 
            this.login_name.AutoSize = true;
            this.login_name.Location = new System.Drawing.Point(689, 12);
            this.login_name.Name = "login_name";
            this.login_name.Size = new System.Drawing.Size(0, 15);
            this.login_name.TabIndex = 1;
            // 
            // btn_RaspodelaForm
            // 
            this.btn_RaspodelaForm.Location = new System.Drawing.Point(128, 12);
            this.btn_RaspodelaForm.Name = "btn_RaspodelaForm";
            this.btn_RaspodelaForm.Size = new System.Drawing.Size(93, 30);
            this.btn_RaspodelaForm.TabIndex = 0;
            this.btn_RaspodelaForm.Text = "Raspodela";
            this.btn_RaspodelaForm.UseVisualStyleBackColor = true;
            this.btn_RaspodelaForm.Click += new System.EventHandler(this.btn_RaspodelaForm_Click);
            // 
            // btn_tabelaBez
            // 
            this.btn_tabelaBez.Location = new System.Drawing.Point(247, 12);
            this.btn_tabelaBez.Name = "btn_tabelaBez";
            this.btn_tabelaBez.Size = new System.Drawing.Size(93, 30);
            this.btn_tabelaBez.TabIndex = 0;
            this.btn_tabelaBez.Text = "Tabela Bez";
            this.btn_tabelaBez.UseVisualStyleBackColor = true;
            this.btn_tabelaBez.Click += new System.EventHandler(this.btn_tabelaBez_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "Videcemo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_osobeForm_Click);
            // 
            // btn_smerovi
            // 
            this.btn_smerovi.Enabled = false;
            this.btn_smerovi.Location = new System.Drawing.Point(247, 48);
            this.btn_smerovi.Name = "btn_smerovi";
            this.btn_smerovi.Size = new System.Drawing.Size(75, 22);
            this.btn_smerovi.TabIndex = 2;
            this.btn_smerovi.Text = "Smerovi";
            this.btn_smerovi.UseVisualStyleBackColor = true;
            this.btn_smerovi.Visible = false;
            this.btn_smerovi.Click += new System.EventHandler(this.btn_smerovi_Click);
            // 
            // btn_skgod
            // 
            this.btn_skgod.Enabled = false;
            this.btn_skgod.Location = new System.Drawing.Point(247, 76);
            this.btn_skgod.Name = "btn_skgod";
            this.btn_skgod.Size = new System.Drawing.Size(109, 22);
            this.btn_skgod.TabIndex = 2;
            this.btn_skgod.Text = "Skolske Godine";
            this.btn_skgod.UseVisualStyleBackColor = true;
            this.btn_skgod.Visible = false;
            this.btn_skgod.Click += new System.EventHandler(this.btn_skgod_Click);
            // 
            // btn_predmeti
            // 
            this.btn_predmeti.Enabled = false;
            this.btn_predmeti.Location = new System.Drawing.Point(247, 104);
            this.btn_predmeti.Name = "btn_predmeti";
            this.btn_predmeti.Size = new System.Drawing.Size(75, 22);
            this.btn_predmeti.TabIndex = 2;
            this.btn_predmeti.Text = "Predmeti";
            this.btn_predmeti.UseVisualStyleBackColor = true;
            this.btn_predmeti.Visible = false;
            this.btn_predmeti.Click += new System.EventHandler(this.btn_predmeti_Click);
            // 
            // btn_osobe
            // 
            this.btn_osobe.Enabled = false;
            this.btn_osobe.Location = new System.Drawing.Point(247, 132);
            this.btn_osobe.Name = "btn_osobe";
            this.btn_osobe.Size = new System.Drawing.Size(75, 22);
            this.btn_osobe.TabIndex = 2;
            this.btn_osobe.Text = "Osobe";
            this.btn_osobe.UseVisualStyleBackColor = true;
            this.btn_osobe.Visible = false;
            this.btn_osobe.Click += new System.EventHandler(this.btn_osobe_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_osobe);
            this.Controls.Add(this.btn_predmeti);
            this.Controls.Add(this.btn_skgod);
            this.Controls.Add(this.btn_smerovi);
            this.Controls.Add(this.login_name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_tabelaBez);
            this.Controls.Add(this.btn_RaspodelaForm);
            this.Controls.Add(this.btn_osobeForm);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Click += new System.EventHandler(this.Menu_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_osobeForm;
        private System.Windows.Forms.Label login_name;
        private System.Windows.Forms.Button btn_RaspodelaForm;
        private System.Windows.Forms.Button btn_tabelaBez;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_smerovi;
        private System.Windows.Forms.Button btn_skgod;
        private System.Windows.Forms.Button btn_predmeti;
        private System.Windows.Forms.Button btn_osobe;
    }
}