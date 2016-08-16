using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_KurucuMetodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yetenek yt = new Yetenek("merhaba ben kurucu");//burada hangi constructurı çağırırsak o tetklenir.
        }
    }
}
/*NOTLAR:
 
 * Global olduğunda bir metod veya bir nesne farklı metod gövdelerinde de kullanılabilir.Kod tekrarinden kurtuluruz.
 * Yordamlama.çBir adrese bir isim vermektir.Bir postacıya hergün aynıyeri tarif etmektense isim vermek daha iyidir gibi düşünülebilir.
 * Throw:Try-Catch içinde sanki parametrenin içinde hata gelmş de yakalamış gibidir.
 * Kurucu Metod özellikleri:
 * Kurucu metodlar sınıf adı ile aynı olmak zorundadırlar.
 * kurucu metodlar return almazlar.
 * kurucu metodlar void ya da herhangi bir dönüş türü almazlar.Yani dönüş tipleri yoktur.
 * Normal metod davranışı sergilemezler.
 * Erişim belirtici alırlar.(public, private gibi)
 * Parametre alırlar.
 * Yazılmasa dahi kurucu metodlar vardır.
 * Nesne olarak türetildiği yerde seçilebilirler.Yani hangi kurucu metodu tetiklemek istiyorsam seçerim.
 * Bir sınıfın hazır bulunuşluğunu artırırlar.
 * Class adı ile kesinlikle aynı olmak zorundadırlar.
 * Constructur kullanım etkileri:Bir database için bağlantı kurulumu yapılabilir.Hazır bulunuşluk.Metod constructur içinde tetiklenebilir.
 * STATİC HAKKINDA:
 * this anahtar sözcüğü ile static beraber kullanılmaz.
 * Static kendine ait bir bellek açtıve kendi pointer adresini oluşturdu this de gelip aynısını yapmaya çalışır o zaman static buna izin vermez.
 * Static oluşturduğumuzda pointer özelliği global olur ve tüm sınıflar nesne türetmeksizin ulaşıp kullanırlar.
 * Static metodlar içinde kesinkle this kullanılmaz.
 */