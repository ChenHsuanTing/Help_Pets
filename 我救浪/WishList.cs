using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetAdopt
{
    public partial class WishList : Form
    {
        public WishList()
        {
            InitializeComponent();
        }

        private void pet_DetailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.tableAdapterManager.UpdateAll(this.陳老師的動物之家DataSet);

        }

        private void WishList_Load(object sender, EventArgs e)
        {
            

        }

        private void member_Wish_SizeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.member_Wish_SizeBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.陳老師的動物之家DataSet);

        }

        private void member_WishBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.tableAdapterManager.UpdateAll(this.陳老師的動物之家DataSet);

        }

        private void member_WishBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            //this.tableAdapterManager.UpdateAll(this.陳老師的動物之家DataSet);

        }


    }
}
