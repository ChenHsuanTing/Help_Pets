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
    public partial class Frm浪浪管理 : Form
    {
        public Frm浪浪管理()
        {
            InitializeComponent();
            LoadAllCombobox();//浪浪管理
            Loadsearchcombox();
        }

       

       

        我救浪Entities PetContext = new 我救浪Entities();
        void LoadPet_detail()
        {
            var q = from n in PetContext.Pet_Detail
                    select new
                    {
                        n.Product.ProductName,
                        n.ProductID,
                        n.Gender.GenderType,
                        n.Color.ColorName,
                        n.City.CityName,
                        n.YearCost,
                        n.Space,
                        n.Size.SizeType,
                        n.Age.AgeType,
                        n.AccompanyTimeWeek,
                        n.Ligation.LigationType,
                        n.Description
                    };
           

            this.dataGridViewPet.DataSource = q.ToList();

        }

        

       

        #region product
        private void btnproductadd_Click(object sender, EventArgs e)
        {//productAdd
            var q = PetContext.SubCategories.Where(p => p.SubCategoryName == combSubcate.SelectedItem.ToString()).Select(p => p);
            var suppierID = PetContext.Suppliers.Where(p => p.Name == comSup.SelectedItem.ToString()).Select(p => p);
            Product pro = new Product
            {
                ProductName = txtproductName.Text,

                SubCategoryID = q.ToList()[0].SubCategoryID,
                Price = 0,//.Convert.ToDecimal(txtprice.Text) ,
                UnitsInStock = 1,
                SupplierID = 3,
                IsPet = true,
                Description="棄養"
            };
            this.PetContext.Products.Add(pro);
            this.PetContext.SaveChanges();
            btnproductsearch.PerformClick();
            //this.Read_RefreshDataGridView();
            LoadAllCombobox();
        }
        
        private void btnpudate_Click(object sender, EventArgs e)
        {//修改

            var pro = (from s in this.PetContext.Products.AsEnumerable()
                       where s.ProductID == (int)CombproductName.SelectedValue
                       select s).FirstOrDefault();

            if (pro == null) return;

            pro.ProductName = txtproductName.Text;
            this.PetContext.SaveChanges();
            MessageBox.Show("更新成功");
            btnproductsearch.PerformClick();




            //this.PetContext.SaveChanges();
            //this.Read_RefreshDataGridView();
            //LoadAllCombobox();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {//刪除
            var delete = (from n in PetContext.Products.AsEnumerable()
                          where n.ProductID == (int)dataGridView4.CurrentRow.Cells[0].Value
                         select n).FirstOrDefault();

            this.PetContext.Products.Remove(delete);
            this.PetContext.SaveChanges();
            btnproductsearch.PerformClick();
            //this.Read_RefreshDataGridView();
            LoadAllCombobox();
        }
        void Read_RefreshDataGridView()
        {
            //this.dataGridView4.DataSource = null;
            this.dataGridViewPet.DataSource = null;
            //var products = PetContext.Products.Where(p => p.SubCategory.Category.IsPet == true).Select(p => p);
            //this.dataGridView4.DataSource = products.ToList();
            var q = from n in PetContext.Pet_Detail
                    where n.Product.IsPet == true
                    select new
                    {
                        n.Product.ProductName,
                        n.ProductID,
                        n.Gender.GenderType,
                        n.Color.ColorName,
                        n.City.CityName,
                        n.YearCost,
                        n.Space,
                        n.Size.SizeType,
                        n.Age.AgeType,
                        n.Ligation.LigationType,
                        n.AccompanyTimeWeek,
                        n.Description
                    };
            this.dataGridViewPet.DataSource = q.ToList();
        }
        #endregion
        void Loadsearchcombox()
        {
            //Category
            var categoryname = from n in PetContext.Categories
                               where n.IsPet == true
                               select n;
            //this.comboBox8.DataSource = categoryname.Select(n => n.CategoryName).ToList();
            this.comboBox8.DataSource = categoryname.ToList();
            this.comboBox8.DisplayMember = "CategoryName";
            this.comboBox8.ValueMember = "CategoryID";
           // SubCategory
            //var subcategory = from n in PetContext.Categories
            //                  where n.IsPet == true
            //                  select n;
            //this.comboBox9.DataSource = subcategory.ToList();
            //comboBox9.DisplayMember = "CategoryName";
            //comboBox9.ValueMember = "CategoryID";

            //性別
            var GenderType = (from n in this.PetContext.Genders
                              select n).Distinct();
            this.comboBox2.DataSource = GenderType.ToList();
            comboBox2.DisplayMember = "GenderType";
            comboBox2.ValueMember = "GenderID";

            //花色
            var ColorName = (from n in this.PetContext.Colors
                             select n).Distinct();
            this.comboBox3.DataSource = ColorName.ToList();
            comboBox3.DisplayMember = "ColorName";
            comboBox3.ValueMember = "ColorID";

            //所在地區
            var CityName = (from n in this.PetContext.Cities
                            select n).Distinct();
            this.comboBox4.DataSource = CityName.ToList();
            comboBox4.DisplayMember = "CityName";
            comboBox4.ValueMember = "CityID";

            //體型
            var SizeType = (from n in this.PetContext.Sizes
                            select n).Distinct();
            this.comboBox7.DataSource = SizeType.ToList();
            comboBox7.DisplayMember = "SizeType";
            comboBox7.ValueMember = "SizeID";
            //年紀
            var Age = (from n in this.PetContext.Ages
                       select n).Distinct();
            this.comboBox6.DataSource = Age.ToList();
            comboBox6.DisplayMember = "AgeType";
            comboBox6.ValueMember = "AgeID";

            //結紮
            var Ligation = from n in this.PetContext.Ligations
                           select n;
            this.comboBox5.DataSource = Ligation.ToList();
            comboBox5.DisplayMember = "LigationType";
            comboBox5.ValueMember = "LigationID";
        }
        void LoadAllCombobox()
        {

          //Name
          //var name = PetContext.Products.Select(n => n.ProductName);
            var name = PetContext.Products.Where(p=>p.SubCategory.Category.IsPet==true).Select(n => n.ProductName);
            comName.Text = "浪浪名稱";
            this.comName.Items.Clear();
            foreach (var i in name.ToList())
            {
                comName.Items.Add(i);
            }


            //性別Gender
            var g = PetContext.Genders.Select(n => n.GenderType);
            comGenderID.Text = "浪浪性別";
            this.comGenderID.Items.Clear();
            foreach (var i in g.ToList())
            {
                comGenderID.Items.Add(i);
            }
            //color
            var c = PetContext.Colors.Select(n => n.ColorName);
            comcolorID.Text = "花色";
            this.comcolorID.Items.Clear();
            foreach (var i in c.ToList())
            {
                comcolorID.Items.Add(i);
            }
            //ISLigation
            var L = PetContext.Ligations.Select(n => n.LigationType);
            comIsLigation.Text = "是否結紮";
            this.comIsLigation.Items.Clear();
            foreach (var i in L.ToList())
            {
                comIsLigation.Items.Add(i);
            }
            //Size
            var s = PetContext.Sizes.Select(n => n.SizeType);
            comSizeID.Text = "體型";
            this.comSizeID.Items.Clear();
            foreach (var i in s.ToList())
            {
                comSizeID.Items.Add(i);
            }
            //City
            var City = PetContext.Cities.Select(n => n.CityName);
            comcityID.Text = "地區";
            this.comcityID.Items.Clear();
            foreach (var i in City.ToList())
            {
                comcityID.Items.Add(i);
            }
            //Age
            var Age = PetContext.Ages.Select(n => n.AgeType);
            comAge.Text = "年齡範圍";
            this.comAge.Items.Clear();
            foreach (var i in Age.ToList())
            {
                comAge.Items.Add(i);
            }
            //次類別
            //var subc = PetContext.SubCategories.Where(n=>n.Category.IsPet.Value==true).Select(n => n.SubCategoryName);
            //combSubcate.Text = "分類";
            //foreach (var i in subc.ToList().Distinct())
            //{
            //    combSubcate.Items.Add(i);
            //}
            var SUB = from su in this.PetContext.SubCategories
                      where su.Category.IsPet == true
                      select su;
            combSubcate.DataSource = SUB.ToList();
            combSubcate.DisplayMember = "SubCategoryName";
            combSubcate.ValueMember = "SubCategoryID";
            //供應商
            var Sup = PetContext.Suppliers.Select(n => n.Name);
           comSup.Text = "供應商";
            foreach (var i in Sup.ToList())
            {
                comSup.Items.Add(i);
            }
        }
        private void combSubcate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var q = from s in this.PetContext.Products.AsEnumerable()
                    where s.SubCategoryID == (int)combSubcate.SelectedValue
                    select s;
            CombproductName.DataSource = q.ToList();
            CombproductName.DisplayMember = "ProductName";
            CombproductName.ValueMember = "ProductID";
        }

        #region pet_detail
        private void btnpetAdd_Click(object sender, EventArgs e)
        {
            //Pet Add
            
            var petname = PetContext.Products.Where(p => p.ProductName == comName.SelectedItem.ToString()).Select(p => p);
            var gender = PetContext.Genders.Where(p => p.GenderType == comGenderID.SelectedItem.ToString()).Select(p => p);
            var color = PetContext.Colors.Where(p => p.ColorName == comcolorID.SelectedItem.ToString()).Select(p => p);
            var city = PetContext.Cities.Where(p => p.CityName == comcityID.SelectedItem.ToString()).Select(p => p);
            var size = PetContext.Sizes.Where(p => p.SizeType == comSizeID.SelectedItem.ToString()).Select(p => p);
            var Ligation = PetContext.Ligations.Where(p => p.LigationType == comIsLigation.SelectedItem.ToString()).Select(p => p);
            var age = PetContext.Ages.Where(p => p.AgeType == comAge.SelectedItem.ToString()).Select(p => p);


            Pet_Detail pet = new Pet_Detail
            {
                ProductID = petname.ToList()[0].ProductID,
                GenderID = gender.ToList()[0].GenderID,
                ColorID = color.ToList()[0].ColorID,
                CityID = city.ToList()[0].CityID,
                YearCost = Convert.ToDecimal(txtYearcost.Text),
                Space = Convert.ToInt32(txtspace.Text),
                SizeID = size.ToList()[0].SizeID,
                AccompanyTimeWeek = Convert.ToInt32(txtweek.Text),
                LigationID = Ligation.ToList()[0].LigationID,
                AgeID = age.ToList()[0].AgeID,
                Description = rtxtdes.Text
            };
            //saveimage();
            this.PetContext.Pet_Detail.Add(pet);
            this.PetContext.SaveChanges();
            this.Read_RefreshDataGridView();
            
            

        }

         void saveimage()
        {
            byte[] bytes;
           
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytes = ms.GetBuffer();
            Photo photo = new Photo { Picture = bytes, ProductID = 1 };
            PetContext.Photos.Add(photo);
            PetContext.SaveChanges();

        }

        private void btnpetUpdate_Click(object sender, EventArgs e)
        {//update
            var q = (from n in PetContext.Pet_Detail.AsEnumerable()
                     where n.Product.ProductName == comName.Text
                     select n).FirstOrDefault();


            if (q == null) return;
           
            q.LigationID = comIsLigation.SelectedIndex + 1;
            q.AgeID = comAge.SelectedIndex + 1;
            q.GenderID = comGenderID.SelectedIndex+1;
            q.ColorID = comcolorID.SelectedIndex+1;
            q.CityID = comcityID.SelectedIndex+1;
            q.YearCost =Convert.ToDecimal(txtYearcost.Text) ;
            q.Space =Convert.ToInt32(txtspace.Text) ;
            q.SizeID = comSizeID.SelectedIndex+1;
            q.AccompanyTimeWeek =Convert.ToInt32(txtweek.Text) ;
            q.Description = rtxtdes.Text;
            

            this.PetContext.SaveChanges();
            this.Read_RefreshDataGridView();
        }

        private void comName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ID = from n in PetContext.Pet_Detail
                     where n.Product.ProductName == comName.Text
                     select n;
            foreach(var n in ID)
            {
                comGenderID.SelectedIndex = int.Parse(n.GenderID.ToString())-1;
                comcolorID.SelectedIndex=int.Parse(n.ColorID.ToString()) - 1;
                comcityID.SelectedIndex = int.Parse(n.CityID.ToString()) - 1;
                txtYearcost.Text =n.YearCost.ToString() ;
                txtspace.Text = n.Space.ToString();
                comSizeID.SelectedIndex = int.Parse(n.SizeID.ToString()) - 1;
                comAge.SelectedIndex = int.Parse(n.AgeID.ToString()) - 1;
                comIsLigation.SelectedIndex = int.Parse(n.LigationID.ToString()) - 1;
                txtweek.Text = n.AccompanyTimeWeek.ToString();
                rtxtdes.Text = n.Description.ToString();

            }
          
        }
        #endregion

        #region 寵物資訊
        private void btnpetDelete_Click(object sender, EventArgs e)
        {//delete
            var delete = (from n in PetContext.Pet_Detail.AsEnumerable()
                          where n.ProductID == (int)postion
                          select n).FirstOrDefault();

            this.PetContext.Pet_Detail.Remove(delete);
            this.PetContext.SaveChanges();
           this.Read_RefreshDataGridView();
            
        }
        object postion;
        private void dataGridViewPet_CellClick(object sender, DataGridViewCellEventArgs e)
        {//dataGridViewPet相對位置
            postion = dataGridViewPet.Rows[((DataGridView)sender).CurrentCell.RowIndex].Cells["ProductID"].Value;
            LoadPicture((int)postion,pictureBox1);
        }

        void LoadPicture(int poston,PictureBox pictureBox)
        {
            this.pictureBox1.Image = null;
            var pic = from n in PetContext.Photos.AsEnumerable()
                      where n.ProductID == (int)postion
                      select n;
           this.pictureBox1.Image = null;
            this.bindingSource1.DataSource = pic.ToList();
            pictureBox.DataBindings.Add("Image", bindingSource1, "Picture", true);
            pictureBox.DataBindings.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {//開啟照片
            this.openFileDialog1.Filter = "*.jpg (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                openFileDialog1.Dispose();
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            //儲存照片
            byte[] bytes;
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            bytes = ms.GetBuffer();
            Photo photo = new Photo { Picture = bytes, ProductID = (int)postion };
            PetContext.Photos.Add(photo);
            PetContext.SaveChanges();
            MessageBox.Show("新增照片成功");


        }
        private void button4_Click(object sender, EventArgs e)
        {//刪除照片
            PetContext.Photos.Remove(((Photo)(bindingSource1.Current)));
            PetContext.SaveChanges();
            MessageBox.Show("刪除成功");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadPet_detail();
        }

        #endregion


        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show((comboBox9.SelectedItem as SubCategory).SubCategoryName);
            
               
            var q = from n in PetContext.Pet_Detail
                    where //n.Product.SubCategoryID==(int)comboBox9.SelectedValue

                    (!string.IsNullOrEmpty(comboBox8.Text) ? n.Product.SubCategory.Category.CategoryName == comboBox8.Text: true)
                    &&(!string.IsNullOrEmpty(comboBox9.Text) ?n.Product.SubCategory.SubCategoryName == comboBox9.Text : true)

                    && (!(comboBox2.Text == "不限") ? comboBox2.Text == n.Gender.GenderType : true)
                     && (!(comboBox3.Text == "不限") ? comboBox3.Text == n.Color.ColorName : true)
                     && (!(comboBox4.Text == "不限") ? comboBox4.Text == n.City.CityName : true)
                     && (!(comboBox7.Text == "不限") ? comboBox7.Text == n.Size.SizeType : true)
                      && (!(comboBox6.Text == "不限") ? comboBox6.Text == n.Age.AgeType : true)
                      && (!(comboBox5.Text == "不限") ? comboBox5.Text == n.Ligation.LigationType : true)
                    select new
                    {
                        n.Product.ProductName,
                        n.ProductID,
                        n.Gender.GenderType,
                        n.Color.ColorName,
                        n.City.CityName,
                        n.YearCost,
                        n.Space,
                        n.Size.SizeType,
                        n.Age.AgeType,
                        n.Ligation.LigationType,
                        n.AccompanyTimeWeek,
                        n.Description
                    };
            this.dataGridView1.DataSource = q.ToList();
            if (q.Any())
            {
                this.dataGridView1.DataSource = q.ToList();
            }
            else
            {
                MessageBox.Show("無相符條件，請重新搜尋");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loadsearchcombox();
            this.dataGridView1.DataSource = null;
        }

   

        private void comboBox8_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var subcategory = from n in PetContext.SubCategories
                              where n.CategoryID == (int)comboBox8.SelectedValue
                              select n;
            this.comboBox9.DataSource = subcategory.ToList();
            comboBox9.DisplayMember = "SubCategoryName";
            comboBox9.ValueMember = "SubCategoryID";
        }

        private void btnproductsearch_Click(object sender, EventArgs e)
        {
            var q = from p in this.PetContext.Products
                    where p.IsPet == true
                    select new
                    {
                        p.ProductID,
                        p.ProductName,
                        SubCategoryName = p.SubCategory.SubCategoryName,
                    };
            this.dataGridView4.DataSource = q.ToList();
        }

        
    }
}
