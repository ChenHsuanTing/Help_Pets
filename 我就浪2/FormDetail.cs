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
using static PetAdopt.FormPetAdopt;

namespace PetAdopt
{
    public partial class FormDetail : Form
    {
        我救浪Entities dbContext = new 我救浪Entities();
        int ProductID;
        int MemberID;
        public FormDetail(int productID,int memberID)
        {
            InitializeComponent();
            ProductID = productID;
            MemberID = memberID;
            Load_Deatil(productID);
            PictureBox_Databinding(pictureBox1, productID);

        }
        void Load_Deatil(int productID)
        {
            var q = (from pt in dbContext.Pet_Detail
                    where pt.ProductID == productID
                    select new
                    {
                        pt.Product.ProductName,
                        pt.Product.SubCategory.Category.CategoryName,
                        pt.Product.SubCategory.SubCategoryName,
                        pt.Gender.GenderType,
                        pt.Size.SizeType,
                        pt.Age.AgeType,
                        pt.Ligation.LigationType,
                        pt.Color.ColorName,
                        pt.Space,
                        pt.City.CityName,
                        pt.AccompanyTimeWeek,
                        pt.YearCost
                    }).FirstOrDefault();
            txtProductName.Text = q.ProductName;
            txtCategory.Text = q.CategoryName;
            txtSubCategory.Text = q.SubCategoryName;
            txtGender.Text = q.GenderType;
            txtSize.Text = q.SizeType;
            txtAge.Text = q.AgeType;
            txtLigation.Text = q.LigationType;
            txtColor.Text = q.ColorName;
            txtCity.Text = q.CityName;
            txtYearCost.Text = q.YearCost.ToString();
            txtSpace.Text = q.Space.ToString();
            txtWeek.Text = q.AccompanyTimeWeek.ToString();
        }
        void PictureBox_Databinding(PictureBox pictureBox,int productID)
        {
            pictureBox.DataBindings.Clear();
            pictureBox.Image = null;
            var q = from ph in dbContext.Photos
                    where ph.ProductID == productID
                    select ph;
            bindingSource1.DataSource = q.ToList();
            pictureBox.DataBindings.Add("Image", bindingSource1, "Picture", true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Position == bindingSource1.Count - 1) bindingSource1.MoveFirst();
            else bindingSource1.MoveNext();
        }

        private void BtnAdopt_Click(object sender, EventArgs e)
        {
            var q = from od in dbContext.Order_Detail
                    where od.ProductID == this.ProductID && od.Order.MemberID == this.MemberID
                    select od;
            if(q.Any())
            {
                MessageBox.Show("你已經申請過了");
                return;
            }

            var q_member = (from m in dbContext.Members
                            where m.MemberID == this.MemberID
                            select m).FirstOrDefault();
            Order order = new Order()
            {
                EmployeeID = 2,
                MemberID = this.MemberID,
                OrderDate = DateTime.Now.Date,
                Order_StatusID = 2,
                SendAddress = q_member.Address
            };
            dbContext.Orders.Add(order);

            Order_Detail order_Detail = new Order_Detail()
            {
                ProductID = this.ProductID,
                UnitPrice = 0,
                Quantity = 0
            };
            dbContext.Order_Detail.Add(order_Detail);

            dbContext.SaveChanges();
            MessageBox.Show("申請成功");


        }
            
    }
}
