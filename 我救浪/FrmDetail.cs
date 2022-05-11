using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PetAdopt.FormPetAdopt;

namespace PetAdopt
{
    public partial class FormDetail : Form
    {
        public FormDetail(string s)
        {
            InitializeComponent();
           textBox8.Text = s;
            我救浪Entities dbcontext = new 我救浪Entities();
            var a = dbcontext.Pet_Detail.Where(m => m.Product.ProductName == s)
                .Select(n => new { 
                                  catename = n.Product.SubCategory.Category.CategoryName,
                                  gender = n.Gender.GenderType,
                                  size = n.Size.SizeType,
                                  age = n.Age1.AgeType,
                                  ligation = n.Ligation.LigationType,
                                  color = n.Color.ColorName,
                                  space = n.Space,
                                  city = n.City.CityName,
                                  cost = n.YearCost
                                 });
            textBox3.Text = a.Select(n => n.catename).First();
        }
    }
}
