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

    public partial class 後臺_Frm留言管理 : Form
    {
        我救浪Entities dbcontext = new 我救浪Entities();
        public 後臺_Frm留言管理()
        {
            InitializeComponent();
            LoadYearToCombobox();
            //LoadMonthToCombobox();
            //LoadGradeToCombobox();
            LoadProductIDToCombobox();
        }

        private void LoadProductIDToCombobox()
        {
            var q = from m in this.dbcontext.Member_Comment
                    orderby m.ProductID
                    select m.ProductID;
            var Mgrade = q.Distinct();
            foreach (var grade in Mgrade)
            {
                this.comboBox4.Items.Add(grade);
            }
        }

        //private void LoadGradeToCombobox()
        //{
        //    var q = from m in this.dbcontext.Member_Comment
        //            orderby m.Grade
        //            select m.Grade;
        //    var Mgrade = q.Distinct();
        //    foreach (var grade in Mgrade)
        //    {
        //        this.comboBox3.Items.Add(grade);
        //    }
        //}

        private void LoadYearToCombobox()
        {
            var q = from m in this.dbcontext.Member_Comment
                    orderby m.CommentDate.Value.Year ascending
                    select m.CommentDate.Value.Year;
            var Myear = q.Distinct();
            foreach (var year in Myear)
            {
                this.comboBox1.Items.Add(year);
            }
        }

        private void btnAllComment_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };

            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn5star_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    where m.Grade == 5
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn4star_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    where m.Grade == 4
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn3star_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    where m.Grade == 3
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn2star_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    where m.Grade == 2
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btn1star_Click(object sender, EventArgs e)
        {
            var q = from m in this.dbcontext.Member_Comment
                    where m.Grade == 1
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("請選擇年份!");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("請選擇月份!");
            }
            else
            {
                string year = comboBox1.Text;
                string month = comboBox2.Text;
                var q = from m in this.dbcontext.Member_Comment
                        where m.CommentDate.Value.Year.ToString() == year
                           && m.CommentDate.Value.Month.ToString() == month
                        select new
                        {
                            m.CommentID,
                            m.ProductID,
                            m.MemberID,
                            m.Member.Name,
                            m.Grade,
                            m.Description,
                            m.CommentDate
                        };
                this.dataGridView1.DataSource = q.ToList();
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Add Product
            if (txtProducts.Text == "")
            {
                MessageBox.Show("請輸入編號!");
            }
            else if (txtMember.Text == "")
            {
                MessageBox.Show("請輸入編號!");
            }
            else if (comboBox3.Text == "")
            {
                MessageBox.Show("請選擇星等!");
            }
            else if (txtComment.Text == "")
            {
                MessageBox.Show("請輸入評論!");
            }
            else
            {

                Member_Comment comment = new Member_Comment
                {
                    ProductID = int.Parse(this.txtProducts.Text),
                    MemberID = int.Parse(this.txtMember.Text),
                    Description = this.txtComment.Text,
                    Grade = int.Parse(this.comboBox3.Text),
                    CommentDate = DateTime.Today,

                };
                this.dbcontext.Member_Comment.Add(comment);

                this.dbcontext.SaveChanges();
                MessageBox.Show("新增成功");
                this.Read_RefreshDataGridView();
                this.comboBox1.Items.Clear();
                this.comboBox4.Items.Clear();
                LoadYearToCombobox();
                LoadProductIDToCombobox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete
            var comment = (from m in this.dbcontext.Member_Comment.AsEnumerable()
                           where m.CommentID == int.Parse(this.dataGridView1.SelectedCells[0].Value.ToString())
                           select m).FirstOrDefault();

            if (comment == null) return;

            this.dbcontext.Member_Comment.Remove(comment);
            this.dbcontext.SaveChanges();
            MessageBox.Show("刪除成功");
            this.Read_RefreshDataGridView();

            this.comboBox1.Items.Clear();
            this.comboBox4.Items.Clear();
            LoadYearToCombobox();
            LoadProductIDToCombobox();
        }
        void Read_RefreshDataGridView()
        {
            var q = from m in this.dbcontext.Member_Comment
                    select new
                    {
                        m.CommentID,
                        m.ProductID,
                        m.MemberID,
                        m.Member.Name,
                        m.Grade,
                        m.Description,
                        m.CommentDate
                    };
            //this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = q.ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                MessageBox.Show("請選擇星等!");
            }
            else if (txtComment.Text == "")
            {
                MessageBox.Show("請輸入評論!");
            }
            else
            {
                var comment = (from m in this.dbcontext.Member_Comment.AsEnumerable()
                               where m.CommentID == int.Parse(this.dataGridView1.SelectedCells[0].Value.ToString())
                               select m).FirstOrDefault();

                if (comment == null) return; //exit method

                comment.Description = txtComment.Text;
                comment.Grade = int.Parse(comboBox3.Text);

                this.dbcontext.SaveChanges();
                int r = dataGridView1.CurrentCell.RowIndex;
                int c = dataGridView1.CurrentCell.ColumnIndex;
                MessageBox.Show("修改成功");
                this.Read_RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1.Rows[r].Cells[c];
            }

        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            {
                MessageBox.Show("請選擇編號!");
            }
            else
            {

                var q = from m in this.dbcontext.Member_Comment.AsEnumerable()
                        where m.ProductID == int.Parse(this.comboBox4.Text)
                        select new
                        {
                            m.CommentID,
                            m.ProductID,
                            m.MemberID,
                            m.Member.Name,
                            m.Grade,
                            m.Description,
                            m.CommentDate
                        };
                this.dataGridView1.DataSource = q.ToList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProducts.Text = dataGridView1.CurrentRow.Cells["ProductID"].Value.ToString();
            txtMember.Text = dataGridView1.CurrentRow.Cells["MemberID"].Value.ToString();
            comboBox3.Text = dataGridView1.CurrentRow.Cells["Grade"].Value.ToString();
            txtComment.Text = dataGridView1.CurrentRow.Cells["Description"].Value.ToString();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.comboBox2.Text = "";
            this.comboBox2.Items.Clear();
            var q = (from m in this.dbcontext.Member_Comment
                     orderby m.CommentDate
                     where m.CommentDate.Value.Year.ToString() == comboBox1.SelectedItem.ToString()
                     select m.CommentDate.Value.Month).Distinct();

            foreach (var n in q)
            {
                this.comboBox2.Items.Add(n);
            }
        }
    }
}
