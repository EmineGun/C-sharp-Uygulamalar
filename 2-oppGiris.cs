using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_oppGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            yetenek yt = new yetenek();//() bu parantez bir constructurı tetikler.
            MessageBox.Show(yt.adi);
            if (yt.islem("merhaba")>10)
            {
                
            }
            int durum = 1 ==1  ? geri() : 2;
            MessageBox.Show(sinifDonder().adi);//yetenek tipine dönemüş oldu.
        }
        public int geri()
        {
            //işlem-1
            return 1;
        }
        //sınıf dönder
        public yetenek sinifDonder() {
            yetenek yt = new yetenek();
            yt.adi = "hasan";
            return yt;

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            islem nesne = new islem();
             label1.Text = Convert.ToString(nesne.topla(textBox1.Text,textBox2.Text));
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            islem nesne = new islem();
            label1.Text = Convert.ToString(nesne.cikar(textBox1.Text, textBox2.Text));
        }
    }
}
