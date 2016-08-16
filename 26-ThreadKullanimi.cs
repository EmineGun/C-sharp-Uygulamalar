using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _26_ThreadKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {

            Thread th1 = new Thread(new ThreadStart(calis1));
            Thread th2 = new Thread(new ThreadStart(calis2));

            th1.Start();
            th2.Start();

        }


        void calis1() {
            int i = 0;
            while (true) {
                Thread.Sleep(100); // uyutma ms cinsinden değer alır
                this.Invoke(new MethodInvoker(delegate()
                    {
                       listBox1.Items.Add("Ali " + i++); 
                    }
                    ));
                //MessageBox.Show("Test -1");
                //listBox1.Items.Add("Ali " + i++);
            }  
        }

        void calis2() {
            int i = 0;
            while (true)
            {
                Thread.Sleep(100);
                this.Invoke(new MethodInvoker(delegate()
                {
                    listBox2.Items.Add("Veli " + i++);
                }
                    ));
                //MessageBox.Show("Test -2");
                //listBox2.Items.Add("Veli " + i++);
            }  
        }
    }
}
