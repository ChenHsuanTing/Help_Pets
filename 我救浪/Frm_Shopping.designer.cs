
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.linlLb_ShoppingCar = new System.Windows.Forms.LinkLabel();
            this.lb_TotalPay = new System.Windows.Forms.Label();
            this.but_Search = new System.Windows.Forms.Button();
            this.comBox_Price = new System.Windows.Forms.ComboBox();
            this.lb_Price = new System.Windows.Forms.Label();
            this.comBox_SubCtg = new System.Windows.Forms.ComboBox();
            this.lb_SubCtg = new System.Windows.Forms.Label();
            this.comBox_Category = new System.Windows.Forms.ComboBox();
            this.lb_Category = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1322, 916);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1318, 133);
            this.label1.TabIndex = 0;
            this.label1.Text = "我救浪~~購物中心";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
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
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(1322, 775);
            this.splitContainer2.SplitterDistance = 296;
            this.splitContainer2.TabIndex = 0;
            // 
            // linlLb_ShoppingCar
            // 
            this.linlLb_ShoppingCar.AutoSize = true;
            this.linlLb_ShoppingCar.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linlLb_ShoppingCar.Location = new System.Drawing.Point(55, 577);
            this.linlLb_ShoppingCar.Name = "linlLb_ShoppingCar";
            this.linlLb_ShoppingCar.Size = new System.Drawing.Size(113, 40);
            this.linlLb_ShoppingCar.TabIndex = 8;
            this.linlLb_ShoppingCar.TabStop = true;
            this.linlLb_ShoppingCar.Text = "購物車";
            this.linlLb_ShoppingCar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlLb_ShoppingCar_LinkClicked);
            // 
            // lb_TotalPay
            // 
            this.lb_TotalPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_TotalPay.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_TotalPay.Location = new System.Drawing.Point(28, 628);
            this.lb_TotalPay.Name = "lb_TotalPay";
            this.lb_TotalPay.Size = new System.Drawing.Size(201, 58);
            this.lb_TotalPay.TabIndex = 7;
            this.lb_TotalPay.Text = "金額:";
            this.lb_TotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // but_Search
            // 
            this.but_Search.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Search.Location = new System.Drawing.Point(46, 381);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(196, 56);
            this.but_Search.TabIndex = 6;
            this.but_Search.Text = "搜尋";
            this.but_Search.UseVisualStyleBackColor = true;
            this.but_Search.Click += new System.EventHandler(this.but_Search_Click);
            // 
            // comBox_Price
            // 
            this.comBox_Price.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBox_Price.FormattingEnabled = true;
            this.comBox_Price.Location = new System.Drawing.Point(22, 288);
            this.comBox_Price.Name = "comBox_Price";
            this.comBox_Price.Size = new System.Drawing.Size(242, 33);
            this.comBox_Price.TabIndex = 5;
            this.comBox_Price.Visible = false;
            // 
            // lb_Price
            // 
            this.lb_Price.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Price.Location = new System.Drawing.Point(26, 253);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(157, 32);
            this.lb_Price.TabIndex = 4;
            this.lb_Price.Text = "價格區間:";
            this.lb_Price.Visible = false;
            // 
            // comBox_SubCtg
            // 
            this.comBox_SubCtg.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBox_SubCtg.FormattingEnabled = true;
            this.comBox_SubCtg.Location = new System.Drawing.Point(22, 165);
            this.comBox_SubCtg.Name = "comBox_SubCtg";
            this.comBox_SubCtg.Size = new System.Drawing.Size(242, 33);
            this.comBox_SubCtg.TabIndex = 3;
            // 
            // lb_SubCtg
            // 
            this.lb_SubCtg.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_SubCtg.Location = new System.Drawing.Point(26, 130);
            this.lb_SubCtg.Name = "lb_SubCtg";
            this.lb_SubCtg.Size = new System.Drawing.Size(94, 32);
            this.lb_SubCtg.TabIndex = 2;
            this.lb_SubCtg.Text = "分類:";
            // 
            // comBox_Category
            // 
            this.comBox_Category.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBox_Category.FormattingEnabled = true;
            this.comBox_Category.Location = new System.Drawing.Point(22, 60);
            this.comBox_Category.Name = "comBox_Category";
            this.comBox_Category.Size = new System.Drawing.Size(242, 33);
            this.comBox_Category.TabIndex = 1;
            this.comBox_Category.SelectedIndexChanged += new System.EventHandler(this.comBox_Category_SelectedIndexChanged);
            // 
            // lb_Category
            // 
            this.lb_Category.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Category.Location = new System.Drawing.Point(26, 25);
            this.lb_Category.Name = "lb_Category";
            this.lb_Category.Size = new System.Drawing.Size(94, 32);
            this.lb_Category.TabIndex = 0;
            this.lb_Category.Text = "總類:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SeaShell;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1018, 771);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Frm_Shopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 916);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm_Shopping";
            this.Text = "Frm_Shopping";
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comBox_SubCtg;
        private System.Windows.Forms.Label lb_SubCtg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linlLb_ShoppingCar;
        private System.Windows.Forms.Label lb_TotalPay;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.ComboBox comBox_Price;
        private System.Windows.Forms.Label lb_Price;
    }
}