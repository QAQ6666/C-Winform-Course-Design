using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApp1.function.pwdFun
{
    partial class modifyPwd
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
            this.noTo = new System.Windows.Forms.Button();
            this.modifyTo = new System.Windows.Forms.Button();
            this.jpwd = new System.Windows.Forms.Label();
            this.newPwd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.confirmPwd = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // noTo
            // 
            this.noTo.BackColor = System.Drawing.Color.DarkGray;
            this.noTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noTo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noTo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.noTo.Location = new System.Drawing.Point(328, 240);
            this.noTo.Name = "noTo";
            this.noTo.Size = new System.Drawing.Size(95, 36);
            this.noTo.TabIndex = 0;
            this.noTo.Text = "取消";
            this.noTo.UseVisualStyleBackColor = false;
            this.noTo.Click += new System.EventHandler(this.noTo_Click);
            // 
            // modifyTo
            // 
            this.modifyTo.BackColor = System.Drawing.Color.SkyBlue;
            this.modifyTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyTo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifyTo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modifyTo.Location = new System.Drawing.Point(167, 240);
            this.modifyTo.Name = "modifyTo";
            this.modifyTo.Size = new System.Drawing.Size(95, 36);
            this.modifyTo.TabIndex = 1;
            this.modifyTo.Text = "修改";
            this.modifyTo.UseVisualStyleBackColor = false;
            this.modifyTo.Click += new System.EventHandler(this.modifyTo_Click);
            // 
            // jpwd
            // 
            this.jpwd.AutoSize = true;
            this.jpwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jpwd.Location = new System.Drawing.Point(137, 54);
            this.jpwd.Name = "jpwd";
            this.jpwd.Size = new System.Drawing.Size(96, 27);
            this.jpwd.TabIndex = 2;
            this.jpwd.Text = "旧 密 码 :";
            // 
            // newPwd
            // 
            this.newPwd.AutoSize = true;
            this.newPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newPwd.Location = new System.Drawing.Point(137, 114);
            this.newPwd.Name = "newPwd";
            this.newPwd.Size = new System.Drawing.Size(96, 27);
            this.newPwd.TabIndex = 3;
            this.newPwd.Text = "新 密 码 :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(248, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(196, 38);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(248, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(196, 38);
            this.textBox2.TabIndex = 5;
            // 
            // confirmPwd
            // 
            this.confirmPwd.AutoSize = true;
            this.confirmPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmPwd.Location = new System.Drawing.Point(111, 172);
            this.confirmPwd.Name = "confirmPwd";
            this.confirmPwd.Size = new System.Drawing.Size(122, 27);
            this.confirmPwd.TabIndex = 6;
            this.confirmPwd.Text = "确 认 密 码 :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(248, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(196, 38);
            this.textBox3.TabIndex = 7;
            // 
            // modifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 323);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.confirmPwd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newPwd);
            this.Controls.Add(this.jpwd);
            this.Controls.Add(this.modifyTo);
            this.Controls.Add(this.noTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modifyPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button noTo;
        private Button modifyTo;
        private Label jpwd;
        private Label newPwd;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label confirmPwd;
        private TextBox textBox3;
    }
}