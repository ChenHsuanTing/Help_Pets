
namespace 我救浪
{
    partial class 後臺_Frm類別管理
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProDetailUpdate = new System.Windows.Forms.Button();
            this.btnProDetailDelete = new System.Windows.Forms.Button();
            this.btnProSubDelete = new System.Windows.Forms.Button();
            this.btnProDetailCreate = new System.Windows.Forms.Button();
            this.btnProReadAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetailCategory = new System.Windows.Forms.TextBox();
            this.btnProSubCreate = new System.Windows.Forms.Button();
            this.btnProSubUpdate = new System.Windows.Forms.Button();
            this.cbProDetailCategory = new System.Windows.Forms.ComboBox();
            this.cbProMainCategory = new System.Windows.Forms.ComboBox();
            this.cbProSubCategory = new System.Windows.Forms.ComboBox();
            this.txtSubCategory = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbSubCategory = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPetDelete = new System.Windows.Forms.Button();
            this.btnPetReadAll = new System.Windows.Forms.Button();
            this.btnPetCreate = new System.Windows.Forms.Button();
            this.btnPetUpdate = new System.Windows.Forms.Button();
            this.cbPetMainCategory = new System.Windows.Forms.ComboBox();
            this.cbPetSubCategory = new System.Windows.Forms.ComboBox();
            this.txtPetSubCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProDetailUpdate);
            this.groupBox1.Controls.Add(this.btnProDetailDelete);
            this.groupBox1.Controls.Add(this.btnProSubDelete);
            this.groupBox1.Controls.Add(this.btnProDetailCreate);
            this.groupBox1.Controls.Add(this.btnProReadAll);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDetailCategory);
            this.groupBox1.Controls.Add(this.btnProSubCreate);
            this.groupBox1.Controls.Add(this.btnProSubUpdate);
            this.groupBox1.Controls.Add(this.cbProDetailCategory);
            this.groupBox1.Controls.Add(this.cbProMainCategory);
            this.groupBox1.Controls.Add(this.cbProSubCategory);
            this.groupBox1.Controls.Add(this.txtSubCategory);
            this.groupBox1.Controls.Add(this.lbCategory);
            this.groupBox1.Controls.Add(this.lbSubCategory);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(21, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 293);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "產品類別異動";
            // 
            // btnProDetailUpdate
            // 
            this.btnProDetailUpdate.Location = new System.Drawing.Point(380, 240);
            this.btnProDetailUpdate.Name = "btnProDetailUpdate";
            this.btnProDetailUpdate.Size = new System.Drawing.Size(74, 33);
            this.btnProDetailUpdate.TabIndex = 33;
            this.btnProDetailUpdate.Text = "修改";
            this.btnProDetailUpdate.UseVisualStyleBackColor = true;
            this.btnProDetailUpdate.Click += new System.EventHandler(this.btnProDetailUpdate_Click);
            // 
            // btnProDetailDelete
            // 
            this.btnProDetailDelete.Location = new System.Drawing.Point(110, 254);
            this.btnProDetailDelete.Name = "btnProDetailDelete";
            this.btnProDetailDelete.Size = new System.Drawing.Size(74, 33);
            this.btnProDetailDelete.TabIndex = 31;
            this.btnProDetailDelete.Text = "刪除";
            this.btnProDetailDelete.UseVisualStyleBackColor = true;
            this.btnProDetailDelete.Click += new System.EventHandler(this.btnProDetailDelete_Click);
            // 
            // btnProSubDelete
            // 
            this.btnProSubDelete.Location = new System.Drawing.Point(110, 173);
            this.btnProSubDelete.Name = "btnProSubDelete";
            this.btnProSubDelete.Size = new System.Drawing.Size(74, 33);
            this.btnProSubDelete.TabIndex = 30;
            this.btnProSubDelete.Text = "刪除";
            this.btnProSubDelete.UseVisualStyleBackColor = true;
            this.btnProSubDelete.Click += new System.EventHandler(this.btnProSubDelete_Click);
            // 
            // btnProDetailCreate
            // 
            this.btnProDetailCreate.Location = new System.Drawing.Point(380, 200);
            this.btnProDetailCreate.Name = "btnProDetailCreate";
            this.btnProDetailCreate.Size = new System.Drawing.Size(74, 33);
            this.btnProDetailCreate.TabIndex = 32;
            this.btnProDetailCreate.Text = "新增";
            this.btnProDetailCreate.UseVisualStyleBackColor = true;
            this.btnProDetailCreate.Click += new System.EventHandler(this.btnProDetailCreate_Click);
            // 
            // btnProReadAll
            // 
            this.btnProReadAll.Location = new System.Drawing.Point(22, 39);
            this.btnProReadAll.Name = "btnProReadAll";
            this.btnProReadAll.Size = new System.Drawing.Size(105, 33);
            this.btnProReadAll.TabIndex = 27;
            this.btnProReadAll.Text = "全部讀取";
            this.btnProReadAll.UseVisualStyleBackColor = true;
            this.btnProReadAll.Click += new System.EventHandler(this.btnProReadAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "產品細項 :";
            // 
            // txtDetailCategory
            // 
            this.txtDetailCategory.Location = new System.Drawing.Point(252, 214);
            this.txtDetailCategory.Multiline = true;
            this.txtDetailCategory.Name = "txtDetailCategory";
            this.txtDetailCategory.Size = new System.Drawing.Size(122, 30);
            this.txtDetailCategory.TabIndex = 23;
            // 
            // btnProSubCreate
            // 
            this.btnProSubCreate.Location = new System.Drawing.Point(380, 120);
            this.btnProSubCreate.Name = "btnProSubCreate";
            this.btnProSubCreate.Size = new System.Drawing.Size(74, 33);
            this.btnProSubCreate.TabIndex = 28;
            this.btnProSubCreate.Text = "新增";
            this.btnProSubCreate.UseVisualStyleBackColor = true;
            this.btnProSubCreate.Click += new System.EventHandler(this.btnProSubCreate_Click);
            // 
            // btnProSubUpdate
            // 
            this.btnProSubUpdate.Location = new System.Drawing.Point(380, 160);
            this.btnProSubUpdate.Name = "btnProSubUpdate";
            this.btnProSubUpdate.Size = new System.Drawing.Size(74, 33);
            this.btnProSubUpdate.TabIndex = 29;
            this.btnProSubUpdate.Text = "修改";
            this.btnProSubUpdate.UseVisualStyleBackColor = true;
            this.btnProSubUpdate.Click += new System.EventHandler(this.btnProSubUpdate_Click);
            // 
            // cbProDetailCategory
            // 
            this.cbProDetailCategory.FormattingEnabled = true;
            this.cbProDetailCategory.Location = new System.Drawing.Point(110, 214);
            this.cbProDetailCategory.Name = "cbProDetailCategory";
            this.cbProDetailCategory.Size = new System.Drawing.Size(122, 30);
            this.cbProDetailCategory.TabIndex = 25;
            // 
            // cbProMainCategory
            // 
            this.cbProMainCategory.FormattingEnabled = true;
            this.cbProMainCategory.Location = new System.Drawing.Point(110, 90);
            this.cbProMainCategory.Name = "cbProMainCategory";
            this.cbProMainCategory.Size = new System.Drawing.Size(122, 30);
            this.cbProMainCategory.TabIndex = 19;
            this.cbProMainCategory.SelectionChangeCommitted += new System.EventHandler(this.cbProMainCategory_SelectionChangeCommitted);
            // 
            // cbProSubCategory
            // 
            this.cbProSubCategory.FormattingEnabled = true;
            this.cbProSubCategory.Location = new System.Drawing.Point(110, 138);
            this.cbProSubCategory.Name = "cbProSubCategory";
            this.cbProSubCategory.Size = new System.Drawing.Size(122, 30);
            this.cbProSubCategory.TabIndex = 24;
            this.cbProSubCategory.SelectionChangeCommitted += new System.EventHandler(this.cbProSubCategory_SelectionChangeCommitted);
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.Location = new System.Drawing.Point(252, 138);
            this.txtSubCategory.Multiline = true;
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(122, 30);
            this.txtSubCategory.TabIndex = 18;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(6, 93);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(86, 22);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "產品總類 :";
            // 
            // lbSubCategory
            // 
            this.lbSubCategory.AutoSize = true;
            this.lbSubCategory.Location = new System.Drawing.Point(6, 141);
            this.lbSubCategory.Name = "lbSubCategory";
            this.lbSubCategory.Size = new System.Drawing.Size(86, 22);
            this.lbSubCategory.TabIndex = 11;
            this.lbSubCategory.Text = "產品分類 :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(493, 236);
            this.dataGridView1.TabIndex = 31;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(573, 351);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(495, 236);
            this.dataGridView2.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPetDelete);
            this.groupBox2.Controls.Add(this.btnPetReadAll);
            this.groupBox2.Controls.Add(this.btnPetCreate);
            this.groupBox2.Controls.Add(this.btnPetUpdate);
            this.groupBox2.Controls.Add(this.cbPetMainCategory);
            this.groupBox2.Controls.Add(this.cbPetSubCategory);
            this.groupBox2.Controls.Add(this.txtPetSubCategory);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(573, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 293);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "領養類別異動";
            // 
            // btnPetDelete
            // 
            this.btnPetDelete.Location = new System.Drawing.Point(126, 175);
            this.btnPetDelete.Name = "btnPetDelete";
            this.btnPetDelete.Size = new System.Drawing.Size(74, 33);
            this.btnPetDelete.TabIndex = 30;
            this.btnPetDelete.Text = "刪除";
            this.btnPetDelete.UseVisualStyleBackColor = true;
            this.btnPetDelete.Click += new System.EventHandler(this.btnPetDelete_Click);
            // 
            // btnPetReadAll
            // 
            this.btnPetReadAll.Location = new System.Drawing.Point(22, 39);
            this.btnPetReadAll.Name = "btnPetReadAll";
            this.btnPetReadAll.Size = new System.Drawing.Size(111, 33);
            this.btnPetReadAll.TabIndex = 27;
            this.btnPetReadAll.Text = "全部讀取";
            this.btnPetReadAll.UseVisualStyleBackColor = true;
            this.btnPetReadAll.Click += new System.EventHandler(this.btnPetReadAll_Click);
            // 
            // btnPetCreate
            // 
            this.btnPetCreate.Location = new System.Drawing.Point(268, 175);
            this.btnPetCreate.Name = "btnPetCreate";
            this.btnPetCreate.Size = new System.Drawing.Size(74, 33);
            this.btnPetCreate.TabIndex = 28;
            this.btnPetCreate.Text = "新增";
            this.btnPetCreate.UseVisualStyleBackColor = true;
            this.btnPetCreate.Click += new System.EventHandler(this.btnPetCreate_Click);
            // 
            // btnPetUpdate
            // 
            this.btnPetUpdate.Location = new System.Drawing.Point(348, 175);
            this.btnPetUpdate.Name = "btnPetUpdate";
            this.btnPetUpdate.Size = new System.Drawing.Size(74, 33);
            this.btnPetUpdate.TabIndex = 29;
            this.btnPetUpdate.Text = "修改";
            this.btnPetUpdate.UseVisualStyleBackColor = true;
            this.btnPetUpdate.Click += new System.EventHandler(this.btnPetUpdate_Click);
            // 
            // cbPetMainCategory
            // 
            this.cbPetMainCategory.FormattingEnabled = true;
            this.cbPetMainCategory.Location = new System.Drawing.Point(126, 90);
            this.cbPetMainCategory.Name = "cbPetMainCategory";
            this.cbPetMainCategory.Size = new System.Drawing.Size(122, 30);
            this.cbPetMainCategory.TabIndex = 19;
            this.cbPetMainCategory.SelectionChangeCommitted += new System.EventHandler(this.cbPetMainCategory_SelectionChangeCommitted);
            // 
            // cbPetSubCategory
            // 
            this.cbPetSubCategory.FormattingEnabled = true;
            this.cbPetSubCategory.Location = new System.Drawing.Point(126, 138);
            this.cbPetSubCategory.Name = "cbPetSubCategory";
            this.cbPetSubCategory.Size = new System.Drawing.Size(122, 30);
            this.cbPetSubCategory.TabIndex = 24;
            // 
            // txtPetSubCategory
            // 
            this.txtPetSubCategory.Location = new System.Drawing.Point(268, 90);
            this.txtPetSubCategory.Multiline = true;
            this.txtPetSubCategory.Name = "txtPetSubCategory";
            this.txtPetSubCategory.Size = new System.Drawing.Size(122, 30);
            this.txtPetSubCategory.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "領養總類 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "領養分類 :";
            // 
            // 後臺_Frm類別管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 651);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "後臺_Frm類別管理";
            this.Text = "FrmNewCategory";
            this.Load += new System.EventHandler(this.FrmNewCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProDetailCategory;
        private System.Windows.Forms.ComboBox cbProMainCategory;
        private System.Windows.Forms.TextBox txtSubCategory;
        private System.Windows.Forms.ComboBox cbProSubCategory;
        private System.Windows.Forms.TextBox txtDetailCategory;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbSubCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProReadAll;
        private System.Windows.Forms.Button btnProDetailUpdate;
        private System.Windows.Forms.Button btnProDetailCreate;
        private System.Windows.Forms.Button btnProDetailDelete;
        private System.Windows.Forms.Button btnProSubDelete;
        private System.Windows.Forms.Button btnProSubUpdate;
        private System.Windows.Forms.Button btnProSubCreate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPetDelete;
        private System.Windows.Forms.Button btnPetReadAll;
        private System.Windows.Forms.Button btnPetCreate;
        private System.Windows.Forms.Button btnPetUpdate;
        private System.Windows.Forms.ComboBox cbPetMainCategory;
        private System.Windows.Forms.ComboBox cbPetSubCategory;
        private System.Windows.Forms.TextBox txtPetSubCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}