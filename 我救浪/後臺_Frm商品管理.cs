using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 我救浪
{
    public partial class 後臺_Frm商品管理 : Form
    {
        我救浪Entities dbContext = new 我救浪Entities();
        public 後臺_Frm商品管理()
        {
            InitializeComponent();
            LoadCategoryToComboBox();
            
        }
    public class ComboboxItem
    {
        public ComboboxItem(string text,int value)
            {
                Text = text;
                Value = value;
            }
        public string Text { get; set; }
        public int Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
        void LoadCategoryToComboBox()
        {
            var q_Supplier = from s in dbContext.Suppliers
                             select s;
            comboBox3.DataSource = q_Supplier.ToList();
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "SupplierID";
            comboBox5.DataSource = q_Supplier.ToList();
            comboBox5.DisplayMember = "Name";
            comboBox5.ValueMember = "SupplierID";

            var q_CategoryPet = from c in dbContext.Categories
                                where c.IsPet == true
                                select c;
            comboBox8.DataSource = q_CategoryPet.ToList();
            comboBox8.DisplayMember = "CategoryName";
            comboBox8.ValueMember = "CategoryID";
            comboBox7.DataSource = q_CategoryPet.ToList();
            comboBox7.DisplayMember = "CategoryName";
            comboBox7.ValueMember = "CategoryID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.Text);
            //MessageBox.Show((comboBox1.SelectedItem as ComboboxItem).Value.ToString());
            var q_SubCategory = from sc in dbContext.SubCategories.AsEnumerable()
                                    //where sc.CategoryID == (comboBox1.SelectedItem as ComboboxItem).Value
                               where sc.Category.CategoryName == comboBox1.Text
                                select sc;
            //foreach (var sc in q_SubCategory)
            //{
            //    comboBox2.Items.Add(sc);
            //}
            comboBox2.DataSource = q_SubCategory.ToList();
            comboBox2.DisplayMember = "SubCategoryName";
            comboBox2.ValueMember = "SubCategoryID";
            comboBox2.Text = "";
        }

        private void Form_商品管理1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox6.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox8.Text = "";
            comboBox7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Products.AsEnumerable()
                    where p.IsPet == false &&
                    (string.IsNullOrEmpty(comboBox1.Text) ? true : comboBox1.Text == p.SubCategory.Category.CategoryName) &&
                     (string.IsNullOrEmpty(comboBox2.Text) ? true : comboBox2.Text == p.SubCategory.SubCategoryName) &&
                      (string.IsNullOrEmpty(textBox1.Text) ? true : textBox1.Text == p.ProductName) &&
                       (string.IsNullOrEmpty(textBox3.Text) ? true : p.Price >= int.Parse(textBox3.Text)) &&
                        (string.IsNullOrEmpty(textBox2.Text) ? true : p.Price <= int.Parse(textBox2.Text)) &&
                        (string.IsNullOrEmpty(textBox6.Text) ? true : p.UnitsInStock >= int.Parse(textBox6.Text)) &&
                        (string.IsNullOrEmpty(textBox8.Text) ? true : p.UnitsInStock <= int.Parse(textBox8.Text)) &&
                         (string.IsNullOrEmpty(comboBox3.Text) ? true : comboBox3.Text == p.Supplier.Name)
                    select new
                    {
                        p.ProductID,
                        p.ProductName,
                        p.Price,
                        p.UnitsInStock,
                        p.SubCategory.Category.CategoryName,
                        p.SubCategory.SubCategoryName,
                        Supplier=p.Supplier.Name
                    };
            dataGridView1.DataSource = q.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var q = (from p in dbContext.Products.AsEnumerable()
                     where p.ProductID == (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value
                     select new
                     {
                         ProductID = p.ProductID,
                         Category = p.SubCategory.Category.CategoryName,
                         SubCategory = p.SubCategory.SubCategoryName,
                         ProductName = p.ProductName,
                         Price = p.Price,
                         p.UnitsInStock,
                         Supplier = p.Supplier.Name,
                         p.Description,
                         Parent = RetrunParentCategory((int)p.SubCategory.Category.ParentCategory),
                         ParentID = p.SubCategory.Category.ParentCategory,
                     }
                     ).FirstOrDefault();

            comboBox7.SelectedIndex = comboBox7.FindStringExact(q.Parent);

            var q2 = from c in dbContext.Categories
                     where c.IsPet == false && c.ParentCategory == q.ParentID
                     select c;
            comboBox6.DataSource = q2.ToList();
            comboBox6.DisplayMember = "CategoryName";
            comboBox6.ValueMember = "CategoryID";

            var q3 = from sc in dbContext.SubCategories
                                where sc.Category.CategoryName == q.Category
                                select sc;

            comboBox4.DataSource = q3.ToList();
            comboBox4.DisplayMember = "SubCategoryName";
            comboBox4.ValueMember = "SubCategoryID";


            textBox4.Text = q.ProductName;
            textBox5.Text = q.Price.ToString();
            comboBox5.Text = q.Supplier;
            textBox7.Text = q.UnitsInStock.ToString();
            textBox9.Text = q.Description;

            LoadPicture(q.ProductID, pictureBox1);
        }
        string RetrunParentCategory(int parentID)
        {
            var q = (from c in dbContext.Categories
                    where c.CategoryID == parentID
                    select c).FirstOrDefault();
            return q.CategoryName;
        }
        void LoadPicture(int productID,PictureBox pictureBox)
        {
            pictureBox.DataBindings.Clear();
            var q = from ph in dbContext.Photos
                    where ph.ProductID == productID
                    select ph;

            pictureBox.Image = null;
            bindingSource1.DataSource = q.ToList();
            pictureBox.DataBindings.Add("Image",bindingSource1,"Picture",true);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product()
                {
                    ProductName = textBox4.Text,
                    Price = decimal.Parse(textBox5.Text),
                    UnitsInStock= int.Parse(textBox7.Text),
                    SubCategoryID = (int)comboBox4.SelectedValue,
                    SupplierID = (int)(comboBox5.SelectedValue),
                    IsPet = false,
                    Description=textBox9.Text
                };
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
                MessageBox.Show("新增成功");
                SelectAllToDatagridview();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void SelectAllToDatagridview()
        {
            var q = from p in dbContext.Products
                    where p.IsPet==false
                    select new
                    {
                        p.ProductID,
                        p.ProductName,
                        p.Price,
                        p.UnitsInStock,
                        p.SubCategory.Category.CategoryName,
                        p.SubCategory.SubCategoryName,
                        Supplier = p.Supplier.Name
                    }
                    ;
            dataGridView1.DataSource = q.ToList();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int productID = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
            var q = (from p in dbContext.Products
                     where p.ProductID == productID
                     select p).FirstOrDefault();
            if(q==null)
            {
                MessageBox.Show("刪除失敗");
                return;
            }
            dbContext.Products.Remove(q);
            dbContext.SaveChanges();
            MessageBox.Show("刪除成功");
            SelectAllToDatagridview();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                int productID = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
                var q = (from p in dbContext.Products
                         where p.ProductID == productID
                         select p).FirstOrDefault();
                if(q==null)
                {
                    MessageBox.Show("修改失敗");
                    return;
                }
                q.ProductName = textBox4.Text;
                q.SubCategoryID = (int)comboBox4.SelectedValue;
                q.Price = decimal.Parse(textBox5.Text);
                q.UnitsInStock = int.Parse(textBox7.Text);
                q.SupplierID =(int)comboBox5.SelectedValue;
                q.Description = textBox9.Text;
                dbContext.SaveChanges();
                MessageBox.Show("修改成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show("修改失敗");
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int productId = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
            byte[] bytes = null;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            bytes = ms.GetBuffer();

            Photo photo = new Photo()
            {
                ProductID=productId,
                Picture=bytes
            };
            dbContext.Photos.Add(photo);
            dbContext.SaveChanges();
            MessageBox.Show("新增照片成功");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dbContext.Photos.Remove(((Photo)(bindingSource1.Current))); 
            dbContext.SaveChanges();
            MessageBox.Show("刪除成功");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Position == bindingSource1.Count - 1) bindingSource1.MoveFirst();
            else
            {
                bindingSource1.MoveNext();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                comboBox2.DataSource = null;
            }
        }

        private void comboBox6_TextChanged(object sender, EventArgs e)
        {
            if (comboBox6.Text == "")
            {
                comboBox4.DataSource = null;
            }
        }
        string ReturnParent(int ParentID)
        {
            var q = (from c in dbContext.Categories
                     where c.CategoryID == ParentID
                     select c).FirstOrDefault();
            return q.CategoryName;
        }

        private void comboBox8_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var q = from c in dbContext.Categories.AsEnumerable()
                                where c.ParentCategory ==(int) (comboBox8.SelectedValue) && c.IsPet==false
                                select c;
            comboBox1.DataSource = q.ToList();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            comboBox1.Text = "";
        }

        private void comboBox7_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox7.SelectedValue.GetType() != typeof(int)) return;
            var q = from c in dbContext.Categories.AsEnumerable()
                    where c.ParentCategory == (int)(comboBox7.SelectedValue) && c.IsPet == false
                    select c;
            comboBox6.DataSource = q.ToList();
            comboBox6.DisplayMember = "CategoryName";
            comboBox6.ValueMember = "CategoryID";
            comboBox6.Text = "";
        }

        private void comboBox6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //  if (comboBox6.SelectedValue.GetType() != typeof(int)) return;;
            var q_SubCategory = from sc in dbContext.SubCategories
                                where sc.CategoryID== (int)comboBox6.SelectedValue
                                select sc;
            comboBox4.DataSource = q_SubCategory.ToList();
            comboBox4.DisplayMember = "SubCategoryName";
            comboBox4.ValueMember = "SubCategoryID";
            comboBox4.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            後臺_Frm留言管理 f = new 後臺_Frm留言管理();
            f.Show();
        }
    }
}
