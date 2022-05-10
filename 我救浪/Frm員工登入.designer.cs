
namespace 我救浪
{
    partial class Frm員工登入
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnclean = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.Lb會員登入 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnclean);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Passwordtxt);
            this.panel1.Controls.Add(this.Usernametxt);
            this.panel1.Controls.Add(this.lbPassWord);
            this.panel1.Controls.Add(this.lbAccount);
            this.panel1.Controls.Add(this.Lb會員登入);
            this.panel1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 178);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnclean.Location = new System.Drawing.Point(157, 123);
            this.btnclean.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(79, 30);
            this.btnclean.TabIndex = 7;
            this.btnclean.Text = "重新輸入";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(61, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "登入";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(119, 86);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(92, 26);
            this.Passwordtxt.TabIndex = 5;
            this.Passwordtxt.Text = "0";
            // 
            // Usernametxt
            // 
            this.Usernametxt.Location = new System.Drawing.Point(119, 53);
            this.Usernametxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(92, 26);
            this.Usernametxt.TabIndex = 4;
            this.Usernametxt.Text = "0000000001";
            // 
            // lbPassWord
            // 
            this.lbPassWord.AutoSize = true;
            this.lbPassWord.Location = new System.Drawing.Point(67, 89);
            this.lbPassWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(40, 18);
            this.lbPassWord.TabIndex = 3;
            this.lbPassWord.Text = "密碼:";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Location = new System.Drawing.Point(67, 55);
            this.lbAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(40, 18);
            this.lbAccount.TabIndex = 2;
            this.lbAccount.Text = "帳號:";
            // 
            // Lb會員登入
            // 
            this.Lb會員登入.AutoSize = true;
            this.Lb會員登入.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lb會員登入.ForeColor = System.Drawing.Color.Black;
            this.Lb會員登入.Location = new System.Drawing.Point(94, 14);
            this.Lb會員登入.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb會員登入.Name = "Lb會員登入";
            this.Lb會員登入.Size = new System.Drawing.Size(100, 28);
            this.Lb會員登入.TabIndex = 1;
            this.Lb會員登入.Text = "員工登入";
            // 
            // Frm員工登入
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 202);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm員工登入";
            this.Text = "Frm員工登入";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label Lb會員登入;
    }
}