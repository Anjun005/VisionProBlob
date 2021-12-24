using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using System.IO;

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Math;
using AForge.Controls;

//copyright @ Jiang.Anjun
namespace WebCam
{
    internal class Cam
    {
        public FilterInfoCollection videoDevices; //摄像头设备
        public VideoCaptureDevice videoSource;   //视频的来源选择
        public VideoSourcePlayer videoSourcePlayer;  //AForge控制控件 
        public string resolutionSize;  //0425
        /// <summary>
        /// 构造函数
        /// </summary>
        public  Cam(int camIndex)
        {
            videoSource = new VideoCaptureDevice();
            videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            //设置视频来源
            try
            {
                // 枚举所有视频输入设备
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();  //没有找到摄像头设备
                videoSource = new VideoCaptureDevice(videoDevices[camIndex].MonikerString);

                //cBoxCam = new ComboBox();
                //foreach (FilterInfo device in videoDevices)
                //{
                //    cBoxCam.Items.Add(device.Name);
                //    camList.Add(device.Name);
                //}
                //cBoxCam.SelectedIndex = 1; //第二个Cam;
                //this.comboBox_camera.SelectedIndex = 0;  //注释掉，选择摄像头来源的时候才会才会触发显示摄像头信息
            }
            catch (ApplicationException)
            {
                videoDevices = null;
                MessageBox.Show("没有找到摄像头设备", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Close video source if it is running
        public void CloseCurrentVideoSource()
        {
            if (videoSourcePlayer.VideoSource != null)
            {
                videoSourcePlayer.SignalToStop();

                // wait ~ 3 seconds
                for (int i = 0; i < 30; i++)
                {
                    if (!videoSourcePlayer.IsRunning)
                        break;
                    System.Threading.Thread.Sleep(100);
                }

                if (videoSourcePlayer.IsRunning)
                {
                    videoSourcePlayer.Stop();
                }

                videoSourcePlayer.VideoSource = null;
            }
        }


        public void SourceStart()
        {
       
            videoSource.Start();
            CloseCurrentVideoSource();           

            videoSource.VideoResolution = videoSource.VideoCapabilities[0];
            string strWidth = videoSource.VideoResolution.FrameSize.Width.ToString();
            string strHeight = videoSource.VideoResolution.FrameSize.Height.ToString();
            resolutionSize = strWidth + "*" + strHeight;

        }

    }
}
