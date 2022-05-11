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
    public partial class Frm0 : Form
    {
        public Frm0()
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
            FrmAdmin1 frm = new FrmAdmin1();
            ShowForm(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            後臺_Frm類別管理 frm = new 後臺_Frm類別管理();
            ShowForm(frm);
        }
    }
}
