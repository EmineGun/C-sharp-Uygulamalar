using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//eklenecek yetenekler
using System.IO;
using System.Data.SQLite;

namespace _11_SQlite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //db bağlantısı yapılıyor.
                string dbName = "proje.db";
                SQLiteConnection conn = new SQLiteConnection("data source="+dbName);//daima bir connnection oluşturmak zorundayız.Burada Sqlite ı kullanmadan önce bir connection yapmalıyız.Connectionımızın içinde kullanacağımız veritabanı ya da dosyanın bilgileri olmalıdır.
                conn.Open();//açtığımız connection daima open() metodu ile açılmalı.
                SQLiteCommand cmd = new SQLiteCommand("select* from kullanicilar",conn);//data okumak için kullanılır.Bu bağlantıyı yürütmek için bir komuta ihtiyaç vardı bu da command sınıfıdır.
                SQLiteDataReader rd = cmd.ExecuteReader();//şimdi execute metodlarından bize değişen satır sayısını integer olarak döndüren metodu kullanacaz.
                while (rd.Read())//peek() ile read() suan aynı
                {//read metodu ile rd nesnesinin içi dolaşılıp okunuyor.
                    MessageBox.Show("gelen değer"+rd["adi"].ToString());
                }

               
                


            }
            catch (Exception ex)
            {

                MessageBox.Show("hata"+ex);
            }
        }
    }
}
/*SQL Veri Türleri

1.	Metinsel Veri Türleri
a.	Char – 8000 karaktere kadar değer alır. 
b.	Varchar – uzun metin işlemleri için kullanılır.
c.	Nvarchar – uzunluğu kadar değer yazılmaz ise kendisini boşlukla tamamlar.
d.	VarcharMax – 2gb değer alır. 
e.	Text – 2 milyar karakterin üzerinde karakter alır.
2.	Matematiksel  Türler
a.	Int – tam sayı veri türleri ailesinden bir üye. 10 karakter sığası vardır. 4 byte’lık yer kaplar.
b.	Bigint – tam sayı, 8 byte’lık yer kaplar. 20 hane alır. 
c.	Smallint – 2 byte yer kaplar
d.	Tinyint – 255 kadar sayı alır, 1 byte yer kaplar.
e.	Byte – true, false değerler için kullanılır.
f.	Decimal – ondalıklı sayı değerleri için kullanılır.
g.	Money – finansal işlemler için kullanılır.8 byte lık yer kaplar.
h.	Smallmoney – 4 byte’lık yer kaplar.
i.	Real – finansal ve daha fazla ondalık değer için kullanılır.
3.	Tarih ve zaman türleri
a.	Date – Yıl, Ay, Gün formatında değer alır.
b.	DateTime – Yıl,Ay,Gün Saat Dakika Saniye
c.	Time – Saat dakika saniye
d.	DatetimeOfset – Datatime formatını verir, yerel saati sunucudan ayırarak kayıt eder.
4.	Diğer very türleri
a.	Geography – harita üzerinde enlem ve boylamın alınarak yazıldığı türdür.
b.	Xml – very türünü xml olarak kaydetmeye yarar. 
c.	Geometry – x,y,z koordinatlarını alır.
1.	DATA ÇEKME SORGULARI - select
a.	select *from Categories – Tüm Categories tablosu
b.	select *from Employees where EmployeeID = 3 – EmployeeID’si 3 olan Employees satırı gelir.
c.	select *from Employees where FirstName = 'Janet' – FirstName’ değeri “janet” olan satırı getir.
d.	select *from orders where CustomerID =  'VINET' and EmployeeID  = 5  - çok koşullu arama yöntemi
e.	select *from orders  where shipvia between   1 and 3 – aralık belirterek data çekme
f.	select *from orders limit 0,5 – 0’dan başla 5 adet satır bilgi getir.
2.	Data ekleme  - insert işlemi
a.	insert into Categories values(null,'Tekstil','','')
b.	insert into Categories(id, name) values(9, ‘Tekstil’)
3.	data güncelleme – update
a.	update  Categories set  CategoryName = 'Beyaz Eşya' where CategoryID = 9 – güncelleme sorgusudur.
4.	Slime işlemi – delete
a.	delete from Categories where CategoryID = 9 – data slime işlemi
5.	tablo birleştirme - select  s.id, s.fiyat, k.adi,k.soyadi,u.adi,u.kisa_aciklama,s.tarih from siparis as s left join kullanicilar as k on s.kul_id = k.id left join urunler as u on  u.id = s.urun_id


*/