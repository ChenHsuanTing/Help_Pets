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
    public partial class Form_配對條件管理 : Form
    {
        我救浪Entities1 dbContext = new 我救浪Entities1();
        public Form_配對條件管理()
        {
            InitializeComponent();
            cityTableAdapter1.Fill(pet_DataSet1.City);
            colorTableAdapter1.Fill(pet_DataSet1.Color);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource =dbContext.City.ToList() ;
            dataGridView1.DataSource = bindingSource1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();
                bindingSource1.EndEdit();
                cityTableAdapter1.Update(pet_DataSet1);
                MessageBox.Show("更新成功");
                button1.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource =dbContext.Color.ToList();
            dataGridView1.DataSource = bindingSource1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();
                bindingSource1.EndEdit();
                colorTableAdapter1.Update(pet_DataSet1);
                MessageBox.Show("更新成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            City c = new City()
            {
                CityName=textBox1.Text
            };
            dbContext.City.Add(c);
            dbContext.SaveChanges();
            MessageBox.Show("新增成功");
            button1.PerformClick();
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("刪除失敗");
                    return;
                }
                int cityId = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value ;
                var city = (from c in dbContext.City
                        where c.CityID == cityId
                        select c).FirstOrDefault();
                if(city==null)
                {
                    MessageBox.Show("刪除失敗");
                    return;
                }
                dbContext.City.Remove(city);
                dbContext.SaveChanges();
                MessageBox.Show("刪除成功");
                button1.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Color c = new Color()
            {
                ColorName = textBox2.Text
            };
            dbContext.Color.Add(c);
            dbContext.SaveChanges();
            MessageBox.Show("新增成功");
            button6.PerformClick();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("刪除失敗");
                    return;
                }
                int colorID = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
                var color = (from c in dbContext.Color
                            where c.ColorID == colorID
                            select c).FirstOrDefault();
                if (color == null)
                {
                    MessageBox.Show("刪除失敗");
                    return;
                }
                dbContext.Color.Remove(color);
                dbContext.SaveChanges();
                MessageBox.Show("刪除成功");
                button6.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
