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
            this.userIn = new System.Windows.Forms.TextBox();
            this.pwdIn = new System.Windows.Forms.TextBox();
            this.openScan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.RoyalBlue;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.login.Location = new System.Drawing.Point(596, 363);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(108, 35);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.tologin);
            this.login.MouseLeave += new System.EventHandler(this.login_MouseLeave);
            this.login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
            // 
            // quit
            // 
            this.quit.AutoSize = true;
            this.quit.BackColor = System.Drawing.Color.RoyalBlue;
            this.quit.FlatAppearance.BorderSize = 0;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quit.ForeColor = System.Drawing.Color.White;
            this.quit.Location = new System.Drawing.Point(729, 363);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(108, 35);
            this.quit.TabIndex = 1;
            this.quit.Text = "Exit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.toquit);
            // 
            // userIn
            // 
            this.userIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userIn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userIn.Location = new System.Drawing.Point(624, 202);
            this.userIn.Margin = new System.Windows.Forms.Padding(4);
            this.userIn.Name = "userIn";
            this.userIn.Size = new System.Drawing.Size(303, 24);
            this.userIn.TabIndex = 4;
            this.userIn.Text = "admin";
            // 
            // pwdIn
            // 
            this.pwdIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwdIn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdIn.Location = new System.Drawing.Point(624, 273);
            this.pwdIn.Margin = new System.Windows.Forms.Padding(4);
            this.pwdIn.Name = "pwdIn";
            this.pwdIn.PasswordChar = '*';
            this.pwdIn.Size = new System.Drawing.Size(303, 24);
            this.pwdIn.TabIndex = 5;
            // 
            // openScan
            // 
            this.openScan.AutoSize = true;
            this.openScan.BackColor = System.Drawing.Color.RoyalBlue;
            this.openScan.FlatAppearance.BorderSize = 0;
            this.openScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openScan.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openScan.ForeColor = System.Drawing.Color.White;
            this.openScan.Location = new System.Drawing.Point(863, 363);
            this.openScan.Name = "openScan";
            this.openScan.Size = new System.Drawing.Size(114, 35);
            this.openScan.TabIndex = 6;
            this.openScan.Text = "ScanCode";
            this.openScan.UseVisualStyleBackColor = false;
            this.openScan.Click += new System.EventHandler(this.openScan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(624, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 3);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 3);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(624, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 3);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(619, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 622);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.openScan);
            this.Controls.Add(this.pwdIn);
            this.Controls.Add(this.userIn);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.login);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button login;
        private Button quit;
        private TextBox userIn;
        private TextBox pwdIn;
        private Button openScan;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
    }
}