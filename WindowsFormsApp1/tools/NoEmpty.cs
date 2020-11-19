using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tools
{
    class NoEmpty
    {
        public static Boolean Isempty(string n)
        {
            if(n == null || n.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
