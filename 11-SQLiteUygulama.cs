using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace _11_SQLiteUygulama
{
    public partial class Form1 : Form
    {
        public static String adi = "";
        public static String soyadi = "";
        public static String id = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminKayit ad = new adminKayit();
            ad.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            String sorgu = "select *from  admin where mail = '"+textBox1.Text+"' and sifre = '"+db.MD5Sifrele(textBox2.Text)+"'";
            SQLiteDataReader rd = db.query(sorgu);
            if (rd.Read())
            {
                Form1.adi = rd["adi"].ToString();
                Form1.soyadi = rd["soyadi"].ToString();
                Form1.id = rd["id"].ToString();
                // giriş Başarılı
                admin ad = new admin();
                ad.Show();
                this.Hide();
                rd.Close();//açılan kapatılmayınca veritabanı kilitleniyor.
            }
            else { 
                // giriş başarısız
                MessageBox.Show("Kullanıcı Adı yada Şifre Hatalı");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }

        }
    }
}
