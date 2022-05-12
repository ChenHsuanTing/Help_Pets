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
    public partial class Frm員工登入 : Form
    {
        public Frm員工登入()
        {
            InitializeComponent();
            Usernametxt.Focus();

        }
        我救浪Entities dbContext = new 我救浪Entities();
        public static int empID = 1;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            Usernametxt.Text = "";
            Passwordtxt.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = Usernametxt.Text;
            string Password = Passwordtxt.Text;

            var q = from m in dbContext.Employees
                    where m.Phone == UserName && m.Password == Password
                    select m.EmpoyeeID;

            if (UserName == "")
            {
                MessageBox.Show("請輸入員工ID", "登入失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Password == "")
            {
                MessageBox.Show("請輸入密碼", "登入失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (q.ToList().Count != 0)
            {
                MessageBox.Show("登入成功");
                後臺_Frm後臺整合 f = new 後臺_Frm後臺整合();
                f.Show();
                empID = q.ToList().First();
            }
            else
            {
                MessageBox.Show("ID或密碼輸入錯誤", "登入失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //FrmAdmin f = new FrmAdmin();
            //f.Show();
        }

        private void Frm員工登入_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Passwordtxt.UseSystemPasswordChar = !Passwordtxt.UseSystemPasswordChar;
        }
    }
}
