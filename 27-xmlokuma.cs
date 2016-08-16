using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace _27_xmlokuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList nlis = root.SelectNodes("/Tarih_Date/Currency");
            ArrayList ls = new ArrayList();
            foreach (XmlNode item in nlis)
            {
                doviz dv = new doviz();
                //dictionary gibi çalışır.
                
                
                dv.Isim=item["Isim"].InnerText;
                dv.Alis1 = item["ForexBuying"].InnerText;
                dv.Veris1 = item["ForexSelling"].InnerText;
                //bununla istediğim isme ait bilgiyi getiriyor.
                if (dv.Isim == "ABD DOLARI" )
                {
                    ls.Add(dv);
                }
                
                
            }
            dataGridView1.DataSource = ls;

        }
    }
}
