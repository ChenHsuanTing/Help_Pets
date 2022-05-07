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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        我救浪Entities PetContext = new 我救浪Entities();




        #region 浪浪管理
       
        private void button20_Click(object sender, EventArgs e)
        {//查詢
            var q = from n in PetContext.Pet_Detail
                    select n;
            this.dataGridView4.DataSource = q.ToList();

            //age  int / bool 錯誤
        }
        private void button1_Click(object sender, EventArgs e)
        {//新增照片
            this.openFileDialog1.Filter = "*.jpg (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                openFileDialog1.Dispose();
            }
        }


        #endregion


    }
}
