using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _8_SoyutSınıflar
{

    class Tansiyon:Hasta
    {

        public Tansiyon():base(50,50) 
        {
            hastaAdi();
            this.boy = boy;
            this.kilo = kilo;
        }
       public  ArrayList  ls = new ArrayList();
        public override float boykiloHesabi(float boy, float kilo)

        {
            for (int i = 0; i < 10; i++)
            {
                Tansiyon ts = new Tansiyon();
                ts.Sehir = "a"+i;
                ts.Adres = "b"+i;
                ls.Add(ts);
            }

            hastaCalis();
            return this.boy / this.kilo;
        }
        //tansiyona ait özellik
        public void calis() {
            System.Windows.Forms.MessageBox.Show("tansiyon hastası");
        }

        public override int boyOran(int boy)
        {
            throw new NotImplementedException();
        }
        public override void hastaAdi() { 
        
        //soyut sınıflar içinde virtual anahtar kelimesi gövdeli metod alır.
        }
    }
}
