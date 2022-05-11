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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadToComboboxNO();
            LoadToComboboxCity();
            txtPhone.Enabled = false;

        }

        private void LoadToComboboxCity()
        {
            //comboCity.Items.Clear();
            var q = from c in dbContext.Cities
                    orderby c.CityID
                    select new { CityName = c.CityName, CityID = c.CityID };

            comboCity.DataSource = q.Skip(1).ToList();
            comboCity.DisplayMember = "CityName";
            comboCity.ValueMember = "CityID";
        }

        private void LoadToComboboxNO()
        {
            var q = from m in dbContext.Members.AsEnumerable()
                    orderby m.MemberID ascending
                    select m.MemberID;

            foreach (var m in q)
            {
                comboBoxMemNO.Items.Add(m);
            }

            comboBoxMemNO.Items.Add("---All---");

        }
        private void LoadMember()
        {

            string Phone = txtPhone.Text;

            var q = (from m in dbContext.Members
                     where m.MemberPhone == Phone
                     select m).ToList().FirstOrDefault();

            txtName.Text = q.Name;
            txtMail.Text = q.Email;
            txtPassword.Text = q.Password;
            txtAddress.Text = q.Address;
            comboCity.Text = q.City.CityName;
            txtBirth.Text = q.BirthdayDate.Value.ToShortDateString();
        }

        我救浪Entities dbContext = new 我救浪Entities();

        private void btnRead_Click(object sender, EventArgs e)
        {
            string p = txtAccount.Text;


            var q = from m in dbContext.Members
                    where m.MemberPhone == p
                    select new
                    {
                        m.MemberID,
                        m.MemberPhone,
                        m.Email,
                        m.Password,
                        m.Name,
                        m.BirthdayDate,
                        m.CityID,
                        m.Address
                    };
            dataGridView3.DataSource = q.ToList();
        }

        private void comboBoxMemNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBoxMemNO.SelectedItem.ToString();
            if (n == "---All---")
            {
                dataGridView3.DataSource = null;
                var q1 = from m in dbContext.Members
                         select new
                         {
                             m.MemberID,
                             m.MemberPhone,
                             m.Email,
                             m.Password,
                             m.Name,
                             m.BirthdayDate,
                             m.CityID,
                             m.Address
                         };
                dataGridView3.DataSource = q1.ToList();
            }
            else
            {
                int n1 = int.Parse(n);
                dataGridView3.DataSource = null;
                var q = from m in dbContext.Members
                        where m.MemberID == n1
                        select new
                        {
                            m.MemberID,
                            m.MemberPhone,
                            m.Email,
                            m.Password,
                            m.Name,
                            m.BirthdayDate,
                            m.CityID,
                            m.Address
                        };
                dataGridView3.DataSource = q.ToList();
            }





        
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            showData5();
        }
        private void showData5()
        {
            var q = from m in dbContext.Members
                    select new
                    {
                        m.MemberID,
                        m.MemberPhone,
                        m.Email,
                        m.Password,
                        m.Name,
                        m.BirthdayDate,
                        m.CityID,
                        m.Address
                    };
            this.dataGridView5.DataSource = null;

            this.dataGridView5.DataSource = q.ToList();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPhone.Text = "";
            txtPhone.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();
            LoadMember();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定修改資料", "更改會員資料", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                string Phone = txtPhone.Text;
                string Name = txtName.Text;
                string Password = txtPassword.Text;
                string Email = txtMail.Text;
                string Address = txtAddress.Text;
                int CityID = (int)comboCity.SelectedValue;
                DateTime Birth = DateTime.Parse(txtBirth.Text);


                var mem = (from m in dbContext.Members
                           where m.MemberPhone.Contains(Phone)
                           select m).FirstOrDefault();


                mem.Email = Email;
                mem.Name = Name;
                mem.CityID = CityID;
                mem.Address = Address;
                mem.BirthdayDate = Birth;
                mem.Password = Password;


                this.dbContext.SaveChanges();
                MessageBox.Show("修改會員資料成功");


                showData5();
            }
            else
            {
                return;
            }

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtPhone.Text = "";
            txtPhone.Text = this.dataGridView5.CurrentRow.Cells[1].Value.ToString();
            LoadMember();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定刪除資料", "刪除會員資料", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string Phone = txtPhone.Text;
                var q = (from m in this.dbContext.Members
                         where m.MemberPhone.Contains(Phone)
                         select m).FirstOrDefault();

                this.dbContext.Members.Remove(q);
                this.dbContext.SaveChanges();
                showData5();
            }
            else
            {
                return;
            }
        }
    }
}
