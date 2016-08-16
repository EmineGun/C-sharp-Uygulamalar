using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _6_Uygulama
{
    public partial class datalar : Form
    {
        public datalar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.ls;//arraylisti diğer fromdaki  data gridviwe çekti
            dataGridView1.Columns[0].Width = 50;

        }
        public void calis(ArrayList ls) {
          //  dataGridView1.DataSource = ls;
            //eğer arraylist static olmasa gidip metod kullanmak zorundayız.
        }
    }
}
