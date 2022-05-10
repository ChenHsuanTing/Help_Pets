using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 我救浪.類別管理
{
    public partial class Form_類別管理 : Form
    {
        我救浪Entities1 dbContext = new 我救浪Entities1();
        public Form_類別管理()
        {
            InitializeComponent();
            categoryTableAdapter1.Fill(pet_DataSet1.Category);
            subCategoryTableAdapter1.Fill(pet_DataSet1.SubCategory);
            supplierTableAdapter1.Fill(pet_DataSet1.Supplier);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q = from c in dbContext.Category
                    select c;
            bindingSource1.DataSource = pet_DataSet1.Category;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               dataGridView1.EndEdit();
               bindingSource1.EndEdit();
                categoryTableAdapter1.Update(pet_DataSet1);
                MessageBox.Show("更新成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = pet_DataSet1.SubCategory;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();
                bindingSource1.EndEdit();
                subCategoryTableAdapter1.Update(pet_DataSet1);
                MessageBox.Show("更新成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = pet_DataSet1.Supplier;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();
                bindingSource1.EndEdit();
                supplierTableAdapter1.Update(pet_DataSet1);
                MessageBox.Show("更新成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
