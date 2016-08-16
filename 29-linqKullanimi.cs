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

namespace _29_linqKullanimi
{
    public partial class Form1 : Form
    {
        ArrayList ls = new ArrayList();
        String[] dizi = { "ali","veli","hasan"};  

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ls.Add(textBox1.Text);
            a ns = new a();
            ns.C = textBox1.Text;
            ls.Add(ns);

            int sayi = dizi.Length;
            sayi++;
            Array.Resize(ref dizi, sayi);

            dizi[sayi-1] = textBox1.Text;
        }

        private void textBox2_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            String gelen = (from isim in dizi
                        where isim == textBox2.Text
                        select isim).FirstOrDefault();
            if (gelen != null)
            listView1.Items.Add(gelen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IEnumerable<a> gelen = from a isim in ls 
                                   where isim.C == "a"
                                   select isim;
            foreach (a item in gelen) {
                listBox1.Items.Add(item.C);
            }


        }


        
    }
}
