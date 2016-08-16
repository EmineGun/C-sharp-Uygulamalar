using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _3_KurucuMetodlar
{
   public  class Yetenek
    {
        //kurucu metodlar:
        //kurucu metdolar sınıf adı ile aynı olmak zorundadır.
        //kurucu metodlar return almazlar 
        //kurucu metodlar void ya da tür almazlar
        //normal metod davranışı sergilemezler.
        //erişim belirteci alırlar.parametre alırlar.
        //nesne türetilirken tetiklenirler.
        //yazılmasa dahi her sınıfın bir kurucu metdou vardır.
        //nesne olarak türetildiği yerde farklı parametrelere sahipse seçilebilirler.
        //sınıfın hazır bulunuşluğunu artırırlar.
        //aynı tipte kurucu metodlar olamazlar.
        //default  halde bulunan kurucu metodu ezer.
        String dbName = "satila";

        public Yetenek()
        {
            //dbName kullan
        }
        public Yetenek(String adi) {
            //adi değişkeninn kullan
            fnc2();
        }
        public void fnc1()
        {
            System.Windows.Forms.MessageBox.Show("fnc1 tetiklendi.");
        }
        public void fnc2()
        {
            System.Windows.Forms.MessageBox.Show("fnc2 tetiklendi.");
        }
    }
}
