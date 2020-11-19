using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp1.tools;

namespace WindowsFormsApp1.sqlOperating
{
    /// <summary>
    ///DbSQLHelper 的摘要说明
    /// </summary>
    public class DbSQLHelper
    {
        public DbSQLHelper()
        {
        }

        private static string connectionString;
        private static MySqlConnection conn;
        private static MySqlCommand command;
        /// <summary>
        /// sql操作连接，
        /// </summary>
        /// <param name="sqlName">数据库名称</param>
        /// <returns>影响的记录数</returns>
        public static void sqlConnect(String sqlName)
        {
            //数据库连接字符串  
            connectionString = "Database=" + sqlName + ";Data Source=localhost;User Id=root;Password=123456;";
            // server=127.0.0.1/localhost 代表本机，端口号port默认是3306可以不写
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();//建立连接，可能出现异常,使用try catch语句
                MessageBox.Show("已完成数据库链接");
            }
            catch (MySqlException e)
            {
                MesShow.errorMs(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #region 执行查询SQL语句方法

        /// <summary>
        /// 执行SQL查询语句，返回影响的记录数
        /// </summary>
        /// <param name="userin">用户</param>
        /// <param name="pwdin">密码</param>
        /// <returns>影响的记录数</returns>
        public static int rowQuery(string userin, string pwdin)
        {
            string SQLString = "select * from administrator WHERE admin = '" + userin + "'";
            try
            {
                conn.Open();
                command = new MySqlCommand(SQLString, conn);
                if (command.ExecuteScalar() == null)
                {
                    //为空时的操作
                    conn.Close();
                    return 0;
                }
                else
                {
                    MySqlDataReader dr = command.ExecuteReader();
                    string pwd = null;
                    if (dr.Read())
                    {
                        //读取指定用户名对应的用户编号和密码
                        pwd = "" + dr[2];
                    }
                    dr.Close();
                    pwd = EncodHelper.DESDeCode(pwd, "78945612");
                    conn.Close();
                    if (pwd.Equals(pwdin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                    //获取第一列所有值
                    /* List<int> idList = new List<int>();
                    while (dr.Read())
                     {
                         idList.Add(dr.GetInt32(0));

                     }*/
                    //string result = command.ExecuteScalar().ToString().Trim();
                }
            }
            catch (Exception e)
            {
                MesShow.errorMs(e.Message);
                return 0;
            }
            finally
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        /// <summary>
        /// 返回数据表数据
        /// </summary>
        /// <param name="sql">查询哪个数据库的sql语句</param>
        /// <returns></returns>
        public static DataTable DataTableInfo(string sql)
        {
            MySqlDataAdapter adapter;
            try
            {
                conn.Open();
                adapter  = new MySqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            }
            catch (SqlException ex)
            {
                MesShow.errorMs(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// 返回具体数据
        /// </summary>
        /// <param name="sql">查询哪个数据库的sql语句</param>
        /// <returns></returns>
        public static DataTable singlelistGet(string sql)
        {
            MySqlDataAdapter adapter;
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            }
            catch (SqlException ex)
            {
                MesShow.errorMs(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// 返回数据表数据(有参数)
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <param name="cmdParms">查询条件参数</param>
        /// <returns></returns>
        public static DataTable DataTableInfo(string SQLString, params MySqlParameter[] cmdParms)
        {
            command = new MySqlCommand();
            PrepareCommand(command, conn, null, SQLString, cmdParms);
            using (MySqlDataAdapter da = new MySqlDataAdapter(command))
            {
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    command.Parameters.Clear();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return dt;
            }
        }
        private static void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, string cmdText, MySqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {
                foreach (MySqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                        (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
            conn.Close();
        }
        /* 更新密码 */
        public static int updatePwd(string npwd)
        {
            npwd = EncodHelper.DESEnCode(npwd, "78945612");
            string str_update = "update administrator set pwd= '" + npwd + "' where admin=" + UserSession.getName();
            try
            {
                conn.Open();
                using (command = new MySqlCommand(str_update, conn)) {
                    command.ExecuteNonQuery();
                    return 1;
                } 
            }
            catch (Exception e)
            {
                //抓錯誤訊息
                MesShow.errorMs(e.Message);
                return 0;
            }
            finally
            {
                //清除
                conn.Close();
            }
        }
        //适合增删操作，返回影响条数
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            conn.Open();
            using (command = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        if (parameters != null)
                        command.Parameters.AddRange(parameters);
                        return command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        if (conn != null && conn.State != ConnectionState.Closed)
                            conn.Close();
                    }
            }
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="admin">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public static void  register(string admin, string pwd)
        {
            try
            {
                conn.Open();
                pwd = EncodHelper.DESEnCode(pwd, "78945612");
                string sql = "insert into administrator(admin,pwd) values ('" + admin + "','" + pwd + "')";
                Console.WriteLine(sql);
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("注册成功");
                conn.Close();
                
            }
            catch (SqlException ex)
            {
            }
        }
        //查看用户名是否存在
        public static MySqlDataReader searchRepeat(string text)
        {
            try
            {
                conn.Open();
                command = new MySqlCommand("select admin from administrator where admin= '" +
                                            text+"'", conn);
                MySqlDataReader result = command.ExecuteReader();
                //closeSql();
                return result;
            } catch (SqlException e)
            {
                MesShow.errorMs("系统错误");
                return null;
            } 

        }
        //DataGridView 更新数据
        public static void updateList(List<string> nameary , List<DataGridViewRow> rlist,string tablename)
        {
            conn.Open();

            deletData(nameary,tablename);
            int c = rlist[0].Cells.Count;

            foreach (DataGridViewRow dgv  in rlist)
            {
                string sql = "insert into " + tablename + " values (";
                for (int j = 0; j < c; j++)
                {
                    if (j == 0)
                    {
                        sql = sql + $"'{dgv.Cells[j].Value}'";
                        continue;
                    }
                    sql = sql + $",'{dgv.Cells[j].Value}'";
                }
                sql = sql + ")";
                
                using (command = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MesShow.errorMs(ex.Message);
                    }
                }
            }
            MesShow.ms("更改数据成功");
            conn.Close();
        }
        //表格对应的 表ID名
        private static string tableToID(string n)
        {
            string head = "";
            switch (n)
            {
                case "ingredients":
                    head = "inId";
                    break;
                case "administrator":
                    head = "aid";
                    break;
                case "dishes":
                    head = "cid";
                    break;
                case "partitions":
                    head = "ppid";
                    break;
                case "supplier":
                    head = "sid";
                    break;
                case "team":
                    head = "tid";
                    break; 
                case "teamplayer":
                    head = "eid";
                    break;
            }
            return head;
        }
        //删除数据函数
        public static bool deletData(List<string> nameary,string tablename)
        {
            conn.Open();
            string head = tableToID(tablename);
            string sql = "delete from " + tablename + " where " + head + " = ";
            foreach (string s in nameary)
            {
                string sql2 = sql + s;
                Console.WriteLine(sql2+"---");
                using (command = new MySqlCommand(sql2, conn))
                {
                    try
                    {
                       int sf = command.ExecuteNonQuery();
                        Console.WriteLine(sf);
                    }
                    catch (Exception ex)
                    {
                        MesShow.errorMs(ex.Message);
                        return false;
                    }
                }
            }
            MesShow.ms("删除数据完成");
            conn.Close();
            return true;
        }
        //插入数据
        public static void datagridAdd(List<DataGridViewRow> rlist, string tablename)
        {
            conn.Open();
            foreach (DataGridViewRow dgv in rlist)
            {
                int c = dgv.Cells.Count;
                string sql = "insert into " + tablename + " values (";
                for (int j = 0; j < c; j++)
                {
                    if (j == 0)
                    {
                      sql = sql + $"'{dgv.Cells[j].Value}'";
                      continue;
                     }
                    sql = sql + $",'{dgv.Cells[j].Value}'";
                }
                sql = sql + ")";
                Console.WriteLine(sql);

                using (command = new MySqlCommand(sql, conn))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        MesShow.ms("添加数据成功");
                    }
                    catch (Exception ex)
                    {
                        MesShow.errorMs(ex.Message);
                    }
                }
            }
            conn.Close();
        }
        public static void closeSql()
        {
            conn.Close();
        }
    }
    #endregion
}


