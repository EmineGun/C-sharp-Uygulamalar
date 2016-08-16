using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Uygulama
{
   public  class Kisi
    {
        private string adi;//ctrl+r+e property oluşturur.
        private string soyadi;
        private string tel;
        private string mail;

        public string Adi
        {
            get
            {
                return adi;
            }

            set
            {
                adi = value;
            }
        }

        public string Soyadi
        {
            get
            {
                return soyadi;
            }

            set
            {
                soyadi = value;
            }
        }

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }
    }
}
