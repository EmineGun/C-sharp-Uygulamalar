using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_inheritance
{
    class yetenek
    {

        public yetenek()
        {
            calis();

            //miras alma yönteminde önce miras alınan kurucu metot tetiklenir sonra bizim nesnemiz tetiklenir
        }

        public yetenek(String adi) {
            System.Windows.Forms.MessageBox.Show("yetenek parametre" + adi);
        
        }
           
        //miras alma
        //sınıf: diğer sınıf şeklinde gerçeklweşir
        //bir sınıf miras aldığğında miras aldığı sınıf gibi davranış gösterir
        //nesne türetmeksizin miras içindeki bütün yeteneklere sahip olur
        //miras alınan sınıf içerisindeki kurucu metod tetiklenmiş
        //kurucu metodlardan hangisinin çalışması gerektiğine base() ile karar ver
        //miras alınan sınıf içine birşey yazılmazsa boş structure çalışır.
       public String adi = "ali";

        public void calis()
        {
System.Windows.Forms.MessageBox.Show("calis() çalıştı");
        }

        //override metod hazırlanması
        //override etmek istiyorsanız virtual anahtar kelimesi almak zorundadır.
        public virtual int toplam(int a, int b) {
            return a + b;
        }
        public static void staticYaz()
        {
            System.Windows.Forms.MessageBox.Show("static metod çalıştı");
        }
      
    }
}
