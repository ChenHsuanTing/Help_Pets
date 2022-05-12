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
using static 我救浪.Frm_Shopping;

namespace 我救浪
{
    public partial class Frm_ProductDetial : Form
    {
        Label lb = new Label();
        List<BuyItem> items= null;
        public Frm_ProductDetial(string name, string price, Image pic,List<BuyItem> car,Label total,Button button)
        {
            InitializeComponent();
            butModel= button;
            button1.Text = button.Text;

            //MyFavoriteButtonText(button1, Frm_Shopping.memID, name);
            lbName.Text= name;
            lb_Price.Text = price;

            //if (pic != null)
            //{
            //    pictureBox1.Image = pic;
            //}
            LoadPhoto(name, pictureBox1);
            var q = dbcontext.Products.Where(n => n.ProductName == lbName.Text).Select(n => n);
            lb_TotalPrice.Text = "總價: " + (int)q.ToList()[0].Price*numericUpDown1.Value+"元";
            lb_Stock.Text = q.ToList()[0].UnitsInStock.Value.ToString();
            richTxt_Des.Text = q.ToList()[0].Description;
            items = car;
            lb = total;
            if (q.ToList()[0].UnitsInStock.Value == 0)
            {
                MessageBox.Show("此產品已無庫存\n請選購其他產品");
                but_AddToCar.Enabled = false;
            }
        }
        public void MyFavoriteButtonText(Button button, int memID, string productName)
        {
            var fav = (dbcontext.MyFavorites.Where(f => f.MemberID == memID && f.Product.ProductName ==productName ).Select(f => f)).FirstOrDefault();
            if (fav != null) { button.Text = "取消收藏"; }
            else { button.Text = "收藏"; }
        }
        我救浪Entities dbcontext = new 我救浪Entities();
        public BuyItem buyItem = new BuyItem();
        Button butModel = new Button();
        void LoadPhoto(string name, PictureBox pictureBox)
        {
            pictureBox.DataBindings.Clear();
            pictureBox1.Image = null;
            var q = dbcontext.Photos.Where(p => p.Product.ProductName == name).Select(p => p);
            bindingSource1.DataSource = q.ToList();
            pictureBox.DataBindings.Add("Image", bindingSource1, "Picture", true);
        }
        
        void MyFavoriteAddOrDelete(Button button, Product product)
        {
            var f = (dbcontext.MyFavorites.Where(p => p.MemberID == memID && p.ProductID == product.ProductID)).FirstOrDefault();
            if (f != null)
            {
                DialogResult result = MessageBox.Show("確認產品移出收藏清單?", "", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    dbcontext.MyFavorites.Remove(f);
                    button.Text = "收藏";
                    butModel.Text = button.Text;
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
                butModel.Text = button.Text;
            }
        }

        private void lb_AddToCar_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                var c = (items.Where(p => p.產品名稱 == lbName.Text).Select(p => p)).FirstOrDefault();
                if (c != null)
                {
                    c.數量 = c.數量 + (int)numericUpDown1.Value;
                    if(c.數量>int.Parse(lb_Stock.Text))
                    {
                        c.數量 = c.數量 - (int)numericUpDown1.Value;
                        MessageBox.Show("您選擇的產品總數已超過庫存數\n請重新選擇數量");
                        numericUpDown1.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("產品已加入購物車!");
                        c.總價 = c.價格 * c.數量;
                        var q1 = items.Sum(p => p.總價).ToString();                       
                        lb.Text = "總金額: " + q1.ToString()+" 元 ("+items.Count()+")";
                    }
                }
                else
                {
                    var q = dbcontext.Products.Where(n => n.ProductName == lbName.Text).Select(n => new { 產品名 = n.ProductName, 價格 = n.Price, 總額 = n.Price * numericUpDown1.Value });
                    buyItem.產品名稱 = q.ToList()[0].產品名;
                    buyItem.價格 = (int)q.ToList()[0].價格;
                    buyItem.數量 = (int)numericUpDown1.Value;
                    buyItem.總價 = (int)q.ToList()[0].總額;
                    items.Add(buyItem);
                    MessageBox.Show("產品已加入購物車!");
                    var q1 = items.Sum(p => p.總價).ToString();
                    lb.Text = "總金額: " + q1.ToString() + " 元 (" + items.Count() + ")";
                }
            }
            else
            {
                MessageBox.Show("請選擇數量!");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > int.Parse(lb_Stock.Text))
             {
                MessageBox.Show("已超過庫存數量");
                numericUpDown1.Value = int.Parse(lb_Stock.Text);
            }
            var q = dbcontext.Products.Where(p => p.ProductName == lbName.Text).Select(p => p);
            int price = (int)q.ToList()[0].Price;
            lb_TotalPrice.Text = "總價: " + price*numericUpDown1.Value;
        }

        private void lb_Cancel_Click(object sender, EventArgs e)
        {           
            this.Close();
        }
        int memberID = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            var q = dbcontext.Products.Where(p => p.ProductName == lbName.Text).Select(p => p).FirstOrDefault();
            MyFavoriteAddOrDelete(button1, q);
            //var f = (dbcontext.MyFavorites.Where(p => p.MemberID == memberID && p.ProductID == q.ProductID)).FirstOrDefault();
            //if (f != null)
            //{
            //    DialogResult result = MessageBox.Show("確認產品移出收藏清單?", "", MessageBoxButtons.OKCancel);
            //    if (result == DialogResult.OK)
            //    {
            //        dbcontext.MyFavorites.Remove(f);
            //        button1.Text = "收藏";
            //        dbcontext.SaveChanges();
            //    }
            //}
            //else
            //{
            //    MyFavorite favorite = new MyFavorite { MemberID = memID, ProductID = q.ProductID };
            //    dbcontext.MyFavorites.Add(favorite);
            //    dbcontext.SaveChanges();
            //    MessageBox.Show("已將產品加入您的收藏");
            //    button1.Text = "取消收藏";
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Position == (bindingSource1.Count - 1))
            {
                bindingSource1.MoveFirst();
            }
            else
            {
                bindingSource1.MoveNext();
            }
        }
        
    }
}
