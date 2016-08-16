using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_EntityUsing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*NORTHWNDEntities nt = new NORTHWNDEntities();//entity classı oluşturup bağlantı kurarız.
            Category ct = new Category();
            ct.CategoryName = "emine";
            nt.Categories.Add(ct);//kategori tablosuna categoriname ekleme işlemi yaptık.
            nt.SaveChanges();//bun yapmazsak kaydetmez.*/
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category ct = new Category();
            ct.CategoryName = "deneme";
            ct.Description = "açıklama";
            ct.Picture = null;
            ekle(ct);

        }
        //data ekleme fonksiyonu
        public int ekle(Category ct) {//ekle burada object alsın her sınıftan is diye tanıtıp kullanabiliriz.
            int sonuc=-1;
            try
            {
                using (var context = new NORTHWNDEntities()) { //bu  using i yukarda kütüphanelerin içinde kullanabiilirdik.ama burda ihtiyaç var başka yere gerek yoktu fiye yazdık
                    context.Categories.Add(ct);
                   sonuc= context.SaveChanges();

                  
                
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ekleme hatası:" +ex);
            }
            return sonuc;//başarısızlık söz konusu ise -1 dönsün
        }
        public int sil(int id)
        {
            int sonuc = -1;
            try
            {
                using (var context = new NORTHWNDEntities()) {

                    Category ct = context.Categories.FirstOrDefault(sil=>sil.CategoryID==id);//firstordefault koşul sayısını artırmak için kullanılır.
                    //sil=>sil.CategoryID==id categoriidsi id ye eşit olanı sil demektir.
                    context.Categories.Remove(ct);
                    sonuc = context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Silme hatası"+ex);
            }
            return sonuc;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sil(10);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = 10;
            try
            {
                using (var context = new NORTHWNDEntities()) { //burada silme ile aynı tek farkla savechange işlemi vardır.
             Category ct = context.Categories.FirstOrDefault(sil => sil.CategoryID == id);
             if (ct!=null)
             {
                 ct.CategoryName = "Deneme1";
                 ct.Description = "Açıklama -1";
                 context.SaveChanges();
                 MessageBox.Show("Güncelleme işlemi başarılı :)");
                 
             }
                
                
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Güncelleme hatası");
            }
        }

        private void btnProdecure_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context=new NORTHWNDEntities())
                {
                    dataGridView1.DataSource = context.getirData();
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA"+ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new NORTHWNDEntities())
                {
                    dataGridView1.DataSource = context.ara(textBox1.Text);
                    context.Categories.SqlQuery("select *from Categories where CategoryID='"+textBox1.Text+"')");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA" + ex);
            }
        }
    }
}
