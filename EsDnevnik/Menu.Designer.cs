
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_osobeForm);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_osobeForm;
    }
}