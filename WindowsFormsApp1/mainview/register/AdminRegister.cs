using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.sqlOperating;
using WindowsFormsApp1.tools;

namespace WindowsFormsApp1.mainview.register
{
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //载入默认头像
        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + HexStringToString(result, System.Text.Encoding.UTF8));
            Console.WriteLine(StringToHexString(@"..\..\Resources\t01eae069596685b82f.webp.jpg", System.Text.Encoding.UTF8));
            ImgSetRound();
        }
        //头像框设置成圆形
        private void ImgSetRound()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBox1.ClientRectangle);
            Region region = new Region(gp);
            pictureBox1.Region = region;
            gp.Dispose();
            region.Dispose();
        }
        //更换头像
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择头像";
            dialog.Filter = "图像文件(*.jpg;*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                variable.portraitUrlFile = dialog.FileName;
                pictureBox1.Image = Image.FromFile(variable.portraitUrlFile);
                //Console.WriteLine(StringToHexString(portraitUrlFile, System.Text.Encoding.UTF8));
                //MySqlCommand cmd1 = new MySqlCommand("update textimg set img='" + StringToHexString(file, System.Text.Encoding.UTF8) + "' where id=1", variable.conn);
                //MySqlCommand cmd1 = new MySqlCommand("insert into textimg(id,img) values(2,'"+ StringToHexString(file, System.Text.Encoding.UTF8) + "')", variable.conn);
                //cmd1.ExecuteNonQuery();
            }
        }
        //字符串转换成16进制数
        private string StringToHexString(string s, Encoding encode)
        {
            byte[] b = encode.GetBytes(s);//按照指定编码将string编程字节数组
            string result = string.Empty;
            for (int i = 0; i < b.Length; i++)//逐字节变为16进制字符
            {
                result += Convert.ToString(b[i], 16);
            }
            return result;
        }
        //16进制数转换成字符串
        private string HexStringToString(string hs, Encoding encode)
        {
            string strTemp = "";
            byte[] b = new byte[hs.Length / 2];
            for (int i = 0; i < hs.Length / 2; i++)
            {
                strTemp = hs.Substring(i * 2, 2);
                b[i] = Convert.ToByte(strTemp, 16);
            }
            //按照指定编码将字节数组变为字符串
            return encode.GetString(b);
        }
        //名称设置(聚焦）
        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (!variable.textboxHasText1)
                textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }
        //名称设置（失去聚焦）
        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "请输入名称";
                textBox1.ForeColor = Color.LightGray;
                variable.textboxHasText1 = false;
                variable.state = false;
                label8.Visible = false;
            }
            else
            {
                if (Verification.HasChinese(textBox1.Text))
                {
                    variable.textboxHasText1 = true;
                    label8.Text = "中文不可输入";
                    label8.Visible = true;
                }
                else
                {
                    label8.Visible = false;
                    label8.Text = "";
                    variable.textboxHasText1 = true;

                    MySqlDataReader result = DbSQLHelper.searchRepeat(textBox1.Text);

                    if (result.Read() == true)
                    {
                        label8.Text = "名称已注册";
                        label8.Visible = true;
                        variable.state = false;
                    }
                    else if (textBox1.TextLength < 4 )
                    {
                        label8.Text = "请输入正确的名称";
                        label8.Visible = true;
                        variable.state = false;
                    }
                    else
                    {
                        label8.Visible = false;
                        variable.state = true;
                    }
                    result.Close();
                }
            }
            DbSQLHelper.closeSql();
        }
        //用户名不能包含中文
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        //密码设置(聚焦）
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (!variable.textboxHasText4)
                textBox4.Text = "";

            textBox4.ForeColor = Color.Black;
        }
        //密码设置（失去聚焦）
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.PasswordChar = '\0';
                textBox4.ForeColor = Color.LightGray;
                variable.textboxHasText4 = false;
                variable.state = false;
                label11.Visible = false;
            }
            else
            {

                Regex regex = new Regex(@"(?=.*[0-9])(?=.*[a-z,A-Z]).{6,15}");

                if (regex.IsMatch(textBox4.Text) == false)
                {
                    label11.Visible = true;
                    variable.state = false;
                }
                else
                {
                    variable.textboxHasText4 = true;
                    label11.Visible = false;
                    variable.state = true;
                }
            }
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)//隐藏密码
        {
            textBox4.PasswordChar = '*';
        }
        private void textBox5_Enter(object sender, EventArgs e)//确认密码设置(聚焦）
        {
            if (variable.textboxHasText5 == false)
                textBox5.Text = "";

            textBox5.ForeColor = Color.Black;
        }

        private void textBox5_Leave(object sender, EventArgs e)//确认密码设置（失去聚焦）
        {
            if (textBox5.Text == "")
            {
                textBox5.PasswordChar = '\0';
                textBox5.Text = "请再次输入密码";
                textBox5.ForeColor = Color.LightGray;
                variable.textboxHasText5 = false;
                variable.state = false;
                label6.Visible = false;
            }
            else
            {
                variable.textboxHasText5 = true;

                if (textBox5.Text != textBox4.Text && variable.textboxHasText5 == true)
                {
                    this.label6.Visible = true;
                    variable.state = false;
                }
                else
                {
                    this.label6.Visible = false;
                    variable.state = true;
                }
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)//隐藏密码
        {
            textBox5.PasswordChar = '*';
        }
        private void button1_Click_1(object sender, EventArgs e)//注册按键
        {
            if (!variable.state)
                MessageBox.Show("请正确填写信息");
            else
            {
                DbSQLHelper.register (textBox1.Text,textBox5.Text);
                Close();
            }
        }

       
    }
    public static class variable//设置全局变量
    {
        public static Boolean textboxHasText1 = false;
        public static Boolean textboxHasText4 = false;
        public static Boolean textboxHasText5 = false;
        public static Boolean state = false;//判断输入是否正确
        public static string portraitUrlFile;
    }
}
