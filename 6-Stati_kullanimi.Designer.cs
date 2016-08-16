namespace _6_Stati_kullanimi
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnDataGonder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(27, 31);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(166, 20);
            this.txtData.TabIndex = 0;
            // 
            // btnDataGonder
            // 
            this.btnDataGonder.Location = new System.Drawing.Point(212, 28);
            this.btnDataGonder.Name = "btnDataGonder";
            this.btnDataGonder.Size = new System.Drawing.Size(75, 23);
            this.btnDataGonder.TabIndex = 1;
            this.btnDataGonder.Text = "Data Gönder";
            this.btnDataGonder.UseVisualStyleBackColor = true;
            this.btnDataGonder.Click += new System.EventHandler(this.btnDataGonder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(212, 87);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(75, 23);
            this.btnAktar.TabIndex = 3;
            this.btnAktar.Text = "Data Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 262);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDataGonder);
            this.Controls.Add(this.txtData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnDataGonder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAktar;
    }
}

