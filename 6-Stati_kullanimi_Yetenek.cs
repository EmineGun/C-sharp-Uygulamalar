using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Stati_kullanimi
{
   public  class Yetenek//her yerden erişim olsun.
    {
        //static anahtar kelimesi:statik değişken yada fonk siyon nesne türetmye ihtiyaç kalmaksızın sınıf ism ile birlikte direk erişime sahipitir.
        //static değerlere erişim için nesne oluşturursak hata oluşur.Çünkü statik kopyaya ihtiyaç duymaz .
        //classları genelde statik oluşturmayız.Yoksa birden fazla kopyalarıını oluşturamayız.
        //fonksiyonlarda da kullanılırlar sınıf.fncÇalistir kullanılır.
        //return varsa çağrıldığı yere cevap olarak döner.
        //static metodlar override edilemez değişime uygun değil.
        //static bir metod ta this anahtar kelimesi kullanılmaz.
        //nesneler static olabilir.
        //static sınıfların kurucuları public olmaksızın statik kelimesi alırlar .statik olduğu için türetme olmaksızın sadece bir kez çalışır.
        public static String deger = "Ali";
       public  static Random ns = new Random();
        
        public static int hesapla(string data)//static metod.
        {
            return data.Length;
        }
    }
}
