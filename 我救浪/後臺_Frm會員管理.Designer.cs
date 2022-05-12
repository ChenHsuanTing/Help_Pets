
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.comboCity = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.comboBoxMemNO = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.dataGridView5);
            this.groupBox5.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.Location = new System.Drawing.Point(461, 311);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(704, 299);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "會員詳細資料";
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(7, 20);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 27;
            this.dataGridView5.Size = new System.Drawing.Size(685, 272);
            this.dataGridView5.TabIndex = 0;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnInsert);
            this.groupBox4.Controls.Add(this.txtMail);
            this.groupBox4.Controls.Add(this.txtBirth);
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.txtPassword);
            this.groupBox4.Controls.Add(this.txtPhone);
            this.groupBox4.Controls.Add(this.txtAddress);
            this.groupBox4.Controls.Add(this.comboCity);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(458, 98);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(707, 208);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "會員修改,刪除";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(556, 158);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 39);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "刪除整筆資料";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(556, 118);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(127, 34);
            this.btnInsert.TabIndex = 47;
            this.btnInsert.Text = "修改";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(317, 90);
            this.txtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 30);
            this.txtMail.TabIndex = 46;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(93, 135);
            this.txtBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(100, 30);
            this.txtBirth.TabIndex = 45;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 85);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 30);
            this.txtName.TabIndex = 44;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(317, 44);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 30);
            this.txtPassword.TabIndex = 43;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(93, 45);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 30);
            this.txtPhone.TabIndex = 42;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(317, 168);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 30);
            this.txtAddress.TabIndex = 7;
            // 
            // comboCity
            // 
            this.comboCity.FormattingEnabled = true;
            this.comboCity.Location = new System.Drawing.Point(317, 135);
            this.comboCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCity.Name = "comboCity";
            this.comboCity.Size = new System.Drawing.Size(121, 30);
            this.comboCity.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(229, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 22);
            this.label18.TabIndex = 40;
            this.label18.Text = "密碼:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(229, 138);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 22);
            this.label19.TabIndex = 39;
            this.label19.Text = "通訊地址:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 22);
            this.label20.TabIndex = 38;
            this.label20.Text = "出生日期:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 22);
            this.label21.TabIndex = 37;
            this.label21.Text = "會員手機:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 22);
            this.label22.TabIndex = 36;
            this.label22.Text = "姓名:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(229, 92);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 22);
            this.label23.TabIndex = 35;
            this.label23.Text = "Email:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnRead);
            this.groupBox3.Controls.Add(this.txtAccount);
            this.groupBox3.Controls.Add(this.comboBoxMemNO);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(28, 98);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(412, 509);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查詢";
            // 
            // btnRead
            // 
            this.btnRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRead.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Location = new System.Drawing.Point(323, 56);
            this.btnRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(72, 44);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "查詢";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(185, 64);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(132, 30);
            this.txtAccount.TabIndex = 5;
            // 
            // comboBoxMemNO
            // 
            this.comboBoxMemNO.FormattingEnabled = true;
            this.comboBoxMemNO.Location = new System.Drawing.Point(23, 64);
            this.comboBoxMemNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMemNO.Name = "comboBoxMemNO";
            this.comboBoxMemNO.Size = new System.Drawing.Size(102, 30);
            this.comboBoxMemNO.TabIndex = 4;
            this.comboBoxMemNO.SelectedIndexChanged += new System.EventHandler(this.comboBoxMemNO_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "手機:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "流水號:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(23, 118);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(364, 385);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 702);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.ComboBox comboBoxMemNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

