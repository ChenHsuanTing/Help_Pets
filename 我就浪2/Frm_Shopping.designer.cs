
namespace 我救浪
{
    partial class Frm_Shopping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_HiMem = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.butAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboBox_Pet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linlLb_ShoppingCar = new System.Windows.Forms.LinkLabel();
            this.lb_TotalPay = new System.Windows.Forms.Label();
            this.but_Search = new System.Windows.Forms.Button();
            this.comBox_Price = new System.Windows.Forms.ComboBox();
            this.lb_Price = new System.Windows.Forms.Label();
            this.comBox_SubCtg = new System.Windows.Forms.ComboBox();
            this.lb_SubCtg = new System.Windows.Forms.Label();
            this.comBox_Category = new System.Windows.Forms.ComboBox();
            this.lb_Category = new System.Windows.Forms.Label();
            this.flowLayoutPanrl1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lb_HiMem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1175, 763);
            this.splitContainer1.SplitterDistance = 114;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(1033, 70);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "登出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(866, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "前往領養平台";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(71, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "我救浪~~購物中心";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_HiMem
            // 
            this.lb_HiMem.BackColor = System.Drawing.Color.Cyan;
            this.lb_HiMem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_HiMem.ForeColor = System.Drawing.SystemColors.Info;
            this.lb_HiMem.Location = new System.Drawing.Point(987, 6);
            this.lb_HiMem.Name = "lb_HiMem";
            this.lb_HiMem.Size = new System.Drawing.Size(176, 27);
            this.lb_HiMem.TabIndex = 9;
            this.lb_HiMem.Text = "label2";
            this.lb_HiMem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.splitContainer2.Panel1.Controls.Add(this.butAll);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.cboBox_Pet);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.linlLb_ShoppingCar);
            this.splitContainer2.Panel1.Controls.Add(this.lb_TotalPay);
            this.splitContainer2.Panel1.Controls.Add(this.but_Search);
            this.splitContainer2.Panel1.Controls.Add(this.comBox_Price);
            this.splitContainer2.Panel1.Controls.Add(this.lb_Price);
            this.splitContainer2.Panel1.Controls.Add(this.comBox_SubCtg);
            this.splitContainer2.Panel1.Controls.Add(this.lb_SubCtg);
            this.splitContainer2.Panel1.Controls.Add(this.comBox_Category);
            this.splitContainer2.Panel1.Controls.Add(this.lb_Category);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanrl1);
            this.splitContainer2.Size = new System.Drawing.Size(1175, 646);
            this.splitContainer2.SplitterDistance = 296;
            this.splitContainer2.TabIndex = 0;
            // 
            // butAll
            // 
            this.butAll.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butAll.Location = new System.Drawing.Point(48, 383);
            this.butAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(125, 33);
            this.butAll.TabIndex = 13;
            this.butAll.Text = "全部產品";
            this.butAll.UseVisualStyleBackColor = true;
            this.butAll.Click += new System.EventHandler(this.butAll_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(33, 457);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "我的收藏";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboBox_Pet
            // 
            this.cboBox_Pet.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboBox_Pet.FormattingEnabled = true;
            this.cboBox_Pet.Location = new System.Drawing.Point(17, 43);
            this.cboBox_Pet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBox_Pet.Name = "cboBox_Pet";
            this.cboBox_Pet.Size = new System.Drawing.Size(216, 30);
            this.cboBox_Pet.TabIndex = 11;
            this.cboBox_Pet.SelectionChangeCommitted += new System.EventHandler(this.cboBox_Pet_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(20, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "寵物分類:";
            // 
            // linlLb_ShoppingCar
            // 
            this.linlLb_ShoppingCar.AutoSize = true;
            this.linlLb_ShoppingCar.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linlLb_ShoppingCar.Location = new System.Drawing.Point(16, 555);
            this.linlLb_ShoppingCar.Name = "linlLb_ShoppingCar";
            this.linlLb_ShoppingCar.Size = new System.Drawing.Size(96, 35);
            this.linlLb_ShoppingCar.TabIndex = 8;
            this.linlLb_ShoppingCar.TabStop = true;
            this.linlLb_ShoppingCar.Text = "購物車";
            this.linlLb_ShoppingCar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlLb_ShoppingCar_LinkClicked);
            // 
            // lb_TotalPay
            // 
            this.lb_TotalPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_TotalPay.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_TotalPay.Location = new System.Drawing.Point(17, 588);
            this.lb_TotalPay.Name = "lb_TotalPay";
            this.lb_TotalPay.Size = new System.Drawing.Size(221, 48);
            this.lb_TotalPay.TabIndex = 7;
            this.lb_TotalPay.Text = "金額:0 元 (0)";
            this.lb_TotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // but_Search
            // 
            this.but_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Search.Location = new System.Drawing.Point(48, 325);
            this.but_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(125, 33);
            this.but_Search.TabIndex = 6;
            this.but_Search.Text = "搜尋";
            this.but_Search.UseVisualStyleBackColor = true;
            this.but_Search.Click += new System.EventHandler(this.but_Search_Click);
            // 
            // comBox_Price
            // 
            this.comBox_Price.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBox_Price.FormattingEnabled = true;
            this.comBox_Price.Location = new System.Drawing.Point(13, 292);
            this.comBox_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comBox_Price.Name = "comBox_Price";
            this.comBox_Price.Size = new System.Drawing.Size(216, 30);
            this.comBox_Price.TabIndex = 5;
            this.comBox_Price.Visible = false;
            // 
            // lb_Price
            // 
            this.lb_Price.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Price.Location = new System.Drawing.Point(20, 263);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(140, 27);
            this.lb_Price.TabIndex = 4;
            this.lb_Price.Text = "價格區間:";
            this.lb_Price.Visible = false;
            // 
            // comBox_SubCtg
            // 
            this.comBox_SubCtg.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBox_SubCtg.FormattingEnabled = true;
            this.comBox_SubCtg.Location = new System.Drawing.Point(17, 206);
            this.comBox_SubCtg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comBox_SubCtg.Name = "comBox_SubCtg";
            this.comBox_SubCtg.Size = new System.Drawing.Size(216, 30);
            this.comBox_SubCtg.TabIndex = 3;
            // 
            // lb_SubCtg
            // 
            this.lb_SubCtg.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_SubCtg.Location = new System.Drawing.Point(20, 177);
            this.lb_SubCtg.Name = "lb_SubCtg";
            this.lb_SubCtg.Size = new System.Drawing.Size(121, 27);
            this.lb_SubCtg.TabIndex = 2;
            this.lb_SubCtg.Text = "產品次分類:";
            // 
            // comBox_Category
            // 
            this.comBox_Category.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBox_Category.FormattingEnabled = true;
            this.comBox_Category.Location = new System.Drawing.Point(17, 118);
            this.comBox_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comBox_Category.Name = "comBox_Category";
            this.comBox_Category.Size = new System.Drawing.Size(216, 30);
            this.comBox_Category.TabIndex = 1;
            this.comBox_Category.SelectionChangeCommitted += new System.EventHandler(this.comBox_Category_SelectionChangeCommitted);
            // 
            // lb_Category
            // 
            this.lb_Category.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Category.Location = new System.Drawing.Point(20, 89);
            this.lb_Category.Name = "lb_Category";
            this.lb_Category.Size = new System.Drawing.Size(96, 27);
            this.lb_Category.TabIndex = 0;
            this.lb_Category.Text = "產品分類:";
            // 
            // flowLayoutPanrl1
            // 
            this.flowLayoutPanrl1.AutoScroll = true;
            this.flowLayoutPanrl1.BackColor = System.Drawing.Color.LightPink;
            this.flowLayoutPanrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanrl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flowLayoutPanrl1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanrl1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.flowLayoutPanrl1.Name = "flowLayoutPanrl1";
            this.flowLayoutPanrl1.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.flowLayoutPanrl1.Size = new System.Drawing.Size(871, 642);
            this.flowLayoutPanrl1.TabIndex = 0;
            // 
            // Frm_Shopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 763);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Shopping";
            this.Text = "Frm_Shopping";
            this.Load += new System.EventHandler(this.Frm_Shopping_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox comBox_Category;
        private System.Windows.Forms.Label lb_Category;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanrl1;
        private System.Windows.Forms.ComboBox comBox_SubCtg;
        private System.Windows.Forms.Label lb_SubCtg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linlLb_ShoppingCar;
        private System.Windows.Forms.Label lb_TotalPay;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.ComboBox comBox_Price;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label lb_HiMem;
        private System.Windows.Forms.ComboBox cboBox_Pet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butAll;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}