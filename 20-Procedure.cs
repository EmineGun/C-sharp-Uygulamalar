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
using Store_Procedure_Odevi;

namespace _20_Procedure
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("dataGetir", db.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show("pro hatası " + ex);
            }
            finally {
                db.conn.Close();
            }
        }

        private void btnarama_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                db.ac();
                SqlCommand cmd = new SqlCommand("prcAra",db.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //parametre gönderiliyor
                /*SqlParameter arama = new SqlParameter("@ara", SqlDbType.VarChar, 100);
                arama.Direction = ParameterDirection.Input;//input işlemi varsa bunu kullanırız.
                arama.Value = textBox1.Text;//valuyu yazıyoruz.
                cmd.Parameters.Add(arama); bunu her parametre için ayrı ayrı yazıyoruz.*/
                SqlParameter arama = new SqlParameter("@ara", SqlDbType.VarChar, 100);
                arama.Direction = ParameterDirection.Input;//input işlemi varsa bunu kullanırız.
                arama.Value = textBox1.Text;//valuyu yazıyoruz.
                cmd.Parameters.Add(arama);
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Arama hatası"+ex);
            }

        }
    }
}
