using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Property
{
    class kisiler
    {

        private String id;//ctrl+r+e property yaparız.
        private String adi;
        private String soyadi;
        private String yas;

        public string İd//id ini get set propertisi
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

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

        public string Yas
        {
            get
            {
                return yas;
            }

            set
            {
                yas = value;
            }
        }
    }
}
