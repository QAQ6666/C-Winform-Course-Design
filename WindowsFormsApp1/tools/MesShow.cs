
using System.Windows.Forms;

namespace WindowsFormsApp1.tools
{
    class MesShow
    {
        public MesShow() { }
        public static void ms(string n)
        {
            MessageBox.Show(n);
        }
        public static void errorMs(string n)
        {
            MessageBox.Show(n, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
