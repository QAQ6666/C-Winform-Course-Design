using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.tools
{
    class DataChange
    {
        //数据集合 类型 转为 String
        public static string DataSetToString(DataSet ds)

        {
            //!@&为表的连接字符串，#$%为行的连接字符串，^&*为字段的连接字符串
            //为了保证连接字符串不在DataSet数据中存在，连接字符串尽量复杂！

            StringBuilder strData = new StringBuilder();

            foreach (DataTable dt in ds.Tables)//遍历ds的表
            {
                if (strData.Length > 0)//从第一个表开始，加上表的连接字符串
                    strData.Append("!@&");
                for (int m = 0; m < dt.Rows.Count; m++)//遍历dt的行
                {
                    DataRow row = dt.Rows[m];
                    for (int n = 0; n < dt.Columns.Count; n++)//遍历row的列
                    {
                        if (m > 0)//从第二行数据开始，加上行的连接字符串
                        {
                            strData.Append("#$%");
                        }
                        if (n > 0)//从第二个字段开始，加上字段的连接字符串
                        {
                            strData.Append("^&*");
                        }
                        strData.Append(Convert.ToString(row[n]));//取数据
                    }
                }
            }

            return strData.ToString();

        }

    }
}
