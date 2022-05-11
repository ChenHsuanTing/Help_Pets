using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 我救浪;

namespace PetAdopt
{
    public partial class FormPetAdopt : Form
    {
        int memberID = 1;
        public FormPetAdopt()
        {
            InitializeComponent();
            LoadToGenderCombobx();
            var q = (from n in this.dbconect.Pet_Detail
                    select n).ToList();
            ShowPetDetail1(q);
            //Button Btn = new Button();
            //Btn.Click += Btn_Click;
        }
        private void ShowPetDetail(List<New_Detail> q)
        {
            foreach (var pet in q)
            {
                Panel p = new Panel();
                p.Click += P_Click;
                p.BorderStyle = BorderStyle.Fixed3D;
                p.Width = 200;
                p.Height = 300;
                p.Name = pet.ProductName;
                var q1 = from pht in this.dbconect.Photos
                         where pht.ProductID == pet.ProductID
                         select pht;
                foreach (var pho in q1)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(pho.Picture);
                    p.Controls.Add(new PictureBox
                    {
                        Name = "pPic",
                        Image = Image.FromStream(ms),
                        Width = 150,
                        Height = 200,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Top
                    });
                }
                p.Controls.Add(new Label { Name = "pName", Text = "Name:" + pet.ProductName, AutoSize = true, Top = 210, Left = 75 });
                p.Controls.Add(new Label { Name = "pCity", Text = "所在地:" + pet.CityName, AutoSize = true, Top = 230, Left = 70 });
                flowLayoutPanel1.Controls.Add(p);
            }
        }
        private void ShowPetDetail1(List<Pet_Detail> q)
        {
            foreach (var pet in q)
            {
                Panel p = new Panel();
                p.Click += P_Click;
                p.BorderStyle = BorderStyle.Fixed3D;
                p.Width = 200;
                p.Height = 300;
                p.Name = pet.Product.ProductName;
                
                //foreach (var pho in q1)
                //{
                    var q1 = (from pht in this.dbconect.Photos
                              where pht.ProductID == pet.ProductID
                              select pht).ToList().FirstOrDefault();
                if (q1 != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(q1.Picture);
                    p.Controls.Add(new PictureBox
                    {
                        Name = "pPic",
                        Image = Image.FromStream(ms),
                        Width = 150,
                        Height = 200,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Top

                    });
                }
                p.Controls.Add(new Label { Name = "pName", Text = "Name:" + pet.Product.ProductName, AutoSize = true, Top = 210, Left = 75 });
                p.Controls.Add(new Label { Name = "pCity", Text = "所在地:" + pet.City.CityName, AutoSize = true, Top = 230, Left = 70 });
                flowLayoutPanel1.Controls.Add(p);
            }
        }
        private void P_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            FormDetail detail = new FormDetail(p.Name);
            detail.Show();
        }

        private void ShowDetail(string tag)
        {
            PictureBox p = new PictureBox();
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            this.flowLayoutPanel1.Controls.Add(p);
            p.Click += P_Click;
        }

        我救浪Entities dbconect = new 我救浪Entities();
        private void LoadToGenderCombobx()
        {
            //種類
            var CategoryName = from n in this.dbconect.Categories
                               where n.IsPet == true
                               select n;
            this.cbxCategoryName.DataSource = CategoryName.ToList();
            cbxCategoryName.DisplayMember = "CategoryName";
            cbxCategoryName.ValueMember = "CategoryID";
            
           
            //性別
            var GenderType = (from n in this.dbconect.Genders
                              select n).Distinct();
            this.cbxGenderID.DataSource = GenderType.ToList();
            cbxGenderID.DisplayMember = "GenderType";
            cbxGenderID.ValueMember = "GenderID";
           
            
            //體型
            var SizeType = (from n in this.dbconect.Sizes
                            select n).Distinct();
            this.cbxSizeID.DataSource = SizeType.ToList();
            cbxSizeID.DisplayMember = "SizeType";
            cbxSizeID.ValueMember = "SizeID";
            
           
            //年紀 
            var Age = (from n in this.dbconect.Ages
                       select n).Distinct();
            this.cbxAge.DataSource = Age.ToList();
            cbxAge.DisplayMember = "AgeType";
            cbxAge.ValueMember = "AgeID";
            

            //結紮
            var Ligation = from n in this.dbconect.Ligations
                           select n;
            this.cbxLigation.DataSource = Ligation.ToList();
            cbxLigation.DisplayMember = "LigationType";
            cbxLigation.ValueMember = "LigationID";
            
            //主要毛色
            var ColorName = (from n in this.dbconect.Colors
                             select n).Distinct();
            this.cbxColorID.DataSource = ColorName.ToList();
            cbxColorID.DisplayMember = "ColorName";
            cbxColorID.ValueMember = "ColorID";
            
            //所在地區
            var CityName = (from n in this.dbconect.Cities
                            select n).Distinct();
            this.cbxCity.DataSource = CityName.ToList();
            cbxCity.DisplayMember = "CityName";
            cbxCity.ValueMember = "CityID";
            
            //所需花費
            //適合空間
        }
        private void button3_Click(object sender, EventArgs e)
        {
            WishList wishList = new WishList(memberID);
            wishList.Show();
        }
        int sizeid;
        int categoryname;
        int color;
        int city;
        int geneder;
        int age;
        int ligation;
        private void button1_Click(object sender, EventArgs e)
        {
            var q = from p in dbconect.Pet_Detail.AsEnumerable()
                    where
                    (!String.IsNullOrEmpty(cbxCategoryName.Text) ? p.Product.SubCategory.Category.CategoryName == cbxCategoryName.Text : true)
                    && ((!(cbxGenderID.Text == "不限")) ? cbxGenderID.Text == p.Gender.GenderType : true)
                    && (!(cbxSizeID.Text== "不限") ? cbxSizeID.Text == p.Size.SizeType : true)
                    && (!(cbxAge.Text == "不限") ? cbxAge.Text == p.Age.AgeType : true)
                    && (!(cbxLigation.Text== "不限") ? cbxLigation.Text == p.Ligation.LigationType : true)
                    && (!(cbxColorID.Text== "不限") ? cbxColorID.Text == p.Color.ColorName : true)
                    && (!(cbxCity.Text== "不限") ? cbxCity.Text == p.City.CityName : true)
                    && (!String.IsNullOrEmpty(txtYearCost.Text) ? int.Parse(txtYearCost.Text) >= p.YearCost : true)
                    && (!String.IsNullOrEmpty(txtSpace.Text) ? int.Parse(txtSpace.Text) >= p.Space : true)
                    select new New_Detail
                    {
                        ProductID = p.ProductID,
                        CategoryName =  p.Product.SubCategory.Category.CategoryName,
                        GenderID=  p.GenderID, //
                        GenderType=p.Gender.GenderType,
                        SizeID= p.SizeID,  //
                        SizeType= p.Size.SizeType,
                        AgeID=p.AgeID, //
                        AgeType=p.Age.AgeType,
                        LigationID= p.LigationID, //
                        LigationType= p.Ligation.LigationType,
                        ColorID=p.ColorID, //
                        ColorName=p.Color.ColorName,
                        YearCost=p.YearCost,
                        Space=p.Space,
                        CityName = p.City.CityName,
                        ProductName = p.Product.ProductName
                    };
            flowLayoutPanel1.Controls.Clear();
            if(q.Any())
            {
                
                ShowPetDetail(q.ToList());
            }
            else
            {
                MessageBox.Show("無相符條件，請重新搜尋");
            }

        }
        public class New_Detail
        {
            public int ProductID { get; set; }
            public string CategoryName { get; set; }
            public int? GenderID { get; set; }
            public string GenderType { get; set; }
            public int? SizeID { get; set; }
            public string SizeType { get; set; }
            public int? AgeID { get; set; }
            public string AgeType { get; set; }
            public int? LigationID { get; set; }
            public string LigationType { get; set; }
            public int? ColorID { get; set; }
            public string ColorName { get; set; }
            public decimal? YearCost { get; set; }
            public int? Space { get; set; }
            public string CityName { get; set; }
            public string ProductName { get; set; }
        };

        private void button2_Click(object sender, EventArgs e)
        {

            var q = from mw in dbconect.Member_Wish
                    where mw.MemberID == memberID
                    select mw;

            try
            {
                if (q.Any())
                {
                    var mw = q.FirstOrDefault();
                    mw.CityID = (int)cbxCity.SelectedValue;
                    mw.AgeID = (int)cbxAge.SelectedValue;
                    mw.GenderID = (int)cbxGenderID.SelectedValue;
                    mw.LigationID = (int)cbxLigation.SelectedValue;
                    mw.SubCategoryID = (int)cbxCategoryName.SelectedValue;
                    mw.YearCost = decimal.Parse(txtYearCost.Text);
                    mw.Space = int.Parse(txtSpace.Text);
                    mw.AccompanyTimeWeek = int.Parse(txtWeekTime.Text);
                    mw.SizeID = (int)cbxSizeID.SelectedValue;
                    //dbconect.SaveChanges();

                    var c = (from mwc in dbconect.Member_Wish_Color
                            where mwc.MemberID == memberID
                            select mwc).FirstOrDefault();
                    c.ColorID = (int)cbxColorID.SelectedValue;
                    dbconect.SaveChanges();
                    MessageBox.Show("修改成功");
                }
                else
                {
                    Member_Wish mw = new Member_Wish();
                    mw.CityID = (int)cbxCity.SelectedValue;
                    mw.AgeID = (int)cbxAge.SelectedValue;
                    mw.GenderID = (int)cbxGenderID.SelectedValue;
                    mw.LigationID = (int)cbxLigation.SelectedValue;
                    mw.SubCategoryID = (int)cbxCategoryName.SelectedValue;
                    mw.YearCost = decimal.Parse(txtYearCost.Text);
                    mw.Space = int.Parse(txtSpace.Text);
                    mw.AccompanyTimeWeek = int.Parse(txtWeekTime.Text);
                    mw.SizeID = (int)cbxSizeID.SelectedValue;
                    dbconect.Member_Wish.Add(mw);
                    dbconect.SaveChanges();

                    Member_Wish_Color color = new Member_Wish_Color()
                    {
                        MemberID = memberID,
                        ColorID = (int)cbxColorID.SelectedValue,
                    };
                    dbconect.Member_Wish_Color.Add(color);
                    dbconect.SaveChanges();
                    MessageBox.Show("新增成功");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cbxCity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //城市
            ComboBox cmb = (ComboBox)sender;
            int cityID = (int)cmb.SelectedValue;
            var City = from n in this.dbconect.Cities
                       where n.CityID == cityID
                       select n;
            city = City.Select(n => n.CityID).First();
        }

        private void cbxColorID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //毛色
            ComboBox cmb = (ComboBox)sender;
            int colorID = (int)cmb.SelectedValue;
            var Color = (from n in this.dbconect.Colors
                        where n.ColorID == colorID
                        select n.ColorID).First();
            color = Color;
        }

        private void cbxLigation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //結紮
            ComboBox cmb = (ComboBox)sender;
            int ligationID = (int)cmb.SelectedValue;
            var Ligation = from n in this.dbconect.Ligations
                           where n.LigationID == ligationID
                           select n;
            ligation = Ligation.Select(n => n.LigationID).First();
        }

        private void cbxAge_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //年紀
            ComboBox cmb = (ComboBox)sender;
            int ageID = (int)cmb.SelectedValue;
            var Age = from n in this.dbconect.Ages
                      where n.AgeID == ageID
                      select n;
            age = Age.Select(n => n.AgeID).First();
        }

        private void cbxSizeID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //體型
            ComboBox cmb = (ComboBox)sender;
            int sizeID = (int)cmb.SelectedValue;
            var SizeType = from n in this.dbconect.Sizes
                           where n.SizeID == sizeID
                           select n;
            sizeid = SizeType.Select(n => n.SizeID).First();
        }

        private void cbxGenderID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //性別
            ComboBox cmb = (ComboBox)sender;
            int genderID = (int)cmb.SelectedValue;
            var Geneder = from n in this.dbconect.Genders
                          where n.GenderID == genderID
                          select n;
            geneder = Geneder.Select(n => n.GenderID).First();
        }

        private void cbxCategoryName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //種類
            ComboBox cmb = (ComboBox)sender;
            int categoryID = (int)cmb.SelectedValue;
            var CategoryName = from n in this.dbconect.Categories
                               where n.CategoryID == categoryID
                               select n;
            categoryname = CategoryName.Select(n => n.CategoryID).First();
        }
    }
}
