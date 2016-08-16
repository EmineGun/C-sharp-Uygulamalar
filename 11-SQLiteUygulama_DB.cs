using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// kütüphaneler
using System.Data;
using System.IO;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace _11_SQLiteUygulama
{
    class DB
    {

        // parametreler
        String dbName = "uygulama.db";
        String dbPath = "DB";
        public SQLiteConnection conn = null;

        // boş kurucu
        public DB() {
            if (conn == null)
            {
                try
                {
                    conn = new SQLiteConnection("Data Source="+ dbPath+ "\\" + dbName);
                    conn.Open();
                    //System.Windows.Forms.MessageBox.Show("Bağlantı Başarılı");
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Bağlantı Hatası : " + ex);
                }
            }
        }

        // dolu kurucu method
        public DB(String dbPath, String dbName) {

            if (conn == null)
            {
                try
                {
                    conn = new SQLiteConnection("Data Source=" + dbPath + "\\" + dbName);
                    conn.Open();
                    //System.Windows.Forms.MessageBox.Show("Bağlantı Başarılı");
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Bağlantı Hatası : " + ex);
                }
            }
        
        }


        // data getirme fonksiyonu
        public SQLiteDataReader dataGetir(String tableName) {
            SQLiteDataReader rd = null;
            try
            {
                SQLiteCommand cm = new SQLiteCommand("select *from " + tableName, conn);
                rd = cm.ExecuteReader();
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Okuma Hatası " + ex);
            }
            return rd;
        }

        // data ekleme fonksiyonu
        public int dataEkle(String query) {
            int sonuc = -1;
            try
            {
                SQLiteCommand cm = new SQLiteCommand(query, conn);
                sonuc = cm.ExecuteNonQuery();
            }
            catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Yazma Hatası " + ex);
            }
            return sonuc;
        }



        // ekleme fonksiyonu
        public int ekleData(String tableName, String[] dizi) {
            int sonuc = -1;
            try
            {
             
                if(dizi[0] == null) dizi[0] = "'null'";
                String sorgu = "insert into " + tableName + " values (" + dizi[0];
                for (int i = 1; i < dizi.Length; i++)
                {
                    sorgu += ",'" + dizi[i] + "'";
                }
                sorgu += ")";
                    System.Windows.Forms.MessageBox.Show(sorgu);
                SQLiteCommand cm = new SQLiteCommand(sorgu, conn);
                sonuc = cm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Hata : " + ex);
            } 
            return sonuc;
        }


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
        public SQLiteDataReader query(String query)
        {
            SQLiteDataReader rd = null;
            try
            {
                SQLiteCommand cm = new SQLiteCommand(query, conn);
                rd = cm.ExecuteReader();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Okuma Hatası " + ex);
            }
            return rd;
        }



        // kapat fnc
        public void kapat() {
            try
            {
                if (conn.State != ConnectionState.Closed) {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                
                
            }
        }


    }
}
