using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Stati_kullanimi
{
    public partial class DataGetir : Form
    {
        public DataGetir()
        {
            InitializeComponent();
        }

        private void DataGetir_Load(object sender, EventArgs e)
        {
            //  MessageBox.Show("Değişen Data: "+Yetenek.deger);
            label1.Text = Yetenek.deger;//static veriler hafızanın heap kısmında saklanır tüm pointerlar bunu görebilir.
          label1.Text=Yetenek.deger+Yetenek.hesapla(Yetenek.deger)+""+Yetenek.ns.Next();//hesapla static olduğu için kendi değişmiş değişkenii gene çağırıyoz.
            
        }
        public void calis(String data) {
            MessageBox.Show("fnc data"+data);

        }

    }
}
