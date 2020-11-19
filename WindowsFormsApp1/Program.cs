using System;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.tools;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //登录验证 
            /*  方式一: */
            //serLogin Log = new UserLogin();
            //og.ShowDialog();
            /*  方式二: */
            Application.Run(new UserLogin());
           
        }
    }
}
