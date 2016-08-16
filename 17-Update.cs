using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//dataReadder için bunu ekledik.
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//arraylist için kullanılacak.

namespace _17_Update
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
            lsDoldur();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //düzenleme işlemi
            db.acma();
            SqlCommand cmd = new SqlCommand("update Employees set LastName ='" + textBox1.Text + "',FirstName ='" + textBox2.Text + "',Title ='" + textBox3.Text + "',TitleOfCourtesy ='" + textBox4.Text + "'where EmployeeID = '" + id + "'", db.conn);
            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc>0)
            {
                lsDoldur();
                MessageBox.Show("Update işlemi :Başarılıdır");
            }
            db.kapat();

        }
        ArrayList ls = new ArrayList();
        //listbox doldurma
        public void lsDoldur() {

            ls.Clear();
            listBox1.Items.Clear();
            SqlDataReader rd = db.dataGetir("Employees");
            while (rd.Read())
            {
                
                listBox1.Items.Add(rd["LastName"]);
                ls.Add(rd["EmployeeID"]);
            }
            db.kapat();
        }
        string id = "";
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            db.acma();
            id = "" + ls[listBox1.SelectedIndex];
            SqlDataReader rd = db.dataGetir("Employees where EmployeeID = '" + id + "'");
            if (rd.Read())
            {
                textBox1.Text = rd["LastName"].ToString();
                textBox2.Text = rd["FirstName"].ToString();
                textBox3.Text = rd["Title"].ToString();
                textBox4.Text = rd["TitleOfCourtesy"].ToString();
            }
            else
            {
                MessageBox.Show("İD değeri hatalı");
            }
            db.kapat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
