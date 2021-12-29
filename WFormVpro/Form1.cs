using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.ImageProcessing;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.Dimensioning;
using Cognex.VisionPro.ToolGroup;
using Cognex.VisionPro.Comm;
using Cognex.VisionPro.ApplicationWizard;
using Cognex.VisionPro.QuickBuild;
using Cognex.VisionPro.Blob;

using WebCam;
using AForge.Video.DirectShow;

namespace WFormVpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] imgByte;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK)
            {
                imgByte = SaveImage(opd.FileName);
            }
        }
        /// <summary>
        /// 将图片以二进制流形式返回
        /// </summary>
        /// <param name = "path" ></ param >
        /// < returns ></ returns >
        public byte[] SaveImage(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imgBytesIn = br.ReadBytes((int)fs.Length);
            return imgBytesIn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromStream(new MemoryStream(imgByte));
        }

        CogJobManager jobmanager;
        private void button3_Click(object sender, EventArgs e)
        {
            CogToolGroup tgp = jobmanager.Job(0).VisionTool as CogToolGroup;
            CogBlobTool bt = tgp.Tools["CogBlobTool1"] as CogBlobTool;
            
            Bitmap bmp = new Bitmap(new MemoryStream(imgByte));//将图像数组转换为位图
           
            CogImage8Grey cogimg = new CogImage8Grey(bmp); //将位图转换为CogImage8Grey图像
            bt.InputImage = cogimg;
            
            bt.Run();//运行visionPro工具测试
            ICogRecord myrdp = tgp.CreateLastRunRecord();
            //MessageBox.Show(bt.Results.GetBlobs().Count.ToString());
            labCt.Text = bt.Results.GetBlobs().Count.ToString();
            labCt.Text = bt.Results.GetBlobs().Count.ToString();

            cogRecordDisplay1.Record = myrdp.SubRecords[1];
            cogRecordDisplay1.AutoFit = true;
        }

        string jobPath;
        private void Form1_Load(object sender, EventArgs e)
        {
            //jobPath = Application.StartupPath;
            //jobmanager = CogSerializer.LoadObjectFromFile(jobPath + @"\QB1.vpp") as CogJobManager;           
            DirectoryInfo info = new DirectoryInfo(Application.StartupPath);
            string strVppPath = info.Parent.Parent.FullName + @"\AForgeDllvpp\QB1.vpp";
            jobmanager = CogSerializer.LoadObjectFromFile(strVppPath) as CogJobManager;
        }


        Cam myCam;
        private void BtnLive_Click(object sender, EventArgs e)
        {
            myCam = new Cam(0);
            myCam.SourceStart();
            
            videoSourcePlayer1.VideoSource = myCam.videoSource;
            videoSourcePlayer1.Start();
            videoSourcePlayer1.VideoSource = myCam.videoSource;

        }

        Bitmap bitmap;
        private void BtnSnap_Click(object sender, EventArgs e)
        {
            bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
            pictureBox1.Image = bitmap;
        }

        private void BtnDealBlob_Click(object sender, EventArgs e)
        {
            CogImage8Grey image8 = new CogImage8Grey(bitmap);
            cogRecordDisplay1.Image = image8;

            CogToolGroup tgp = jobmanager.Job(0).VisionTool as CogToolGroup;
            CogBlobTool bt = tgp.Tools["CogBlobTool1"] as CogBlobTool;
            bt.InputImage = image8;

            bt.Run();//运行visionPro工具测试
            ICogRecord myrdp = tgp.CreateLastRunRecord();
            //MessageBox.Show(bt.Results.GetBlobs().Count.ToString());
            cogRecordDisplay1.Record = myrdp.SubRecords[1];
            cogRecordDisplay1.AutoFit = true;

        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            myCam.CloseCurrentVideoSource();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCam.CloseCurrentVideoSource();
            
        }
    }
}
