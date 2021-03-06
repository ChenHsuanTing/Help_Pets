using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCategoryToComboBox();
            LoadYearToCombobox();
            //LoadMonthToCombobox();
            //LoadGradeToCombobox();
            LoadProductIDToCombobox();
        }

        public class ComboboxItem
        {
            public ComboboxItem(string text, int value)
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
                        Supplier = p.Supplier.Name
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
        void LoadPicture(int productID, PictureBox pictureBox)
        {
            pictureBox.DataBindings.Clear();
            var q = from ph in dbContext.Photos
                    where ph.ProductID == productID
                    select ph;

            pictureBox.Image = null;
            bindingSource1.DataSource = q.ToList();
            pictureBox.DataBindings.Add("Image", bindingSource1, "Picture", true);
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
                    UnitsInStock = int.Parse(textBox7.Text),
                    SubCategoryID = (int)comboBox4.SelectedValue,
                    SupplierID = (int)(comboBox5.SelectedValue),
                    IsPet = false,
                    Description = textBox9.Text
                };
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
                MessageBox.Show("新增成功");
                SelectAllToDatagridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void SelectAllToDatagridview()
        {
            var q = from p in dbContext.Products
                    where p.IsPet == false
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
            if (q == null)
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
                if (q == null)
                {
                    MessageBox.Show("修改失敗");
                    return;
                }
                q.ProductName = textBox4.Text;
                q.SubCategoryID = (int)comboBox4.SelectedValue;
                q.Price = decimal.Parse(textBox5.Text);
                q.UnitsInStock = int.Parse(textBox7.Text);
                q.SupplierID = (int)comboBox5.SelectedValue;
                q.Description = textBox9.Text;
                dbContext.SaveChanges();
                MessageBox.Show("修改成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("修改失敗");
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
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
                ProductID = productId,
                Picture = bytes
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
            if (comboBox1.Text == "")
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
                    where c.ParentCategory == (int)(comboBox8.SelectedValue) && c.IsPet == false
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
                                where sc.CategoryID == (int)comboBox6.SelectedValue
                                select sc;
            comboBox4.DataSource = q_SubCategory.ToList();
            comboBox4.DisplayMember = "SubCategoryName";
            comboBox4.ValueMember = "SubCategoryID";
            comboBox4.Text = "";
        }
        //==================================================================
        //評論管理
        private void LoadProductIDToCombobox()
        {
            var q = from m in this.dbcontext.Member_Comment
                    orderby m.ProductID
                    select m.ProductID;
            var Mgrade = q.Distinct();
            foreach (var grade in Mgrade)
            {
                this.comboBox4.Items.Add(grade);
            }
        }

        //private void LoadGradeToCombobox()
        //{
        //    var q = from m in this.dbcontext.Member_Comment
        //            orderby m.Grade
        //            select m.Grade;
        //    var Mgrade = q.Distinct();
        //    foreach (var grade in Mgrade)
        //    {
        //        this.comboBox3.Items.Add(grade);
        //    }
        //}

        private void LoadYearToCombobox()
        {
            var q = from m in this.dbcontext.Member_Comment
                    orderby m.CommentDate.Value.Year ascending
                    select m.CommentDate.Value.Year;
            var Myear = q.Distinct();
            foreach (var year in Myear)
            {
                this.comboBox1.Items.Add(year);
            }
        }

        private void btnAllComment_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };

            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn5star_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    where m.Grade == 5
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn4star_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    where m.Grade == 4
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn3star_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    where m.Grade == 3
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn2star_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    where m.Grade == 2
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn1star_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    where m.Grade == 1
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("請選擇年份!");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("請選擇月份!");
            }
            else
            {
                string year = comboBox1.Text;
                string month = comboBox2.Text;
                var q = from m in this.dbcontext.Member_Comment
                        where m.CommentDate.Value.Year.ToString() == year
                           && m.CommentDate.Value.Month.ToString() == month
                        select new
                        {
                            m.CommentID,
                            m.ProductID,
                            m.MemberID,
                            m.Member.Name,
                            m.Grade,
                            m.Description,
                            m.CommentDate
                        };
                this.dataGridView1.DataSource = q.ToList();
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Add Product
            if (txtProducts.Text == "")
            {
                MessageBox.Show("請輸入編號!");
            }
            else if (txtMember.Text == "")
            {
                MessageBox.Show("請輸入編號!");
            }
            else if (comboBox3.Text == "")
            {
                MessageBox.Show("請選擇星等!");
            }
            else if (txtComment.Text == "")
            {
                MessageBox.Show("請輸入評論!");
            }
            else
            {

                Member_Comment comment = new Member_Comment
                {
                    ProductID = int.Parse(this.txtProducts.Text),
                    MemberID = int.Parse(this.txtMember.Text),
                    Description = this.txtComment.Text,
                    Grade = int.Parse(this.comboBox3.Text),
                    CommentDate = DateTime.Today,

                };
                this.dbcontext.Member_Comment.Add(comment);

                this.dbcontext.SaveChanges();
                MessageBox.Show("新增成功");
                this.Read_RefreshDataGridView();
                this.comboBox1.Items.Clear();
                this.comboBox4.Items.Clear();
                LoadYearToCombobox();
                LoadProductIDToCombobox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete
            var comment = (from m in this.dbcontext.Member_Comment.AsEnumerable()
                           where m.CommentID == int.Parse(this.dataGridView1.SelectedCells[0].Value.ToString())
                           select m).FirstOrDefault();

            if (comment == null) return;

            this.dbcontext.Member_Comment.Remove(comment);
            this.dbcontext.SaveChanges();
            MessageBox.Show("刪除成功");
            this.Read_RefreshDataGridView();

            this.comboBox1.Items.Clear();
            this.comboBox4.Items.Clear();
            LoadYearToCombobox();
            LoadProductIDToCombobox();
        }
        void Read_RefreshDataGridView()
        {
            var q = from m in this.dbcontext.Member_Comment
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            //this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                MessageBox.Show("請選擇星等!");
            }
            else if (txtComment.Text == "")
            {
                MessageBox.Show("請輸入評論!");
            }
            else
            {
                var comment = (from m in this.dbcontext.Member_Comment.AsEnumerable()
                               where m.CommentID == int.Parse(this.dataGridView1.SelectedCells[0].Value.ToString())
                               select m).FirstOrDefault();

                if (comment == null) return; //exit method

                comment.Description = txtComment.Text;
                comment.Grade = int.Parse(comboBox3.Text);

                this.dbcontext.SaveChanges();
                int r = dataGridView1.CurrentCell.RowIndex;
                int c = dataGridView1.CurrentCell.ColumnIndex;
                MessageBox.Show("修改成功");
                this.Read_RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1.Rows[r].Cells[c];
            }

        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            {
                MessageBox.Show("請選擇編號!");
            }
            else
            {

                var q = from m in this.dbcontext.Member_Comment.AsEnumerable()
                        where m.ProductID == int.Parse(this.comboBox4.Text)
                        select new
                        {
                            m.CommentID,
                            m.ProductID,
                            m.MemberID,
                            m.Member.Name,
                            m.Grade,
                            m.Description,
                            m.CommentDate
                        };
                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {//todo
            txtProducts.Text = dataGridView2.CurrentRow.Cells["ProductID"].Value.ToString();
            txtMember.Text = dataGridView2.CurrentRow.Cells["MemberID"].Value.ToString();
            comboBox3.Text = dataGridView2.CurrentRow.Cells["Grade"].Value.ToString();
            txtComment.Text = dataGridView2.CurrentRow.Cells["Description"].Value.ToString();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.comboBox2.Text = "";
            this.comboBox2.Items.Clear();
            var q = (from m in this.dbcontext.Member_Comment
                     orderby m.CommentDate
                     where m.CommentDate.Value.Year.ToString() == comboBox1.SelectedItem.ToString()
                     select m.CommentDate.Value.Month).Distinct();

            foreach (var n in q)
            {
                this.comboBox2.Items.Add(n);
            }
        }
    }
}
