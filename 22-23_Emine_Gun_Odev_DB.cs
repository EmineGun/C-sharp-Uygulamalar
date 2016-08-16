using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace _22_23_Emine_Gun_Odev
{
    class DB
    {
        /*DataBase classın bulunan Metodlar:
         * data ekleme
         * data getirme
         * kapatma fonksiyonu
         * DB açma
         * data getir fnc
         * ekleme fonksiyonu
         * MD5 şifreleme
         
         */

        //İnsert için gereken propertiler
        public String Sifre { get; set; }
       
        public String Ad { get; set; }
      
        public String Soyad { get; set; }
     
        public String Mail { get; set; }

        // bağlantı değişkenleri
        String dbName = "NORTHWND";
        String userName = "sa";
        String userPass = "12345";
        String dataSource = "SC-105-04\\MSSQL2012";

        // sqlconnetion nesnesi
        public SqlConnection conn = null;


        public DB() {
            try
            {
                // sql bağlantısı yapılıyor
                conn = new SqlConnection("Data Source=" + dataSource + ";Initial Catalog =" + dbName + ";User Id=" + userName + ";Password=" + userPass);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bağlantı Hatası : " + ex);
            } 
        }

        //yeni ürün ekleme fonksiyonu
        /*  
        }


        

        
        */
        // data ekleme fonksiyonu
        public int dataEkle(String query)
        {
            int sonuc = -1;
            try
            {
                SqlCommand cm = new SqlCommand(query, conn);
                sonuc = cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Yazma Hatası " + ex);
            }
            return sonuc;
        }
        // data getirme fonksiyonu
        public SqlDataReader dataGetir(String tableName)
        {
            SqlDataReader rd = null;
            try
            {
                SqlCommand cm = new SqlCommand("select *from " + tableName, conn);
                rd = cm.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Okuma Hatası " + ex);
            }
            return rd;
        }
        //kapatma fonksiyonu
        public void kapat()
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("DB kapatma sorunu" + ex);
            }
        }
        //DB açma sorunu
        public void acma()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("DB açma sorunu" + ex);
            }
        }
        //data getir fnc
        public SqlDataReader dataGetirme(string tableName)
        {
            SqlDataReader rd = null;
            try
            {


                SqlCommand cmd = new SqlCommand("select *from " + tableName, conn);
                rd = cmd.ExecuteReader();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Data Getir Hatası" + ex);
            }
            return rd;
        }
        // ekleme fonksiyonu
        public int dataEkle()
        {
            SqlCommand command = new SqlCommand("INSERT INTO Admin(Mail, Sifre, Ad, Soyad) VALUES(@Mail, @Sifre, @Ad, @Soyad)", conn);
            command.Parameters.AddWithValue("@Mail", Mail);
            command.Parameters.AddWithValue("@Sifre", Sifre);
            command.Parameters.AddWithValue("@Ad", Ad);
            command.Parameters.AddWithValue("@Soyad", Soyad);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }

            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

        }
        //MD5 şifreleme

        public string MD5Sifrele(string metin)
        {
            // MD5CryptoServiceProvider nesnenin yeni bir instance'sını oluşturalım.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            //Girilen veriyi bir byte dizisine dönüştürelim ve hash hesaplamasını yapalım.
            byte[] btr = Encoding.UTF8.GetBytes(metin);
            btr = md5.ComputeHash(btr);

            //byte'ları biriktirmek için yeni bir StringBuilder ve string oluşturalım.
            StringBuilder sb = new StringBuilder();


            //hash yapılmış her bir byte'ı dizi içinden alalım ve her birini hexadecimal string olarak formatlayalım.
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürelim.
            return sb.ToString();
        }
        // data getirme fonksiyonu
        public SqlDataReader query(String query)
        {
            SqlDataReader rd = null;
            try
            {
                SqlCommand cm = new SqlCommand(query, conn);
                rd = cm.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Okuma Hatası " + ex);
            }
            return rd;
        }


    }
}
