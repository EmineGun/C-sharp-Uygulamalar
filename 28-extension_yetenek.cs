using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_extension
{
    public static class yetenek
    {

        public static int tekUret(this Random sayi, int basla, int bitis) {
            Random rd = new Random();
            int deger = rd.Next(basla,bitis);
            while(deger %2 == 0){
                deger = rd.Next(basla, bitis);
            }
            return deger;
        }


        public static char[] karakterDizi(this String data, String bilgi) {
            char[] dizi = bilgi.ToCharArray();
            return dizi;
        }


        public static int cikarma(this yeniYetenek yt, int a, int b) {
            return a - b;
        }


    }
}
