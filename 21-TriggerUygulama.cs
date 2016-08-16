using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _21_TriggerUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            dataGetir();
           
        }
 DB db=new DB();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            db.acma();
                
            string adi = textBox1.Text;
            try
            {
                SqlCommand cmd = new SqlCommand("insert into isimler values('"+adi+"',GetDate())",db.conn);

                int sonuc = cmd.ExecuteNonQuery();
                if (sonuc>0)
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata"+ex);
            }
            db.kapat();
            dataGetir();

        }

        public void dataGetir() {
            db.acma();
            
            try
            {
              
                AutoCompleteStringCollection isim = new AutoCompleteStringCollection();
                SqlCommand cmd = new SqlCommand("select *from isimlerArama",db.conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    isim.Add(rd["ekleisim"].ToString());
                }
                textBox2.AutoCompleteCustomSource = isim;
            }
            catch (Exception ex)
            {

                MessageBox.Show("hata"+ex);
            }
            db.kapat();
        }
    }
}
