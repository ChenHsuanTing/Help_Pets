
namespace 我救浪
{
    partial class Frm_ShoppingCar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Ship = new System.Windows.Forms.Label();
            this.but_CheckOut = new System.Windows.Forms.Button();
            this.but_Cancle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lb = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comBox_City = new System.Windows.Forms.ComboBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_TotalPay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Delete});
            this.dataGridView1.Location = new System.Drawing.Point(185, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(924, 363);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column_Delete
            // 
            this.Column_Delete.HeaderText = "";
            this.Column_Delete.MinimumWidth = 8;
            this.Column_Delete.Name = "Column_Delete";
            this.Column_Delete.ReadOnly = true;
            this.Column_Delete.Text = "刪除";
            this.Column_Delete.UseColumnTextForButtonValue = true;
            this.Column_Delete.Width = 60;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "購物清單:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Ship
            // 
            this.lb_Ship.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Ship.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Ship.Location = new System.Drawing.Point(351, 507);
            this.lb_Ship.Name = "lb_Ship";
            this.lb_Ship.Size = new System.Drawing.Size(167, 53);
            this.lb_Ship.TabIndex = 0;
            this.lb_Ship.Text = "運送方式:";
            this.lb_Ship.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Ship.Visible = false;
            // 
            // but_CheckOut
            // 
            this.but_CheckOut.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_CheckOut.Location = new System.Drawing.Point(351, 754);
            this.but_CheckOut.Name = "but_CheckOut";
            this.but_CheckOut.Size = new System.Drawing.Size(279, 99);
            this.but_CheckOut.TabIndex = 0;
            this.but_CheckOut.Text = "結帳";
            this.but_CheckOut.UseVisualStyleBackColor = true;
            this.but_CheckOut.Click += new System.EventHandler(this.but_CheckOut_Click);
            // 
            // but_Cancle
            // 
            this.but_Cancle.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_Cancle.Location = new System.Drawing.Point(704, 754);
            this.but_Cancle.Name = "but_Cancle";
            this.but_Cancle.Size = new System.Drawing.Size(279, 99);
            this.but_Cancle.TabIndex = 3;
            this.but_Cancle.Text = "取消";
            this.but_Cancle.UseVisualStyleBackColor = true;
            this.but_Cancle.Click += new System.EventHandler(this.but_Cancle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 579);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 39);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(647, 579);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(245, 39);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Visible = false;
            // 
            // lb
            // 
            this.lb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb.Location = new System.Drawing.Point(647, 507);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(167, 53);
            this.lb.TabIndex = 5;
            this.lb.Text = "運送方式:";
            this.lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 476);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 261);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 772);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 81);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(342, 634);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "寄送地區:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comBox_City
            // 
            this.comBox_City.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comBox_City.FormattingEnabled = true;
            this.comBox_City.Location = new System.Drawing.Point(499, 636);
            this.comBox_City.Name = "comBox_City";
            this.comBox_City.Size = new System.Drawing.Size(245, 39);
            this.comBox_City.TabIndex = 10;
            this.comBox_City.SelectedIndexChanged += new System.EventHandler(this.comBox_City_SelectedIndexChanged);
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Address.Location = new System.Drawing.Point(390, 694);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(860, 37);
            this.txt_Address.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(303, 695);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "地址:";
            // 
            // lb_TotalPay
            // 
            this.lb_TotalPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_TotalPay.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_TotalPay.Location = new System.Drawing.Point(913, 489);
            this.lb_TotalPay.Name = "lb_TotalPay";
            this.lb_TotalPay.Size = new System.Drawing.Size(331, 85);
            this.lb_TotalPay.TabIndex = 13;
            this.lb_TotalPay.Text = "label4";
            this.lb_TotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_ShoppingCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 886);
            this.Controls.Add(this.lb_TotalPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.comBox_City);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.but_Cancle);
            this.Controls.Add(this.but_CheckOut);
            this.Controls.Add(this.lb_Ship);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_ShoppingCar";
            this.Text = "購物車";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Ship;
        private System.Windows.Forms.Button but_CheckOut;
        private System.Windows.Forms.Button but_Cancle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBox_City;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_TotalPay;
        private System.Windows.Forms.DataGridViewButtonColumn Column_Delete;
    }
}