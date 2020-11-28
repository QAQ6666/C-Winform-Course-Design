using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.sqlOperating;
using WindowsFormsApp1.tools;

namespace WindowsFormsApp1
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            tocon("canteen");
        }
        public UserLogin(int i)
        {
            InitializeComponent();
        }
        //链接数据库
        public void tocon(string dbname)
        {
            DbSQLHelper.sqlConnect(dbname);
        }

        //用户登录操作
        /* sql查询用户名 */
        private void tologin(object sender, EventArgs e)
        {
            //获取用户输入的文本
            string userin = this.userIn.Text;
            string pwdin = this.pwdIn.Text;
            Boolean empty = NoEmpty.Isempty(userin);
            Boolean empty2 = NoEmpty.Isempty(pwdin);
            if (!(empty && empty2))
            {
                MesShow.ms("输入内容存在空，请重新输入");
                return;
            }
            Boolean ver = Verification.HasChinese(userin);
            if (ver)
            {
                MesShow.ms("用户名包含中文，请重新输入");
            }
            else
            {
                ver = Verification.HasChinese(pwdin);
                if (ver)
                {
                    MesShow.ms("密码包含中文，请重新输入");
                }
                else
                {
                    int rows = DbSQLHelper.rowQuery(userin, pwdin);
                    if (rows == 11 || rows == 10)
                    {
                        string str = rows == 11 ? "ROOT" : "N";
                        UserSession.setAll(userin, str, DateTime.Now.ToString());
                        MesShow.ms("登录成功");
                        this.Close();
                        /* 方式二: */
                        SystemManagementView systemManagementView = new SystemManagementView();
                        Thread th = new Thread(delegate () { systemManagementView.ShowDialog(); });
                        th.Start();
                    }
                    else
                    {
                        MesShow.ms("登录失败，输入错误");
                    }
                }
            }
            //初始化管理界面
            /* 方式一 */
            //ogram.openMain();
        }
       
        //用户退出操作
        /* 直接退出当前程序 */
        private void toquit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            //login.BackColor = Color.SkyBlue;
            //login.ForeColor = Color.White;
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            //login.BackColor = Color.White;
            //login.ForeColor = Color.Black;
        }

        private void openScan_Click(object sender, EventArgs e)
        {
            scanQRCode scan = new scanQRCode(this);
            //Thread th = new Thread(delegate () { scan.ShowDialog(); });
            //th.Start();
            scan.ShowDialog();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
