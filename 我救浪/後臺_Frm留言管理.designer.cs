
namespace 我救浪
{
    partial class 後臺_Frm留言管理
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProducts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbproID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn1star = new System.Windows.Forms.Button();
            this.btn2star = new System.Windows.Forms.Button();
            this.btn3star = new System.Windows.Forms.Button();
            this.btn4star = new System.Windows.Forms.Button();
            this.btn5star = new System.Windows.Forms.Button();
            this.btnAllComment = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProductSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComment);
            this.groupBox2.Controls.Add(this.txtMember);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtProducts);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbproID);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(536, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 284);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "評論異動";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(19, 117);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(376, 158);
            this.txtComment.TabIndex = 12;
            this.txtComment.Text = "";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(283, 23);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(59, 29);
            this.txtMember.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "會員編號 :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(409, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(409, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(409, 115);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(74, 33);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "新增";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(283, 76);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(59, 29);
            this.comboBox3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "評論星等 :";
            // 
            // txtProducts
            // 
            this.txtProducts.Location = new System.Drawing.Point(112, 24);
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Size = new System.Drawing.Size(59, 29);
            this.txtProducts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "評論內容 :";
            // 
            // lbproID
            // 
            this.lbproID.AutoSize = true;
            this.lbproID.Location = new System.Drawing.Point(20, 29);
            this.lbproID.Name = "lbproID";
            this.lbproID.Size = new System.Drawing.Size(86, 22);
            this.lbproID.TabIndex = 0;
            this.lbproID.Text = "產品編號 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn1star);
            this.groupBox1.Controls.Add(this.btn2star);
            this.groupBox1.Controls.Add(this.btn3star);
            this.groupBox1.Controls.Add(this.btn4star);
            this.groupBox1.Controls.Add(this.btn5star);
            this.groupBox1.Controls.Add(this.btnAllComment);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(36, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 182);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 評論等級查詢";
            // 
            // btn1star
            // 
            this.btn1star.Location = new System.Drawing.Point(133, 122);
            this.btn1star.Name = "btn1star";
            this.btn1star.Size = new System.Drawing.Size(110, 43);
            this.btn1star.TabIndex = 5;
            this.btn1star.Text = "★";
            this.btn1star.UseVisualStyleBackColor = true;
            this.btn1star.Click += new System.EventHandler(this.btn1star_Click);
            // 
            // btn2star
            // 
            this.btn2star.Location = new System.Drawing.Point(22, 122);
            this.btn2star.Name = "btn2star";
            this.btn2star.Size = new System.Drawing.Size(110, 43);
            this.btn2star.TabIndex = 4;
            this.btn2star.Text = "★★";
            this.btn2star.UseVisualStyleBackColor = true;
            this.btn2star.Click += new System.EventHandler(this.btn2star_Click);
            // 
            // btn3star
            // 
            this.btn3star.Location = new System.Drawing.Point(133, 76);
            this.btn3star.Name = "btn3star";
            this.btn3star.Size = new System.Drawing.Size(110, 43);
            this.btn3star.TabIndex = 3;
            this.btn3star.Text = "★★★";
            this.btn3star.UseVisualStyleBackColor = true;
            this.btn3star.Click += new System.EventHandler(this.btn3star_Click);
            // 
            // btn4star
            // 
            this.btn4star.Location = new System.Drawing.Point(22, 76);
            this.btn4star.Name = "btn4star";
            this.btn4star.Size = new System.Drawing.Size(110, 43);
            this.btn4star.TabIndex = 2;
            this.btn4star.Text = "★★★★";
            this.btn4star.UseVisualStyleBackColor = true;
            this.btn4star.Click += new System.EventHandler(this.btn4star_Click);
            // 
            // btn5star
            // 
            this.btn5star.Location = new System.Drawing.Point(133, 30);
            this.btn5star.Name = "btn5star";
            this.btn5star.Size = new System.Drawing.Size(110, 43);
            this.btn5star.TabIndex = 1;
            this.btn5star.Text = "★★★★★";
            this.btn5star.UseVisualStyleBackColor = true;
            this.btn5star.Click += new System.EventHandler(this.btn5star_Click);
            // 
            // btnAllComment
            // 
            this.btnAllComment.Location = new System.Drawing.Point(22, 30);
            this.btnAllComment.Name = "btnAllComment";
            this.btnAllComment.Size = new System.Drawing.Size(110, 43);
            this.btnAllComment.TabIndex = 0;
            this.btnAllComment.Text = "全部評論";
            this.btnAllComment.UseVisualStyleBackColor = true;
            this.btnAllComment.Click += new System.EventHandler(this.btnAllComment_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.btnDateSearch);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(36, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 77);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " 日期評論查詢";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "月";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "年";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(79, 29);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.Location = new System.Drawing.Point(281, 22);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(85, 39);
            this.btnDateSearch.TabIndex = 4;
            this.btnDateSearch.Text = "查詢";
            this.btnDateSearch.UseVisualStyleBackColor = true;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1173, 682);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnProductSearch);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 9.792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(317, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 182);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "產品編號查詢";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(40, 79);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(96, 29);
            this.comboBox4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(26, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "請選擇產品編號";
            // 
            // btnProductSearch
            // 
            this.btnProductSearch.Location = new System.Drawing.Point(40, 127);
            this.btnProductSearch.Name = "btnProductSearch";
            this.btnProductSearch.Size = new System.Drawing.Size(96, 32);
            this.btnProductSearch.TabIndex = 5;
            this.btnProductSearch.Text = "查詢";
            this.btnProductSearch.UseVisualStyleBackColor = true;
            this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 53;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 後臺_Frm留言管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 682);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "後臺_Frm留言管理";
            this.Text = "Frmmembercomment";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn1star;
        private System.Windows.Forms.Button btn2star;
        private System.Windows.Forms.Button btn3star;
        private System.Windows.Forms.Button btn4star;
        private System.Windows.Forms.Button btn5star;
        private System.Windows.Forms.Button btnAllComment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbproID;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnProductSearch;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtComment;
    }
}