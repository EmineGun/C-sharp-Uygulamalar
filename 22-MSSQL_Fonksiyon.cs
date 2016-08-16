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
namespace _22_MSSQL_Fonksiyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataGetir_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            String data = textBox1.Text;
            SqlCommand cmd = new SqlCommand("select dbo.fncCalis(@adi)",db.conn);
            SqlParameter adi = new SqlParameter("@adi",SqlDbType.VarChar,50);
            adi.Value = data;
            cmd.Parameters.Add(adi);
            SqlDataReader rd = cmd.ExecuteReader();
            rd.Read();
            String gelen = rd[0].ToString();
           /* 1. Yöntem String gelen = Convert.ToString(cmd.ExecuteScalar());//tekil bir yanıt beklendiğinden bu kullanıldı.*/
            textBox2.Text = gelen;
        }
    }
}
