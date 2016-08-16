using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Interface
{
    class yetenek:erisim,soyut,DigerInterface//implement ettik soyut , den sonra kabul edilir çünkü interface 
        //çoklu kalıtıma interface ile izin veriliyor.
        //interface in amaçlarından biri programa root vermek.
        //aynı isimde farklı sınıflarda fonksiyon varsa fonksiyonlar sınıfIsmi. operatörü ile birbirinden ayrılırlar.
        //interfacelerin içinde gövdeli metod yazılmaz.
        //kurucu metodları olmaz.
        //base vs gibi şeyleri kabul etmez.
        //property oluşturulmaz(interfacete)
        //interface bir düşünce yapısıdır.
        

    {
        public int islem(int a,int b) {
            return a + b;
        }


        public void adiniYaz(string data)
        {
            System.Windows.Forms.MessageBox.Show(data+" Adini Yaz çalişti");

        }

        public override string durum()
        {
            return "durum çalıştı";
        }



        /*public void calis()//diğerinterface içinde calis var sınıf adı ile çağıracaz.
        {
            System.Windows.Forms.MessageBox.Show("diğer interface çalıştı.");
        }*/


     
        void soyut.calis()//aynı metod adına sahip oldukları için böle yazdık.
        {
           
        }

        void DigerInterface.calis()
        {
            
        }
    }
}
