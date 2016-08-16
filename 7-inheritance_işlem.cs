using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_inheritance
{
    class işlem:yetenek
    {
         public işlem()
         {
             isimYaz();
             
         }
        //base 2 kullanımı var kurucu ve gövdeli metot
        //base  anahtar kelimesi kurucu metod içerinde kullanılırsa miras aldığı
        //sınıfın kurucu metodunu etkiler.
        //base aynı zamanda sınıfa gelen parametreyi miras sınıfına gönderir.
        // base içindeki parametrelere karar verebiliriz base(adi=1==1? gonder"":"sadas")gibi


         public işlem(String adi) : base(adi) {//mirası veren için bir kurucu söz konusu değil.
            

             govdeli();
             //System.Windows.Forms.MessageBox.Show("parametreli çaliştı:" + adi);
             System.Windows.Forms.MessageBox.Show("toplam1 : " + toplam(10,30));
             System.Windows.Forms.MessageBox.Show("toplam2 : " +base. toplam(10, 30));
             toplam(10, 30);
             staticYaz();
             //yetenek.staticYaz();
             
             
             
         }
        
        public void isimYaz()
        {
            System.Windows.Forms.MessageBox.Show("isimYaz() çalıştı");
        }
        //gövdeli metod
        public static String gonder()
        {
            return "merhaba ali";
        }
        //base:miras alınan baba sınıftır.
       // gövdeli metot kullanımı
        public void govdeli() {
            base.calis();
            //String a = "yazı";
           
        }

        public override int toplam(int a, int b)
        {
            return (a+ b)*3;
        }
        //aynı isimdeki overload
        public int toplam(int a, int b, int c) {
            return (a - b);
        }
        //static kullanımı
        // static ve virtual kelimesi aynı yerde kullanılamazlar
        //bu yüzden override edilemezler
       
    }
}
