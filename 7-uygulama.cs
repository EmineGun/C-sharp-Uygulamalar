using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int saat = Convert.ToInt32(textBox1.Text);
            int maas = Convert.ToInt32(textBox2.Text);
            polis pl = new polis(maas,saat);//kurucu metod oluşturulduktan sonra alt satırlara artık ihtiyaç kalmıyor
           // yetenek pl = new polis();// bu kullanımla bir üstteki satır aynı çünkü miras alıyor.
           // pl.maas = maas;
          //  pl.saat = saat;
            ogretmen og = new ogretmen();
            og.maas = maas;
            og.saat = saat;//değişken aktarımı yapmadan constructur ile yapılabilirdi.
            memur mr = new memur();
            mr.maas = maas;
            mr.saat = saat;
           // textBox3.Text = pl.hesapla() + "\r\n" + og.hesapla() +"\r\n"+ mr.hesapla();
            calis(pl);
            calis(og);
            calis(mr);//polimorfism örneği çokbiçimlilik.

        }
        public void calis(yetenek yt) { 
       
            MessageBox.Show("gelen"+yt.hesapla());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
