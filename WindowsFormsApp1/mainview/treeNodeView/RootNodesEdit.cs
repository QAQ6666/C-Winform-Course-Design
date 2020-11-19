using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/* 节点命名 */
struct nodesName
{
    public string t;
    public string n;
    public nodesName[] znodes;
    public void setValues(string tt,string nn, nodesName[] c)
    {
        t = tt;
        n = nn;
        znodes = c;
    }
};
namespace WindowsFormsApp1.mainview.treeNodeView
{
    class RootNodesEdit
    {
        //终极节点创建
        private static nodesName publicRoot = new nodesName();
        //食材管理节点
        static void scglCreat(){
            //子节点组建
            nodesName gys = nNodes("供应商", "gys");
            nodesName clist = nNodes("食材清单", "scl");
            nodesName[] child2 = new nodesName[] { gys, clist };
            nodesName croot = nNodes("采购", "cg");
            nodesName gf = new nodesName();
            gf.setValues("具体查看", "jt", child2);
            //中介点
            nodesName[] child = new nodesName[] { croot, gf };
            //根节点
            publicRoot.setValues("食材管理", "scgl", child);
        }
        //菜品管理节点
        static void cpglCreat()
        {
            nodesName a = nNodes("查看详情", "cpck");
            nodesName[] child = new nodesName[] { a };
            publicRoot.setValues("菜品管理", "cpgl" , child);
        }
        //食堂编辑节点
        static void stCreat()
        {
            nodesName a = nNodes("查看信息", "ckxx");
            nodesName c = nNodes("编辑(暂无)", "stbj");
            nodesName[] child = new nodesName[] {a,c };
            publicRoot.setValues("食堂编辑", "st", child);
        }
        //食堂团队管理节点
        static void steamCreat()
        {
            nodesName a = nNodes("团队信息", "tdxx");
            nodesName c = nNodes("团队个人)", "tdgr");
            nodesName[] child = new nodesName[] { a, c };
            publicRoot.setValues("食堂团队管理", "steam", child);
        }
        //权限管理节点
        static void qxCreat()
        {
            nodesName c = nNodes("子管理员列表", "zgl");
            nodesName[] child = new nodesName[] { c };
            publicRoot.setValues("权限管理", "qx", child);
        }
        /*动态添加子节点
         * 0-食材管理
         *1-菜品管理
         *2-食堂编辑
         *3-食堂团队管理
         *4-权限管理
         */
        public void addChildtree(TreeNode root,int orderIndex)
        {
            this.clearTree(root);
            
            switch (orderIndex)
            {
                case 0:
                    scglCreat();
                    addFun(root);
                    break;
                case 1:
                    cpglCreat();
                    addFun(root);
                    break;
                case 2:
                    stCreat();
                    addFun(root);
                    break;
                case 3:
                    steamCreat();
                    addFun(root);
                    break;
                case 4:
                    qxCreat();
                    addFun(root);
                    break;
               
            }
        }
        /*节点添加拓展方法*/
        public void addFun(TreeNode root)
        {
            if (publicRoot.znodes != null)
            {
                //TreeNode father = new TreeNode();
                root.Text = publicRoot.t;
                root.Name = publicRoot.n;
                FunDiGui(publicRoot.znodes, root);
                //root.Nodes.Add(father);
                //root = father;
            }
        }
        /* 递归调用遍历节点 */
        private void FunDiGui(nodesName[] c, TreeNode father)
        {
            if (c != null){
                int ind = c.Length;
                if (ind != 0)
                {
                    for (int i = 0; i < ind; i++)
                    {
                        TreeNode t = new TreeNode();
                        t.Name = c[i].n;
                        t.Text = c[i].t;
                        father.Nodes.Add(t);
                        FunDiGui(c[i].znodes , t);
                    }
                }
            }
        }
        //返回新生成的子节点
        public static nodesName nNodes(string n,string mark)
        {
            nodesName c = new nodesName();
            c.setValues(n, mark, null);
            return c;
        }
        /*删除某节点*/
        public void removeOneName(TreeNode root, TreeNode child)
        {
            root.Nodes.Remove(child);
        }

        /*删除特定的节点*/
        public void removeOneIndex(TreeNode root,int index)
        {
            root.Nodes.RemoveAt(index);
        }
        /*清空All节点*/
        public void clearTree(TreeNode root)
        {
            if(root != null || root.Nodes != null)
            {
                root.Nodes.Clear();
            }
        }
    }
}
