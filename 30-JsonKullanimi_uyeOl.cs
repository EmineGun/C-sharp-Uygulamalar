using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;


namespace _30_JsonKullanimi
{
    public partial class uyeOl : Form
    {
        public uyeOl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String adi = textBox4.Text;
            String soyadi = textBox3.Text;
            String telefon = textBox5.Text;
            String mail = textBox1.Text;
            String sifre = textBox2.Text;

            String url = "http://dinles.com/rentecar/json/kullanici_yaz.php?adi="+adi+"&soyadi="+soyadi+"&telefon="+telefon+"&mail="+mail+"&sifre="+sifre+"";

            WebClient c = new WebClient();
            var data = c.DownloadString(url);

            // [ parantez başlıyor ise dizi gibi davranış gösterir
            JArray dizi = JArray.Parse(data);
            JObject dt = JObject.Parse(dizi[0].ToString());

            // denetim yapılıyor
            if (dt["kullanici_id"] == null)
            {
                // kayıt başarısız
                MessageBox.Show(dt["durum"].ToString());
            }
            else { 
                // kayıt başarılı
                MessageBox.Show("Kayıt Başarılı : id'niz" + dt["kullanici_id"]);
            }
        }
    }
}
