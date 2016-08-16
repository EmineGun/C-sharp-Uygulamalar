using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_SoyutSınıflar
{
    public partial class Form1 : Form
    {

        //soyut sınıflar abstract anahtar kelimesi ile gerçeklerşir.
        //eğer soyut sınıfın içinde soyut metod varsa metodlar da absc-tract nalır.Gövdesiz metodlardır.Void ya da return alabilirler.
        //soyut sınıf içine normal gövdeli metodlar yazılır.
        //nesne olarak türetilemez.
        //miras olarak alınırlar.
        //sınıf davranışı göstermezler.
        //soyut sınıflar iş bölümü sağlar takım liderlerine iş yükü konusunda yardımcı olur.
        //soyut sınıflar içinde metodlar private olamaz.
        //normal metod olyuşturulduğunda virtual anahtar kelimesi alamazlar.
        //normal method virtual anahtar kelimesi alarak miras verildiğinde override edilebilirler.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hasta.stFnc();//sınıf türetimi yapmadan gelir staticin özelliğinden kaynaklı
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tansiyon ts = new Tansiyon();
           
            Noroloji nr = new Noroloji();
            nr.boy =(float) Convert.ToDouble(textBox1.Text);
            nr.kilo = (float) Convert.ToDouble(textBox2.Text);
            label1.Text = "" + ts.boykiloHesabi(0,0);
            label2.Text = "" + nr.boykiloHesabi(0,0);
            dataGridView1.DataSource = ts.ls;
        }
    }
}
