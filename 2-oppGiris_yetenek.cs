using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//windows formu miras yapacam message box getirecem.

namespace _2_oppGiris
{
   public class yetenek
    {
      public   string adi = "ali";//public attık ki yt. ile erişelim çünkü default olarak private tanımlanış.
        public void adiniYaz()
        {
            string soyadi = "bilmem";
            Console.WriteLine(this.adi);
        }

        //namespace proje adı
        //class-bir sınıf oluşturmanın anahtar kelimesidir.
        //her sınıfn bir kurucu metodu vardır.Yazılmasa bile mutlaka tetiklenir.
        //sınıflar içinde metodlar ,özellikler,değişkenler ,static değşken tipleri vb.
        //sınıf içindeki yetenekleri kullanmak istiyosak nesne türetimi yapmak zorundayız.
        //nesne türetimi=> sınıfadı nesneadı=new sınıfadı(); şeklinde tanımlanır.
        //sınıf içerisindekş yeteneklere erişmek istiyosak . operatörü ile erişiriz.
        public yetenek()
        {
            //kurucu metodu eğer yazmaak dahi gelir.
            MessageBox.Show("merhaba ben boş kurucu metod");
          
            
        }
        //geri dön
        public int islem(string data) {
            return data.Length;
        }

    }
}
