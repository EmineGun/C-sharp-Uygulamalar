using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_TEKRAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yetenek yt = new yetenek("ali");
            yetenek.diger dg = new yetenek.diger("gün");//sınıf içinde sınıfa erişmek.ne kadar sınıf olursa da . operatörü ile erişilir.
        }
    }
}
