using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_uygulama
{
  public   class yetenek
    {
      public yetenek(){
      
      }
      //mesaiye kalan çalışan 
      public yetenek(int maas,int saat)
      {
         this. maas = maas*2;
         this.saat = saat;
        
          
      }
        // public String islem = "";
        public String unvan = "";
        public int saat = 0;
        public int maas =0;
        public virtual String hesapla() {
            int ucret = this.saat * this.maas;
            return unvan + "aylık" + ucret;
        }

    }
}
