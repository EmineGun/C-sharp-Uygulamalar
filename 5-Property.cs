using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;//collectionlardan birini kullanmak için ekleriz.

namespace _5_Property
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  ArrayList ls = new ArrayList();//arraylist sınıfından bir nesne 
        private void btnDataGetir_Click(object sender, EventArgs e)
        {
            //arraylist tanımı
          
            for (int i = 0; i < 100; i++)
            {
                kisiler ks = new kisiler();
                ks.İd = "" + i;//"" kullanarak cast (parse)ediyor.
                ks.Adi = "ali" + i;
                ks.Soyadi = "bilmem"+i;
                ks.Yas = "" + (10+i);
                ls.Add(ks);

            }
            dataGridView1.DataSource = ls;//
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = null;
            string data = textBox1.Text;
            ArrayList ekle = new ArrayList();//eşit olanları burda biriktirdik.
            for (int i = 0; i < ls.Count; i++)//count dinamiktir yani uzunluğu bilmiyoruz.
                //as ve is objectlerde kullanılır ama tryparse hepsi için kullanılabilir.
            {
                kisiler ara =(kisiler) ls[i];
                if (ara.Adi.Contains(data) || ara.Soyadi.Contains(data))
                {
                    ekle.Add(ls[i]);
                }
            }
            dataGridView1.DataSource = ekle;//ekle olanları çektik.
           
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