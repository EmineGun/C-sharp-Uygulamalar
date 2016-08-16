using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_oppGiris
{
   public  class islem//public olmak zorunda
    {
        public int topla(string sayi1, string sayi2)

        {
            int sonuc = 0;
            try
            {
                sonuc = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Tür dönüşüm hatası:" + ex);
            }
            return sonuc;
        }
        public int cikar(string sayi1, string sayi2)

        {
            int sonuc = 0;
            try
            {
                sonuc = Convert.ToInt32(sayi1) - Convert.ToInt32(sayi2);
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Tür dönüşüm hatası:" + ex);
            }
            return sonuc;
        }
    }
}
/*NOTLAR:
 * Bir sınıf oluşturunca kopyasını türetmediğimiz sürece çalışmaz.
 * Bu türetmee işlemi new anahtar sözcüğü ile yapılır.Tıpkı kimliğimiz gibi ası bizde durmak zorundadır kullanmak istediğimizde fotokopisini kullanır ve ilgili yerlere veririz.Bunun gibi classları kopyalarız ki başka uygulamalar aynı anda kullanabilsin bu classı.Bir sınıf kendinden oluşan bir nesneyi birbaşka nesneye veriyorsa tüm yeteneklerini de veriyordur demek olur.
 * Her sınıfın bir kurucu metodu vardır yazılmasa dahi tetiklenir.
 * Bir sınıf nesne olarak üretildiğinde mutlaka tetiklenmek zorundadır.
 * Biz  bir kurucu metod yazarsak bizim yazdığımız her halükarda default olanı ezer.
 * Sınıflar içinpropertyler , metodlar ve parametreler bulunur bir sınıfın gövdesi {} arasındatanımlı olan alandır.
 * Her fonksiyon gövdesi kendi içinde tanımlıdır ve aynı sınıf içindeki aynı metodlar dahi bunu kullanamazlar static hariç.
 * Sınıf içindeki yetrenekleri kullanmak istiyorsak nesne türetmek zoundayız nesne türetimi: SınıfAdı nesneAdı=new SınıfAdı();şeklindedir.
 * Sınıflar default olarak publictir.Private olsalar Başka sınıflar göremezlerdi.
 * Private:Gizli kalsın ama kendi sınıfım içinde kullanabileyim demektir.
 * Kurucu metodlar bir sınıfın hazır bulunuşluğunu arttırır.
 * sınıf içindei yeteneklere . operatörü ile erişilir.
 * Bir değişken default olarak Privatetır biz istersek public yaparız.
 * Bir fonksiyonun dönüş tipi neyse ona göre davranış gösterir.
 
 */
