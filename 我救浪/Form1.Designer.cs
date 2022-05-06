
namespace 我救浪
{
    partial class FrmMemLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemLogIn));
            this.Lb會員登入 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb會員登入
            // 
            this.Lb會員登入.AutoSize = true;
            this.Lb會員登入.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb會員登入.ForeColor = System.Drawing.Color.Black;
            this.Lb會員登入.Location = new System.Drawing.Point(90, 11);
            this.Lb會員登入.Name = "Lb會員登入";
            this.Lb會員登入.Size = new System.Drawing.Size(127, 36);
            this.Lb會員登入.TabIndex = 1;
            this.Lb會員登入.Text = "會員登入";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtPassWord);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Controls.Add(this.lbPassWord);
            this.panel1.Controls.Add(this.lbAccount);
            this.panel1.Controls.Add(this.Lb會員登入);
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(262, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 222);
            this.panel1.TabIndex = 2;
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(54, 63);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(48, 22);
            this.lbAccount.TabIndex = 2;
            this.lbAccount.Text = "帳號:";
            // 
            // lbPassWord
            // 
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Location = new System.Drawing.Point(54, 105);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(48, 22);
            this.lbPassWord.TabIndex = 3;
            this.lbPassWord.Text = "密碼:";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(124, 60);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(121, 30);
            this.txtAccount.TabIndex = 4;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(124, 102);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(121, 30);
            this.txtPassWord.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(58, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "登入";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(164, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "註冊";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrmMemLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 539);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMemLogIn";
            this.Text = "會員登入";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Lb會員登入;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.Label lbAccount;
    }
}

