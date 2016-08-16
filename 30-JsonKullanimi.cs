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
using System.Collections;


namespace _30_JsonKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mail = textBox1.Text.Trim();
            String sifre = textBox2.Text.Trim();
            
                WebClient n = new WebClient();
                var json = n.DownloadString("http://dinles.com/rentecar/json/kullanici_oku.php?mail="+mail+"&sifre="+sifre);
                string data = Convert.ToString(json);
                

            // json bilgi ayrıştırma - eğer data "{" parantez ile başlıyor ise JObject Sınıfırıdır.
                JObject obj = JObject.Parse(data);
                if (obj["id"] == null)
                {
                    // gişiş hatalı
                    MessageBox.Show(obj["durum"].ToString());
                }
                else { 
                    // giriş başarılı
                    MessageBox.Show("Hoş Geldin : " + obj["adi"]);
                }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeOl ns = new uyeOl();
            ns.Show();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList ls = new ArrayList();
            WebClient c = new WebClient();
            var data = c.DownloadString("http://dinles.com/rentecar/json/urunler.php");
            JArray arr = JArray.Parse(data);

            foreach (var item in arr)
            {
                urun u = new urun();
                u.UrunId = item["urunId"].ToString();
                u.Baslik = item["baslik"].ToString();
                u.Ucret = item["ucret"].ToString();
                u.Tarih = item["tarih"].ToString();
                ls.Add(u);
            }
            dataGridView1.DataSource = ls;
        }
    }
}
