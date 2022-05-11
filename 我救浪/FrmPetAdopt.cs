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
                var q1 = from pht in this.dbconect.Photos
                         where pht.PictureID == pet.ProductID
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
                var q1 = from pht in this.dbconect.Photos
                         where pht.PictureID == pet.ProductID
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
            this.cbxCategoryName.DataSource = CategoryName.Select(n => n.CategoryName).ToList();
            //性別
            var GenderType = (from n in this.dbconect.Genders
                              select n).Distinct();
            this.cbxGenderID.DataSource = GenderType.Select(n => n.GenderType).ToList();
            //體型
            var SizeType = (from n in this.dbconect.Sizes
                            select n).Distinct();
            this.cbxSizeID.DataSource = SizeType.Select(n => n.SizeType).ToList();
            //年紀 
            var Age = (from n in this.dbconect.Ages
                       select n).Distinct();
            this.cbxAge.DataSource = Age.Select(n => n.AgeType).ToList();
            //結紮
            var Ligation = from n in this.dbconect.Ligations
                           select n;
            this.cbxLigation.DataSource = Ligation.Select(n => n.LigationType).ToList();
            //主要毛色
            var ColorName = (from n in this.dbconect.Colors
                             select n).Distinct();
            this.cbxColorID.DataSource = ColorName.Select(n => n.ColorName).ToList();
            //所在地區
            var CityName = (from n in this.dbconect.Cities
                            select n).Distinct();
            this.cbxCity.DataSource = CityName.Select(n => n.CityName).ToList();
            //所需花費
            //適合空間
        }
        private void button3_Click(object sender, EventArgs e)
        {
            WishList wishList = new WishList();
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
                    (!String.IsNullOrEmpty(cbxCategoryName.SelectedItem.ToString()) ? p.Product.SubCategory.Category.CategoryName == cbxCategoryName.SelectedItem.ToString() : true)
                    && ((!(cbxGenderID.SelectedItem.ToString() == "不限")) ? cbxGenderID.SelectedItem.ToString() == p.Gender.GenderType : true)
                    && (!(cbxSizeID.SelectedItem.ToString() == "不限") ? cbxSizeID.SelectedItem.ToString() == p.Size.SizeType : true)
                    && (!(cbxAge.SelectedItem.ToString() == "不限") ? cbxAge.SelectedItem.ToString() == p.Age.AgeType : true)
                    && (!(cbxLigation.SelectedItem.ToString() == "不限") ? cbxLigation.SelectedItem.ToString() == p.Ligation.LigationType : true)
                    && (!(cbxColorID.SelectedItem.ToString() == "不限") ? cbxColorID.SelectedItem.ToString() == p.Color.ColorName : true)
                    && (!(cbxCity.SelectedItem.ToString() == "不限") ? cbxCity.SelectedItem.ToString() == p.City.CityName : true)
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
        private void cbxSizeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //體型
            ComboBox cmb = (ComboBox)sender;
            var SizeType = from n in this.dbconect.Sizes
                           where n.SizeType == cmb.SelectedItem.ToString()
                           select n;
            sizeid = SizeType.Select(n => n.SizeID).First();
        }
        private void cbxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //種類
            ComboBox cmb = (ComboBox)sender;
            string str = cmb.SelectedItem.ToString();
            var CategoryName = from n in this.dbconect.Categories
                               where n.CategoryName == str
                               select n;
            categoryname = CategoryName.Select(n => n.CategoryID).First();
        }
        private void cbxColorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //毛色
            ComboBox cmb = (ComboBox)sender;
            string str = cmb.SelectedItem.ToString();
            var Color = from n in this.dbconect.Colors
                        where n.ColorName == str
                        select n;
            color = Color.Select(n => n.ColorID).First();
        }
        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //所在地區
            ComboBox cmb = (ComboBox)sender;
            string str = cmb.SelectedItem.ToString();
            var City = from n in this.dbconect.Cities
                       where n.CityName == str
                       select n;
            city = City.Select(n => n.CityID).First();
        }
        private void cbxGenderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //性別
            ComboBox cmb = (ComboBox)sender;
            string str = cmb.SelectedItem.ToString();
            var Geneder = from n in this.dbconect.Genders
                          where n.GenderType == str
                          select n;
            geneder = Geneder.Select(n => n.GenderID).First();
        }
        private void cbxAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //年紀
            ComboBox cmb = (ComboBox)sender;
            string str = cmb.SelectedItem.ToString();
            var Age = from n in this.dbconect.Ages
                      where n.AgeType == str
                      select n;
            age = Age.Select(n => n.AgeID).First();
        }
        private void cbxIsLigation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //結紮
            ComboBox cmb = (ComboBox)sender;
            string str = cmb.SelectedItem.ToString();
            var Ligation = from n in this.dbconect.Ligations
                           where n.LigationType == str
                           select n;
            ligation = Ligation.Select(n => n.LigationID).First();
        }


    }
}
