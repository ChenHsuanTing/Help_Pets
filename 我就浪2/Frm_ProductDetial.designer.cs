
namespace 我救浪
{
    partial class Frm_ProductDetial
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lb_Price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_TotalPrice = new System.Windows.Forms.Label();
            this.but_AddToCar = new System.Windows.Forms.Button();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTxt_Des = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Stock = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(387, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 536);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbName.Location = new System.Drawing.Point(524, 551);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(87, 33);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "label1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numericUpDown1.Location = new System.Drawing.Point(704, 760);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 39);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Price.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Price.Location = new System.Drawing.Point(387, 762);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(87, 33);
            this.lb_Price.TabIndex = 4;
            this.lb_Price.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(604, 762);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "數量:";
            // 
            // lb_TotalPrice
            // 
            this.lb_TotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_TotalPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_TotalPrice.Location = new System.Drawing.Point(594, 828);
            this.lb_TotalPrice.Name = "lb_TotalPrice";
            this.lb_TotalPrice.Size = new System.Drawing.Size(219, 33);
            this.lb_TotalPrice.TabIndex = 6;
            this.lb_TotalPrice.Text = "總價:";
            this.lb_TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_AddToCar
            // 
            this.but_AddToCar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_AddToCar.Location = new System.Drawing.Point(342, 828);
            this.but_AddToCar.Name = "but_AddToCar";
            this.but_AddToCar.Size = new System.Drawing.Size(246, 73);
            this.but_AddToCar.TabIndex = 7;
            this.but_AddToCar.Text = "加入購物車";
            this.but_AddToCar.UseVisualStyleBackColor = true;
            this.but_AddToCar.Click += new System.EventHandler(this.lb_AddToCar_Click);
            // 
            // but_Cancel
            // 
            this.but_Cancel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Cancel.Location = new System.Drawing.Point(832, 828);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(246, 73);
            this.but_Cancel.TabIndex = 8;
            this.but_Cancel.Text = "取消";
            this.but_Cancel.UseVisualStyleBackColor = true;
            this.but_Cancel.Click += new System.EventHandler(this.lb_Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTxt_Des);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_Stock);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.but_Cancel);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.but_AddToCar);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.lb_TotalPrice);
            this.panel1.Controls.Add(this.lb_Price);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 961);
            this.panel1.TabIndex = 9;
            // 
            // richTxt_Des
            // 
            this.richTxt_Des.AcceptsTab = true;
            this.richTxt_Des.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTxt_Des.Location = new System.Drawing.Point(387, 599);
            this.richTxt_Des.Name = "richTxt_Des";
            this.richTxt_Des.ReadOnly = true;
            this.richTxt_Des.Size = new System.Drawing.Size(652, 137);
            this.richTxt_Des.TabIndex = 12;
            this.richTxt_Des.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(880, 760);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "庫存:";
            // 
            // lb_Stock
            // 
            this.lb_Stock.AutoSize = true;
            this.lb_Stock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Stock.Location = new System.Drawing.Point(954, 760);
            this.lb_Stock.Name = "lb_Stock";
            this.lb_Stock.Size = new System.Drawing.Size(87, 33);
            this.lb_Stock.TabIndex = 10;
            this.lb_Stock.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 39);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_ProductDetial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 961);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ProductDetial";
            this.Text = "Frm_ProductDetil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_TotalPrice;
        private System.Windows.Forms.Button but_AddToCar;
        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Stock;
        private System.Windows.Forms.RichTextBox richTxt_Des;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}