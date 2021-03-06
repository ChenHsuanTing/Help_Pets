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
    public partial class Frm_ShoppingCar : Form
    {
        List<BuyItem> p = new List<BuyItem>();
        Label totalPay;

        public Frm_ShoppingCar(List<BuyItem> car, Label lb)
        {
            InitializeComponent();
            AddCity();
            p = car;
            totalPay = lb;
            TotalPay();
        }
        public static int memID = FrmMemLogIn.memID;
        我救浪Entities dbContext = new 我救浪Entities();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                byte[] bytes;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                bytes = ms.GetBuffer();
                Photo photo = new Photo { Picture = bytes, ProductID = 21 };
                dbContext.Photos.Add(photo);
                dbContext.SaveChanges();

            }

        }

        private void but_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_CheckOut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("尚未選擇產品");
                this.Close();
            }
            else
            {
                if (txt_Address.Text == "")
                {
                    MessageBox.Show("請輸入地址");
                }
                else
                {

                    DialogResult result = MessageBox.Show("您的結帳金額為: " + p.Sum(p => p.總價) + "元" + "\n是否確認結帳?", "", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        Order order = new Order { MemberID = memID, EmployeeID = id, OrderDate = DateTime.Now, SendAddress = txt_Address.Text, Order_StatusID = 2 };
                        dbContext.Orders.Add(order);
                        dbContext.SaveChanges();
                        var q1 = (dbContext.Orders.OrderByDescending(p => p.OrderID).Where(p => p.MemberID == order.MemberID && p.EmployeeID == order.EmployeeID
                          && p.SendAddress == order.SendAddress && p.Order_StatusID == order.Order_StatusID
                        ).Select(p => p)).FirstOrDefault();
                        foreach (var od in p)
                        {
                            var q = (dbContext.Products.Where(p => p.ProductName == od.產品名稱).Select(p => p)).FirstOrDefault();
                            Order_Detail detail = new Order_Detail { OrderID = q1.OrderID, ProductID = q.ProductID, Quantity = od.數量, UnitPrice = od.價格 };
                            dbContext.Order_Detail.Add(detail);
                            q.UnitsInStock = q.UnitsInStock.Value - od.數量;
                            dbContext.SaveChanges();
                        }
                        p.Clear();

                        MessageBox.Show("訂單已成立,感謝您的訂購");
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = p;
                        TotalPay();
                    }
                }
            }
        }
        void AddCity()
        {
            var q = dbContext.Cities.Select(c => c);
            comBox_City.Text = "---請選擇地區---";
            foreach (var c in q)
            {
                if (c.CityName == "不限")
                {
                    comBox_City.Items.Add("同會員地址");
                }
                else
                {
                    comBox_City.Items.Add(c.CityName);
                }
            }
        }
        int id = 1;
        private void comBox_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBox_City.SelectedItem.ToString() == "同會員地址")
            {
                txt_Address.Text = "";
                var q = dbContext.Members.Where(p => p.MemberID == memID).Select(p => p);
                txt_Address.Text = q.ToList()[0].Address;
            }
            else
            {
                txt_Address.Text = "";
                txt_Address.Text = comBox_City.SelectedItem.ToString();
            }
        }
        void TotalPay()
        {
            var q = p.Sum(p => p.總價).ToString();
            lb_TotalPay.Text = "結帳金額: " + q + " 元";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = p;
            totalPay.Text = "總金額: " + q + " 元 ("+p.Count()+")";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                DialogResult result=MessageBox.Show("是否將此產品從清單中刪除?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var q = (p.Where(p => p.產品名稱 == dataGridView1.CurrentRow.Cells[3].Value.ToString()).
                          Select(p => p)).FirstOrDefault();
                    p.Remove(q);
                    TotalPay();
                }
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                var q = (p.Where(p => p.產品名稱 == dataGridView1.CurrentRow.Cells[3].Value.ToString()).
                      Select(p => p)).FirstOrDefault();
                var pro = (dbContext.Products.AsEnumerable().Where(p => p.ProductName == q.產品名稱).Select(p => p)).FirstOrDefault();
                if (q.數量 == pro.UnitsInStock)
                {
                    MessageBox.Show("產品數量已達庫存量");
                }
                else
                {
                    q.數量 += 1;
                    q.總價 = q.價格 * q.數量;
                    TotalPay();
                }
            }
            else
            {
                var q = (p.Where(p => p.產品名稱 == dataGridView1.CurrentRow.Cells[3].Value.ToString()).
                      Select(p => p)).FirstOrDefault();
                var pro = (dbContext.Products.Where(p => p.ProductName == q.產品名稱).Select(p => p)).FirstOrDefault();
                if (q.數量 == 1)
                {
                    DialogResult result = MessageBox.Show("產品數量已為0\n是否刪除此產品", "", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        var item = (p.Where(p => p.產品名稱 == dataGridView1.CurrentRow.Cells[3].Value.ToString()).
                     Select(p => p)).FirstOrDefault();
                        p.Remove(item);
                        TotalPay();
                    }
                }
                else
                {
                    q.數量 -= 1;
                    q.總價 = q.價格 * q.數量;
                    TotalPay();
                }
            }
        }
    }
}
