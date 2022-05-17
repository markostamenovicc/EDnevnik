
namespace EsDnevnik
{
    partial class upisnica
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_god = new System.Windows.Forms.ComboBox();
            this.cmb_odelj = new System.Windows.Forms.ComboBox();
            this.cmb_uce = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_izmeni = new System.Windows.Forms.Button();
            this.btn_izbrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 0;
            // 
            // cmb_god
            // 
            this.cmb_god.FormattingEnabled = true;
            this.cmb_god.Location = new System.Drawing.Point(224, 69);
            this.cmb_god.Name = "cmb_god";
            this.cmb_god.Size = new System.Drawing.Size(128, 23);
            this.cmb_god.TabIndex = 1;
            this.cmb_god.SelectedValueChanged += new System.EventHandler(this.cmb_god_SelectedValueChanged);
            // 
            // cmb_odelj
            // 
            this.cmb_odelj.FormattingEnabled = true;
            this.cmb_odelj.Location = new System.Drawing.Point(377, 69);
            this.cmb_odelj.Name = "cmb_odelj";
            this.cmb_odelj.Size = new System.Drawing.Size(128, 23);
            this.cmb_odelj.TabIndex = 2;
            this.cmb_odelj.SelectedValueChanged += new System.EventHandler(this.cmb_odelj_SelectedValueChanged);
            // 
            // cmb_uce
            // 
            this.cmb_uce.FormattingEnabled = true;
            this.cmb_uce.Location = new System.Drawing.Point(530, 69);
            this.cmb_uce.Name = "cmb_uce";
            this.cmb_uce.Size = new System.Drawing.Size(128, 23);
            this.cmb_uce.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Godina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Odeljenje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ucenik";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(715, 189);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(189, 127);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(75, 23);
            this.btn_dodaj.TabIndex = 9;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_izmeni
            // 
            this.btn_izmeni.Location = new System.Drawing.Point(338, 127);
            this.btn_izmeni.Name = "btn_izmeni";
            this.btn_izmeni.Size = new System.Drawing.Size(75, 23);
            this.btn_izmeni.TabIndex = 10;
            this.btn_izmeni.Text = "Izmeni";
            this.btn_izmeni.UseVisualStyleBackColor = true;
            this.btn_izmeni.Click += new System.EventHandler(this.btn_izmeni_Click);
            // 
            // btn_izbrisi
            // 
            this.btn_izbrisi.Location = new System.Drawing.Point(498, 127);
            this.btn_izbrisi.Name = "btn_izbrisi";
            this.btn_izbrisi.Size = new System.Drawing.Size(75, 23);
            this.btn_izbrisi.TabIndex = 11;
            this.btn_izbrisi.Text = "Izbrisi";
            this.btn_izbrisi.UseVisualStyleBackColor = true;
            this.btn_izbrisi.Click += new System.EventHandler(this.btn_izbrisi_Click);
            // 
            // upisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_izbrisi);
            this.Controls.Add(this.btn_izmeni);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_uce);
            this.Controls.Add(this.cmb_odelj);
            this.Controls.Add(this.cmb_god);
            this.Controls.Add(this.textBox1);
            this.Name = "upisnica";
            this.Text = "upisnica";
            this.Load += new System.EventHandler(this.upisnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmb_god;
        private System.Windows.Forms.ComboBox cmb_odelj;
        private System.Windows.Forms.ComboBox cmb_uce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_izmeni;
        private System.Windows.Forms.Button btn_izbrisi;
    }
}