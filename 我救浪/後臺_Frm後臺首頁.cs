using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace 我救浪
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            後臺_Frm訂單管理 ordersManage = new 後臺_Frm訂單管理();
            ordersManage.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(ordersManage);
            ordersManage.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Form1 frm = new Form1();
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            splitContainer2.Panel2.Controls.Clear();
            後臺_Frm類別管理 frm = new 後臺_Frm類別管理();
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            後臺_Frm留言管理 frm = new 後臺_Frm留言管理();
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            後臺_Frm商品管理 frm = new 後臺_Frm商品管理();
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            後臺_Frm配對條件管理 frm = new 後臺_Frm配對條件管理();
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2.Controls.Clear();
            Frm浪浪管理 frm = new Frm浪浪管理();
            frm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(frm);
            frm.Show();
        }
    }
}
