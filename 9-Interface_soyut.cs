using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Interface
{
    //class anahtar kelimesi kullanılmaz.
    //ınterface anahtar kelimesi ile kullanılır
    //sınıf davranışı yook.
    //interface içinde herhangi bir özellik default olarak publictir.
    //içerisndeki soyut metodlar herhangi bir anahtar kelime almazlar.
    interface soyut
    {
        //yetenek yt = new yetenek();//nesneyi aktaramaz.
       
       // int a = 10;

        
        void adiniYaz(string data);
        void calis();
       
    }
}
