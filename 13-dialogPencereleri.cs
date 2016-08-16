using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace _13_dialogPencereleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.SelectionBackColor = Color.White;
                richTextBox1.SelectionColor = colorDialog1.Color;
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        String yaz = "";
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Tüm dosyalar(.*)|*.*| Zengin Metin Belgesi(*.rtf)|*.rtf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                String filePath = openFileDialog1.FileName;
                yaz = filePath;
                StreamReader rd = new StreamReader(filePath);
                richTextBox1.Rtf = rd.ReadToEnd();
                rd.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Tüm dosyalar(.*)|*.*| Zengin Metin Belgesi(*.rtf)|*.rtf";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                String path = saveFileDialog1.FileName;
                StreamWriter yaz = new StreamWriter(path);
                yaz.Write(richTextBox1.Rtf);
                yaz.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter sy = new StreamWriter(yaz);
            sy.Write(richTextBox1.Rtf);
            sy.Close();
        }
    }
}
