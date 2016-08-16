using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_Update
{
    class DB
    {
        //bağlantı değişkenleri
        String dbName = "NORTHWND";
        String userName = "sa";
        String userPassword = "12345";
        String dataSource = "SC-105-04\\MSSQL2012";

        //Sqlconnection nesnesi
        public SqlConnection conn = null;//bağlantı değişkenleri


        public DB()
        {
            try
            {
                //sql bağlantısı yapılıyor
                conn = new SqlConnection("Data Source = " + dataSource + ";Initial Catalog=" + dbName + ";User Id=" + userName + ";Password=" + userPassword);
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
        //kapatma fonksiyonu
        public void kapat() {
            try
            {
                if (conn.State!=ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("DB kapatma sorunu"+ex);
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
        public SqlDataReader dataGetir(string tableName)
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
    }
}
