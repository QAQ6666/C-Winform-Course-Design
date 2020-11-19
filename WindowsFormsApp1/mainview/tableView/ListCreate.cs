using System;
using System.Collections;
using System.Data;

using System.Windows.Forms;
using WindowsFormsApp1.sqlOperating;

namespace WindowsFormsApp1.mainview.tableView
{
    class ListCreate
    {
        public static string tableName = "";
        public static void singleCreate(ListView l, String name)
        {
            DataTable dataTable;
            switch (name)
            {
                //采购
                case "cg":
                    dataTable = DbSQLHelper.DataTableInfo("select * from purchase");
                    tableName = "purchase";
                    if (dataTable.Rows.Count != 0)
                    {
                        purchaseView(l);
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems[0].Text = dr["purId"].ToString();
                            item.SubItems.Add(dr["resertime"].ToString());
                            item.SubItems.Add(dr["amount"].ToString());
                            item.SubItems.Add(dr["signinTime"].ToString());
                            item.SubItems.Add(dr["inglenumber"].ToString());
                            l.Items.Add(item);
                        }
                    }
                    else
                    {
                        EmptyData(l);
                    }
                    break;
                //具体信息查看
                case "jt":

                    break;
                //供应商
                case "gys":
                    dataTable = DbSQLHelper.DataTableInfo("select * from supplier");
                    tableName = "supplier";
                    if (dataTable.Rows.Count != 0)
                    {
                        pubsupplier(l);
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems[0].Text = dr["sid"].ToString();
                            item.SubItems.Add(dr["supplierName"].ToString());
                            item.SubItems.Add(dr["registerAddress"].ToString());
                            item.SubItems.Add(dr["produceAddress"].ToString());
                            item.SubItems.Add(dr["principal"].ToString());
                            item.SubItems.Add(dr["tel"].ToString());
                            item.SubItems.Add(dr["email"].ToString());
                            item.SubItems.Add(dr["business"].ToString());
                            item.SubItems.Add(dr["qaliNumber"].ToString());
                            l.Items.Add(item);
                        }
                    }
                    else
                    {
                        EmptyData(l);
                    }
                    break;
                //食材清单
                case "scl":
                     dataTable = DbSQLHelper.DataTableInfo("select * from ingredients");
                    tableName = "ingredients";
                    if (dataTable.Rows.Count != 0)
                    {
                        SystemManagementView.isImgshow = true;
                        pubInstantiate(l);
                        l.Columns.Add("图片", 100, HorizontalAlignment.Center);
                        l.Columns.Add("产地", 80, HorizontalAlignment.Center);

                        foreach (DataRow dr in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems[0].Text = dr["inid"].ToString();
                            item.SubItems.Add(dr["name"].ToString());
                            item.SubItems.Add(dr["price"].ToString());
                            item.SubItems.Add(dr["desc"].ToString());
                            item.SubItems.Add(dr["img"].ToString());
                            item.SubItems.Add(dr["origin"].ToString());
                           
                            l.Items.Add(item);
                        }
                    }
                    else
                    {
                        EmptyData(l);
                    }
                    break;
                //团队信息
                case "tdxx":
                    dataTable = DbSQLHelper.DataTableInfo("select * from team");
                    tableName = "team";
                    if (dataTable.Rows.Count != 0)
                    {
                        puteam(l);
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems[0].Text = dr["tid"].ToString();
                            item.SubItems.Add(dr["principal"].ToString());
                            item.SubItems.Add(dr["total"].ToString());
                            item.SubItems.Add(dr["tpartiton"].ToString());
                            item.SubItems.Add(dr["tfloot"].ToString());
                            item.SubItems.Add(dr["tdesc"].ToString());
                            item.SubItems.Add(dr["tnumbering"].ToString());
                            item.SubItems.Add(dr["qualification"].ToString());
                            l.Items.Add(item);
                        }
                    }
                    else
                    {
                        EmptyData(l);
                    }
                    break;
                case "cpck":
                    dataTable = DbSQLHelper.DataTableInfo("select * from dishes");
                    tableName = "dishes";
                    if (dataTable.Rows.Count != 0)
                    {
                        SystemManagementView.isImgshow = true;
                        pubInstantiate(l);
                        l.Columns.Add("评价", 60, HorizontalAlignment.Center);
                        l.Columns.Add("菜品类别", 60, HorizontalAlignment.Center);
                        l.Columns.Add("出菜时间", 60, HorizontalAlignment.Center);
                        l.Columns.Add("图片", 60, HorizontalAlignment.Center);
                        l.Columns.Add("所属食堂", 60, HorizontalAlignment.Center);

                        foreach (DataRow dr in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems[0].Text = dr["cid"].ToString();
                            item.SubItems.Add(dr["cname"].ToString());
                            item.SubItems.Add(dr["cprice"].ToString());
                            item.SubItems.Add(dr["cdesc"].ToString());
                            
                            item.SubItems.Add(dr["cevaluation"].ToString());
                            item.SubItems.Add(dr["type"].ToString());
                            item.SubItems.Add(dr["earlyornoon"].ToString());
                            item.SubItems.Add(dr["cpic"].ToString());
                            item.SubItems.Add(dr["partitionArea"].ToString());
                            l.Items.Add(item);
                        }
                    }
                    else
                    {
                        EmptyData(l);
                    }
                    break;
                case "ckxx":
                    dataTable = DbSQLHelper.DataTableInfo("select * from partitions");
                    tableName = "partitions";
                    if (dataTable.Rows.Count != 0)
                    {
                        stck(l);
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems[0].Text = dr["ppid"].ToString();
                            item.SubItems.Add(dr["pname"].ToString());
                            item.SubItems.Add(dr["pareaNumber"].ToString());
                            item.SubItems.Add(dr["pdesc"].ToString());
                            item.SubItems.Add(dr["ppostition"].ToString());
                            item.SubItems.Add(dr["presponsible"].ToString());
                            item.SubItems.Add(dr["ptele"].ToString());
                            item.SubItems.Add(dr["ppic"].ToString());
                            item.SubItems.Add(dr["pfloor"].ToString());
                            l.Items.Add(item);
                        }
                    }
                    else
                    {
                        EmptyData(l);
                    }
                    break;
                case "tdgr":
                    dataTable = DbSQLHelper.DataTableInfo("select * from teamplayer");
                    tableName = "teamplayer";
                    if (dataTable.Rows.Count != 0)
                    {
                        teamgr(l);
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems[0].Text = dr["eid"].ToString();
                            item.SubItems.Add(dr["chef"].ToString());
                            item.SubItems.Add(dr["age"].ToString());
                            item.SubItems.Add(dr["infoTeam"].ToString());
                            item.SubItems.Add(dr["cpic"].ToString());
                            item.SubItems.Add(dr["headChef"].ToString());
                            l.Items.Add(item);
                        }
                    }
                    else
                    {
                        EmptyData(l);
                    }
                    break;
                case "zgl":
                    dataTable = DbSQLHelper.DataTableInfo("select * from administrator");
                    tableName = "administrator";
                    if (dataTable.Rows.Count != 0)
                    {
                        adminManagement(l);
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem();
                            item.SubItems[0].Text = dr["aid"].ToString();
                            item.SubItems.Add(dr["admin"].ToString());
                            item.SubItems.Add("不可见");
                            //item.SubItems.Add(dr["pwd"].ToString());
                            item.SubItems.Add(dr["isroot"].ToString());
                            //item.SubItems.Add(dr["isroot"].ToString().Equals("y") ? "是" : "否");
                            l.Items.Add(item);
                        }
                    }
                    else{
                        EmptyData(l);
                    }
                    break;
            }

        }
        //空数据
        private static void EmptyData(ListView l)
        {
            SystemManagementView.isImgshow = false;
            l.Clear();
            l.Columns.Add("无数据", 100, HorizontalAlignment.Center);
        }
        //食材清单数据显示
        private static void pubInstantiate(ListView l)
        {
            l.Clear();
            l.Columns.Add("序号", 60, HorizontalAlignment.Center);
            l.Columns.Add("名称", 150, HorizontalAlignment.Center);
            l.Columns.Add("价格", 80, HorizontalAlignment.Center);
            l.Columns.Add("描述", 200, HorizontalAlignment.Center);
        }
        //供应商数据显示
        private static void pubsupplier(ListView l)
        {
            SystemManagementView.isImgshow = false;

            l.Clear();
            l.Columns.Add("序号", 60, HorizontalAlignment.Center);
            l.Columns.Add("名称", 80, HorizontalAlignment.Center);
            l.Columns.Add("注册地址", 100, HorizontalAlignment.Center);
            l.Columns.Add("生产地址", 100, HorizontalAlignment.Center);
            l.Columns.Add("负责人", 70, HorizontalAlignment.Center);
            l.Columns.Add("电话", 100, HorizontalAlignment.Center);
            l.Columns.Add("邮箱", 80, HorizontalAlignment.Center);
            l.Columns.Add("业务范围", 150, HorizontalAlignment.Center);
            l.Columns.Add("资质编号", 150, HorizontalAlignment.Center);
        }
        //团队信息显示
        private static void puteam(ListView l)
        {
            SystemManagementView.isImgshow = false;
            l.Clear();
            l.Columns.Add("序号", 60, HorizontalAlignment.Center);
            l.Columns.Add("负责人", 80, HorizontalAlignment.Center);
            l.Columns.Add("队员人数", 100, HorizontalAlignment.Center);
            l.Columns.Add("负责食堂", 100, HorizontalAlignment.Center);
            l.Columns.Add("负责楼层", 70, HorizontalAlignment.Center);
            l.Columns.Add("描述", 100, HorizontalAlignment.Center);
            l.Columns.Add("团队编号", 80, HorizontalAlignment.Center);
            l.Columns.Add("团队资质", 150, HorizontalAlignment.Center);
        }
        //食堂查看信息
        private static void stck(ListView l)
        {
            SystemManagementView.isImgshow = true;
            l.Clear();
            l.Columns.Add("序号", 50, HorizontalAlignment.Center);
            l.Columns.Add("食堂名称", 150, HorizontalAlignment.Center);
            l.Columns.Add("食堂编号", 80, HorizontalAlignment.Center);
            l.Columns.Add("描述", 200, HorizontalAlignment.Center);
            l.Columns.Add("位置", 60, HorizontalAlignment.Center);
            l.Columns.Add("负责人", 60, HorizontalAlignment.Center);
            l.Columns.Add("电话", 60, HorizontalAlignment.Center);
            l.Columns.Add("图片", 60, HorizontalAlignment.Center);
            l.Columns.Add("楼层", 60, HorizontalAlignment.Center);
            
        }
        private static void teamgr(ListView l)
        {
            SystemManagementView.isImgshow = true;
            l.Clear();
            l.Columns.Add("序号", 50, HorizontalAlignment.Center);
            l.Columns.Add("厨师名", 60, HorizontalAlignment.Center);
            l.Columns.Add("年龄", 50, HorizontalAlignment.Center);
            l.Columns.Add("所属团队", 100, HorizontalAlignment.Center);
            l.Columns.Add("图片", 70, HorizontalAlignment.Center);
            l.Columns.Add("是否为厨师长", 50, HorizontalAlignment.Center);
        }
        private static void adminManagement(ListView l)
        {
            SystemManagementView.isImgshow = false;
            l.Clear();
            l.Columns.Add("序号", 50, HorizontalAlignment.Center);
            l.Columns.Add("管理员", 60, HorizontalAlignment.Center);
            l.Columns.Add("密码", 80, HorizontalAlignment.Center);
            l.Columns.Add("是否为终极管理员", 100, HorizontalAlignment.Center);
        }
        private static void purchaseView(ListView l)
        {
            SystemManagementView.isImgshow = false;
            l.Clear();
            l.Columns.Add("序号", 50, HorizontalAlignment.Center);
            l.Columns.Add("预约时间", 50, HorizontalAlignment.Center);
            l.Columns.Add("金额", 50, HorizontalAlignment.Center);
            l.Columns.Add("签货时间", 50, HorizontalAlignment.Center);
            l.Columns.Add("单号", 50, HorizontalAlignment.Center);
        }
    }
}
