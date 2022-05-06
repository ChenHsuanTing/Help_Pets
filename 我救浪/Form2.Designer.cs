
namespace 我救浪
{
    partial class FrmAdminLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminLogIn));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.Lb管理員登入 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(209, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "註冊";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(64, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "登入";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(148, 101);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(150, 30);
            this.txtPassWord.TabIndex = 12;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(148, 56);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(150, 30);
            this.txtAccount.TabIndex = 11;
            // 
            // lbPassWord
            // 
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Location = new System.Drawing.Point(60, 105);
            this.lbPassWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(48, 22);
            this.lbPassWord.TabIndex = 10;
            this.lbPassWord.Text = "密碼:";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(60, 60);
            this.lbAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(48, 22);
            this.lbAccount.TabIndex = 9;
            this.lbAccount.Text = "帳號:";
            // 
            // Lb管理員登入
            // 
            this.Lb管理員登入.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb管理員登入.ForeColor = System.Drawing.Color.Black;
            this.Lb管理員登入.Location = new System.Drawing.Point(79, 10);
            this.Lb管理員登入.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb管理員登入.Name = "Lb管理員登入";
            this.Lb管理員登入.Size = new System.Drawing.Size(219, 42);
            this.Lb管理員登入.TabIndex = 8;
            this.Lb管理員登入.Text = "後臺管理員登入";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lb管理員登入);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lbAccount);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbPassWord);
            this.panel1.Controls.Add(this.txtPassWord);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Location = new System.Drawing.Point(362, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 235);
            this.panel1.TabIndex = 15;
            // 
            // FrmAdminLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAdminLogIn";
            this.Text = "後台管理系統";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label Lb管理員登入;
        private System.Windows.Forms.Panel panel1;
    }
}