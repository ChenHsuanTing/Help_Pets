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
    public partial class WishList : Form
    {
        我救浪Entities dbContext = new 我救浪Entities();
        public WishList(int memberID)
        {
            InitializeComponent();
            Load_Pet_Detail(memberID);
        }
        void Load_Pet_Detail(int memberID)
        {
            var q = (from mw in dbContext.Member_Wish
                    where mw.MemberID == memberID
                    select new
                    {
                        MemberID=mw.MemberID,
                        CityName=mw.City.CityName,
                        YearCost=mw.YearCost,
                        Space=mw.Space,
                        Size=mw.Size.SizeType,
                        Age=mw.Age.AgeType,
                        AccompanyWeek=mw.AccompanyTimeWeek,
                        Li=mw.Ligation.LigationType,
                        SubCategoryID=mw.SubCategoryID,
                        Gender=mw.Gender.GenderType
                    }).FirstOrDefault();
            memberIDTextBox.Text = q.MemberID.ToString();
            //subCategoryIDTextBox.Text = q.SubCategory;
            genderIDTextBox.Text = q.Gender;
            sizeIDTextBox.Text = q.Size;
            txtAgeID.Text = q.Age;
            txtLigationID.Text = q.Li;
            txtTimeWeek.Text = q.AccompanyWeek.ToString();
            txtCityID.Text = q.CityName;
            txtYearCost.Text = q.YearCost.ToString();
            txtSpace.Text = q.Space.ToString();

            var q_color = (from mwc in dbContext.Member_Wish_Color
                          where mwc.MemberID == q.MemberID
                          select new
                          {
                            ColorName=mwc.Color.ColorName
                          }
                          ).FirstOrDefault();
            txtColorID.Text = q_color.ColorName;

            var q_Category = (from c in dbContext.Categories
                             where q.SubCategoryID == c.CategoryID
                             select new { c.CategoryName}).FirstOrDefault();
            subCategoryIDTextBox.Text = q_Category.CategoryName;
        }
    }
}
