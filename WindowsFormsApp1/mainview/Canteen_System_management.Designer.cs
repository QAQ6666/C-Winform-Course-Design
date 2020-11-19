using System.Drawing;
using WindowsFormsApp1.mainview.treeNodeView;

namespace WindowsFormsApp1
{
    using System.Windows.Forms;
    partial class SystemManagementView
    {
        
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        
        private  TreeNode rootNode;
        private void InitializeComponent()
        {
            this.rootNode = new System.Windows.Forms.TreeNode("无");
            this.panel1 = new System.Windows.Forms.Panel();
            this.registeredBtn = new System.Windows.Forms.Button();
            this.outLogin = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.Bigtitle = new System.Windows.Forms.Label();
            this.mainBottom = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.Label();
            this.IPview = new System.Windows.Forms.Label();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.authorityBtn = new System.Windows.Forms.Button();
            this.modifyPWDbtn = new System.Windows.Forms.Button();
            this.canteenTeambtn = new System.Windows.Forms.Button();
            this.canteen_edit = new System.Windows.Forms.Button();
            this.ingredientsbtn = new System.Windows.Forms.Button();
            this.dishesBtn = new System.Windows.Forms.Button();
            this.flush = new System.Windows.Forms.Button();
            this.editDataBtn = new System.Windows.Forms.Button();
            this.pictureShowBox = new System.Windows.Forms.PictureBox();
            this.simg = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listView = new System.Windows.Forms.ListView();
            this.ingrediChildtree = new System.Windows.Forms.TreeView();
            this.adresslab = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.mainBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.registeredBtn);
            this.panel1.Controls.Add(this.outLogin);
            this.panel1.Controls.Add(this.help);
            this.panel1.Controls.Add(this.Bigtitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 120);
            this.panel1.TabIndex = 3;
            // 
            // registeredBtn
            // 
            this.registeredBtn.AutoSize = true;
            this.registeredBtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.registeredBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registeredBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.registeredBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.registeredBtn.Location = new System.Drawing.Point(972, 12);
            this.registeredBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registeredBtn.Name = "registeredBtn";
            this.registeredBtn.Size = new System.Drawing.Size(75, 39);
            this.registeredBtn.TabIndex = 7;
            this.registeredBtn.Text = "注册";
            this.registeredBtn.UseVisualStyleBackColor = false;
            this.registeredBtn.Click += new System.EventHandler(this.registeredBtn_Click);
            // 
            // outLogin
            // 
            this.outLogin.AutoSize = true;
            this.outLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.outLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.outLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.outLogin.Location = new System.Drawing.Point(1146, 12);
            this.outLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outLogin.Name = "outLogin";
            this.outLogin.Size = new System.Drawing.Size(108, 39);
            this.outLogin.TabIndex = 6;
            this.outLogin.Text = "退出登录";
            this.outLogin.UseVisualStyleBackColor = false;
            this.outLogin.Click += new System.EventHandler(this.outLogin_Click);
            // 
            // help
            // 
            this.help.AutoSize = true;
            this.help.BackColor = System.Drawing.Color.RoyalBlue;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.help.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.help.Location = new System.Drawing.Point(1061, 11);
            this.help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(75, 39);
            this.help.TabIndex = 5;
            this.help.Text = "帮助";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.helpClick_1);
            // 
            // Bigtitle
            // 
            this.Bigtitle.AutoSize = true;
            this.Bigtitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Bigtitle.Font = new System.Drawing.Font("微软雅黑", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bigtitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Bigtitle.Location = new System.Drawing.Point(53, 20);
            this.Bigtitle.Margin = new System.Windows.Forms.Padding(20);
            this.Bigtitle.Name = "Bigtitle";
            this.Bigtitle.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.Bigtitle.Size = new System.Drawing.Size(399, 77);
            this.Bigtitle.TabIndex = 4;
            this.Bigtitle.Text = "校园饭堂后台管理";
            this.Bigtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainBottom
            // 
            this.mainBottom.BackColor = System.Drawing.Color.MediumAquamarine;
            this.mainBottom.Controls.Add(this.adresslab);
            this.mainBottom.Controls.Add(this.description);
            this.mainBottom.Controls.Add(this.IPview);
            this.mainBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainBottom.Location = new System.Drawing.Point(0, 750);
            this.mainBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainBottom.Name = "mainBottom";
            this.mainBottom.Size = new System.Drawing.Size(1280, 50);
            this.mainBottom.TabIndex = 7;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.description.ForeColor = System.Drawing.Color.Snow;
            this.description.Location = new System.Drawing.Point(723, 14);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(149, 19);
            this.description.TabIndex = 1;
            this.description.Text = "C#高级项目系统管理";
            // 
            // IPview
            // 
            this.IPview.AutoSize = true;
            this.IPview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IPview.ForeColor = System.Drawing.Color.Snow;
            this.IPview.Location = new System.Drawing.Point(998, 14);
            this.IPview.Name = "IPview";
            this.IPview.Size = new System.Drawing.Size(58, 19);
            this.IPview.TabIndex = 0;
            this.IPview.Text = "当前IP:";
            // 
            // MainContainer
            // 
            this.MainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainContainer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainContainer.IsSplitterFixed = true;
            this.MainContainer.Location = new System.Drawing.Point(3, 128);
            this.MainContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MainContainer.Panel1.Controls.Add(this.authorityBtn);
            this.MainContainer.Panel1.Controls.Add(this.modifyPWDbtn);
            this.MainContainer.Panel1.Controls.Add(this.canteenTeambtn);
            this.MainContainer.Panel1.Controls.Add(this.canteen_edit);
            this.MainContainer.Panel1.Controls.Add(this.ingredientsbtn);
            this.MainContainer.Panel1.Controls.Add(this.dishesBtn);
            this.MainContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint_1);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.MainContainer.Panel2.Controls.Add(this.flush);
            this.MainContainer.Panel2.Controls.Add(this.editDataBtn);
            this.MainContainer.Panel2.Controls.Add(this.pictureShowBox);
            this.MainContainer.Panel2.Controls.Add(this.simg);
            this.MainContainer.Panel2.Controls.Add(this.checkBox1);
            this.MainContainer.Panel2.Controls.Add(this.listView);
            this.MainContainer.Panel2.Controls.Add(this.ingrediChildtree);
            this.MainContainer.Size = new System.Drawing.Size(1275, 618);
            this.MainContainer.SplitterDistance = 146;
            this.MainContainer.TabIndex = 8;
            // 
            // authorityBtn
            // 
            this.authorityBtn.AutoSize = true;
            this.authorityBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authorityBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.authorityBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.authorityBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.authorityBtn.Location = new System.Drawing.Point(16, 292);
            this.authorityBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.authorityBtn.MaximumSize = new System.Drawing.Size(200, 0);
            this.authorityBtn.Name = "authorityBtn";
            this.authorityBtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.authorityBtn.Size = new System.Drawing.Size(143, 30);
            this.authorityBtn.TabIndex = 5;
            this.authorityBtn.Text = "权  限  管  理";
            this.authorityBtn.UseVisualStyleBackColor = false;
            this.authorityBtn.Click += new System.EventHandler(this.authorityClick);
            this.authorityBtn.MouseLeave += new System.EventHandler(this.ingredientsbtn_MouseLeave);
            this.authorityBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ingredientsbtn_MouseMove);
            // 
            // modifyPWDbtn
            // 
            this.modifyPWDbtn.AutoSize = true;
            this.modifyPWDbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modifyPWDbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.modifyPWDbtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.modifyPWDbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modifyPWDbtn.Location = new System.Drawing.Point(16, 568);
            this.modifyPWDbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modifyPWDbtn.MaximumSize = new System.Drawing.Size(200, 0);
            this.modifyPWDbtn.Name = "modifyPWDbtn";
            this.modifyPWDbtn.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.modifyPWDbtn.Size = new System.Drawing.Size(101, 30);
            this.modifyPWDbtn.TabIndex = 4;
            this.modifyPWDbtn.Text = "修 改 密 码";
            this.modifyPWDbtn.UseVisualStyleBackColor = false;
            this.modifyPWDbtn.Click += new System.EventHandler(this.modifyPwdclick);
            // 
            // canteenTeambtn
            // 
            this.canteenTeambtn.AutoSize = true;
            this.canteenTeambtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.canteenTeambtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.canteenTeambtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.canteenTeambtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.canteenTeambtn.Location = new System.Drawing.Point(16, 208);
            this.canteenTeambtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.canteenTeambtn.MaximumSize = new System.Drawing.Size(200, 0);
            this.canteenTeambtn.Name = "canteenTeambtn";
            this.canteenTeambtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.canteenTeambtn.Size = new System.Drawing.Size(143, 30);
            this.canteenTeambtn.TabIndex = 3;
            this.canteenTeambtn.Text = "食  堂  团  队";
            this.canteenTeambtn.UseVisualStyleBackColor = false;
            this.canteenTeambtn.Click += new System.EventHandler(this.canteenTeambtn_Click);
            this.canteenTeambtn.MouseLeave += new System.EventHandler(this.ingredientsbtn_MouseLeave);
            this.canteenTeambtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ingredientsbtn_MouseMove);
            // 
            // canteen_edit
            // 
            this.canteen_edit.AutoSize = true;
            this.canteen_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.canteen_edit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.canteen_edit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.canteen_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.canteen_edit.Location = new System.Drawing.Point(16, 158);
            this.canteen_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.canteen_edit.MaximumSize = new System.Drawing.Size(400, 0);
            this.canteen_edit.Name = "canteen_edit";
            this.canteen_edit.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.canteen_edit.Size = new System.Drawing.Size(143, 30);
            this.canteen_edit.TabIndex = 2;
            this.canteen_edit.Text = "食  堂  编  辑";
            this.canteen_edit.UseVisualStyleBackColor = false;
            this.canteen_edit.Click += new System.EventHandler(this.canteen_editClick);
            this.canteen_edit.MouseLeave += new System.EventHandler(this.ingredientsbtn_MouseLeave);
            this.canteen_edit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ingredientsbtn_MouseMove);
            // 
            // ingredientsbtn
            // 
            this.ingredientsbtn.AutoSize = true;
            this.ingredientsbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ingredientsbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ingredientsbtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ingredientsbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ingredientsbtn.Location = new System.Drawing.Point(16, 25);
            this.ingredientsbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingredientsbtn.MaximumSize = new System.Drawing.Size(400, 0);
            this.ingredientsbtn.Name = "ingredientsbtn";
            this.ingredientsbtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ingredientsbtn.Size = new System.Drawing.Size(143, 30);
            this.ingredientsbtn.TabIndex = 1;
            this.ingredientsbtn.Text = "食  材  管  理";
            this.ingredientsbtn.UseVisualStyleBackColor = false;
            this.ingredientsbtn.Click += new System.EventHandler(this.ingredientsbtn_Click);
            this.ingredientsbtn.MouseLeave += new System.EventHandler(this.ingredientsbtn_MouseLeave);
            this.ingredientsbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ingredientsbtn_MouseMove);
            // 
            // dishesBtn
            // 
            this.dishesBtn.AutoSize = true;
            this.dishesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dishesBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dishesBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dishesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dishesBtn.Location = new System.Drawing.Point(16, 112);
            this.dishesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dishesBtn.MaximumSize = new System.Drawing.Size(200, 0);
            this.dishesBtn.Name = "dishesBtn";
            this.dishesBtn.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.dishesBtn.Size = new System.Drawing.Size(143, 30);
            this.dishesBtn.TabIndex = 0;
            this.dishesBtn.Text = "菜  品  管  理";
            this.dishesBtn.UseVisualStyleBackColor = false;
            this.dishesBtn.Click += new System.EventHandler(this.dishesBtnClick);
            this.dishesBtn.MouseLeave += new System.EventHandler(this.ingredientsbtn_MouseLeave);
            this.dishesBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ingredientsbtn_MouseMove);
            // 
            // flush
            // 
            this.flush.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flush.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flush.Location = new System.Drawing.Point(474, 584);
            this.flush.Name = "flush";
            this.flush.Size = new System.Drawing.Size(75, 29);
            this.flush.TabIndex = 9;
            this.flush.Text = "刷新";
            this.flush.UseVisualStyleBackColor = true;
            this.flush.Click += new System.EventHandler(this.flush_Click);
            // 
            // editDataBtn
            // 
            this.editDataBtn.BackColor = System.Drawing.Color.White;
            this.editDataBtn.Location = new System.Drawing.Point(339, 583);
            this.editDataBtn.Name = "editDataBtn";
            this.editDataBtn.Size = new System.Drawing.Size(75, 32);
            this.editDataBtn.TabIndex = 12;
            this.editDataBtn.Text = "编辑";
            this.editDataBtn.UseVisualStyleBackColor = false;
            this.editDataBtn.Click += new System.EventHandler(this.editDataBtn_Click);
            // 
            // pictureShowBox
            // 
            this.pictureShowBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureShowBox.Location = new System.Drawing.Point(773, 364);
            this.pictureShowBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureShowBox.Name = "pictureShowBox";
            this.pictureShowBox.Size = new System.Drawing.Size(299, 250);
            this.pictureShowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShowBox.TabIndex = 11;
            this.pictureShowBox.TabStop = false;
            this.pictureShowBox.Visible = false;
            this.pictureShowBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureShowBox_MouseDown);
            this.pictureShowBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureShowBox_MouseMove);
            this.pictureShowBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureShowBox_MouseUp);
            // 
            // simg
            // 
            this.simg.ForeColor = System.Drawing.Color.Teal;
            this.simg.Location = new System.Drawing.Point(940, 74);
            this.simg.Margin = new System.Windows.Forms.Padding(4);
            this.simg.Name = "simg";
            this.simg.Size = new System.Drawing.Size(100, 29);
            this.simg.TabIndex = 6;
            this.simg.Text = "查看图片";
            this.simg.UseVisualStyleBackColor = true;
            this.simg.Visible = false;
            this.simg.Click += new System.EventHandler(this.ToshowImg);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(224, 588);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 23);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "全选";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CbAll_CheckedChanged);
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(153, 5);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(919, 576);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            this.listView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_ItemChecked);
            this.listView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView_ItemMouseHover);
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            this.listView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView_MouseMove);
            // 
            // ingrediChildtree
            // 
            this.ingrediChildtree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ingrediChildtree.Location = new System.Drawing.Point(3, 5);
            this.ingrediChildtree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingrediChildtree.Name = "ingrediChildtree";
            this.rootNode.Name = "无";
            this.rootNode.Text = "无";
            this.ingrediChildtree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            this.rootNode});
            this.ingrediChildtree.Size = new System.Drawing.Size(144, 608);
            this.ingrediChildtree.TabIndex = 0;
            this.ingrediChildtree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // adresslab
            // 
            this.adresslab.AutoSize = true;
            this.adresslab.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adresslab.ForeColor = System.Drawing.Color.White;
            this.adresslab.Location = new System.Drawing.Point(1062, 10);
            this.adresslab.Name = "adresslab";
            this.adresslab.Size = new System.Drawing.Size(0, 26);
            this.adresslab.TabIndex = 2;
            // 
            // SystemManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.mainBottom);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Orange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SystemManagementView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainBottom.ResumeLayout(false);
            this.mainBottom.PerformLayout();
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel1.PerformLayout();
            this.MainContainer.Panel2.ResumeLayout(false);
            this.MainContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureShowBox)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private Panel panel1;
        private Label Bigtitle;
        private Button outLogin;
        private Button help;
        private Panel mainBottom;
        private Label description;
        private Label IPview;
        private SplitContainer MainContainer;
        private Button canteen_edit;
        private Button ingredientsbtn;
        private Button dishesBtn;
        private Button canteenTeambtn;
        private Button registeredBtn;
        private Button modifyPWDbtn;
        private Button authorityBtn;
        private TreeView ingrediChildtree;
        private RootNodesEdit rootNodesEdit;
        private ListView listView;
        private CheckBox checkBox1;
        private Button simg;
        private PictureBox pictureShowBox;
        private Point mouse_offset;
        private Point original_pos;
        private Button editDataBtn;
        private Button flush;
        public static bool isImgshow;
        private Label adresslab;
    }
}

