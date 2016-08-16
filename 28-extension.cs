using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_extension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int basla = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);

            Random rd = new Random();
            int sonuc = rd.tekUret(basla, bitis);
            MessageBox.Show("Üretilen Değer : " + sonuc);

            MessageBox.Show("String Dizi " + "".karakterDizi("ali")[0]);

            yeniYetenek yt = new yeniYetenek();
            int gelen = yt.cikarma(10, 7);
            MessageBox.Show("Çıkarma Sonucu : " + gelen);
        }
    }
}
