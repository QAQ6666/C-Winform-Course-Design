using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using WindowsFormsApp1.sqlOperating;
using WindowsFormsApp1.tools;
using ZXing;


namespace WindowsFormsApp1
{

    
    public partial class scanQRCode : Form
    {
        private UserLogin user;
        int i = 0;
        VideoCaptureDevice videoSource;
        public scanQRCode(UserLogin userLogin )
        {
            user = userLogin;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilterInfoCollection videoDevices;
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                //可以做出处理
            }
            try
            {
                  videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);

                videoSourcePlayer1.VideoSource = videoSource;
                videoSourcePlayer1.Start();

                System.Threading.Thread.Sleep(2000); //毫秒
                while (true)
                {
                    //创建图像对象
                    Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
                    //定义图片路径
                    string filename = "jietu" + i + ".jpg";
                    //创建图片
                    bitmap.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Console.WriteLine(bitmap);
                    //QRCodeDecoder decoder = new QRCodeDecoder();
                    //System.Threading.Thread.Sleep(1000); //毫秒
                    //String decodedString = decoder.decode(new QRCodeBitmapImage(new Bitmap(filename)));
                    //Console.WriteLine(decodedString);
                    BarcodeReader reader = new BarcodeReader();
                    reader.Options.CharacterSet = "UTF-8";
                    var result = reader.Decode(new Bitmap(filename));
                    i++;
                    if (i == 20)
                    {
                        Console.WriteLine("未能识别二维码！！！");
                        Environment.Exit(0);
                    }
                    if (result != null)
                    {
                        string str =  result.ToString();
                        Console.WriteLine(result);
                        string[] ContentLines = str.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries); //忽略空行
                        int i = 0;
                        string userin = "";
                        string pwdin = ""; 
                        foreach (string s in ContentLines)
                        {
                            ++i;
                            if (i == 1)
                            {
                                userin = s;
                            }
                            else
                            {
                                pwdin = s;
                            }
                        }
                        int rows = DbSQLHelper.rowQuery(userin, pwdin);
                        if (rows == 1)
                        {
                            UserSession.setAll(userin, "ROOT", DateTime.Now.ToString());
                            MesShow.ms("登录成功");
                            this.Close();
                            user.Close();
                            /* 方式二: */
                            SystemManagementView systemManagementView = new SystemManagementView();
                            Thread th = new Thread(delegate () { systemManagementView.ShowDialog(); });
                            th.Start();
                        }
                        else
                        {
                            MesShow.ms("登录失败，输入错误");
                        }
                        videoSource.SignalToStop();
                        videoSource.WaitForStop();
                        Environment.Exit(0);

                    }
                    else
                    {
                        System.Threading.Thread.Sleep(1000); //毫秒
                    }
                }
                //创建图像对象


                //videoSource.SignalToStop();
                //videoSource.WaitForStop();
            }
            catch (ArgumentOutOfRangeException)
            {
                MesShow.ms("找不到摄像头设备");
            }
            

        }
    }
}

