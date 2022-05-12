using PetAdopt;
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
    public partial class FrmMemLogIn : Form
    {
        public static int memID;
        public FrmMemLogIn()
        {
            InitializeComponent();
            Usernametxt.Focus();
            Usernametxt.Text = "0952586543";
            Passwordtxt.Text = "123";
        }
        我救浪Entities dbContext = new 我救浪Entities();
        private void button3_Click(object sender, EventArgs e)
        {

        }

        public static string UserName = "";
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            string UserName = Usernametxt.Text;
            string Password = Passwordtxt.Text;
            
            var q = from m in dbContext.Members
                    where m.MemberPhone == UserName && m.Password == Password
                    select m;

            if (q.ToList().Count != 0)
            {
                MessageBox.Show("登入成功");
                FormPetAdopt frm = new FormPetAdopt();
                memID = q.Select(m => m.MemberID).ToList().First();
                this.Visible = false;
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.No)
                {
                    this.Visible = true;
                }
            }
            else if (UserName == "")
            {
                MessageBox.Show("請輸入帳號密碼", "登入失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Password == "")
            {
                MessageBox.Show("請輸入密碼", "登入失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("帳號或密碼輸入錯誤", "登入失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm註冊 f = new Frm註冊();
            f.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm忘記密碼 f = new Frm忘記密碼();
            f.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserName = Usernametxt.Text;
            var q = from m in dbContext.Members
                    where m.MemberPhone == UserName
                    select m;

            if (q.ToList().Count() != 0)
            {
                Frm修改會員資料 f = new Frm修改會員資料();
                f.Show();
            }

            else if (UserName == "")
            {
                MessageBox.Show("請輸入帳號，更改會員資料", "會員資料修改", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                MessageBox.Show("尚未註冊為會員", "會員資料修改", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Passwordtxt.UseSystemPasswordChar = !Passwordtxt.UseSystemPasswordChar;
        }
    }
}
