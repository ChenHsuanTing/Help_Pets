using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 我就浪2;
using 我救浪;

namespace PetAdopt
{
    public partial class FormPetAdopt : Form
    {
        int memberID = FrmMemLogIn.memID;
        public FormPetAdopt()
        {
            InitializeComponent();
            LoadToGenderCombobx();
            var q = (from n in this.dbconect.Pet_Detail
                    select n).ToList();
            ShowPetDetail(q);
            //Button Btn = new Button();
            //Btn.Click += Btn_Click;
        }
        private void ShowPetDetail(List<Pet_Detail> q)
        {
            foreach (var pet in q)
            {
                Panel p = new Panel();
                p.BorderStyle = BorderStyle.Fixed3D;
                p.Width = 200;
                p.Height = 300;
                var q1 = (from pht in this.dbconect.Photos
                         where pht.ProductID == pet.ProductID
                         select pht).FirstOrDefault();
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

                p.Controls.Add(new Label { Name = "pName", Text = "Name:" + pet.Product.ProductName, AutoSize = true, Top = 220, Left = 75 });
                p.Controls.Add(new Label { Name = "pCity", Text = "所在地:" + pet.City.CityName, AutoSize = true, Top = 240, Left = 70 });
                Button showDetail = new Button {  Text = "詳細資訊", AutoSize = true, Top = 260, Left = 70,Tag=pet.ProductID };
                showDetail.Click += P_Click;
                p.Controls.Add(showDetail);
                flowLayoutPanel1.Controls.Add(p);

            }
        }
        private void P_Click(object sender, EventArgs e)
        {
            Control p = (Control)sender;
            FormDetail detail = new FormDetail((int)p.Tag,memberID);
            detail.Show();
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
            //品種
            var q_SubCategory = from sc in dbconect.SubCategories
                                where sc.SubCategoryName == "不限"
                                select sc;
            cbxSubCategory.DataSource = q_SubCategory.ToList();
            cbxSubCategory.DisplayMember = "SubCategoryName";
            cbxSubCategory.ValueMember = "SubCategoryID";

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
            //sizeid = SizeType.Select(n => n.SizeID).First();
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
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var q = from p in dbconect.Pet_Detail.AsEnumerable()
                    where
                    (!(cbxCategoryName.Text == "不限") ? p.Product.SubCategory.Category.CategoryName == cbxCategoryName.Text : true)
                    && (!(cbxSubCategory.Text == "不限") ? p.Product.SubCategory.SubCategoryName == cbxSubCategory.Text : true)
                    && ((!(cbxGenderID.Text == "不限")) ? cbxGenderID.Text == p.Gender.GenderType : true)
                    && (!(cbxSizeID.Text == "不限") ? cbxSizeID.Text == p.Size.SizeType : true)
                    && (!(cbxAge.Text == "不限") ? cbxAge.Text == p.Age.AgeType : true)
                    && (!(cbxLigation.Text == "不限") ? cbxLigation.Text == p.Ligation.LigationType : true)
                    && (!(cbxColorID.Text == "不限") ? cbxColorID.Text == p.Color.ColorName : true)
                    && (!(cbxCity.Text == "不限") ? cbxCity.Text == p.City.CityName : true)
                    && (!String.IsNullOrEmpty(txtYearCost.Text) ? int.Parse(txtYearCost.Text) >= p.YearCost : true)
                    && (!String.IsNullOrEmpty(txtSpace.Text) ? int.Parse(txtSpace.Text) >= p.Space : true)
                    && (!String.IsNullOrEmpty(txtSpace.Text) ? int.Parse(txtWeek.Text) >= p.AccompanyTimeWeek : true)
                    select p;

            if(q.Any())
            {
                ShowPetDetail(q.ToList());
            }
            else
            {
                MessageBox.Show("無相符條件，請重新搜尋");
            }
        }
       

        private void cbxCategoryName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var q = from sc in dbconect.SubCategories
                    where sc.CategoryID == (int)cbxCategoryName.SelectedValue || sc.SubCategoryName == "不限"
                    select sc;
            cbxSubCategory.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q = from m in dbconect.Member_Wish
                    where memberID == m.MemberID
                    select m;



            if (q.Any())
            {
                var q2 = q.FirstOrDefault();
                q2.CityID = (int)cbxCity.SelectedValue;
                q2.YearCost = int.Parse(txtYearCost.Text);
                q2.Space = int.Parse(txtSpace.Text);
                q2.AgeID = (int)cbxAge.SelectedValue;
                q2.AccompanyTimeWeek = int.Parse(txtWeek.Text);
                q2.LigationID = (int)cbxLigation.SelectedValue;
                q2.SubCategoryID = (int)cbxSubCategory.SelectedValue;
                q2.GenderID = (int)cbxGenderID.SelectedValue;
                q2.SizeID = (int)cbxSizeID.SelectedValue;
                q2.SubCategoryID = (int)cbxCategoryName.SelectedValue;
                dbconect.SaveChanges();
                MessageBox.Show("條件修改成功");


                var q_color = (from mws in dbconect.Member_Wish_Color
                               where mws.MemberID == memberID
                               select mws).FirstOrDefault();

                q_color.ColorID = (int)cbxColorID.SelectedValue;
                dbconect.SaveChanges();


                MessageBox.Show("顏色條件修改成功");
            }
            else
            {
                Member_Wish mw = new Member_Wish()
                {
                    MemberID=memberID,
                    CityID = (int)cbxCity.SelectedValue,
                    YearCost = int.Parse(txtYearCost.Text),
                    Space = int.Parse(txtSpace.Text),
                    AgeID = (int)cbxAge.SelectedValue,
                    AccompanyTimeWeek = int.Parse(txtWeek.Text),
                    LigationID = (int)cbxLigation.SelectedValue,
                    SubCategoryID = (int)cbxSubCategory.SelectedValue,
                    GenderID = (int)cbxGenderID.SelectedValue,
                    SizeID = (int)cbxSizeID.SelectedValue,
                    CategoryID = (int)cbxCategoryName.SelectedValue
                };
                dbconect.Member_Wish.Add(mw);
                dbconect.SaveChanges();
                MessageBox.Show("條件新增成功");
                Member_Wish_Color mwc = new Member_Wish_Color()
                {
                    MemberID = memberID,
                    ColorID = (int)cbxColorID.SelectedValue
                };
                dbconect.Member_Wish_Color.Add(mwc);
                dbconect.SaveChanges();
                MessageBox.Show("顏色條件新增成功");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Shopping frm = new Frm_Shopping();
            this.Visible = false;
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.No)
            {
                this.Visible = true;
            }
            else if(frm.DialogResult == DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.No;
        }
    }
}
