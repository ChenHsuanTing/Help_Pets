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
    public partial class 後臺_Frm後臺整合 : Form
    {
        public 後臺_Frm後臺整合()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            ShowForm(frm);
        }
        void ShowForm(Form frm)
        {
            splitContainer4.Panel2.Controls.Clear();
            frm.TopLevel = false;
            splitContainer4.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            後臺_Frm訂單管理 frm = new 後臺_Frm訂單管理();
            ShowForm(frm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            後臺_Frm商品管理 frm = new 後臺_Frm商品管理();
            ShowForm(frm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm浪浪管理 frm = new Frm浪浪管理();
            ShowForm(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            後臺_Frm類別管理 frm = new 後臺_Frm類別管理();
            ShowForm(frm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            後臺_Frm留言管理 frm = new 後臺_Frm留言管理();
            ShowForm(frm);
        }
    }
}
