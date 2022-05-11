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
using static PetAdopt.FormPetAdopt;

namespace PetAdopt
{
    public partial class FormDetail : Form
    {
        public FormDetail(string name)
        {
            InitializeComponent();
           textBox8.Text = name;
            我救浪Entities dbcontext = new 我救浪Entities();

            var a = dbcontext.Pet_Detail.Where(m => m.Product.ProductName == name)
                .Select(n => new
                {
                    ProductID = n.ProductID, 
                    catename = n.Product.SubCategory.Category.CategoryName,
                    gender = n.Gender.GenderType,
                    size = n.Size.SizeType,
                    age = n.Age.AgeType,
                    ligation = n.Ligation.LigationType,
                    color = n.Color.ColorName,
                    space = n.Space,
                    city = n.City.CityName,
                    cost = n.YearCost,
                    description = n.Description
                }).FirstOrDefault();
            textBox2.Text = a.color;
            textBox3.Text = a.catename;
            textBox4.Text = a.gender;
            textBox5.Text = a.size;
            textBox6.Text = a.age;
            textBox7.Text = a.ligation;
            textBox1.Text = a.city;
            txtSpace.Text = a.space.ToString();
            txtYearCost.Text = a.cost.ToString();
            listBox1.Items.Add(a.description);
            var b = (from n in dbcontext.Photos
                    where n.ProductID == a.ProductID
                    select n).FirstOrDefault();
            if (b == null) return;
            Byte[] bytes =b.Picture;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
