using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApp1
{
    partial class UserLogin
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
            this.login = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.userIn = new System.Windows.Forms.TextBox();
            this.pwdIn = new System.Windows.Forms.TextBox();
            this.openScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.White;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.Location = new System.Drawing.Point(130, 173);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(108, 35);
            this.login.TabIndex = 0;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.tologin);
            this.login.MouseLeave += new System.EventHandler(this.login_MouseLeave);
            this.login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.BackColor = System.Drawing.Color.White;
            this.quit.FlatAppearance.BorderSize = 0;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quit.ForeColor = System.Drawing.Color.Black;
            this.quit.Location = new System.Drawing.Point(294, 173);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(108, 35);
            this.quit.TabIndex = 1;
            this.quit.Text = "退出";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.toquit);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(100, 56);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(84, 27);
            this.username.TabIndex = 2;
            this.username.Text = "用户名 :";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwd.ForeColor = System.Drawing.Color.White;
            this.pwd.Location = new System.Drawing.Point(100, 112);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(64, 27);
            this.pwd.TabIndex = 3;
            this.pwd.Text = "密码 :";
            this.pwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userIn
            // 
            this.userIn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userIn.Location = new System.Drawing.Point(209, 58);
            this.userIn.Margin = new System.Windows.Forms.Padding(4);
            this.userIn.Name = "userIn";
            this.userIn.Size = new System.Drawing.Size(217, 31);
            this.userIn.TabIndex = 4;
            this.userIn.Text = "admin";
            // 
            // pwdIn
            // 
            this.pwdIn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdIn.Location = new System.Drawing.Point(209, 112);
            this.pwdIn.Margin = new System.Windows.Forms.Padding(4);
            this.pwdIn.Name = "pwdIn";
            this.pwdIn.PasswordChar = '*';
            this.pwdIn.Size = new System.Drawing.Size(217, 31);
            this.pwdIn.TabIndex = 5;
            // 
            // openScan
            // 
            this.openScan.AutoSize = true;
            this.openScan.BackColor = System.Drawing.Color.White;
            this.openScan.FlatAppearance.BorderSize = 0;
            this.openScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openScan.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openScan.ForeColor = System.Drawing.Color.Black;
            this.openScan.Location = new System.Drawing.Point(447, 173);
            this.openScan.Name = "openScan";
            this.openScan.Size = new System.Drawing.Size(108, 35);
            this.openScan.TabIndex = 6;
            this.openScan.Text = "扫码登录";
            this.openScan.UseVisualStyleBackColor = false;
            this.openScan.Click += new System.EventHandler(this.openScan_Click);
            // 
            // userLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(567, 273);
            this.Controls.Add(this.openScan);
            this.Controls.Add(this.pwdIn);
            this.Controls.Add(this.userIn);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.username);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.login);
            this.Name = "userLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button login;
        private Button quit;
        private Label username;
        private Label pwd;
        private TextBox userIn;
        private TextBox pwdIn;
        private Button openScan;
    }
}