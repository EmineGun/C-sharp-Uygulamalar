using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//dosya işlemleri için 


namespace _1_dosyaislemleri
{
    
    public partial class Form1 : Form
    {
        string filePath = "";//dosya için path belirtmek zorundayız.Proje nerede çalışırsa orada türer.
        StreamReader ilkYaz = new StreamReader("acilis.txt");
        public Form1()
        {
            InitializeComponent();//bu form yüklendiğinde formla ilgili tüm nesneleri getirir.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("acilis.txt"))//varsa oluşturma yoksa oluştur 
            {
            StreamWriter yaz= new StreamWriter("acilis.txt");//bunu korumak için yapıyoruz.
                yaz.WriteLine("ol.txt");
                yaz.Close();
            filePath =ilkYaz.ReadLine();
                ilkYaz.Close();
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter yaz = new StreamWriter(filePath);
            yaz.WriteLine("yazılan değer");
            yaz.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
           StreamWriter ekle = File.AppendText(filePath);//ekle nesnesi oluştu eklemek üzere oluşturuldu//appent ile var olan dosyayı koruyarak yazıyoruz.
            
            ekle.WriteLine(textBox1.Text);//textbox1 den gelen veriyi ekliyor.
            ekle.Close();
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader oku = new StreamReader(filePath);//dosyalardan okuma yapöak için.
                                                          //iterasyon oluştur.
            textBox2.Text = oku.ReadLine();//iterasyon biterse okumaz.
            while (oku.Peek()>=0)//peek tıpkı foreach gibi işlem yapar.bu koşul olmazsa sonusz döner.
                //peek():reader nesnesi içine filePath gibi bir içerik alıyordu.
            {
                listBox1.Items.Add(oku.ReadLine());//spesific bir satırı okumak istesem bunu for ile yapmam gerek.
                //for (int i = 0; i <= listBox1.Items.Count; i++)
                //{
                //    listBox1.Items.Add(oku.ReadLine());
                //}
                
            }
            oku.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter hataYaz = null;
            try
            {
                int a = 1;
                int b = 0;
                int i = a / b;
            }
            catch (Exception ex)
            {

            hataYaz = new StreamWriter("hata.txt");
                hataYaz.WriteLine(ex);
            }
            finally
            {
                hataYaz.Close();//hata olsa da kapatmak zorundayız.
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //dosya içine dosya yazma
            StreamWriter ilkOku = new StreamWriter("acilis.txt");
            ilkOku.WriteLine(textBox3.Text);
            ilkOku.Close();
          
        }
    }
}
/*NOTLAR: FileStream => StreamWriter ve StreamReader metodları dosya işlemleri için yeterli.
 * FilePath:dosyayolu fileStream sınıfı birparametre olmadan işleme girmiyor.
 * FileWriter:mevcut dosyayı siler ve yeni bri tane ekler.
 * FileApend :Append.text varolan dosyanın içine ekleme yapar.
 * Dosyadan okuma işlemleri iterasyon iterasyon ilerler Peek() Metodu bunun için kullanılır.Peek() Foreach döngüsü gibi içini gezer.
 * StreamReader :Dosyadan Okuma sınıfı.
 * Listbox içine değer yazma:ListBox1.Items.Add(Oku.ReadLine()); Readline satır satır okuma yapar read deseydik ilk karekterin ASCII kodunu dönderirdi.
 * Okunan dosya kaptılmak zorunda.Oku.Close() gibi.
 * FileExist:Bu dosyadan var mı yok mu varsa oluşturma yoksa oluştur bool değer dönderir.
 * File.Append: var olan dosyayı koruyarak içine yazar.

 */
