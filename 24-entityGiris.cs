using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace _24_entityGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DBEntity db = new DBEntity();
        private void button1_Click(object sender, EventArgs e)
        {
            Category cr = new Category();
            cr.CategoryName = "ornek";
            cr.Description = "açıklama";
            cr.Picture = null;
            db.Categories.Add(cr);
            db.SaveChanges();
            button2_Click(null, null);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            IEnumerable<Category> liste = db.Categories;
            ArrayList ls = new ArrayList();
            foreach (var item in liste)
            {
                Category c = new Category();
                c.CategoryID = item.CategoryID;
                c.CategoryName = item.CategoryName;
                c.Description = item.Description;
                c.Picture = item.Picture;
                ls.Add(c);
            }
            dataGridView1.DataSource = ls;
        }




        int did = -1;
        private void button3_Click(object sender, EventArgs e)
        {
            String id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            did = Convert.ToInt32(id);
            db.Categories.Remove(db.Categories.Find(did));
            try
            {
                db.SaveChanges();
                button2_Click(null, null);
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Silme Hatası : " + ex);
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            String query = "delete from Categories where CategoryID = '"+did+"'";
            var rows = db.Database.ExecuteSqlCommand(query);
            if (rows >= 0) {
                MessageBox.Show("silme İşlemi Başarılı");
            }
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            did = Convert.ToInt32(id);
        }



        }
    }
}
