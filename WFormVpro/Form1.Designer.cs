
namespace WFormVpro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.BtnDealBlob = new System.Windows.Forms.Button();
            this.BtnLive = new System.Windows.Forms.Button();
            this.BtnSnap = new System.Windows.Forms.Button();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.labCt = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "读入图像";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "数组转图像";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "cognex";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(474, 86);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(350, 352);
            this.cogRecordDisplay1.TabIndex = 13;
            // 
            // BtnDealBlob
            // 
            this.BtnDealBlob.Location = new System.Drawing.Point(704, 47);
            this.BtnDealBlob.Name = "BtnDealBlob";
            this.BtnDealBlob.Size = new System.Drawing.Size(66, 27);
            this.BtnDealBlob.TabIndex = 2;
            this.BtnDealBlob.Text = "cogBlob";
            this.BtnDealBlob.UseVisualStyleBackColor = true;
            this.BtnDealBlob.Click += new System.EventHandler(this.BtnDealBlob_Click);
            // 
            // BtnLive
            // 
            this.BtnLive.Location = new System.Drawing.Point(581, 14);
            this.BtnLive.Name = "BtnLive";
            this.BtnLive.Size = new System.Drawing.Size(61, 23);
            this.BtnLive.TabIndex = 14;
            this.BtnLive.Text = "建立";
            this.BtnLive.UseVisualStyleBackColor = true;
            this.BtnLive.Click += new System.EventHandler(this.BtnLive_Click);
            // 
            // BtnSnap
            // 
            this.BtnSnap.Location = new System.Drawing.Point(704, 16);
            this.BtnSnap.Name = "BtnSnap";
            this.BtnSnap.Size = new System.Drawing.Size(66, 21);
            this.BtnSnap.TabIndex = 15;
            this.BtnSnap.Text = "采图";
            this.BtnSnap.UseVisualStyleBackColor = true;
            this.BtnSnap.Click += new System.EventHandler(this.BtnSnap_Click);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.videoSourcePlayer1.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(474, 9);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(71, 58);
            this.videoSourcePlayer1.TabIndex = 16;
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(648, 14);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(50, 23);
            this.BtnDisconnect.TabIndex = 17;
            this.BtnDisconnect.Text = "断开";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // labCt
            // 
            this.labCt.AutoSize = true;
            this.labCt.Location = new System.Drawing.Point(385, 64);
            this.labCt.Name = "labCt";
            this.labCt.Size = new System.Drawing.Size(35, 13);
            this.labCt.TabIndex = 18;
            this.labCt.Text = "label1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(251, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 30);
            this.button4.TabIndex = 19;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.labCt);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.BtnSnap);
            this.Controls.Add(this.BtnLive);
            this.Controls.Add(this.cogRecordDisplay1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnDealBlob);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private System.Windows.Forms.Button BtnDealBlob;
        private System.Windows.Forms.Button BtnLive;
        private System.Windows.Forms.Button BtnSnap;
        public AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Label labCt;
        private System.Windows.Forms.Button button4;
    }
}

