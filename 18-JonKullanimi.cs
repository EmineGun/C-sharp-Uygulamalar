using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_JonKullanimi
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.dataGrid("select *from Orders left join Customers on Customers.CustomerID =Orders.CustomerID");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
