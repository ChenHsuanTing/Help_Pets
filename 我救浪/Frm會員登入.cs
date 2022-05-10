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
    public partial class FrmMemLogIn : Form
    {
        public FrmMemLogIn()
        {
            InitializeComponent();
            Usernametxt.Focus();
        }
        我救浪Entities dbContext = new 我救浪Entities();
        private void button3_Click(object sender, EventArgs e)
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

            else if (UserName=="")
            {
                MessageBox.Show("請輸入帳號，更改會員資料", "會員資料修改", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
               
                MessageBox.Show("尚未註冊為會員", "會員資料修改", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            Frm員工登入 f = new Frm員工登入();
            f.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm忘記密碼 f = new Frm忘記密碼();
            f.Show();
        }
    }
}
