using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_uygulama
{
    class ogretmen:yetenek//ogretmen yetenekten miras aldı

    {
        public override string hesapla()
        {
            unvan = "öğretmen";
            int ucret = saat * maas*2;//metodu öğretmene özgü bir metod haline getirdik.
            return unvan + "aylık" + ucret;
        }
    }
}
