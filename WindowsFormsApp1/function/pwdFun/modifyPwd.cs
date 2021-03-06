﻿using System;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.sqlOperating;
using WindowsFormsApp1.tools;

namespace WindowsFormsApp1.function.pwdFun
{
    public partial class modifyPwd : Form
    {
        public modifyPwd()
        {
            InitializeComponent();
        }
        private void modifyTo_Click(object sender, EventArgs e )
        {
            //获取文本
            string oldpwd = this.textBox1.Text;
            string newpwdIn = this.textBox2.Text;
            string confirmPwdIn = this.textBox3.Text;
            Boolean verPwd = Verification.HasChinese(oldpwd);
            Boolean vernPwd = Verification.HasChinese(newpwdIn);
            Boolean conPwd = Verification.HasChinese(confirmPwdIn);
            if (oldpwd.Equals(""))
            {
                MesShow.ms("内容包含空值");
                return;

            }

            if (verPwd && vernPwd && conPwd)
            {
                MesShow.ms("文本包含中文，请重新输入");
            }
            else
            {
                if(newpwdIn.Length < 4 || confirmPwdIn.Length < 4)
                {
                    MesShow.ms("密码长度必须大于4");
                }
                else
                {
                    verPwd = confirmPwdIn.Equals(newpwdIn);
                    if (verPwd)
                    {
                        //修改数据
                        int rows = DbSQLHelper.updatePwd(newpwdIn);
                        if (rows == 1)
                        {
                            MesShow.ms("修改成功,请重新登录");
                            this.Close();
                            //退出登录代码:
                            Thread th = new Thread(delegate () { new UserLogin(1).ShowDialog(); });
                            th.Start();

                        }
                    }
                    else
                    {
                        MesShow.ms("前后密码输入不一致");
                    }
                }
            }
        }

        private void noTo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
