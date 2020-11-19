using System;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1.tools
{
    class Verification
    {
        //判断输入是否包含中文  不管你有没有输入英文,只要包含中文,就返回 true
        public static bool HasChinese(string content)
        {
            //判断是不是中文
            string regexstr = @"[\u4e00-\u9fa5]";

            if (Regex.IsMatch(content, regexstr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //只允许数字或字母的判断
        public static bool isIntergerOrLetter(string content)
        {
            Regex reg1 = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9]+$");
            return reg1.IsMatch(content);
        }
        //是否为整数判断
        public static bool isInt(string s)
        {
            int i = 0;
            bool result = int.TryParse(s, out i);
            //如果验证通过为true，则把i设置为通过值
            return result;
        }
        //是否为浮点数判断
        public static bool isFloat(string s)
        {
            float fnum = 0;
            bool result = float.TryParse(s, out fnum);
            //如果验证通过为true，则把i设置为通过值
            return result;
        }
        //最新是否电话号码和手机号码 
        public static bool IsPhoneNo(string str_handset)
        {
            return Regex.IsMatch(str_handset, "^(0\\d{2,3}-?\\d{7,8}(-\\d{3,5}){0,1})|(((13[0-9])|(15([0-3]|[5-9]))|(18[0-9])|(17[0-9])|(14[0-9]))\\d{8})$");
        }
    }
}
