
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.function;
using WindowsFormsApp1.mainview.tableView;
using WindowsFormsApp1.sqlOperating;
using WindowsFormsApp1.tools;

namespace WindowsFormsApp1.mainview
{
    public partial class Editdata : Form
    {
        private List<String> idRow = new List<string>();
        public Editdata()
        {
            InitializeComponent();
        }
        public Editdata(List<ListViewItem> list, List<String> headlist,bool f,string tableName)
        {

            InitializeComponent();
            if (f)
            {
                detailsBtn.Visible = true;
            }
            foreach( string text in headlist)
            {
                DataGridViewTextBoxColumn Column5 = new DataGridViewTextBoxColumn();
                Column5.HeaderText = text;
                Column5.MinimumWidth = 6;
                Column5.Name = text;
                Column5.Width = 125;
                dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
                Column5});
            }
            int len = headlist.Count;
            
            foreach (ListViewItem lvi in list)
            {
                int ind = dataGridView1.Rows.Add();
                for (int i  = 0;i < len; i++)
                {
                    string text = lvi.SubItems[i].Text;
                    dataGridView1.Rows[ind].Cells[i].Value = text;
                    //如果为采购内容，则预约时间不可任意添加
                    if (tableName.Equals("purchase"))
                    {
                        dataGridView1.Rows[ind].Cells[1].ReadOnly = true;
                    }
                        
                }
                idRow.Add(lvi.SubItems[0].Text);
            }
            dataGridView1.Columns[0].ReadOnly = true;
            number = "";
            //dataGridView1.Rows[0].ReadOnly = true;
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private List<DataGridViewRow> addRowlist = new List<DataGridViewRow>();
        //添加空白数据行
        private void addsBtn_Click(object sender, EventArgs e)
        {
            Boolean isto = true;
            int rtotal = dataGridView1.Rows.Count;
            int ctotal = dataGridView1.Columns.Count;
            int ind = int.Parse(dataGridView1.Rows[rtotal - 1].Cells[0].Value.ToString()) ;
            for (int f = 0;f < ctotal; f++)
            {
                string text = dataGridView1.Rows[rtotal-1].Cells[f].Value.ToString();
                if (text == "")
                {
                    isto = false;
                }
                else
                {
                    isto = true;
                }
            }
            if (isto)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = ind + 1 + "";
                addRowlist.Add(dataGridView1.Rows[index]);
                for (int i = 1; i < ctotal; i++)
                {
                    dataGridView1.Rows[index].Cells[i].Value = "";
                    if (ListCreate.tableName.Equals("purchase"))
                    {
                        dataGridView1.Rows[ind].Cells[1].Value = DateTime.Now.ToLocalTime().ToString();
                    }
                }
            }
            else
            {
                MesShow.ms("最后一行未添加数据，无法新增");
            }
            
        }
        private int rowIndex = 0;
        private int columnIndex = 0;
        private bool isToUpdate = true;
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要更新数据了吗?", "更新数据", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //update
                if (isToUpdate)
                {
                    string s = ListCreate.tableName;
                    DbSQLHelper.updateList(nameary, rowlist, ListCreate.tableName);
                    this.Close();
                    
                }
                else
                {
                    MesShow.ms("存在非法输入值,位置："+ rowIndex+1+"行"+ columnIndex+1+"列");
                }
            }

        }
       
        //单元格选中触发函数
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

             rowIndex = dataGridView1.CurrentCell.RowIndex;
             columnIndex = dataGridView1.CurrentCell.ColumnIndex;
        }
        private string editstr = "";
        private List<string> nameary = new List<string>();
        private List<DataGridViewRow> rowlist = new List<DataGridViewRow>();
        //单元格结束编辑触发函数
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            nameary.Add(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //添加被编辑过的数据行
            rowlist.Add(dataGridView1.CurrentRow);

            string head = dataGridView1.Columns[columnIndex].HeaderText;
            if (head.Equals("价格"))
            {
                if (!Verification.isInt((string)dataGridView1.CurrentCell.Value))
                {
                    isToUpdate = false;
                    MesShow.ms("输入值仅能包含数字");
                    dataGridView1.CurrentCell.Value = editstr;
                }
                else
                {
                    isToUpdate = true;
                }
            }
        }
       
        //单元格值变换时候
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool noAdd = false;
        private void confirmAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要添加数据吗?", "添加数据", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                switch (ListCreate.tableName)
                {
                    case "purchase":
                        addTableDataVerFloat(addRowlist,2);
                        break;
                    case "supplier":
                        addTableDataVerPhone(addRowlist,5);
                        break;
                    case "ingredients":
                        addTableDataVerFloat(addRowlist,2);
                        break;
                    case "team":
                        addTableDataVerInt(addRowlist,2);
                        break;
                    case "dishes":
                        addTableDataVerInt(addRowlist, 2);
                        break;
                    case "partitions":
                        addTableDataVerInt(addRowlist, 8);
                        break;
                    case "teamplayer":
                        addTableDataVerInt(addRowlist, 2);
                        break;
                    case "administrator":
                        addTableDataVerZM(addRowlist, 3);
                        break;

                }
                if (noAdd)
                {
                   int result =  DbSQLHelper.datagridAdd(addRowlist, ListCreate.tableName);
                   if (result == 1)
                    {
                        this.Close();
                    }
                }
            }
        }
        //新增的数据行进行数据验证:整数
        private void addTableDataVerInt(List<DataGridViewRow> addRowlist, int ind)
        {
            noAdd = true;
            foreach (DataGridViewRow row in addRowlist)
            {
                if (!Verification.isInt(row.Cells[ind].Value.ToString()))
                {
                    MesShow.ms("验证数值内容存在非数值,位置 : 第"+ ind + 1 + "列");
                    noAdd = false;
                    break;
                }
            }
        }
        //新增的数据行进行数据验证:浮点数
        private void addTableDataVerFloat(List<DataGridViewRow> addRowlist, int ind)
        {
            noAdd = true;
            foreach (DataGridViewRow row in addRowlist)
            {
                if (!Verification.isFloat(row.Cells[ind].Value.ToString()))
                {
                    MesShow.ms("验证数值内容存在非数值,位置 : 第" + ind + 1 + "列");
                    noAdd = false;
                    break;
                }
            }
        }
        //新增的数据行进行数据验证:电话
        private void addTableDataVerPhone(List<DataGridViewRow> addRowlist, int ind)
        {
            noAdd = true;
            foreach (DataGridViewRow row in addRowlist)
            {
                if (!Verification.IsPhoneNo(row.Cells[ind].Value.ToString()))
                {
                    MesShow.ms("请填充正确的电话号码,位置 : 第" + ind + 1 + "列");
                    noAdd = false;
                    break;
                }
            }
        }
        //新增的数据行进行数据验证:单个字母
        private void addTableDataVerZM(List<DataGridViewRow> addRowlist, int ind)
        {
            noAdd = true;
            foreach (DataGridViewRow row in addRowlist)
            {
                if (row.Cells[ind].Value.ToString().Length > 1)
                {
                    MesShow.ms("请填充正确的年龄数值,位置 : 第" + ind+1 + "列");
                    noAdd = false;
                    break;
                }
            }
        }
        //删除所有被选中的数据
        private void delectBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("确定要删除当前数据?", "删除数据", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (DbSQLHelper.deletData(idRow, ListCreate.tableName))
                {
                    this.Close();
                }
                //dataGridView1.Rows??
            }
        }
        public Singlelist singlelist;
        //查看单号具体的采购信息
        private void detailsBtn_Click(object sender, EventArgs e)
        {
            if (number.Equals(""))
            {
                MesShow.ms("请选中一行");
            }
            else
            {
                string sql = "select * from singlelist where inglenumberw = " + number;
                DataTable dataTable = DbSQLHelper.singlelistGet(sql);

                if (dataTable.Rows.Count != 0)
                {
                    singlelist = new Singlelist(dataTable);
                    SystemManagementView.thsinglist = new Thread(delegate () { singlelist.ShowDialog(); });
                    SystemManagementView.thsinglist.IsBackground = true;
                    SystemManagementView.thsinglist.Start();
                }
                else
                {
                    MesShow.ms("该表数据无详细信息");
                }
            }
           
        }
        //选中的单号
        private string number = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            number = row.Cells[row.Cells.Count - 1].Value.ToString();
            Console.WriteLine(number);
        }
        public void closeWin()
        {
            this.Close();
        }
    }
}
