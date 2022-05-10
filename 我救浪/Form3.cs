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
    public partial class FrmAdmin1 : Form
    {
        public FrmAdmin1()
        {
            InitializeComponent();
            LoadAllCombobox();//浪浪管理
            LoadProduct();
            LoadDetailCombobox();

        }

         void LoadDetailCombobox()
        {
            //var g = PetContext.Gender.Select(n => n.GenderType);
            //comboBox2.Text = "浪浪性別";
            //foreach (var i in g.ToList())
            //{
            //    comboBox2.Items.Add(i);
            //}
            //color
            //var c = PetContext.Color.Select(n => n.ColorName);
            //comboBox3.Text = "花色";
            //foreach (var i in c.ToList())
            //{
            //    comboBox3.Items.Add(i);
            //}

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
                        n.Age,
                        n.AccompanyTimeWeek,
                        n.LigationID,
                        n.Description
                    };
           

            this.dataGridViewPet.DataSource = q.ToList();

        }

        

        private void LoadProduct()
        {
            this.dataGridView4.DataSource = PetContext.Products.ToList();
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
                Price =Convert.ToDecimal(txtprice.Text) ,
                SupplierID = suppierID.ToList()[0].SupplierID,
                IsPet = true

            };
            this.PetContext.Products.Add(pro);
            this.PetContext.SaveChanges();
            this.Read_RefreshDataGridView();
            LoadAllCombobox();
        }
        
        private void btnpudate_Click(object sender, EventArgs e)
        {//修改
            this.PetContext.SaveChanges();
            this.Read_RefreshDataGridView();
            LoadAllCombobox();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {//刪除
            var delete = (from n in PetContext.Products.AsEnumerable()
                          where n.ProductID == (int)dataGridView4.CurrentRow.Cells[0].Value
                         select n).FirstOrDefault();

            this.PetContext.Products.Remove(delete);
            this.PetContext.SaveChanges();
            this.Read_RefreshDataGridView();
            LoadAllCombobox();
        }
        void Read_RefreshDataGridView()
        {
            this.dataGridView4.DataSource = null;
            this.dataGridViewPet.DataSource = null;
            this.dataGridView4.DataSource = this.PetContext.Products.ToList();
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
                        n.Age,
                        n.AccompanyTimeWeek,
                        n.Description
                    };
            this.dataGridViewPet.DataSource = q.ToList();
        }
        #endregion

        void LoadAllCombobox()
        {  //Name

            var name = PetContext.Products.Select(n => n.ProductName);
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
            var subc = PetContext.SubCategories.Where(n=>n.Category.IsPet.Value==true).Select(n => n.SubCategoryName);
            combSubcate.Text = "分類";
            foreach (var i in subc.ToList())
            {
                combSubcate.Items.Add(i);
            }
            //供應商
            var Sup = PetContext.Suppliers.Select(n => n.Name);
           comSup.Text = "供應商";
            foreach (var i in Sup.ToList())
            {
                comSup.Items.Add(i);
            }
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
                Description = txtdes.Text
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
            q.AccompanyTimeWeek =Convert.ToInt32( txtweek.Text);
            q.Description = txtdes.Text;
            

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
                txtdes.Text = n.Description.ToString();

            }
            #endregion
        }

       
        
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadPet_detail();
        }

        private void btneach_Click(object sender, EventArgs e)
        {
            //int c = PetContext.Gender.Where(m => m.GenderType == comboBox2.Text).Select(n => n.GenderID).First();
            //int color = PetContext.Color.Where(p => p.ColorName == comboBox3.Text).Select(p => p.ColorID).First();
            //var a = (PetContext.Pet_Detail.Where(m => m.GenderID == c && m.ColorID== color) .Select(n => new
            //{
            //    n.Product.ProductName,
            //    n.ProductID,
            //    n.Gender.GenderType,
            //    n.Color.ColorName,
            //    n.City.CityName,
            //    n.YearCost,
            //    n.Space,
            //    n.Size.SizeType,
            //    n.Age,
            //    n.AccompanyTimeWeek,
            //    n.Description
            //})).ToList();
           

            //this.dataPetdetail.DataSource = a;

        }

       
    }
}
