using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//arraylisti kullnmak için ekledik


namespace _6_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public static  ArrayList ls = new ArrayList();
      //  public ArrayList ls = new ArrayList();//2.durumda static anahtar kelimesini siliyoruz.
        private void btnDataAktar_Click(object sender, EventArgs e)
        {
            Kisi ks = new Kisi();
            ks.Adi = textBox1.Text;
            ks.Soyadi = textBox2.Text;
            ks.Tel = textBox3.Text;
            ks.Mail = textBox4.Text;
            ls.Add(ks);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void btnGecisYap_Click(object sender, EventArgs e)
        {
            datalar dt = new datalar();
            dt.calis(ls);
            dt.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
