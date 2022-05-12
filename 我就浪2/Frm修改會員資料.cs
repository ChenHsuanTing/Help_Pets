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

namespace 我救浪
{
    public partial class Frm修改會員資料 : Form
    {
        public Frm修改會員資料()
        {
            InitializeComponent();
            LoadToCombobox();
            LoadMember();
            txtPhone.Focus();
            txtPhone.Enabled = false;


        }

        string Phone = FrmMemLogIn.UserName;
        private void LoadMember()
        {
            txtPhone.Text = Phone;

            var q = (from m in dbContext.Members
                    where m.MemberPhone == Phone
                    select m).ToList().FirstOrDefault();

            txtName.Text = q.Name;
            txtEmail.Text = q.Email;
            txtAddress.Text = q.Address;
            comboBoxCity.Text= q.City.CityName;
            dateTimePicker1.Value = (DateTime)q.BirthdayDate;
          
        }

        private void LoadToCombobox()
        {

            var q = from m in dbContext.Cities.AsEnumerable()
                    orderby m.CityID ascending
                    select new { CityName = m.CityName, CityID = m.CityID };
            comboBoxCity.DataSource = q.Skip(1).ToList();
            comboBoxCity.DisplayMember = "CityName";
            comboBoxCity.ValueMember = "CityID";

        }
        
        我救浪Entities dbContext = new 我救浪Entities();


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void Clean()
        {
            txtPhone.Text = "";
            txtName.Text = ""; ;
            txtPassword.Text = "";
            txtPassword1.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            comboBoxCity.Text = "";
        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            string Name = txtName.Text;
            string Password = txtPassword.Text;
            string Password1 = txtPassword1.Text;
            string Email = txtEmail.Text;
            string Address = txtAddress.Text;
            int CityID = (int)comboBoxCity.SelectedValue;
            DateTime Birth = dateTimePicker1.Value;
            
            if (Password == "" || Password == "")
            {
                MessageBox.Show("請輸入完整資料");
            }
            else if (Password != Password1)
            {
                MessageBox.Show("請確認輸入密碼一致！", " 密碼有誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    var mem = (from m in dbContext.Members
                                          where m.MemberPhone.Contains(Phone)
                                           select m).FirstOrDefault();
                  

                    mem.Email = Email;
                    mem.Name = Name;
                    mem.CityID = CityID;
                    mem.Address =Address;
                    mem.BirthdayDate = Birth;
                    mem.Password = Password1;

                    this.dbContext.SaveChanges();
                    MessageBox.Show("修改會員資料成功");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void Frm修改會員資料_Load(object sender, EventArgs e)
        {
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            txtPassword1.UseSystemPasswordChar = !txtPassword1.UseSystemPasswordChar;
        }
    }
}
