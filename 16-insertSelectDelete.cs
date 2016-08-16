using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;


namespace _16_insertSelectDelete
{
    public partial class Form1 : Form
    {
        ArrayList ls = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            data();
        }
        //İNSERT İŞLEMİ YAPAN KOD PARÇASI
        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            String sorgu = "insert into kullanici values('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "', GETDATE())";
            SqlCommand cm = new SqlCommand(sorgu, db.conn);
            int sonuc = cm.ExecuteNonQuery();
            if (sonuc > 0)
            {
                data();
                MessageBox.Show("Kayıt İşlemi Başarılı !!!");
            }
            db.conn.Close();
        }


        // DATALARI GETİREN FONSİYON
        public void data() {
            try
            {
                listBox1.Items.Clear();
                ls.Clear();

                DB db = new DB();
                SqlCommand cm = new SqlCommand("select *from kullanici", db.conn);
                SqlDataReader rd = cm.ExecuteReader();
                while (rd.Read()) {
                    listBox1.Items.Add(rd["adi"] + " "+ rd["soyadi"]);
                    ls.Add(rd["id"]);
                }
                db.conn.Close();
                rd.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Data Okuma Hatası : " + ex);
            }
        }

        String id = "";
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = ls[listBox1.SelectedIndex].ToString() ;
            //MessageBox.Show("Gelen " + id);
        }
        //SİLME İŞLEMİ YAPAN KODLAR
        private void button2_Click(object sender, EventArgs e)
        {
            if (id.Equals(""))
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }
            else
            {

                DB db = new DB();
                SqlCommand cm = new SqlCommand("delete from kullanici where id = '" + id + "'", db.conn);
                int sonuc = cm.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    data();
                    MessageBox.Show("Silme İşlemi Başarılı");
                    id = "";
                }
            }
        }


    }
}
