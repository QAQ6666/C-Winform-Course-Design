using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1.function.pwdFun;
using WindowsFormsApp1.mainview;
using WindowsFormsApp1.mainview.register;
using WindowsFormsApp1.mainview.tableView;
using WindowsFormsApp1.mainview.treeNodeView;
using WindowsFormsApp1.tools;

namespace WindowsFormsApp1
{
    public partial class SystemManagementView : Form
    {
        private UserSession userSession1;
        private bool quanxian = true;
        public SystemManagementView()
        {
            InitializeComponent();
            adresslab.Text = GetAdress.GetLocalIP();
            rootNodesEdit = new RootNodesEdit();
            IsMdiContainer = true;
        }
        public SystemManagementView(UserSession userSession)
        {
            InitializeComponent();
            adresslab.Text = GetAdress.GetLocalIP();
            rootNodesEdit = new RootNodesEdit();
            IsMdiContainer = true;
            userSession1 = userSession;
        }

        public static Thread thEdit;
        public static Thread thsinglist;
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(UserSession.getRoot());
            if(UserSession.getRoot() == "ROOT")
            {
                quanxian = true;
                this.authorityBtn.Visible = true;
            }
            else
            {
                quanxian = false;
                this.authorityBtn.Visible = false;
            }
        }
      
        //帮助按钮
        private void helpClick_1(object sender, EventArgs e)
        {
            MessageBoxButtons msgButton = MessageBoxButtons.OK;
            DialogResult dr = MessageBox.Show("软件说明: University canteen management \n课程计划小组:计科3 \n文件版本： 1.0.0\n开发日期: 2020/9/01", "提示", msgButton);
            if (dr == DialogResult.OK)
            {
               
            }

        }
        private void splitContainer2_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        //退出登录按钮
        private void outLogin_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msgButton = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("确定要退出吗?All Windows are close", "提示", msgButton);
            if (dr == DialogResult.Yes)
            {
                //退出登录代码:
                try
                {
                }
                catch (NullReferenceException)
                {
                   
                }
                this.Close();
                Thread th = new Thread(delegate () { new UserLogin(1).ShowDialog(); });
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                MessageBox.Show("已取消");
            }
        }
        //食材管理按钮
        private void ingredientsbtn_Click(object sender, EventArgs e)
        {
            clearList();
            closeImg();
            rootNodesEdit.addChildtree(this.rootNode, 0);
        }
        //菜品管理按钮
        private void dishesBtnClick(object sender, EventArgs e)
        {
            clearList();
            closeImg();
            rootNodesEdit.addChildtree(rootNode, 1);
        }
        //食堂编辑按钮
        private void canteen_editClick(object sender, EventArgs e)
        {
            clearList();
            closeImg();
            rootNodesEdit.addChildtree(rootNode, 2);
        }
        //食堂团队按钮
        private void canteenTeambtn_Click(object sender, EventArgs e)
        {
            closeImg();
            clearList();
            rootNodesEdit.addChildtree(rootNode, 3);
        }
        //注册管理员
        private void registeredBtn_Click(object sender, EventArgs e)
        {
            clearList();
            closeImg();
            Thread th = new Thread(delegate () { new AdminRegister().ShowDialog(); });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private modifyPwd modifyPwd;
        //密码修改
        private void modifyPwdclick(object sender, EventArgs e)
        {
            closeImg();
            modifyPwd = new modifyPwd();
            Thread th = new Thread(delegate () { modifyPwd.ShowDialog(); });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        //权限管理
        private void authorityClick(object sender, EventArgs e)
        {
            closeImg();
            clearList();
            rootNodesEdit.addChildtree(rootNode, 4);
        }
       
        //图标清空
        private void clearList()
        {
            listView.Clear();
        }

        private static string eNodeName = "";
        /* 子节点选择事件 */
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            closeImg();
            eNodeName = e.Node.Name;
            ListCreate.singleCreate(listView, eNodeName);
        }
     
        //数据更新完，重新调用数据库数据刷新界面
        public void treeViewUpdate()
        {
            ListCreate.singleCreate(listView, eNodeName);
        }
        //公用样式改变Fun
        private void ingredientsbtn_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font, FontStyle.Bold);
            ((Button)sender).ForeColor = Color.White;
        }
        private void ingredientsbtn_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Font = new Font(((Button)sender).Font, FontStyle.Regular);
            ((Button)sender).ForeColor = Color.Black;
        }
        /// <summary>
        /// 每一行颜色改变，高亮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_MouseMove(object sender, MouseEventArgs e)
        {
            ListView lv = (ListView)sender;
            ListViewItem oldItem = null;
            if (lv.Tag != null)
                oldItem = (ListViewItem)lv.Tag;

            ListViewItem curItem = lv.GetItemAt(e.X, e.Y);//获取鼠标所在的项
            if (curItem != null)
            {
                // 还原鼠标上次所在项的背景颜色
                if (oldItem != null && oldItem != curItem)
                    oldItem.BackColor = lv.BackColor;

                curItem.BackColor = Color.LightGreen;//设置当前项的背景颜色
                lv.Tag = curItem;
            }
            else
            {
                if (oldItem != null && oldItem.BackColor != lv.BackColor)
                    oldItem.BackColor = lv.BackColor;
            }
        }
        private ListViewItem lastSelectedItem = null;
        private void listView_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            if (lastSelectedItem != null)
            {
                lastSelectedItem.BackColor = Color.White;
            }
            e.Item.BackColor = Color.LightGreen;
            lastSelectedItem = e.Item;
        }

        private void CbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.listView.Columns.Count != 0)
            {
                SelectAllCheckBoxes(this.listView, checkBox1.Checked);
            }
            else
            {
                CheckBox c = (CheckBox)sender;
                c.Checked = false;
                MesShow.ms("无数据可选");
            }
        }
        private void SelectAllCheckBoxes(ListView lv, bool currVal)
        {
            foreach (ListViewItem item in lv.Items)
                item.Checked = currVal;
        }
        //每一行数据状态改变
        private void listView_ItemActivate(object sender, EventArgs e)
        {
        }
        //图片按钮，显示控件关闭
        private void closeImg()
        {
            simg.Visible = false;
            pictureShowBox.Visible = false;
        }
        /// <summary>
        ///  单击每一行数据显示 查看图片按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private string imgpath = "";
        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (isImgshow)
            {
                ListView lv = (ListView)sender;
                int img = lv.Columns.Count - 2;
                imgpath = lv.FocusedItem.SubItems[img].Text;
                simg.Visible = true;
                simg.Location = new System.Drawing.Point(MousePosition.X - 410, MousePosition.Y - 210);
               
            }
        }
        ////////获取图片路径并显示
        private void ToshowImg(object sender, EventArgs e)
        {
            
            pictureShowBox.Visible = true;
            //程序根目录的上级目录(通常是bin\下)
            string path = @"..\dishes\"+ imgpath;
            
            try
            {
                pictureShowBox.Image = Image.FromFile(path);
            }
            catch (FileNotFoundException f)
            {
                MesShow.errorMs("图片未找到");
            }
        }
        //////////图片控件拖拽按钮(下三个)
        private void pictureShowBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
            original_pos = ((Control)sender).Location;
        }

        private void pictureShowBox_MouseMove(object sender, MouseEventArgs e)
        {
            ((Control)sender).Cursor = Cursors.Arrow;
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                ((Control)sender).Location = ((Control)sender).Parent.PointToClient(mousePos);
            }
           
        }

        private void pictureShowBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                    ((Control)sender).Location = ((Control)sender).Parent.PointToClient(mousePos);
                    //((Control)sender).Location = original_pos;
            }

        }
        //每次选中列表都会更新被选中的列
        private List<ListViewItem> list;
        private void listView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
           list = new List<ListViewItem>();
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Checked)
                {
                    list.Add(item);
                }
            }
        }
        private List<String> headlist;
        private Editdata editdata;
        private void editDataBtn_Click(object sender, EventArgs e)
        {
            bool f = false;
            if (eNodeName.Equals("cg"))
            {
                f = true;
            }
            try
            {
                if (list == null || list.Count == 0)
                {
                    MesShow.ms("无选中数据可编辑");
                }
                else
                {
                    headlist = new List<String>();
                    int len = listView.Columns.Count;
                    for(int i = 0; i < len; i++)
                    {
                        headlist.Add(listView.Columns[i].Text);
                    }
                    editdata = new Editdata(list, headlist, f,ListCreate.tableName);
                    Thread th = new Thread(delegate () { editdata.ShowDialog(); });
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            catch (NullReferenceException)
            {
                MesShow.ms("无选中数据可编辑");
            }
        }

        private void flush_Click(object sender, EventArgs e)
        {
            ListCreate.singleCreate(listView, eNodeName);
        }
    }
}
