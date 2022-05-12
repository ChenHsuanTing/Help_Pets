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
    public partial class 後臺_Frm類別管理 : Form
    {
        我救浪Entities dbcontext = new 我救浪Entities();
        public 後臺_Frm類別管理()
        {
            InitializeComponent();
            LoadCategoryNameToCombobox();

        }

        private void LoadCategoryNameToCombobox()
        {
            var q = from c in this.dbcontext.Categories
                    where c.IsPet == true && c.CategoryName != "不限"
                    select c;
            this.cbProMainCategory.DataSource = q.ToList();
            cbProMainCategory.DisplayMember = "CategoryName";
            cbProMainCategory.ValueMember = "CategoryID";

            this.cbPetMainCategory.DataSource = q.ToList();
            cbPetMainCategory.DisplayMember = "CategoryName";
            cbPetMainCategory.ValueMember = "CategoryID";
        }

        private void cbPetMainCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var q = from s in this.dbcontext.SubCategories.AsEnumerable()
                    where s.CategoryID == (int)cbPetMainCategory.SelectedValue
                    select s;
            cbPetSubCategory.DataSource = q.ToList();
            cbPetSubCategory.DisplayMember = "SubCategoryName";
            cbPetSubCategory.ValueMember = "SubCategoryID";
        }
        private void btnPetCreate_Click(object sender, EventArgs e)
        {
            if (cbPetMainCategory.Text == "請選擇總類")
            {
                MessageBox.Show("請選擇總類");
            }
            else if (txtPetSubCategory.Text == "")
            {
                MessageBox.Show("請輸入分類名");
            }
            else
            {
                SubCategory subCategory = new SubCategory
                {
                    SubCategoryName = txtPetSubCategory.Text,
                    CategoryID = (int)cbPetMainCategory.SelectedValue
                };
                dbcontext.SubCategories.Add(subCategory);
                dbcontext.SaveChanges();
                MessageBox.Show("新增成功");
                btnPetReadAll.PerformClick();
                txtPetSubCategory.Text = "";
            }
        }
        private void btnPetUpdate_Click(object sender, EventArgs e)
        {
            if (cbPetMainCategory.Text == "請選擇總類")
            {
                MessageBox.Show("請選擇總類");
            }
            else if (cbPetSubCategory.Text == "請選擇分類")
            {
                MessageBox.Show("請選擇分類");
            }
            else if (txtPetSubCategory.Text == "")
            {
                MessageBox.Show("請輸入分類名");
            }
            else
            {
                var sub = (from s in this.dbcontext.SubCategories.AsEnumerable()
                           where s.SubCategoryID == (int)cbPetSubCategory.SelectedValue 
                           select s).FirstOrDefault();

                if (sub == null) return;
                sub.SubCategoryName = txtPetSubCategory.Text;
                this.dbcontext.SaveChanges();
                MessageBox.Show("更新成功");
                btnPetReadAll.PerformClick();
                txtPetSubCategory.Text = "";
            }

        }
        private void btnPetDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPetMainCategory.Text == "請選擇總類")
                {
                    MessageBox.Show("請選擇總類");
                }
                else if (cbPetSubCategory.Text == "請選擇分類")
                {
                    MessageBox.Show("請選擇分類");
                }
                else
                {
                    var sub = (from s in this.dbcontext.SubCategories.AsEnumerable()
                               where s.SubCategoryID == (int)cbPetSubCategory.SelectedValue
                               select s).FirstOrDefault();
                    if (sub == null) return;
                    this.dbcontext.SubCategories.Remove(sub);
                    this.dbcontext.SaveChanges();
                    MessageBox.Show("刪除成功");
                    btnPetReadAll.PerformClick();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("該分類尚有相關資訊未刪除，請確認");
                this.dbcontext = new 我救浪Entities();
            }


        }
        private void cbProMainCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var q = from c in this.dbcontext.Categories.AsEnumerable()
                    where c.IsPet == false && c.ParentCategory == (int)cbProMainCategory.SelectedValue
                    select c;
            cbProSubCategory.DataSource = q.ToList();
            cbProSubCategory.DisplayMember = "CategoryName";
            cbProSubCategory.ValueMember = "CategoryID";
        }
        private void cbProSubCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            var q = from s in this.dbcontext.SubCategories.AsEnumerable()
                    where s.CategoryID == (int)cbProSubCategory.SelectedValue
                    select s;
            cbProDetailCategory.DataSource = q.ToList();
            cbProDetailCategory.DisplayMember = "SubCategoryName";
            cbProDetailCategory.ValueMember = "SubCategoryID";
        }
        private void btnProSubCreate_Click(object sender, EventArgs e)
        {
            if (cbProMainCategory.Text == "請選擇總類")
            {
                MessageBox.Show("請選擇總類");
            }
            else if (txtSubCategory.Text == "")
            {
                MessageBox.Show("請輸入分類名");
            }
            else
            {
                Category category = new Category
                {
                    CategoryName = txtSubCategory.Text,
                    ParentCategory = (int)cbProMainCategory.SelectedValue,
                    IsPet = false
                };
                this.dbcontext.Categories.Add(category);
                this.dbcontext.SaveChanges();
                MessageBox.Show("新增成功");
                btnProReadAll.PerformClick();
                txtSubCategory.Text = "";
            }
        }
        private void btnProDetailCreate_Click(object sender, EventArgs e)
        {
            if (cbProMainCategory.Text == "請選擇總類")
            {
                MessageBox.Show("請選擇總類");
            }
            else if (cbProSubCategory.Text == "請選擇分類")
            {
                MessageBox.Show("請選擇分類");
            }
            else if (txtDetailCategory.Text == "")
            {
                MessageBox.Show("請輸入分類名");
            }
            else
            {
                SubCategory subCategory = new SubCategory
                {
                    SubCategoryName = txtDetailCategory.Text,
                    CategoryID = (int)cbProSubCategory.SelectedValue
                };
                dbcontext.SubCategories.Add(subCategory);
                dbcontext.SaveChanges();
                MessageBox.Show("新增成功");
                btnProReadAll.PerformClick();
                txtDetailCategory.Text = "";
            }
        }
        private void btnProSubUpdate_Click(object sender, EventArgs e)
        {
            if (cbProMainCategory.Text == "請選擇總類")
            {
                MessageBox.Show("請選擇總類");
            }
            else if (cbProSubCategory.Text == "請選擇分類")
            {
                MessageBox.Show("請選擇分類");
            }
            else if (txtSubCategory.Text == "")
            {
                MessageBox.Show("請輸入分類名");
            }
            else
            {
                var category = (from c in this.dbcontext.Categories.AsEnumerable()
                                where c.CategoryID == (int)cbProSubCategory.SelectedValue
                                select c).FirstOrDefault();

                if (category == null) return; //exit method
                category.CategoryName = txtSubCategory.Text;
                this.dbcontext.SaveChanges();
                MessageBox.Show("更新成功");
                btnProReadAll.PerformClick();
                txtSubCategory.Text = "";
            }
        }
        private void btnProDetailUpdate_Click(object sender, EventArgs e)
        {

            if (cbProMainCategory.Text == "請選擇總類")
            {
                MessageBox.Show("請選擇總類");
            }
            else if (cbProSubCategory.Text == "請選擇分類")
            {
                MessageBox.Show("請選擇分類");
            }
            else if (cbProDetailCategory.Text == "請選擇細項")
            {
                MessageBox.Show("請選擇細項");
            }
            else if (txtDetailCategory.Text == "")
            {
                MessageBox.Show("請輸入細項名");
            }
            else
            {
                var sub = (from s in this.dbcontext.SubCategories.AsEnumerable()
                           where s.SubCategoryID == (int)cbProDetailCategory.SelectedValue
                           select s).FirstOrDefault();

                if (sub == null) return; //exit method
                sub.SubCategoryName = txtDetailCategory.Text;
                this.dbcontext.SaveChanges();
                MessageBox.Show("更新成功");
                btnProReadAll.PerformClick();
                txtDetailCategory.Text = "";
            }
        }
        private void btnProSubDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProMainCategory.Text == "請選擇總類")
                {
                    MessageBox.Show("請選擇總類");
                }
                else if (cbProSubCategory.Text == "請選擇分類")
                {
                    MessageBox.Show("請選擇分類");
                }
                else
                {
                    var category = (from c in this.dbcontext.Categories.AsEnumerable()
                                    where c.CategoryID == (int)cbProSubCategory.SelectedValue
                                    select c).FirstOrDefault();

                    if (category == null) return;

                    this.dbcontext.Categories.Remove(category);
                    this.dbcontext.SaveChanges();
                    MessageBox.Show("刪除成功");
                    btnProReadAll.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("無法刪除!請確認細項是否有資料。");
                this.dbcontext = new 我救浪Entities();
            }
        }

        private void btnProDetailDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProMainCategory.Text == "請選擇總類")
                {
                    MessageBox.Show("請選擇總類");
                }
                else if (cbProSubCategory.Text == "請選擇分類")
                {
                    MessageBox.Show("請選擇分類");
                }
                else if (cbProDetailCategory.Text == "請選擇細項")
                {
                    MessageBox.Show("請選擇細項");
                }
                else
                {
                    var sub = (from s in this.dbcontext.SubCategories.AsEnumerable()
                               where s.SubCategoryID == (int)cbProDetailCategory.SelectedValue
                               select s).FirstOrDefault();
                    if (sub == null) return;
                    this.dbcontext.SubCategories.Remove(sub);
                    this.dbcontext.SaveChanges();
                    MessageBox.Show("刪除成功");
                    btnProReadAll.PerformClick();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("無法刪除!請再次確認。");
                this.dbcontext = new 我救浪Entities();
            }
        }
        private void btnProReadAll_Click(object sender, EventArgs e)
        {
            var q = from sc in this.dbcontext.SubCategories.AsEnumerable()
                    where sc.Category.IsPet == false
                    select new
                    {
                        SubCategoryName = sc.SubCategoryName,
                        CategoryName = sc.Category.CategoryName,
                        ParentCategory = ReturnParentCategoryName((int)sc.Category.ParentCategory)
                    };
            this.dataGridView1.DataSource = q.ToList();
        }
        string ReturnParentCategoryName(int ParentID)
        {
            var q = (from c in dbcontext.Categories
                     where c.CategoryID == ParentID
                     select new { c.CategoryName }).FirstOrDefault();

            return q.CategoryName;
        }

        private void FrmNewCategory_Load(object sender, EventArgs e)
        {
            cbProMainCategory.Text = "請選擇總類";
            cbProSubCategory.Text = "請選擇分類";
            cbProDetailCategory.Text = "請選擇細項";
            cbPetMainCategory.Text = "請選擇總類";
            cbPetSubCategory.Text = "請選擇分類";
        }

        private void btnPetReadAll_Click(object sender, EventArgs e)
        {
            var q = from sc in this.dbcontext.SubCategories.AsEnumerable()
                    where sc.Category.IsPet == true
                    select new
                    {
                        SubCategoryName = sc.SubCategoryName,
                        CategoryName = sc.Category.CategoryName,
                    };
            this.dataGridView2.DataSource = q.ToList();
        }
    }
}
