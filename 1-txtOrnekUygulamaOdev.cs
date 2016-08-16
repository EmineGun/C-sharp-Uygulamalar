using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1_txtOrnekUygulamaOdev
{
    public partial class Form1 : Form
    {
      String filePath = ""; // proje nerede çalışırsa orada türer
        //FileStream dosya = new FileStream();
        //StreamReader ilkYaz = new StreamReader("acilis.txt");
        StreamWriter Dosya = File.CreateText("ornek1.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            //yükle denilince oluşturulan dosyanın ayrıntısı gelecek.
            StreamReader oku = new StreamReader(filePath);
            txtYukle.Text = oku.ReadLine();
            while (oku.Peek() >= 0)
            {
               // txtYukle.Items.Add(oku.ReadLine());
            }
            oku.Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            //yenile dediğimiz textboxun içi silinecek.(oluşturulan dosyayı temizler.)
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            //Dosya oluşturma

            StreamWriter yaz = new StreamWriter(filePath);
            yaz.WriteLine("Yazılan Değer");
            yaz.Close();

        }

        private void txtYukle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
