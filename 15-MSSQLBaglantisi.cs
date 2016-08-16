using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;


namespace _15_MSSQLBaglantisi
{
    public partial class Form1 : Form
    {

        // bağlantı değişkenleri
        String dbName = "NORTHWND";
        String userName = "sa";
        String userPass = "12345";
        String dataSource = "SC-105-01\\MSSQL2012";

        // sqlconnetion nesnesi
        SqlConnection conn = null;


        public Form1()
        {
            InitializeComponent();

            try
            {
                // sql bağlantısı yapılıyor
                conn = new SqlConnection("Data Source=" + dataSource+ ";Initial Catalog ="+dbName+";User Id="+userName+";Password="+userPass);
                if (conn.State == ConnectionState.Closed) {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bağlantı Hatası : " + ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            dataGridView1.DataSource = null;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cm = new SqlCommand("select *from Categories", conn);
                SqlDataReader rd = cm.ExecuteReader();
                while (rd.Read()) {
                    listBox1.Items.Add(rd["CategoryName"].ToString());
                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Data Okuma Hatası : " + ex);
            }


            // datagridview
            try
            {
                conn.Open();
                SqlCommand cm = new SqlCommand("select *from Categories", conn);
                SqlDataReader rd = cm.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("DataGrid Hatası " + ex);
            }


        }
    }
}
