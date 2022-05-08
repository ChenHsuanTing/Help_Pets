using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 我救浪
{
    public partial class Form_商品管理 : Form
    {
        我救浪Entities1 dbContext=new  我救浪Entities1();
        public Form_商品管理()
        {
            InitializeComponent();
            PageClear();
            LoadToComboBoxFromStart();
            
        }
        void PageClear()
        {
            tabPage1.Parent = null;
            tabPage2.Parent = null;
            tabPage3.Parent = null;
            tabPage4.Parent = null;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PageClear();
            tabPage2.Parent = tabControl1;
            comboBox6.ResetText();
            comboBox7.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageClear();
            tabPage1.Parent = tabControl1;
            comboBox1.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PageClear();
            tabPage3.Parent= tabControl1;
            comboBox11.ResetText();
            comboBox10.ResetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PageClear();
            tabPage4.Parent= tabControl1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = from p in dbContext.Product
                        where p.IsPet==false
                    select new
                    {
                        p.ProductID,
                        p.ProductName,
                        p.SubCategory.SubCategoryName,
                        p.Price,
                       Supplier=p.Supplier.Name
                   };
             bindingSource1.DataSource = q.ToList();
            dataGridView1.DataSource = bindingSource1;
        }
        void LoadToComboBoxFromStart()
        {
            var q = from c in dbContext.Category
                    where c.IsPet == false
                    select new { CategoryID=c.CategoryID, CategoryName=c.CategoryName };

            var q_EmployeeName=from e in dbContext.Employee
                               select new {EmployeeID=e.EmpoyeeID, EmployeeName=e.Name};

            var q_Supplier=from s in dbContext.Supplier
                           select new {SupplierID=s.SupplierID,SupplierName=s.Name};

            //搜尋的主分類
            comboBox1.DataSource= q.ToList();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            //新增的主分類
            comboBox6.DataSource = q.ToList();
            comboBox6.DisplayMember = "CategoryName";
            comboBox6.ValueMember = "CategoryID";
            //新增的員工姓名
            comboBox7.DataSource = q_EmployeeName.ToList();
            comboBox7.DisplayMember = "EmployeeName";
            comboBox7.ValueMember = "EmployeeID";

            //修改的主分類
            comboBox11.DataSource = q.ToList();
            comboBox11.DisplayMember = "CategoryName";
            comboBox11.ValueMember = "CategoryID";
            //修改的供應商
            comboBox10.DataSource = q_Supplier.ToList();
            comboBox10.DisplayMember = "SupplierName";
            comboBox10.ValueMember = "SupplierID";

        }

        void SelectCategoryInComboBox(ComboBox source,ComboBox SubCategoryBox)
        {
            var q = from sc in dbContext.SubCategory
                    where sc.Category.CategoryName == source.Text
                    select new { SubCategoryID = sc.SubCategoryID, SubCategoryName = sc.SubCategoryName };

            SubCategoryBox.DataSource = q.ToList();
            SubCategoryBox.DisplayMember = "SubCategoryName";
            SubCategoryBox.ValueMember = "SubCategoryID";
            SubCategoryBox.ResetText();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCategoryInComboBox(comboBox1,comboBox2);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = from p in dbContext.Product
                    where p.SubCategory.SubCategoryName == comboBox2.Text
                    select new {ProductID=p.ProductID,  ProductName = p.ProductName };
            
            comboBox3.DataSource = q.ToList();
            comboBox3.DisplayMember = "ProductName";
            comboBox6.ValueMember = "ProductID";
            comboBox3.ResetText();
        }
        delegate bool Condition(Product p);
        void LoadProductSelectToDatagridview(Condition condition)
        {
            var q = from p in dbContext.Product.AsEnumerable()
                    where condition(p)
                    select new
                    {
                        p.ProductID,
                        p.ProductName,
                        p.SubCategory.SubCategoryName,
                        p.Price,
                        Supplier = p.Supplier.Name
                    };
            bindingSource1.DataSource = q.ToList();
            dataGridView1.DataSource = bindingSource1;
        }
        private void button6_Click(object sender, EventArgs e)
        {
           if(comboBox2.Text=="")
            {
                LoadProductSelectToDatagridview(p => p.SubCategory.Category.CategoryName == comboBox1.Text);
            }
           else if(comboBox3.Text=="")
            {
                LoadProductSelectToDatagridview(p=>p.SubCategory.SubCategoryName==comboBox2.Text);
            }
           else LoadProductSelectToDatagridview(p=>p.ProductName==comboBox3.Text);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCategoryInComboBox(comboBox6, comboBox4);
        }

        private void Form_商品管理_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = from s in dbContext.Supplier
                    where s.EmployeeID == (int)comboBox7.SelectedValue
                    select new { SupplierID =s.SupplierID , SupplierName = s.Name };

            comboBox5.DataSource = q.ToList();
            comboBox5.DisplayMember = "SupplierName";
            comboBox5.ValueMember = "SupplierID";
            comboBox5.ResetText();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
               Product product = new Product()
                {
                    SubCategoryID = (int)comboBox4.SelectedValue,
                    SupplierID = (int)comboBox5.SelectedValue,
                    Price = int.Parse(textBox2.Text),
                    ProductName = textBox1.Text,
                    IsPet = false
                };

                dbContext.Product.Add(product);
                dbContext.SaveChanges();
                MessageBox.Show("新增成功");
            }
            catch (Exception)
            {
                MessageBox.Show("新增失敗");
            }
 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                var q = from p in dbContext.Product.AsEnumerable()
                        where p.ProductID == int.Parse(textBox3.Text) && p.IsPet == false
                        select new
                        {
                            CategoryName = p.SubCategory.Category.CategoryName,
                            CategoryID = p.SubCategory.CategoryID,
                            SubCategoryID=p.SubCategoryID,
                            SubCategoryName = p.SubCategory.SubCategoryName,
                            SupplierID=p.SupplierID,
                            SupplierName=p.Supplier.Name,
                            Price=p.Price,
                            p.ProductName,
                            p.ProductID
                        };
                if(q==null)
                {
                    MessageBox.Show("找不到對應商品");

                }
                else
                {
                    var Q=q.ToList();
                    label12.Text = Q[0].CategoryName.ToString();
                    label12.Tag = Q[0].CategoryID;
                    label20.Text = Q[0].SubCategoryName;
                    label20.Tag= Q[0].SubCategoryID;
                    label19.Text = Q[0].SupplierName;
                    label19.Tag = Q[0].SupplierID;
                    label18.Text = Q[0].Price.ToString();

                    label17.Text = Q[0].ProductName;

                    label21.Text=Q[0].ProductID.ToString();

                }
            }
            catch (Exception )
            {
                MessageBox.Show("找不到對應商品");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var product=(from p in dbContext.Product.AsEnumerable()
                        where p.ProductID==int.Parse(label21.Text) 
                        select p).FirstOrDefault();
            if (product == null)
            {
                MessageBox.Show("修改失敗");
                return;
            }
            else
            {
                product.SubCategoryID = (int)label20.Tag;
                product.SupplierID = (int)label19.Tag;
                product.Price = int.Parse(textBox4.Text);
                product.ProductName = textBox5.Text;
            }
            dbContext.SaveChanges();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.Text=comboBox11.Text;
            label12.Tag = comboBox11.SelectedValue;

            SelectCategoryInComboBox(comboBox11, comboBox9);
        }
    }
}
