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
                    where m.Phone == UserName&& m.Password == Password
                    select m;

            if (UserName == "")
            {
                MessageBox.Show("請輸入員工ID", "登入失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (Password == "")
            {
                MessageBox.Show("請輸入密碼", "登入失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (q.ToList().Count !=0)
            {
                MessageBox.Show("登入成功");
                FrmAdmin f = new FrmAdmin();
                f.Show();
             
            }
            else
            {
                MessageBox.Show("ID或密碼輸入錯誤", "登入失敗 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //this.Close();
        }
    }
}
