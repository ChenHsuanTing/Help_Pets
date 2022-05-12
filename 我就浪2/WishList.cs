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

namespace PetAdopt
{
    public partial class WishList : Form
    {
        我救浪Entities dbconect = new 我救浪Entities();
        public WishList(int memberID)
        {
            InitializeComponent();
            Load_Member_Wish(memberID);

        }
        void Load_Member_Wish(int memberID)
        {
            var q = (from mw in dbconect.Member_Wish
                    where mw.MemberID == memberID
                    select new
                    {
                        mw.Category.CategoryName,
                        mw.SubCategory.SubCategoryName,
                        mw.Size.SizeType,
                        mw.Ligation.LigationType,
                        mw.Gender.GenderType,
                        mw.AccompanyTimeWeek,
                        mw.Space,
                        mw.YearCost,
                        mw.Age.AgeType,
                        mw.City.CityName,
                    }
                    ).FirstOrDefault();
            var q_color = (from mws in dbconect.Member_Wish_Color
                           where mws.MemberID == memberID
                           select new { mws.Color.ColorName} ).FirstOrDefault();

            memberIDTextBox.Text = memberID.ToString();
            txtCategory.Text = q.CategoryName;
            txtSubCategory.Text = q.SubCategoryName;
            sizeIDTextBox.Text = q.SizeType;
            textBox2.Text = q.LigationType;
            genderIDTextBox.Text = q.GenderType;
            accompanyTimeWeekTextBox.Text = q.AccompanyTimeWeek.ToString();
            spaceTextBox.Text = q.Space.ToString();
            yearCostTextBox.Text = q.YearCost.ToString();
            textBox1.Text = q.AgeType;
            cityIDTextBox.Text = q.CityName;

            colorIDTextBox.Text = q_color.ColorName;

        }


    }
}
