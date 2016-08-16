using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_uygulama
{
    class memur:yetenek
    {
        public override string hesapla()
        {
            unvan = "memur";
            int ucret = saat * maas * 3;//metodu memura özgü bir metod haline getirdik.
            return unvan + "aylık" + ucret;
        }
    }
}
