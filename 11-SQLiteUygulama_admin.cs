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
using System.Collections;

namespace _11_SQLiteUygulama
{
    public partial class admin : Form
    {


        ArrayList kulList = new ArrayList();
        ArrayList urList = new ArrayList();

        String secKul = "";
        String secUr = "";

        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + Form1.adi + " " + Form1.soyadi;
            kulGetir();
            urunGetir();
            
        }


        // kullanıcılar
        public void kulGetir() {
            DB db = new DB();
            kulList.Clear();
            comboBox1.Items.Clear();
            SQLiteDataReader rd = db.dataGetir("kullanicilar");
            while (rd.Read()) {
                kulList.Add(rd["id"].ToString());
                comboBox1.Items.Add(rd["adi"].ToString() + " " +  rd["soyadi"].ToString());
            }
            
            
        }

        // ürümler
        public void urunGetir()
        {
            DB db = new DB();
            comboBox2.Items.Clear();
            urList.Clear();
            SQLiteDataReader rd = db.dataGetir("urunler");
            while (rd.Read())
            {
                urList.Add(rd["id"].ToString());
                comboBox2.Items.Add(rd["adi"].ToString());
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secKul = kulList[comboBox1.SelectedIndex].ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            secUr = urList[comboBox2.SelectedIndex].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                int sonuc = db.ekleData("siparis", new String[] { "null", secKul, secUr, textBox1.Text, DateTime.Now.ToString() });
                if (sonuc > 0)
                {
                    siparisTable();
                    MessageBox.Show("Sipariş Tamamlandı");
                }
                else {
                    MessageBox.Show("Hata");
                }
                db.kapat();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata " + ex);
            }
            
        }

//eklediğimiz datanın anlık gelmesi gerekiyor.
        public void siparisTable() {
            DB db = new DB();
           // SQLiteDataReader rd = db.dataGetir("siparis");
            SQLiteDataReader rd = db.query("select s.id,s.fiyat,k.adi,u.adi,u.kisa_aciklama ,s.tarih from siparis as s left join kullanicilar as k on s.kul_id=k.id left join urunler as u on u.id=s.urun_id");//bunu yazarsak insert ederiz.İstediğimiz veriyi getiriyoruz.
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;

        }
        //
    }
}
