namespace _6_Uygulama
{
    partial class Form1
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnDataAktar = new System.Windows.Forms.Button();
            this.btnGecisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(311, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(311, 20);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(54, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(311, 20);
            this.textBox4.TabIndex = 0;
            // 
            // btnDataAktar
            // 
            this.btnDataAktar.Location = new System.Drawing.Point(233, 178);
            this.btnDataAktar.Name = "btnDataAktar";
            this.btnDataAktar.Size = new System.Drawing.Size(132, 21);
            this.btnDataAktar.TabIndex = 1;
            this.btnDataAktar.Text = "Data Aktar";
            this.btnDataAktar.UseVisualStyleBackColor = true;
            this.btnDataAktar.Click += new System.EventHandler(this.btnDataAktar_Click);
            // 
            // btnGecisYap
            // 
            this.btnGecisYap.Location = new System.Drawing.Point(54, 178);
            this.btnGecisYap.Name = "btnGecisYap";
            this.btnGecisYap.Size = new System.Drawing.Size(126, 23);
            this.btnGecisYap.TabIndex = 2;
            this.btnGecisYap.Text = "Geçiş Yap";
            this.btnGecisYap.UseVisualStyleBackColor = true;
            this.btnGecisYap.Click += new System.EventHandler(this.btnGecisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 262);
            this.Controls.Add(this.btnGecisYap);
            this.Controls.Add(this.btnDataAktar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnDataAktar;
        private System.Windows.Forms.Button btnGecisYap;
    }
}

