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
    public partial class Form2 : Form
    {
        int durX = 0;

        public Form2()
        {
            InitializeComponent();
            durX = label3.Location.X;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(new ThreadStart(kutu1));
            Thread th2 = new Thread(new ThreadStart(kutu2));

            th1.Start();
            th2.Start();
        }

        Random rd = new Random();
        void kutu1() {
            
            int i = 0;
            int sayac = 0;
            while(true){
                Thread.Sleep(100);
                if (label1.Location.X + label1.Width + label3.Width >= durX) break;
                this.Invoke(new MethodInvoker(delegate(){
                    if (i < 10) i++;
                    label1.Location = new Point(label1.Location.X + rd.Next(0,10) , label1.Location.Y);
                    textBox1.Text = "" + sayac++;
                }));
            }
        }

        void kutu2() {
            int i = 0;
            int sayac = 0;
            while (true)
            {
                Thread.Sleep(100);
                if (label2.Location.X + label2.Width + label3.Width >= durX) break; 
                this.Invoke(new MethodInvoker(delegate()
                {
                    if (i < 10) i++;
                    label2.Location = new Point(label2.Location.X + rd.Next(0, 10), label2.Location.Y);
                    textBox2.Text = "" + sayac++;
                }));
            }
        }
    }
}
