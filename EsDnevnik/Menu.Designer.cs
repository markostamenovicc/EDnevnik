
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Videcemo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_osobeForm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Videcemo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_osobeForm_Click);
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_osobeForm);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_osobeForm;
        private System.Windows.Forms.Label login_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}