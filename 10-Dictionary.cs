using System;
using System.Collections.Generic;//dictionary burdan alır .
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //dictionary yapısı:
            //key - value anahtar çiftlerii ile gerçekleşir.
        Dictionary<String, String> dic = new Dictionary<string, string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //deger ekleme
            dic.Add("adi","Ali");
            dic.Add("soyadi", "Veli");
           // dic.Add("yasi", "30");//aynı keyler olamaz.
            dic.Add("yasi", "30");
            //değer değiştirme
            dic["adi"] = "Hasan";

            //deger çağırma
           // MessageBox.Show(dic["adi"]);//çalıştığın ali ibaresi gelir.
            //eleman silme
          dic.Remove("yasi");//key ve value birlikte gider
           // dic.Remove("30");//value silme olmuyor.
            //tüm elemanları silme
         // dic.Clear();
            //eleman sayısı
          dic.Count();
          if (dic.ContainsKey("adi"))
          {
               MessageBox.Show("key bulundu");
          }
          if (dic.ContainsValue("Ali"))
          {
              MessageBox.Show("Value bulundu");
          }

           //key-val değerlerini alma
            foreach (KeyValuePair<String, String> item in dic)//KeyValuePair<String,String> dic in içinde gezeriz.
            {
                listBox1.Items.Add(item.Key);
               listBox2.Items.Add(item.Value);
              // MessageBox.Show(dic[item.Key]);
               // dic.Remove(item.Key);
            }
           

            //sadece key listeleme
            //listBox2.Items.Clear();
            foreach (String item in dic.Keys)
            {
                listBox2.Items.Add(item);//artık direk iteme ulaşırız.
            }
        }
    }
}
