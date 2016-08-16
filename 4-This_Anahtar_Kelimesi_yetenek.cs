using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_This_Anahtar_Kelimesi
{
    class yetenek
    {
        //this anahtar kelimesi sınıfı işareti eder.Bulunduğu metodun referans metodunu işaret eder.
        //static metodlarda kullanılamazlar.
        private string sinifi;
        public String Sinifi {
            get
            {
                return sinifi;
            } set
            {
                sinifi = value;
            }

        }
      //  public string sinifi { get; }
        public  string adi = "ali";
    public    string soyadi = "bilmem";
        public static void test()
        {
            //static ile this aynı anda kullanılamaz çünkü staticin pointerı var bi daha pointer oluşturulamaz.
        }
        public void test1()
        {
            //static methotda this kullanılmaz.
            

        }
        public void test2(string adi)
        {
            //static methotda this kullanılmaz.
            this.adi = adi;//sınıfa gelen yeni adi değişkenini change et.
            soyadi = adi;
            

        }
        class dahili {

            String adi = "hasan";
        public void cagir()
            {
                System.Windows.Forms.MessageBox.Show(this.adi);
            }

        } 

        class sinif
        {
      
          
        }

    }
}
