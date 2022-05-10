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
    public partial class Frm忘記密碼 : Form
    {
        public Frm忘記密碼()
        {
            InitializeComponent();
            txtPhone.Focus();
            txtPassword.Enabled = false;
            txtPassword1.Enabled = false;
        }
        我救浪Entities dbContext = new 我救浪Entities();

        private void btn驗證_Click(object sender, EventArgs e)
        {
            string Phone = txtPhone.Text;
            string Email = txtEmail.Text;
            var q = from m in dbContext.Members
                    where m.MemberPhone == Phone && m.Email == Email
                    select m;

            if (q.ToList().Count() != 0)
            {
                MessageBox.Show("驗證成功");
                txtPassword.Enabled = true;
                txtPassword1.Enabled = true;
            }
            else
            {
                MessageBox.Show("驗證失敗");
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string Phone=txtPhone.Text;
            string Password = txtPassword.Text;
            string Password1 = txtPassword1.Text;

            if (Password == Password1)
            {

                var q = (from m in dbContext.Members
                         where m.MemberPhone.Contains(Phone)
                         select m).FirstOrDefault();

                q.Password = Password;

                this.dbContext.SaveChanges();
                MessageBox.Show("修改密碼成功");

            }
            else if(Password==""||Password1=="")
            {
                MessageBox.Show("請輸入更改的密碼", "更改密碼失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("密碼輸入不一致", "更改密碼失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }
    }
}
