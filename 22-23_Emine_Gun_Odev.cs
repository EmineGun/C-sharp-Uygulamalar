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

namespace _22_23_Emine_Gun_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            /* 1. Yöntem String gelen = Convert.ToString(cmd.ExecuteScalar());//tekil bir yanıt beklendiğinden bu kullanıldı.*/
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            DateTimePicker data1 = dateTimePicker1;
            DateTimePicker data2 = dateTimePicker2;
            SqlCommand cmd = new SqlCommand("select dbo.TarihKiyasla(@tarih1,@tarih2)", db.conn);
            SqlParameter t1 = new SqlParameter("@tarih1", SqlDbType.DateTime);
            SqlParameter t2 = new SqlParameter("@tarih2", SqlDbType.DateTime);
            t1.Value = data1;
            t2.Value = data2;

            cmd.Parameters.Add(t1);
            cmd.Parameters.Add(t2);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            String gelen = rd[0].ToString();
        }
    }
}
