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
    public partial class Frm註冊 : Form
    {
        public Frm註冊()
        {
            InitializeComponent();
            LoadToCombobox();
            txtPhone.Focus();
            btnCreat.Enabled =false ;

            //comboBoxCity.ResetText();
        }

        public void LoadToCombobox()
        {
            

            var q = from m in dbContext.Cities.AsEnumerable()
                          orderby m.CityID ascending
                    select new { CityName=m.CityName,CityID=m.CityID };
            comboBoxCity.DataSource = q.ToList();
            comboBoxCity.DisplayMember = "CityName";
            comboBoxCity.ValueMember = "CityID";
            

        }

        我救浪Entities dbContext = new 我救浪Entities();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Name = txtName.Text;
            string Password = txtPassword.Text;
            string Password1 = txtPassword1.Text;
            string Phone = txtPhone.Text;
            string Address = txtAddress.Text;
            int CityID = (int)comboBoxCity.SelectedValue;
            DateTime Birth = dateTimePicker1.Value;


            if (Email == "" || Name == "" || Password1 == "" || Address == "")
            { MessageBox.Show("請輸入完整資料"); }
            else if(Password !=Password1)
            {
                MessageBox.Show("請確認輸入密碼一致！", " 密碼有誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                  

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    Member mem = new Member
                    { 
                        Email = Email,
                        Name = Name, 
                        CityID = CityID, 
                        Address =Address, 
                        BirthdayDate = Birth, 
                        MemberPhone = Phone, 
                        Password = Password1 
                    };
                    this.dbContext.Members.Add(mem);
                    this.dbContext.SaveChanges();
                    MessageBox.Show("註冊成功");
                    this.Close();

            }
        }

        private void Frm註冊_Load(object sender, EventArgs e)
        {
            comboBoxCity.Text = "--請選擇城市--";
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
           
        }

      public void Clean()
        {
            txtEmail.Text = "";
            txtName.Text = ""; ;
            txtPassword.Text = "";
            txtPassword1.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            comboBoxCity.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Phone = txtPhone.Text;

            var q = from m in dbContext.Members
                    where m.MemberPhone == Phone
                    select m.MemberPhone;
            if (Phone == "")
            {
                MessageBox.Show("請輸入手機號碼", "驗證失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (q.ToList().Count != 0)
            {
                MessageBox.Show("此號碼已註冊為會員", " 驗證失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
              btnCreat.Enabled = true;

                MessageBox.Show("驗證成功");
            }
        }
    }
}
