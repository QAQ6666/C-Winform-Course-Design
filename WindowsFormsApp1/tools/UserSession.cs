using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tools
{
    class UserSession
    {
        public UserSession()
        {}
        public static void setAll(string u, string r, string t)
        {
            userName = u;
            userRoot = r;
            loginTime = t;
        }
        private static string userName;
        private static string userRoot;
        private static string loginTime;

        public static void setName(string n) { userName = n;  }
        public static void setRoot(string r) { userRoot = r; }
        public static void setTime(string t) { loginTime = t;  }
        public static string getName() { return userName;  }
        public static string getTime() { return loginTime; }
        public static string getRoot() { return userRoot; }

    }
}
