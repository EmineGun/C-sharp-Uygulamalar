using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _8_SoyutSınıflar
{
   abstract  class Hasta//abstract ile artık soyut sınıf yaptık.//abstract sınıfının defaultu publictir.
    {
        private String sehir;

        public String Sehir
        {
            get { return sehir; }
            set { sehir = value; }
        }
        private String adres;

        public String Adres
        {
            get { return adres; }
            set { adres = value; }
        }

       public static int yasi = 0;
       public static void stFnc() {//static kullanımı
           System.Windows.Forms.MessageBox.Show("Static çalıştı");
       }
       //arraylist
       ArrayList hastaList = new ArrayList();
      

       public Hasta() {

           for (int i = 0; i < 10; i++)
           {//soyut sınıfın içindeki propertileri kullanmak için dictionary oluşturduk çünkü soyut sınıf türetilemiyor.
                Dictionary<string, string> dc = new Dictionary<string, string>();
                dc.Add("adres","a"+i);
                dc.Add("sehir","b"+i);
                hastaList.Add(dc);
           }
       
       }
       public Hasta(float boy,float kilo) {
           System.Windows.Forms.MessageBox.Show("çalıştı");
           this.boy = boy;
           this.kilo = kilo;
       }
        //hastada olan ortak özellikler buraya yazılacak.
        public float boy;
        public float kilo;
        //Soyut bir metod soyut bir metod içine yazılır.
        //soyut sınıf proje geliştirme aşamasıdır.
       //SOYUT METOD TANIMLAMA
        public abstract float boykiloHesabi(float boy, float kilo);//abstract ile gövdesiz metod yaratırız.
        public abstract int boyOran(int boy);//+shift+b yaptığımızda implemente edilmediği için hata verir.


       //soyut sınıf içinde gövdeli metod da yazılabilir.
        public void hastaCalis() {
            System.Windows.Forms.MessageBox.Show("toplam değeri"+(this.boy+this.kilo));
        }
       //virtual metod:abstract virtual kullabnımına izin vermez.

      // public virtual void hastaAdi(){
     //  System.Windows.Forms.MessageBox.Show("hasta adi: ALİ");
       //}
    }
}
