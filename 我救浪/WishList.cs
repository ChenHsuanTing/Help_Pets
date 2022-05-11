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
            //// TODO: 這行程式碼會將資料載入 '陳老師的動物之家DataSet.Member_Wish_Size' 資料表。您可以視需要進行移動或移除。
            //this.member_Wish_SizeTableAdapter.Fill(this.陳老師的動物之家DataSet.Member_Wish_Size);
            //// TODO: 這行程式碼會將資料載入 '陳老師的動物之家DataSet.Member_Wish_Color' 資料表。您可以視需要進行移動或移除。
            //this.member_Wish_ColorTableAdapter.Fill(this.陳老師的動物之家DataSet.Member_Wish_Color);
            //// TODO: 這行程式碼會將資料載入 '陳老師的動物之家DataSet.Member_Wish' 資料表。您可以視需要進行移動或移除。
            //this.member_WishTableAdapter.Fill(this.陳老師的動物之家DataSet.Member_Wish);
            //// TODO: 這行程式碼會將資料載入 '陳老師的動物之家DataSet.Member_Wish' 資料表。您可以視需要進行移動或移除。
            //this.member_WishTableAdapter.Fill(this.陳老師的動物之家DataSet.Member_Wish);
            //// TODO: 這行程式碼會將資料載入 '陳老師的動物之家DataSet.Member_Wish_Size' 資料表。您可以視需要進行移動或移除。
            //this.member_Wish_SizeTableAdapter.Fill(this.陳老師的動物之家DataSet.Member_Wish_Size);
            //// TODO: 這行程式碼會將資料載入 '陳老師的動物之家DataSet.Category' 資料表。您可以視需要進行移動或移除。
            //// TODO: 這行程式碼會將資料載入 '陳老師的動物之家DataSet.Pet_Detail' 資料表。您可以視需要進行移動或移除。

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
