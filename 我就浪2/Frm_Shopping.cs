using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI;
using System.Windows.Forms;
using 我就浪2;

namespace 我救浪
{
    public partial class Frm_Shopping : Form
    {
        public static int memID = FrmMemLogIn.memID;
        public Frm_Shopping()
        {
            InitializeComponent();
            AddCategory();
            var q = from p in dbcontext.Products
                    where p.IsPet == false
                    select p;
            var mem = (dbcontext.Members.Where(p => p.MemberID == FrmMemLogIn.memID).Select(p => p)).FirstOrDefault();
            //memID = mem.MemberID;
            ShowProducts(q.ToList());
            //MessageBox.Show("Hi!~ " + memID);
            lb_HiMem.Text = "Hi!~ " + mem.Name;
        }
        public List<BuyItem> car = new List<BuyItem>();
        
        bool delete = false;
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
                var q1 = (from ph in dbcontext.Photos
                          where ph.ProductID == item.ProductID
                          select ph).FirstOrDefault();
                if (q1 == null) { }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(q1.Picture);
                    p.Controls.Add(new PictureBox
                    {
                        Name = "pPic",
                        Image = Image.FromStream(ms),
                        Width = 170,
                        Height = 200,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Bottom
                    });
                    
                    p.Controls.Add(new Label { Name = "pName", Text = item.ProductName, AutoSize = true });
                    p.Controls.Add(new Label { Name = "pPrice", Text = $"價格:  { item.Price:c2}", AutoSize = true, Top = 30 });
                    Button showDetail = new Button { Text = "查看", AutoSize = true, Top = 60, Left = 120 };
                    Button favorite = new Button {  Name="favorite",AutoSize = true, Top = 60, Left = 10 };
                    MyFavoriteButtonText(favorite, memID, item.ProductID);
                    //var fav = (dbContext.MyFavorites.Where(f => f.MemberID == memID && f.ProductID == item.ProductID).Select(f => f)).FirstOrDefault();
                    //if (fav != null) { favorite.Text = "取消收藏"; }
                    //else { favorite.Text = "收藏"; }
                    p.Controls.Add(showDetail);
                    p.Controls.Add(favorite);
                    showDetail.Click += ShowDetail_Click;
                    favorite.Click += Favorite_Click;
                    flowLayoutPanrl1.Controls.Add(p);
                }
            }
        }
        public  void MyFavoriteButtonText(Button button,int memID,int productID)
        {
            var fav = (dbcontext.MyFavorites.Where(f => f.MemberID == memID && f.ProductID == productID).Select(f => f)).FirstOrDefault();
            if (fav != null) { button.Text = "取消收藏"; }
            else { button.Text = "收藏"; }
        
        }

        private void Favorite_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            var q = dbcontext.Products.AsEnumerable().Where(p => p.ProductName == ((Label)b.Parent.Controls["pName"]).Text).Select(p => p).FirstOrDefault();
            MyFavoriteAddOrDelete(b, q);
            if (delete == true && b.Text == "收藏")
            {
                flowLayoutPanrl1.Controls.Remove(((Panel)b.Parent));
            }
     
        }
        void MyFavoriteAddOrDelete(Button button,Product product)
        {
            var f = (dbcontext.MyFavorites.Where(p => p.MemberID == memID && p.ProductID == product.ProductID)).FirstOrDefault();
            if (f != null)
            {
                DialogResult result = MessageBox.Show("確認產品移出收藏清單?", "", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dbcontext.MyFavorites.Remove(f);
                    button.Text = "收藏";
                    dbcontext.SaveChanges();
                }
            }
            else
            {
                MyFavorite favorite = new MyFavorite { MemberID = memID, ProductID = product.ProductID };
                dbcontext.MyFavorites.Add(favorite);
                dbcontext.SaveChanges();
                MessageBox.Show("已將產品加入您的收藏");
                button.Text = "取消收藏";
            }
        }
       

        private void ShowDetail_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Frm_ProductDetial f = new Frm_ProductDetial(((Label)b.Parent.Controls["pName"]).Text, 
                ((Label)b.Parent.Controls["pPrice"]).Text, ((PictureBox)b.Parent.Controls["pPic"]).Image, car, lb_TotalPay,((Button)((Panel)b.Parent).Controls["favorite"]));
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
        我救浪Entities dbcontext = new 我救浪Entities();
        void AddCategory()
        {
            var pet = dbcontext.Categories.Where(p => p.CategoryID == p.ParentCategory&&p.ParentCategory!=1
            ).Select(p => p);
            cboBox_Pet.DataSource = pet.ToList();
            cboBox_Pet.DisplayMember = "CategoryName";
            cboBox_Pet.ValueMember = "CategoryID";
            var cate = dbcontext.Categories.Where(c => c.IsPet == false).
                Select(n => n);
            comBox_Category.DataSource = cate.ToList();
            comBox_Category.DisplayMember = "CategoryName";
            comBox_Category.ValueMember = "CategoryID";
            var subcate = dbcontext.SubCategories.Where(p => p.Category.IsPet == false).Select(p => p);
            comBox_SubCtg.DataSource = subcate.ToList();
            comBox_SubCtg.DisplayMember = "SubCategoryName";
            comBox_SubCtg.ValueMember = "SubCategoryID";
            comBox_SubCtg.Text = "";
        }

        //private void comBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    comBox_SubCtg.Items.Clear();
        //    var q = from sc in dbContext.SubCategories
        //            where sc.Category.CategoryName == comBox_Category.SelectedItem.ToString()
        //            select sc;
        //    comBox_SubCtg.Text = "---請選擇---";
        //    foreach (var n in q)
        //    {
        //        comBox_SubCtg.Items.Add(n.SubCategoryName);
        //    }
        //}
        private void but_Search_Click(object sender, EventArgs e)
        {

            if (cboBox_Pet.Text == "---請選擇---" && comBox_Category.Text == "---請選擇---" && comBox_SubCtg.Text == "---請選擇---")
            {
                MessageBox.Show("請選擇種類~~^U^");
            }
            else
            {
                var q = dbcontext.Products.AsEnumerable().Where(p => p.IsPet == false &&
              (!(cboBox_Pet.Text=="---請選擇---" )? p.SubCategory.Category.ParentCategory == (int)cboBox_Pet.SelectedValue : true)
              && (!(comBox_Category.Text== "---請選擇---") ? p.SubCategory.Category.CategoryID == (int)comBox_Category.SelectedValue : true)
              && (!(comBox_SubCtg.Text == "---請選擇---") ? p.SubCategoryID == (int)comBox_SubCtg.SelectedValue : true))
                    .Select(p => p);
                flowLayoutPanrl1.Controls.Clear();
                ShowProducts(q.ToList());
                delete = false;
            }
        }
        
    
    public class BuyItem
    {
        public string 產品名稱 { get; set; }
        public int 價格 { get; set; }
        public int 數量 { get; set; }
            public int 總價 { get; set; } 
    }

        private void linlLb_ShoppingCar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_ShoppingCar f = new Frm_ShoppingCar(car,lb_TotalPay);
            f.Show();
        }

        private void cboBox_Pet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cate = dbcontext.Categories.Where(p => p.ParentCategory == (int)cboBox_Pet.SelectedValue && p.IsPet == false).
                Select(p => p);
            comBox_Category.DataSource = cate.ToList();
            comBox_Category.DisplayMember ="CategoryName";
            comBox_Category.ValueMember ="CategoryID";
            var sub = dbcontext.SubCategories.Where(p => p.Category.ParentCategory == (int)cboBox_Pet.SelectedValue && p.Category.IsPet == false);
            comBox_SubCtg.DataSource = sub.ToList();
            comBox_SubCtg.DisplayMember = "SubCategoryName";
            comBox_SubCtg.ValueMember = "SubCategoryID";
            comBox_SubCtg.Text= "---請選擇---";
            comBox_Category.Text = "---請選擇---";

        }

        private void comBox_Category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comBox_SubCtg.DataSource = null;
            var sub = dbcontext.SubCategories.Where(p=>p.CategoryID==(int)comBox_Category.SelectedValue).Select(p=>p);
            comBox_SubCtg.DataSource = sub.ToList();
            comBox_SubCtg.DisplayMember = "SubCategoryName";
            comBox_SubCtg.ValueMember = "SubCategoryID";
            comBox_SubCtg.Text = "---請選擇---";
        }

        void ComBoBoxClear()
        {
            comBox_Category.Text = "---請選擇---";
            cboBox_Pet.Text = "---請選擇---";
            comBox_SubCtg.Text = "---請選擇---";
        }

        private void Frm_Shopping_Load(object sender, EventArgs e)
        {
            ComBoBoxClear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            delete = true;
            var q = dbcontext.MyFavorites.Where(p => p.MemberID == memID);
            flowLayoutPanrl1.Controls.Clear();
            foreach(var f in q)
            {
                var p = dbcontext.Products.Where(n => n.ProductID == f.ProductID).Where(n=>n.IsPet==false).Select(n => n);
                ShowProducts(p.ToList());
            }
        }

        private void butAll_Click(object sender, EventArgs e)
        {
            delete = false;
            flowLayoutPanrl1.Controls.Clear();
            var q = dbcontext.Products.Where(p => p.IsPet == false).Select(p => p);
            ShowProducts(q.ToList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
