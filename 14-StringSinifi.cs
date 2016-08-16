using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_StringSinifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.ToUpper();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.ToLower();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            int sonuc = a.CompareTo(b);
           
            MessageBox.Show(sonuc+"");
        }

        private void button5_Click(object sender, EventArgs e)
        {
              String a = textBox1.Text;
            String b = textBox2.Text;
            Boolean durum = a.Equals(b);//iki string değeri kesinlikle bu yöntemle kıyaslamamız gerekiyor.Tercih edilen yöntem.
            if (a==b)
            {
                MessageBox.Show("bilgiler doğru -1");
            }
            if (durum)
            {
                MessageBox.Show("bilgiler doğru -2");
            }
            else
            {
                MessageBox.Show("hata");
            }
        }
        //compare metodu
        private void button6_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
           int sonuc = String.Compare(a,b,true);//büyük küçük harf duyarlılığı olmadan kıyasla.
           if (sonuc>-1)
           {
               MessageBox.Show("Değerler Eşit");
           }
           MessageBox.Show("compare sonuc:"+sonuc);
        }
//Trim metodu
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
        }

        //concat metodu + opertaörü gibidir.(+) operatörü int değer varsa işlem yapmaya çalışır bu daha iyi.
        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Concat(textBox1.Text, textBox2.Text);
        }
        //contains metodu:karekter katarı alır.
        private void button9_Click(object sender, EventArgs e)
        {
            bool sonuc = textBox3.Text.Contains(textBox1.Text);
           // int i = textBox3.Text.IndexOf(textBox1.Text);//indexof metodu kaçıncı index olduğu
            MessageBox.Show("gelen sonuc "+sonuc);
        }
        //split metodu
        private void button10_Click(object sender, EventArgs e)
        {
           
            String[] dizi = textBox3.Text.Split(' ');
            MessageBox.Show("Texte"+dizi.Length+"sayıda kelime var");
        }
        //Substring metodu
        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.Substring(6,5 );//Substring(0,5);0:başlangıç 5: kaç tane getirecek length
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int indexbaslangic = textBox3.Text.IndexOf(textBox1.Text);
            int indexbitis = indexbaslangic + textBox1.Text.Length;
            MessageBox.Show("başlangıç"+indexbaslangic+"bitiş"+indexbitis);
        }
        //replace metodu:
        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.Replace(textBox1.Text,textBox2.Text);
        }
        //IsNullOrEmpty:içi boşsa tru döner.
        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("isNull Kontrol "+String.IsNullOrEmpty(textBox1.Text.Trim()));
            
        }
        //join metodu
        private void button1_Click(object sender, EventArgs e)
        {
            String[] dizi = new string[] { "ali","veli","hasan","ayşe"};
            String degisken = String.Join(",",dizi);
            MessageBox.Show("gelen değişken"+degisken);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
