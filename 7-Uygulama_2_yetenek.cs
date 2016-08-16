using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _7_Uygulama_2
{
    class yetenek
    { public ArrayList ls=new ArrayList();
        public yetenek() {

            calis();//burada calis metodunu tetikliyoruz.
        }
        
       //arraylist biçimlendirme metodu
        public void calis() {

            for (int i = 0; i < 100; i++)
            {
                Kisiler ks = new Kisiler();
                ks.Id = "" + i;
                ks.Adi = "" + i;
                ks.Soyadi = "bilmem" + i;
                ks.Mail = "ali@ali.com" + i;
                ls.Add(ks);//farklı sınıfları arraylistin içine atabiliyoruz.

            }
        }
           
    }
}
