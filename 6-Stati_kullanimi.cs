using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Stati_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataGonder_Click(object sender, EventArgs e)
        {
            Yetenek.deger = txtData.Text;
            DataGetir ns = new DataGetir();
            ns.Show();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            //bir formdan diğer forma data aktarma.
            DataGetir ns = new DataGetir();
            ns.calis(txtData.Text);
            ns.Show();
        }
    }
}
/*NOTLAR:
 
 * Bir değişken tanımlandıktan sonra ilk değer atamazsak bazen ilk değer ister bazen de istemez hangi durumda ister hangi durumlarda istemez? inr id; id=a; dersek hata verir.Burada değer change yapmaya çalışıyoruz.
 * Bir değişkenin değerini kullanmaya çalıştığımızda hata verir çünkü ilk değer ataması yok.
 * string ilk değeri null boolean default değeri false integerın 0'dır.Sayı doğrusunu düşünüp ortadan yakalamaya çalışmalıyız.
 * Private bir değişken kendi değeri içinde erişilir.Farklı sınıflar içinde erişilemezler.get:yazmaya set:okumaya uygunluk demek.
 * Bir değişken private halde ise properti haline gelmeden başka sınıflar tarafından kullanılamaz.
 * Private değişken adı:CTRL+E+R kısa yolu ile properti haline getirilir.
 * keyup:tıklandığında harekete geçen bir eventtir.
 * Keypress:Tıklayıp çekince çalışır.
 * Contains Metodu:Gibi miyi arar.Benzerini arar.True ya da falsedeğer döner.
 */