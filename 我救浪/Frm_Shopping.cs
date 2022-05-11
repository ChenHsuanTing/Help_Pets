using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace 我救浪
{
    public partial class Frm_Shopping : Form
    {
        public Frm_Shopping()
        {
            InitializeComponent();
            AddCategory();
            var q = from p in dbContext.Products
                    where p.IsPet == false
                   select p;
            ShowProducts(q.ToList());
        }
        public List<BuyItem> car = new  List<BuyItem>();
        private void ShowProducts(List<Product> q)
        {
            foreach (var item in q)
            {
                Panel p = new Panel();
                p.Click += P_Click;
                p.BorderStyle = BorderStyle.FixedSingle;
                p.Width = 200;
                p.Height = 300;
                p.BackColor = System.Drawing.Color.DarkSeaGreen;
                var q1 = (from ph in dbContext.Photos
                         where ph.ProductID == item.ProductID
                         select ph).FirstOrDefault();
                System.IO.MemoryStream ms = new System.IO.MemoryStream(q1.Picture);
                //if (q1.Picture != null)
                //{
                //     ms = ms.(q1.Picture);
                //}
                    p.Controls.Add(new PictureBox
                    {
                        Name="pPic",
                        Image = Image.FromStream(ms),
                        Width = 150,
                        Height = 200,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Bottom
                    });
                
                p.Controls.Add(new Label {Name="pName", Text = item.ProductName, AutoSize = true });
                p.Controls.Add(new Label { Name = "pPrice",Text = $"價格:  { item.Price:c2}", AutoSize = true, Top = 30 });
                Button showDetail = new Button { Text = "查看", AutoSize = true, Top = 50, Left = 120 };
                Button favorite = new Button { Text = "收藏", AutoSize = true, Top = 50, Left = 10 };
                p.Controls.Add(showDetail);
                p.Controls.Add(favorite);
                showDetail.Click += ShowDetail_Click;
                favorite.Click += Favorite_Click;
                flowLayoutPanel1.Controls.Add(p);
            }
        }
        int memberID = 1;
        private void Favorite_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            var q = dbContext.Products.AsEnumerable().Where(p => p.ProductName == ((Label)b.Parent.Controls["pName"]).Text).Select(p => p).FirstOrDefault();
            var f = dbContext.MyFavorites.Where(p => p.MemberID == memberID && p.ProductID == q.ProductID);
            if (f.ToList().Count!=0)
            {
                MessageBox.Show("產品已在您的收藏清單");
            }
            else
            {
                MyFavorite favorite = new MyFavorite { MemberID = memberID, ProductID = q.ProductID };
                dbContext.MyFavorites.Add(favorite);
                dbContext.SaveChanges();
                MessageBox.Show("已將產品加入您的收藏");
            }
        }

        private void ShowDetail_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Frm_ProductDetial f = new Frm_ProductDetial(((Label)b.Parent.Controls["pName"]).Text, ((Label)b.Parent.Controls["pPrice"]).Text, ((PictureBox)b.Parent.Controls["pPic"]).Image, car, lb_TotalPay);
            f.Text = ((Label)b.Parent.Controls["pName"]).Text;
            f.Show();
        }

        private void P_Click(object sender, EventArgs e)
        {
            //Panel p = (Panel)sender;
            //Frm_ProductDetial f = new Frm_ProductDetial(((Label)p.Controls["pName"]).Text, ((Label)p.Controls["pPrice"]).Text, ((PictureBox)p.Controls["pPic"]).Image, car,lb_TotalPay) ;
            //f.Text = ((Label)p.Controls["pName"]).Text;
            //f.Show();          
        }
        我救浪Entities dbContext = new 我救浪Entities();
        void AddCategory()
        {
        
            var q = dbContext.Categories.Where(c => c.IsPet == false).
                Select(n => new { n.CategoryName, n.CategoryID });
            foreach (var n in q.ToList())
            {
                comBox_Category.Items.Add(n.CategoryName);
            }
        }

        private void comBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBox_SubCtg.Items.Clear();
            var q = from sc in dbContext.SubCategories
                    where sc.Category.CategoryName == comBox_Category.SelectedItem.ToString()
                    select sc;
            comBox_SubCtg.Text = "---請選擇---";
            foreach (var n in q)
            {
                comBox_SubCtg.Items.Add(n.SubCategoryName);
            }
        }
        private void but_Search_Click(object sender, EventArgs e)
        {
            if (comBox_Category.SelectedItem != null)
            {
                if (comBox_SubCtg.SelectedItem != null)
                {
                    flowLayoutPanel1.Controls.Clear();
                    var q = dbContext.Products.
                        Where(p => p.SubCategory.SubCategoryName == comBox_SubCtg.SelectedItem.ToString()).
                        Select(p => p);
                    ShowProducts(q.ToList());
                }
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    var q = dbContext.Products.
                        Where(p => p.SubCategory.Category.CategoryName == comBox_Category.SelectedItem.ToString()).
                        Select(p => p);
                    ShowProducts(q.ToList());
                }
            }
            else { MessageBox.Show("請選擇種類~~^U^"); }
        }
        public class BuyItem
        {
           public string 產品名稱 { get; set; }
            public int 價格{ get; set; }
        public int 數量 { get; set; }
            public int 總價 { get; set; }
        }

        private void linlLb_ShoppingCar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_ShoppingCar f = new Frm_ShoppingCar(car,lb_TotalPay);
            f.Show();
        }
    }
}
