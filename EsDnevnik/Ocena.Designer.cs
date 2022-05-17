
namespace EsDnevnik
{
    partial class Ocena
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
            this.cmb_godina = new System.Windows.Forms.ComboBox();
            this.cmb_profesor = new System.Windows.Forms.ComboBox();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.cmb_odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_ucenik = new System.Windows.Forms.ComboBox();
            this.cmb_ocena = new System.Windows.Forms.ComboBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_godina = new System.Windows.Forms.Label();
            this.lbl_profesor = new System.Windows.Forms.Label();
            this.lbl_predmet = new System.Windows.Forms.Label();
            this.lbl_odeljenje = new System.Windows.Forms.Label();
            this.lbl_ucenik = new System.Windows.Forms.Label();
            this.lbl_ocena = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.Grid_ocene = new System.Windows.Forms.DataGridView();
            this.txt_command = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ocene)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_godina
            // 
            this.cmb_godina.FormattingEnabled = true;
            this.cmb_godina.Location = new System.Drawing.Point(37, 46);
            this.cmb_godina.Name = "cmb_godina";
            this.cmb_godina.Size = new System.Drawing.Size(121, 23);
            this.cmb_godina.TabIndex = 0;
            this.cmb_godina.SelectedValueChanged += new System.EventHandler(this.cmb_godina_SelectedValueChanged);
            // 
            // cmb_profesor
            // 
            this.cmb_profesor.FormattingEnabled = true;
            this.cmb_profesor.Location = new System.Drawing.Point(174, 46);
            this.cmb_profesor.Name = "cmb_profesor";
            this.cmb_profesor.Size = new System.Drawing.Size(121, 23);
            this.cmb_profesor.TabIndex = 0;
            this.cmb_profesor.SelectedValueChanged += new System.EventHandler(this.cmb_profesor_SelectedValueChanged);
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(312, 46);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(121, 23);
            this.cmb_predmet.TabIndex = 0;
            this.cmb_predmet.SelectedValueChanged += new System.EventHandler(this.cmb_predmet_SelectedValueChanged);
            // 
            // cmb_odeljenje
            // 
            this.cmb_odeljenje.FormattingEnabled = true;
            this.cmb_odeljenje.Location = new System.Drawing.Point(449, 46);
            this.cmb_odeljenje.Name = "cmb_odeljenje";
            this.cmb_odeljenje.Size = new System.Drawing.Size(121, 23);
            this.cmb_odeljenje.TabIndex = 0;
            this.cmb_odeljenje.SelectedValueChanged += new System.EventHandler(this.cmb_odeljenje_SelectedValueChanged);
            // 
            // cmb_ucenik
            // 
            this.cmb_ucenik.FormattingEnabled = true;
            this.cmb_ucenik.Location = new System.Drawing.Point(37, 106);
            this.cmb_ucenik.Name = "cmb_ucenik";
            this.cmb_ucenik.Size = new System.Drawing.Size(121, 23);
            this.cmb_ucenik.TabIndex = 0;
            // 
            // cmb_ocena
            // 
            this.cmb_ocena.FormattingEnabled = true;
            this.cmb_ocena.Location = new System.Drawing.Point(174, 106);
            this.cmb_ocena.Name = "cmb_ocena";
            this.cmb_ocena.Size = new System.Drawing.Size(121, 23);
            this.cmb_ocena.TabIndex = 0;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(449, 106);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(121, 23);
            this.dateTime.TabIndex = 1;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(312, 106);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(121, 23);
            this.txt_ID.TabIndex = 2;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(592, 47);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(79, 23);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Dodaj";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(592, 76);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(79, 23);
            this.btn_change.TabIndex = 3;
            this.btn_change.Text = "Izmeni";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(592, 105);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(79, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Brisi";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_godina
            // 
            this.lbl_godina.AutoSize = true;
            this.lbl_godina.Location = new System.Drawing.Point(37, 28);
            this.lbl_godina.Name = "lbl_godina";
            this.lbl_godina.Size = new System.Drawing.Size(45, 15);
            this.lbl_godina.TabIndex = 4;
            this.lbl_godina.Text = "Godina";
            // 
            // lbl_profesor
            // 
            this.lbl_profesor.AutoSize = true;
            this.lbl_profesor.Location = new System.Drawing.Point(174, 28);
            this.lbl_profesor.Name = "lbl_profesor";
            this.lbl_profesor.Size = new System.Drawing.Size(51, 15);
            this.lbl_profesor.TabIndex = 4;
            this.lbl_profesor.Text = "Profesor";
            // 
            // lbl_predmet
            // 
            this.lbl_predmet.AutoSize = true;
            this.lbl_predmet.Location = new System.Drawing.Point(312, 28);
            this.lbl_predmet.Name = "lbl_predmet";
            this.lbl_predmet.Size = new System.Drawing.Size(52, 15);
            this.lbl_predmet.TabIndex = 4;
            this.lbl_predmet.Text = "Predmet";
            // 
            // lbl_odeljenje
            // 
            this.lbl_odeljenje.AutoSize = true;
            this.lbl_odeljenje.Location = new System.Drawing.Point(449, 28);
            this.lbl_odeljenje.Name = "lbl_odeljenje";
            this.lbl_odeljenje.Size = new System.Drawing.Size(57, 15);
            this.lbl_odeljenje.TabIndex = 4;
            this.lbl_odeljenje.Text = "Odeljenje";
            // 
            // lbl_ucenik
            // 
            this.lbl_ucenik.AutoSize = true;
            this.lbl_ucenik.Location = new System.Drawing.Point(37, 88);
            this.lbl_ucenik.Name = "lbl_ucenik";
            this.lbl_ucenik.Size = new System.Drawing.Size(43, 15);
            this.lbl_ucenik.TabIndex = 4;
            this.lbl_ucenik.Text = "Ucenik";
            // 
            // lbl_ocena
            // 
            this.lbl_ocena.AutoSize = true;
            this.lbl_ocena.Location = new System.Drawing.Point(174, 88);
            this.lbl_ocena.Name = "lbl_ocena";
            this.lbl_ocena.Size = new System.Drawing.Size(39, 15);
            this.lbl_ocena.TabIndex = 4;
            this.lbl_ocena.Text = "ocena";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(312, 88);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 15);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "ID";
            // 
            // lbl_datum
            // 
            this.lbl_datum.AutoSize = true;
            this.lbl_datum.Location = new System.Drawing.Point(449, 88);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(43, 15);
            this.lbl_datum.TabIndex = 4;
            this.lbl_datum.Text = "Datum";
            // 
            // Grid_ocene
            // 
            this.Grid_ocene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ocene.Location = new System.Drawing.Point(37, 204);
            this.Grid_ocene.Name = "Grid_ocene";
            this.Grid_ocene.RowTemplate.Height = 25;
            this.Grid_ocene.Size = new System.Drawing.Size(634, 252);
            this.Grid_ocene.TabIndex = 5;
            this.Grid_ocene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_ocene_CellClick);
            // 
            // txt_command
            // 
            this.txt_command.Location = new System.Drawing.Point(37, 157);
            this.txt_command.Name = "txt_command";
            this.txt_command.Size = new System.Drawing.Size(634, 23);
            this.txt_command.TabIndex = 6;
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 523);
            this.Controls.Add(this.txt_command);
            this.Controls.Add(this.Grid_ocene);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lbl_odeljenje);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_ocena);
            this.Controls.Add(this.lbl_predmet);
            this.Controls.Add(this.lbl_ucenik);
            this.Controls.Add(this.lbl_profesor);
            this.Controls.Add(this.lbl_godina);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.cmb_odeljenje);
            this.Controls.Add(this.cmb_ocena);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.cmb_ucenik);
            this.Controls.Add(this.cmb_profesor);
            this.Controls.Add(this.cmb_godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ocene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_godina;
        private System.Windows.Forms.ComboBox cmb_profesor;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.ComboBox cmb_odeljenje;
        private System.Windows.Forms.ComboBox cmb_ucenik;
        private System.Windows.Forms.ComboBox cmb_ocena;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_godina;
        private System.Windows.Forms.Label lbl_profesor;
        private System.Windows.Forms.Label lbl_predmet;
        private System.Windows.Forms.Label lbl_odeljenje;
        private System.Windows.Forms.Label lbl_ucenik;
        private System.Windows.Forms.Label lbl_ocena;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.DataGridView Grid_ocene;
        private System.Windows.Forms.TextBox txt_command;
    }
}