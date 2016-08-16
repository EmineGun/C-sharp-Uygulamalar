using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_TimerKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start(); // timer başlat
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer başladığında çalışacak gövde
            i++;
            listBox1.Items.Add("Ekle : " + i);
            label1.Text = ""+DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
