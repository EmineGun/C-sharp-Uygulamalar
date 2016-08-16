using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_TEKRAR
{
    class yetenek
    {
       yetenek()//private özelliğinde ise başka sınıfın içinde değil kendi sınıfı içinde görünür.
        {
 yetenek yt = new yetenek();//constructur içinde constructur dersek sonsuz döngüye girer..kendi içinde tetiklenirse sonsuz döngü.

        }
        public yetenek(string adi,int yasi)
        {
            yetenek yt = new yetenek();//cunstructr overload1
            diger dg = new diger("gün");
        }
        public yetenek(string adi)
        {
            yetenek yt = new yetenek();//cunstructr overload2
            geriDon();//bu parametreli olan çalıştığında geridön çalıştır.
        }
        public int geriDon()
        {
            return 10;
        }
        public string data = "ben de";//this iile buna ulaştım. aynı isimde .olunca this kullanmak gerek.
        public string  ekleData="";
        public string ekle(string data)
        {
            new diger("").geriDon();
            return this.data + data;
        }
        public class diger
        {
            String soyadi = "";
            public diger(string soyadi)//dahili sınıf olsa bile kurucu metod oluşturuyoz.kendi içinde bir iş parcacığı.
            {
                yetenek yt = new yetenek();
                this.soyadi = soyadi + yt.ekleData;
            }
            public int geriDon()
            {
                return 10;
            }
        }
        
    }
}
