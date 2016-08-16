using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_uygulama
{
    class polis:yetenek
    {
        public polis(int maas, int saat):base(maas,saat)//yetenek sınıfının içinde boş bir constructur vardır onu deil bunu çalıştır.
        {
            //polisten alınan data direkt olarak base e gönderdik.
        }
        public override string hesapla()
        {

            unvan = "polis";
            int ucret = saat * maas * 3;//metodu polise özgü bir metod haline getirdik.
            return unvan + "aylık" + ucret;
        }
    }
}
