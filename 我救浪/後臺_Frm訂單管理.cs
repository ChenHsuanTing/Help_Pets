using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 我救浪
{
    public partial class 後臺_Frm訂單管理 : Form
    {
        public 後臺_Frm訂單管理()
        {
            InitializeComponent();
            panel1.Visible = false;
            dataGridView2.ShowCellToolTips = true;
            
        }

        我救浪Entities dbContext = new 我救浪Entities();
        decimal productPrice;
        #region 刪除(Keys.Delete)
        //dgv1 刪除選中orderid及其底下details
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            DataGridView se = (DataGridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                int memberID = (int)dataGridView1.Rows[se.CurrentCell.RowIndex].Cells["MemberID"].Value;
                int orderID = (int)dataGridView1.Rows[se.CurrentCell.RowIndex].Cells["OrderID"].Value;
                var a = (dbContext.Order_Detail.Where(m => m.OrderID == orderID).Select(n => n).ToList()).Count();
                DialogResult result = MessageBox.Show($"刪除訂單編號 {orderID} 及底下共 {a} 筆資料?", "刪除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    while ((dbContext.Order_Detail.Where(m => m.OrderID == orderID).Select(n => n)).FirstOrDefault() != null)
                    {
                        var b = (dbContext.Order_Detail.Where(m => m.OrderID == orderID).Select(n => n)).FirstOrDefault();

                        dbContext.Order_Detail.Remove(b);
                        dbContext.SaveChanges();
                    }
                    var c = (dbContext.Orders.Where(m => m.OrderID == orderID).Select(n => n)).FirstOrDefault();
                    dbContext.Orders.Remove(c);
                    dbContext.SaveChanges();
                    dataGridView1.DataSource = dbContext.Orders.Select(n => n).ToList();
                    dataGridView2.DataSource = dbContext.Order_Detail.Where(m => m.OrderID == orderID).Select(n => n).ToList();
                }
            }
        }
        //dgv1 刪除選中的指定details
        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridView se = (DataGridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                int productID = (int)dataGridView2.Rows[se.CurrentCell.RowIndex].Cells["ProductID"].Value;
                int orderID = (int)dataGridView2.Rows[se.CurrentCell.RowIndex].Cells["OrderID"].Value;
                DialogResult result = MessageBox.Show($"刪除訂單編號 {orderID} 的第 {se.CurrentCell.RowIndex + 1} 筆資料?", "刪除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    var a = (dbContext.Order_Detail.Where(m => m.OrderID == orderID).Where(o => o.ProductID == productID).Select(n => n)).FirstOrDefault();
                    dbContext.Order_Detail.Remove(a);
                    dbContext.SaveChanges();
                    dataGridView2.DataSource = dbContext.Order_Detail.Where(m => m.OrderID == orderID).Select(n => n).ToList();
                }
            }
        }

        #endregion

        #region 新增(Button)
        //btn1 submit 執行新增訂單
        int memberID_forInsert, orderID_forInsert, Quan, combo1selected_SubCateID, combo2selected_ProductID;
        string sendAdress;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox4.Text, out memberID_forInsert))
                {
                    if (textBox3.Text == "" || textBox4.Text == "" || (radioButton1.Checked == false && radioButton2.Checked == false) || comboBox1.Text == "" || comboBox2.Text == "")
                    {
                        MessageBox.Show("請輸入完整訂單資料");
                        return;
                    }
                    else
                    {
                        if (dbContext.Members.Where(n => n.MemberID == memberID_forInsert).Count() == 0)
                        {
                            MessageBox.Show("查無此會員ID");
                            return;
                        }
                        if (radioButton4.Checked || radioButton3.Checked)
                        {
                            if (radioButton3.Checked)  //新增已存在orderid的detail
                            {
                                try
                                {
                                    if (int.TryParse(textBox5.Text, out orderID_forInsert))
                                    {
                                        //combo2selected_ProductID = 
                                        Order_Detail order_Detail1 = new Order_Detail
                                        {
                                            OrderID = orderID_forInsert,
                                            ProductID = combo2selected_ProductID,
                                            Quantity = Quan,
                                            UnitPrice = productPrice
                                        };
                                        dbContext.Order_Detail.Add(order_Detail1);
                                        dbContext.SaveChanges();
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("OrderID請輸入數值");
                                        return;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"訂單已存在，更改數量請編輯");
                                    dbContext = new 我救浪Entities();
                                }
                            }
                            else if (radioButton4.Checked)  //繼續新增上一筆建立orderID的detail
                            {
                                try
                                {
                                    Order_Detail order_Detail1 = new Order_Detail
                                    {
                                        OrderID = orderID_forInsert,
                                        ProductID = combo2selected_ProductID,
                                        Quantity = Quan,
                                        UnitPrice = productPrice
                                    };
                                    dbContext.Order_Detail.Add(order_Detail1);
                                    dbContext.SaveChanges();
                                    return;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"訂單已存在，更改數量請編輯");
                                    dbContext = new 我救浪Entities();
                                }
                            }
                        }
                        else  //新增訂單
                        {
                            if (textBox2.Text == "")
                            {
                                MessageBox.Show("請輸入寄送地址");
                                return;
                            }
                            string DateTime_str = dateTimePicker1.Text;
                            Order order = new Order
                            {
                                //OrderID = 0,  /*可以隨便放?*/
                                MemberID = memberID_forInsert,
                                EmployeeID = Frm員工登入.empID,  /*TODO  抓登入empID*/
                                OrderDate = DateTime.Parse(DateTime_str),
                                SendAddress = sendAdress,
                                Order_StatusID = 2, /*預設未送達?*/
                            };
                            dbContext.Orders.Add(order);
                            dbContext.SaveChanges();

                            //dbContext.Order_Detail.Add()
                            orderID_forInsert = dbContext.Orders.Where(m => m.MemberID == memberID_forInsert).Select(n => n.OrderID).ToList().Last();
                            Order_Detail order_Detail2 = new Order_Detail
                            {
                                OrderID = orderID_forInsert,
                                ProductID = combo2selected_ProductID,
                                Quantity = Quan,
                                UnitPrice = productPrice
                            };
                            dbContext.Order_Detail.Add(order_Detail2);
                            dbContext.SaveChanges();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("會員ID輸入有誤");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"最外層ex???=>{ex.Message}");
            }
            finally
            {
                dataGridView1.DataSource = dbContext.Orders.Where(m => m.MemberID == memberID_forInsert).Select(n => n).ToList();
                dataGridView2.DataSource = dbContext.Order_Detail.Where(m => m.OrderID == orderID_forInsert).Select(n => n).ToList();
            }
        }
        //btn2 啟用或取消radioBtn3 and 4
        bool flag = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                button2.Text = "取消";
                panel1.Visible = true;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                flag = !flag;
            }
            else
            {
                button2.Text = "選項";
                panel1.Visible = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                flag = !flag;
            }
        }

        //radioBtn1 領養
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            var a = from i in dbContext.SubCategories
                    where i.Category.IsPet == true
                    select new { ItemName = i.SubCategoryName, ID = i.SubCategoryID };
            combo1selected_SubCateID = (int)a.Select(n => n.ID).First();
            foreach (var str in a)
            {
                comboBox1.Items.Add(str.ItemName);
            }
        }
        //radioBtn2 商城
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            var a = from i in dbContext.SubCategories
                    where i.Category.IsPet == false
                    select new { ItemName = i.SubCategoryName, ID = i.SubCategoryID };
            foreach (var str in a)
            {
                comboBox1.Items.Add(str.ItemName);
            }
        }
        //radioBtn3 新增指定orderid的details
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox2.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
            }
        }
        //radioBtn4 新增最後加入一筆orderid的details
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (radioButton4.Checked)
                {
                    dateTimePicker1.Enabled = false;
                    textBox4.Enabled = false;
                    textBox2.Enabled = false;
                }
                else
                {
                    dateTimePicker1.Enabled = true;
                    textBox4.Enabled = true;
                    textBox2.Enabled = true;
                }
            }
        }
        //tb1 查memberID訂單
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //search
            int memberID;
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBox1.Text, out memberID))
                {
                    if (dbContext.Members.Where(n => n.MemberID == memberID).Count() == 0)
                    {
                        MessageBox.Show("查無此會員ID");
                    }
                    else
                    {
                        if (dbContext.Orders.Where(n => n.MemberID == memberID).Count() == 0)
                        {
                            MessageBox.Show("此會員無訂單紀錄");
                        }
                        else
                        {
                            dbContext.Configuration.ProxyCreationEnabled = false;

                            var a = from i in dbContext.Orders
                                    where i.MemberID == memberID
                                    select i;

                            dataGridView1.DataSource = a.ToList();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("請輸入數值");
                }
            }
        }
        //tb2 寄送地址
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sendAdress = textBox2.Text;
        }
        //tb3 數量
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out Quan))
            {
                return;
            }
            else
            {
                MessageBox.Show("數量欄位請輸入數值");
            }
        }
        //comboBox1 種類
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo1selected_SubCateID = dbContext.SubCategories.Where(m => m.SubCategoryName == comboBox1.SelectedItem.ToString()).Select(n => n.SubCategoryID).ToList().First();
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            var a = from i in dbContext.Products
                    where i.SubCategoryID == combo1selected_SubCateID
                    select new { ProductName = i.ProductName, ProductID = i.ProductID };
            foreach (var i in a)
            {
                comboBox2.Items.Add(i.ProductName);
            }
            try
            {
                comboBox2.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("無商品");
            }

        }
        //comboBox2 品名
        string combo2selected_ProductName;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = from i in dbContext.Products
                    where i.ProductName == comboBox2.Text
                    select new { ProductID = i.ProductID, ProductName = i.ProductName, UnitPrice = i.Price };
            combo2selected_ProductID = a.Select(n => n.ProductID).First();
            combo2selected_ProductName = a.Select(n => n.ProductName).First();
            productPrice = (decimal)a.Select(n => n.UnitPrice).First();
        }
        #endregion

        #region   修改(DataGridView)
        string current_value;
        //dgv1 編輯前
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView se = (DataGridView)sender;
            try
            {
                current_value = se.CurrentCell.Value.ToString();
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("欄位為空");
                se.CurrentCell.Value = DateTime.Today;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //dvg1 編輯後
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView se = (DataGridView)sender;
            string str = dataGridView1.Columns[se.CurrentCell.ColumnIndex].Name;
            try
            {
                dbContext.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show($"欄位{str}無此編號成員");
                se.CurrentCell.Value = (object)current_value;
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("訂單尚未建立");
                se.CurrentCell.Value = (object)current_value;
            }
        }

        //dgv1 Click後
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView se = (DataGridView)sender;
            int id = (int)se.Rows[se.CurrentCell.RowIndex].Cells["OrderID"].Value;
            var a = dbContext.Order_Detail.Where(n => n.OrderID == id).Select(m => m);
            dataGridView2.DataSource = a.ToList();
        }
        //dgv2 編輯後
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView se = (DataGridView)sender;
            string str = dataGridView2.Columns[se.CurrentCell.ColumnIndex].Name;
            try
            {
                dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"欄位{str}無法進行修改");
                se.CurrentCell.Value = (object)current_value;
            }
        }
        //dgv2 編輯前
        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridView se = (DataGridView)sender;
            current_value = se.CurrentCell.Value.ToString();
        }
        #endregion

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = (int)(((DataGridView)sender).CurrentCell.Value);
            if (((DataGridView)sender).CurrentCell.ColumnIndex == 1)
            {
                var a = dbContext.Products.Where(m => m.ProductID == x).Select(n => new { Name = n.ProductName, Supplier = n.Supplier.Name, Description = n.Description, InStock = n.UnitsInStock });
                DataGridViewCell cell = this.dataGridView2.CurrentCell;
                cell.ToolTipText = $"產品名稱 : {a.Select(n => n.Name).ToList().First()}\n供應商 : {a.Select(n => n.Supplier).ToList().First()}\n庫存量 : {a.Select(n => n.InStock).ToList().First()}\n商品敘述 : {a.Select(n => n.Description).ToList().First()}";
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dataGridView1.Columns[((DataGridView)sender).CurrentCell.ColumnIndex].Name == "Order_StatusID")
            {
                int x = (int)(((DataGridView)sender).CurrentCell.Value);
                DataGridViewCell cell = this.dataGridView2.CurrentCell;
                if ((int)((DataGridView)sender).CurrentCell.Value == 2)
                {
                    cell.ToolTipText = "送達";
                    MessageBox.Show("Test");
                }
                else
                {
                    cell.ToolTipText = "未送達";
                }
                
            }
        }
    }
}