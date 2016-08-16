using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_JsonKullanimi
{
    class urun
    {

        private string urunId;

        public string UrunId
        {
            get { return urunId; }
            set { urunId = value; }
        }
        private string baslik;

        public string Baslik
        {
            get { return baslik; }
            set { baslik = value; }
        }
        private string ucret;

        public string Ucret
        {
            get { return ucret; }
            set { ucret = value; }
        }
        private string tarih;

        public string Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }


    }
}
