using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_insertSelectDelete
{
    class DB
    {

        // bağlantı değişkenleri
        String dbName = "NORTHWND";
        String userName = "sa";
        String userPass = "12345";
        String dataSource = "SC-105-01\\MSSQL2012";

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



    }
}
