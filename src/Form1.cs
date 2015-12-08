//=============================================================================
// Copyright © 2010 Point Grey Research, Inc. All Rights Reserved.
//
// This software is the confidential and proprietary information of Point
// Grey Research, Inc. ("Confidential Information").  You shall not
// disclose such Confidential Information and shall use it only in
// accordance with the terms of the license agreement you entered into
// with PGR.
//
// PGR MAKES NO REPRESENTATIONS OR WARRANTIES ABOUT THE SUITABILITY OF THE
// SOFTWARE, EITHER EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE, OR NON-INFRINGEMENT. PGR SHALL NOT BE LIABLE FOR ANY DAMAGES
// SUFFERED BY LICENSEE AS A RESULT OF USING, MODIFYING OR DISTRIBUTING
// THIS SOFTWARE OR ITS DERIVATIVES.
//=============================================================================
//=============================================================================
// $Id: Form1.cs,v 1.4 2011-02-03 23:34:52 soowei Exp $
//=============================================================================

using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

using FlyCapture2Managed;
using FlyCapture2Managed.Gui;
using System.Drawing.Drawing2D;




namespace HeartBeatDetector
{
    public partial class Form1 : Form
    {
        private FlyCapture2Managed.Gui.CameraControlDialog m_camCtlDlg;
        private ManagedCameraBase m_camera = null;
        private ManagedImage m_rawImage;
        private ManagedImage m_processedImage;
        private bool m_grabImages;
        private AutoResetEvent m_grabThreadExited;
        private BackgroundWorker m_grabThread;
        Rectangle rect = new Rectangle();
        System.Drawing.Imaging.BitmapData newImageData  = new System.Drawing.Imaging.BitmapData();
        IntPtr  ptr =new IntPtr();
        Int32 bytes = new System.Int32();
        Byte[] rgbValues=new byte[2]; //we will then resize this array
        private Int32 sum = new System.Int32();
        private Int32 sumW = new System.Int32();
        private double  ave = new System.Double();
        private Int32 sumBackground = new System.Int32();
        private double aveBackground = new System.Double();
        private int aveSum = new System.Int32();
        private int pastAverage = new System.Int32();
        private int aveSumCopyForGraph = new System.Int32();
        private int aveSumPrevious = new System.Int32();
        private int aveSumCopy = new System.Int32();

        Boolean FakePulse = false;
        Int32 w= new System.Int32();
        Int32 h= new System.Int32();
        Int32 offset = new System.Int32();
        Int32 a = new System.Int32();
        Int32 b = new System.Int32();
        Int32 c = new System.Int32();
        Bitmap newimage =new System.Drawing.Bitmap(640,480);
        Bitmap newimageTEST = new System.Drawing.Bitmap(640, 480);
        Int32 My_count = new System.Int32( );
        Int32 My_hertz = new System.Int32();
        Stopwatch stopWatch = new Stopwatch();
        Stopwatch PulseStopWatch = new Stopwatch();
        TimeSpan ts;
        TimeSpan tsPulse;
        Rectangle cloneRect = new Rectangle(0, 0, 640, 480);
        Rectangle cloneRect2 = new Rectangle(0,0,640,480);
        Rectangle cloneRectBackground = new Rectangle(0, 0, 213, 160);
        Rectangle cloneRectBackground2 = new Rectangle(214, 160, 212, 160);
        Bitmap newimageBackground = new System.Drawing.Bitmap(213, 160);
        LockBitmap lockBitmap;
        Boolean ismax = false;
        int[] array = new int[] { 0, 0, 0,0,0 };
        int[] longarray = new int[30]; // a heart cycle is a about 10 points.
        int maxInterval = 1;
        int intervalSafetyPulse =2;
        string selection="(0,0)";
        string elapsedTime;
        string PulseElapsedTime;
        int TESTint = 0;
        int testCount = 0;
        string savepath = "C:\\PulseTrackerValues\\";
        //string savepath = "C:\\tmp\\SavedMaxima\\";
        int numSaved = 0;
        int saveCount = 0;
        int showCount = 0;
        int[] graphArray = new int[40];
        int[] graphMaxArray = new int[40];
        Boolean readyToRecordValues = false;

        public Form1()
        {
            InitializeComponent();

            m_rawImage = new ManagedImage();
            m_processedImage = new ManagedImage();
            m_camCtlDlg = new CameraControlDialog();

            m_grabThreadExited = new AutoResetEvent(false);

           
            
        }
        
       
        private void UpdateStatusBar()
        {

            String statusString;

            statusString = String.Format(
                "Image size: {0} x {1}",
                m_rawImage.cols,
                m_rawImage.rows);

            toolStripStatusLabelImageSize.Text = statusString;

            try
            {
                statusString = String.Format(
                "Requested frame rate: {0}Hz",
                m_camera.GetProperty(PropertyType.FrameRate).absValue);
            }
            catch (FC2Exception ex)
            {
                statusString = "Requested frame rate: 0.00Hz";
            }

            toolStripStatusLabelFrameRate.Text = statusString;

            toolStripStatusSelection.Text = selection;

            /*

           TimeStamp timestamp;

          lock (this)
           {
               timestamp = m_rawImage.timeStamp;
           }

           statusString = String.Format(
               "Timestamp: {0:000}.{1:0000}.{2:0000}",
               timestamp.cycleSeconds,
               timestamp.cycleCount,
               timestamp.cycleOffset);

           toolStripStatusLabelTimestamp.Text = statusString;*/
            statusStrip1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("VS2013");

            textBox1.Text = Properties.Settings.Default.mirrorAngleStep;
            textBox2.Text= Properties.Settings.Default.mirrorAngle;
            textBoxDCMotorTime.Text = Properties.Settings.Default.motorTime;
            textBoxDCMotor2Time.Text = Properties.Settings.Default.motor2Time;
            
            

            Directory.CreateDirectory(savepath);
            Directory.CreateDirectory(savepath + "\\SavedMaxima\\");
            PulseStopWatch.Start();

            comboBox1.Items.Clear();
            
            
            foreach (string item in System.IO.Ports.SerialPort.GetPortNames())
            {         
                comboBox1.Items.Add(item);
            }
            //comboBox1.SelectedItem = Properties.Settings.Default.myserialport;
            try
            {
                comboBox1.SelectedItem = comboBox1.Items[0];
            }
            catch
            {

            }


            My_count = 0;
            Hide();
            //CameraSelectionDialog camSlnDlg = new CameraSelectionDialog();
            //bool retVal = camSlnDlg.ShowModal();
            //if (retVal)
            if (true)
            {
                try
                {
                    //ManagedPGRGuid[] selectedGuids = camSlnDlg.GetSelectedCameraGuids();
                    //ManagedPGRGuid guidToUse = selectedGuids[0];

                    ManagedBusManager busMgr = new ManagedBusManager();
                    /*InterfaceType ifType = busMgr.GetInterfaceTypeFromGuid(guidToUse);         
                    if (ifType == InterfaceType.GigE)
                    {
                        m_camera = new ManagedGigECamera();
                    }
                    else
                    {
                        m_camera = new ManagedCamera();
                    }*/

                    m_camera = new ManagedCamera();

                    // Connect to the first selected GUID
                    //m_camera.Connect(guidToUse);
                    uint serial1 = busMgr.GetCameraSerialNumberFromIndex(0);
                    ManagedPGRGuid guid = busMgr.GetCameraFromSerialNumber(serial1);
                    m_camera.Connect(guid);
                    m_camCtlDlg.Connect(m_camera);

                    CameraInfo camInfo = m_camera.GetCameraInfo();
                    UpdateFormCaption(camInfo);

                    // Set embedded timestamp to on
                    EmbeddedImageInfo embeddedInfo = m_camera.GetEmbeddedImageInfo();
                    embeddedInfo.timestamp.onOff = true;
                    m_camera.SetEmbeddedImageInfo(embeddedInfo);

                    m_camera.StartCapture();

                    m_grabImages = true;

                    StartGrabLoop();
                }
                catch (FC2Exception ex)
                {
                    //MessageBox.Show("Camera not detected. Make sure you have connected a camera");
                    label14.Show();

                    Debug.WriteLine("Failed to load form successfully: " + ex.Message);
                   // Environment.ExitCode = -1;
                    //Application.Exit();
                    //return;
                }



                toolStripButtonStart.Enabled = false;
                toolStripButtonStop.Enabled = true;
            }
            else
            {
                Environment.ExitCode = -1;
                Application.Exit();
                return;
            }

            Show();

            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
           // chart1.ChartAreas[0].AxisY.
            //chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gray;
            //chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.Series[0].BorderWidth = 3;
            /*
            if (checkBoxGraph.Checked) { timerGraph.Start(); }
            else { timerGraph.Stop(); }*/
        }

        private void UpdateFormCaption(CameraInfo camInfo)
        {
            /*String captionString = String.Format(
                "FlyCapture2SimpleGUI_CSharp - {0} {1} ({2})",
                camInfo.vendorName,
                camInfo.modelName,
                camInfo.serialNumber);

            this.Text = captionString;*/

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                toolStripButtonStop_Click(sender, e);
                m_camera.Disconnect();
            }
            catch (FC2Exception ex)
            {
                // Nothing to do here
            }
            catch (NullReferenceException ex)
            {
                // Nothing to do here
            }
        }

        private void UpdateUI(object sender, ProgressChangedEventArgs e)
        {     
            //label5.Text = TESTint.ToString();
            UpdateStatusBar();
            label1.Text = aveSumPrevious.ToString();
            label1.Refresh();
            label2.Text = elapsedTime;
            label2.Refresh();
            if (checkBoxTestMode.Checked || checkBoxShow.Checked) pictureBox1.Image = newimageTEST;
            else
            {
                try
                {
                    pictureBox1.Image = m_processedImage.bitmap;
                }
                catch
                {

                }
            }


            if (ismax == true)
            {

                if (maxInterval == 1)
                {
                    if (checkBoxSendSignal.Checked)
                    {
                        arduinoPin("m");
                    }
                    buttonMax.BackColor = Color.Green;
                    maxInterval = (int)numericUpDown1.Value;
                    PulseStopWatch.Restart();
                }
                else maxInterval -= 1;

            }
            else
            {
                buttonMax.BackColor = SystemColors.Control;
            }
            buttonMax.Refresh();
            //this.Refresh();

            if (checkBox4sPulses.Checked)
            {
                tsPulse = PulseStopWatch.Elapsed;
                //elapsedTime = String.Format("{0:0.0}", (10 / tsPulse.TotalSeconds));  //hertz (10 images over their duration)
                PulseElapsedTime = String.Format("{0:0}.{1:0}", tsPulse.Seconds, tsPulse.Milliseconds / 100);
                TimeSinceMaxLabel.Text = PulseElapsedTime;
                TimeSinceMaxLabel.Refresh();
                if (tsPulse.Seconds >= intervalSafetyPulse)
                {
                    arduinoPin("m");
                    if (CheckBoxRecordValues.Checked) FakePulse = true;
                    PulseCountLabel.Text = Convert.ToString((Convert.ToInt32(PulseCountLabel.Text) + 1));
                    PulseStopWatch.Restart();
                }
            }
            if (checkBoxGraph.Checked )
            {
                myPlotGraph();
            }
            //MessageBox.Show("ok");
            
        }
        private void StartGrabLoop()


        {
            //cloneRect = new Rectangle(xa, ya, xb - xa, yb - ya);
            m_grabThread = new BackgroundWorker();
            m_grabThread.ProgressChanged += new ProgressChangedEventHandler(UpdateUI);
            m_grabThread.DoWork += new DoWorkEventHandler(GrabLoop);
            m_grabThread.WorkerReportsProgress = true;
            m_grabThread.RunWorkerAsync();
        }
        private void GrabLoop(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (m_grabImages)
            {             
                try
                {                 
                    m_camera.RetrieveBuffer(m_rawImage);

                }
                catch (FC2Exception ex)
                {
                    Debug.WriteLine("Error: " + ex.Message);
                    continue;
                }

                lock (this)
                {
                    m_rawImage.Convert(PixelFormat.PixelFormatBgr, m_processedImage);
                    //sum = sum + 1;               
                }
                                
                System.Drawing.Imaging.PixelFormat format =
                       m_processedImage.bitmap.PixelFormat;
                if (checkBoxTestMode.Checked && checkBoxShow.Checked==false)
                { 
                    label6.Text=(testCount.ToString("000"));
                    try {
                        newimageTEST = new Bitmap(savepath+"TestImages\\trimmed" + testCount.ToString("000") + ".bmp");
                        newimage = newimageTEST.Clone(cloneRect, format);
                    }
                    catch { stopCaptureLoop(); MessageBox.Show("Images not found"); }
                    testCount++;
                    if (testCount > 435) 
                    { 
                        testCount = 0;
                        CheckBoxRecordValues.Checked = false;
                    }

                                    
                }
                
                if (checkBoxShow.Checked)
                {
                    numSaved = Directory.GetFiles(savepath + "\\SavedMaxima", "*", SearchOption.TopDirectoryOnly).Length;
                    if (showCount < numSaved)
                    {
                        try
                        {
                            newimageTEST = new Bitmap(savepath + "\\SavedMaxima\\" + showCount.ToString("000") + ".bmp");
                            newimage = newimageTEST.Clone(cloneRect, format);
                        }
                        catch { stopCaptureLoop(); MessageBox.Show("Images not found: " + savepath + "\\SavedMaxima\\" + showCount.ToString("000") + ".bmp"); }
                        showCount++;
                    }
                    else showCount = 0;
                }
                if (checkBoxShow.Checked == false && checkBoxTestMode.Checked==false)
                {
                    newimage = m_processedImage.bitmap.Clone(cloneRect, format);
                }            

                lockBitmap = new LockBitmap(newimage);
                lockBitmap.LockBits();
                
                sum = 0;
                sumW=0;
                aveSumPrevious = aveSum;
                aveSum = 0;
                if (CheckBoxAlgorithm2.Checked)
                {
                    /* //this was the previous alternative algorithm 
                    for (int y = ya; y < yb; y = y + 1)
                    {
                        for (int x = xa; x < xb; x = x + 1)
                        {
                            sumW = sumW + (x - xa) * (lockBitmap.GetPixel(x, y).G + lockBitmap.GetPixel(x, y).R); //the .R selects the red component of the RGB color                         
                            sum = sum + (lockBitmap.GetPixel(x, y).G + lockBitmap.GetPixel(x, y).R);
                        }
                        aveSum = aveSum + Convert.ToInt32(1000*sumW / sum);
                    }
                    aveSum = aveSum / (yb - ya);
                    lockBitmap.UnlockBits();*/


                }
                else
                {               
                    for (int y = ya; y < yb; y=y+1)
                    {
                        for (int x = xa; x < xb; x=x+1)
                        {
                            sum = sum + (lockBitmap.GetPixel(x, y).G + lockBitmap.GetPixel(x, y).R); //the .R selects the red component of the RGB color                         
                        }
                    }
                    sumBackground = 0;     
                    if (checkBoxBackgroundCorrection.Checked){
                        for (int y = 160; y < 320; y = y + 3)
                        {
                            //TESTint = 0;
                            for (int x = 214; x < 426; x = x + 3)
                            {
                                // TESTint = TESTint + 1;
                                sumBackground = sumBackground + (lockBitmap.GetPixel(x, y).G + lockBitmap.GetPixel(x, y).R); //the .R selects the red component of the RGB color                         
                            }
                        }
                    }
                    
                    lockBitmap.UnlockBits();
                    if (((yb - ya) * (xb - xa)) != 0) ave = Convert.ToDouble(sum) / ((yb - ya) * (xb - xa));
                    if (checkBoxBackgroundCorrection.Checked)
                    {
                        aveBackground = Convert.ToDouble(sumBackground) / (54 * 71);
                    }
                    else { aveBackground = 1; }
                    
                    aveSum = Convert.ToInt32(((10000*ave / aveBackground) ));  
                }


                

                if (checkBoxMax.Checked)
                {
                    if (UseSensitiveAlgorithmCheckbox.Checked)
                    {
                        for (int i = 1; i < longarray.Length; i++) longarray[i - 1] = longarray[i];
                        longarray[longarray.Length-1] = aveSum;
                        pastAverage = Convert.ToInt32(longarray.Average());

                        if (radioButtonUp.Checked)
                        {
                            if ((aveSum > pastAverage) & (aveSumPrevious < pastAverage))
                            {
                                ismax = true;
                                if (checkBoxSaveMax.Checked)
                                {
                                    newimage.Save(savepath + "\\SavedMaxima\\" + saveCount.ToString("000") + ".bmp");
                                    saveCount++;
                                }
                            }
                            else ismax = false;
                        }
                        else if (radioButtonDown.Checked)
                        {
                            if ((aveSum < pastAverage) & (aveSumPrevious > pastAverage))
                            {
                                ismax = true;
                                if (checkBoxSaveMax.Checked)
                                {
                                    newimage.Save(savepath + "\\SavedMaxima\\" + saveCount.ToString("000") + ".bmp");
                                    saveCount++;
                                }
                            }
                            else ismax = false;
                        }
                        
                    }
                    else
                    {                  
                        array[0] = array[1];
                        array[1] = array[2];
                        array[2] = array[3];
                        array[3] = array[4];
                        array[4] = aveSum;
                        if (checkBoxTriggerOnMinimum.Checked)
                        {
                            if ((array[1] < array[0]) && (array[2] < array[1]) && (array[2] < array[3]) && (array[3] < array[4]))
                            {
                                ismax = true;
                                if (checkBoxSaveMax.Checked)
                                {
                                    newimage.Save(savepath + "\\SavedMaxima\\" + saveCount.ToString("000") + ".bmp");
                                    saveCount++;
                                }
                            }
                            else ismax = false;

                        }
                        else
                        {
                            if ((array[1] > array[0]) && (array[2] > array[1]) && (array[2] > array[3]) && (array[3] > array[4]))
                            {
                                ismax = true;
                                if (checkBoxSaveMax.Checked)
                                {
                                    newimage.Save(savepath + "\\SavedMaxima\\" + saveCount.ToString("000") + ".bmp");
                                    saveCount++;
                                }
                            }
                            else ismax = false;

                        }

                        
                    }
                }
                else ismax = false;

                if (readyToRecordValues)
                {
                    if (ismax)
                    {
                        if (CheckBoxAlgorithm2.Checked ) aveSumCopy = aveSum + 0;   //+1500; to highlight the max value in a graph.
                        else aveSumCopy = aveSum + 0; // 700;
                    }
                    else aveSumCopy = aveSum; 
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@savepath+"values.txt", true))
                    {
                        file.Write(aveSumCopy.ToString());
                        if (ismax) file.Write("\t1");
                        else file.Write("\t0");
                        if (FakePulse) 
                        {
                            file.WriteLine("\t1");
                            FakePulse = false;
                        }
                        else file.WriteLine("\t0");
                    }
                    /*using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\tmp\values2.txt", true))
                    {
                        file.WriteLine(array[0]+" " +array[1]+" " +array[2]+" " +array[3]+" " +array[4]);
                    }*/
                }
                     


                             
                if (My_count ==0) stopWatch.Start();
            
                My_count = My_count + 1;
                if (My_count > 10)
                {
                    My_count = 0;
                    stopWatch.Stop();
                    ts = stopWatch.Elapsed;
                    elapsedTime=String.Format("{0:0.0}", (10 / ts.TotalSeconds));  //hertz (10 images over their duration)
                    //elapsedTime = String.Format("{0:00}.{1:00}",ts.Seconds,ts.Milliseconds / 10);
                    stopWatch.Reset();         
                }
                Thread.Sleep(10);  //this sleep is neccessary, otherwise it gets close to 60fps and UpdateUI can't go that fast.
                worker.ReportProgress(0);                          
            }
            m_grabThreadExited.Set();
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            try
            {
                m_camera.StartCapture();
            }
            catch
            {
                //MessageBox.Show("Camera not detected. Make sure you have connected a camera");
            }
           

            m_grabImages = true;

            StartGrabLoop();

            toolStripButtonStart.Enabled = false;
            toolStripButtonStop.Enabled = true;
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            stopCaptureLoop();
        }

        private void stopCaptureLoop()
        {
            m_grabImages = false;

            try
            {
                m_camera.StopCapture();
            }
            catch (FC2Exception ex)
            {
                Debug.WriteLine("Failed to stop camera: " + ex.Message);
            }
            catch (NullReferenceException)
            {
                Debug.WriteLine("Camera is null");
            }

            toolStripButtonStart.Enabled = true;
            toolStripButtonStop.Enabled = false;
        }


        private void toolStripButtonCameraControl_Click(object sender, EventArgs e)
        {
            if (m_camCtlDlg.IsVisible())
            {
                m_camCtlDlg.Hide();
                toolStripButtonCameraControl.Checked = false;
            }
            else
            {
                m_camCtlDlg.Show();
                toolStripButtonCameraControl.Checked = true;
            }
        }

        private void OnNewCameraClick(object sender, EventArgs e)
        {
            if (m_grabImages == true)
            {
                toolStripButtonStop_Click(sender, e);
                m_camCtlDlg.Hide();
                m_camCtlDlg.Disconnect();
                m_camera.Disconnect();
            }
            
            Form1_Load(sender, e);
        }


        int xa=620;
        int xb=630;
        int ya=460;
        int yb=470;

        GraphicsPath myPath = new GraphicsPath();
        Boolean mouseisdown = false;
        
       
        
      

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("hi");
            xa = e.X;
            ya = e.Y;
            mouseisdown = true;
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {          
            if (mouseisdown)
            {        
                xb = e.X;
                yb = e.Y;
                cloneRect2 = new Rectangle(xa, ya, xb - xa, yb - ya);
                selection = "(" + xa.ToString() + "," + ya.ToString() + "),(" + (xb).ToString() + "," + (yb).ToString() + ")";
                //label6.Text = "(" + xa.ToString() + "," + ya.ToString() + "),(" + (xb).ToString() + "," + (yb).ToString() + ")";
                
                
                //myPath.AddRectangle(cloneRect);
                pictureBox1.Invalidate();  
            }
        }

        private void arduinoPin(string value)
        {
            try {
                serialPort1.Close();
                serialPort1.Open();
                Thread.Sleep(100);
                serialPort1.Write(value);

            }
            catch {
                //stopCaptureLoop();
                //MessageBox.Show("Arduino Board not detected. It either has been disconnected or you have selected the wrong com port!");
                label10.Show();
            }
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseisdown = false;
            xb = e.X;
            yb = e.Y;
            //label6.Text = "(" + xa.ToString() + "," + ya.ToString() + "),(" + (xb).ToString() + "," + (yb).ToString() + ")";
            //myPath.AddRectangle(cloneRect);
            //cloneRect2 = new Rectangle(xa, ya, xb - xa, yb - ya);
            //pictureBox1.Invalidate();
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Green, cloneRect2);
            if (NormalizationBoxCheckbox.Checked) e.Graphics.DrawRectangle(Pens.Blue, cloneRectBackground2); 
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            arduinoPin("m");
            buttonMax.BackColor = Color.Green;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.myserialport = comboBox1.SelectedItem.ToString();         
            Properties.Settings.Default.Save();
            try
            {
                serialPort1.Close();
            }
            catch { }
            serialPort1.PortName = Properties.Settings.Default.myserialport;
            try
            {
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("Wrong Com Port");
            }           
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            maxInterval = (int)numericUpDown1.Value;
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            showCount = 0;
        }

        private void checkBoxSaveMax_CheckedChanged(object sender, EventArgs e)
        {
            saveCount = 0;
        }

        private void checkBoxTestMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTestMode.Checked) 
            {
                testCount = 0;
            }



        }

        private void CheckBoxRecordValues_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxRecordValues.Checked)
            {
                //if (checkBoxTestMode.Checked)
                //{
                    testCount = 0;
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@savepath+"values.txt", false))
                    {
                        file.WriteLine("VALUES\tPULSE\tFAKE\t"+DateTime.Now);
                    }
                    /*using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\tmp\values2.txt", false))
                    {
                        file.Write("");
                    }*/
                    readyToRecordValues = true;
                //}
            }
            else readyToRecordValues = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xa = 323;
            ya = 146;

            xb = 364;
            yb = 180;
            cloneRect2 = new Rectangle(xa, ya, xb - xa, yb - ya);
            selection = "(" + xa.ToString() + "," + ya.ToString() + "),(" + (xb).ToString() + "," + (yb).ToString() + ")";
            //label6.Text = "(" + xa.ToString() + "," + ya.ToString() + "),(" + (xb).ToString() + "," + (yb).ToString() + ")";


            //myPath.AddRectangle(cloneRect);
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xa = 2;
            ya = 2;

            xb = 630;
            yb = 150;
            cloneRect2 = new Rectangle(xa, ya, xb - xa, yb - ya);
            selection = "(" + xa.ToString() + "," + ya.ToString() + "),(" + (xb).ToString() + "," + (yb).ToString() + ")";
            //label6.Text = "(" + xa.ToString() + "," + ya.ToString() + "),(" + (xb).ToString() + "," + (yb).ToString() + ")";


            //myPath.AddRectangle(cloneRect);
            pictureBox1.Invalidate();
        }

        private void checkBox4sPulses_CheckedChanged(object sender, EventArgs e)
        {
        
        }      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                intervalSafetyPulse = Convert.ToInt32(textBoxPulseInterval.Text);
            }
            catch { }
        }  

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles(@savepath + "\\SavedMaxima");
            foreach (string filePath in filePaths)
                File.Delete(filePath);
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start(savepath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PulseCountLabel.Text = "0";
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            float newvalue = Convert.ToSingle(textBox2.Text) + Convert.ToSingle(textBox1.Text);
            if ((newvalue>=3)&&(newvalue<167)){
                textBox2.Text = Convert.ToString(newvalue);
                arduinoPin("zf" + textBox2.Text);
            }          
        }
       
        private void button6_Click(object sender, EventArgs e)
        {
            float newvalue = Convert.ToSingle(textBox2.Text) - Convert.ToSingle(textBox1.Text);
            if ((newvalue >= 3) && (newvalue < 167))            {
                textBox2.Text = Convert.ToString(newvalue);
                arduinoPin("zb" + textBox2.Text);
            }    
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.mirrorAngleStep = textBox1.Text;
                Properties.Settings.Default.Save();
            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            float newvalue = Convert.ToSingle(textBox2.Text);
            if ((newvalue >= 3) && (newvalue < 167))
            {
                //textBox2.Text = Convert.ToString(newvalue);
                arduinoPin("zb" + textBox2.Text);
            }    

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //arduinoPin("g" +"b" + textBox2.Text);
            arduinoPin("t" + "b" + textBoxDCMotorTime.Text);
            
            
            //timerDCMotor.Interval = Convert.ToInt32(textBoxDCMotorTime.Text) * 1;      
            //timerDCMotor.Start();
           
            
            //System.Threading.Thread.Sleep(Convert.ToInt32(textBoxDCMotorTime.Text));
            //stopDCMotor();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            arduinoPin("t" + "f" + textBoxDCMotorTime.Text);


            //timerDCMotor.Interval = Convert.ToInt32(textBoxDCMotorTime.Text)  * 1;
            //timerDCMotor.Start();



            //System.Threading.Thread.Sleep(Convert.ToInt32(textBoxDCMotorTime.Text));
            //stopDCMotor();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            stopDCMotor();
        }

        private void stopDCMotor()
        {
            arduinoPin("s" + "s" + textBox2.Text);
        }

        private void timerDCMotor_Tick(object sender, EventArgs e)
        {
            timerDCMotor.Stop();
            stopDCMotor();
        }


        private void plotMyGraph()
        {
            Array.Copy(graphArray, 1, graphArray, 0, graphArray.Length - 1);
            Array.Copy(graphMaxArray, 1, graphMaxArray, 0, graphMaxArray.Length - 1);
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
            for (int i = 0; i < graphArray.Length; i++)
            {
                chart1.Series["Series1"].Points.AddY(graphArray[i]);
                chart1.Series["Series2"].Points.AddY(graphMaxArray[i]);
            }
            chart1.ChartAreas[0].AxisY.Minimum = Convert.ToInt32(graphArray.Average()* 5/ 6);
            

        }

        private void myPlotGraph()
        {

            if (aveSum == 0)
            { //I'm not sure why this is necessary to avoid 0 showing up sometimes in the graph.
                aveSum = aveSumCopyForGraph;
                //MessageBox.Show(aveSumCopy.ToString()); 
            }
            graphArray[graphArray.Length - 1] = aveSum;
            if (ismax)
            {
                graphMaxArray[graphMaxArray.Length - 3] = aveSum;
                //MessageBox.Show("m");
            }


            plotMyGraph();
            aveSumCopyForGraph = aveSum;
        }

        private void timerGraph_Tick(object sender, EventArgs e)
        {

            if (aveSum ==0) { //I'm not sure why this is necessary to avoid 0 showing up sometimes in the graph.
                aveSum=aveSumCopyForGraph;
                //MessageBox.Show(aveSumCopy.ToString()); 
            }
            graphArray[graphArray.Length-1] = aveSum;
            if (ismax) {
                graphMaxArray[graphMaxArray.Length - 3] = aveSum;
                //MessageBox.Show("m");
            }
            

            plotMyGraph();
            aveSumCopyForGraph = aveSum;
        }

        private void checkBoxGraph_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (checkBoxGraph.Checked) { timerGraph.Start(); }
            else { timerGraph.Stop(); }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.mirrorAngle = textBox2.Text;
                Properties.Settings.Default.Save();
            }
            catch { }
        }

        private void textBoxDCMotorTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.motorTime = textBoxDCMotorTime.Text;
                Properties.Settings.Default.Save();
            }
            catch { }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            arduinoPin("p" + "f" + textBoxDCMotor2Time.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            arduinoPin("p" + "b" + textBoxDCMotor2Time.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stopDCMotor();
        }

        private void textBoxDCMotor2Time_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.motor2Time = textBoxDCMotor2Time.Text;
                Properties.Settings.Default.Save();
            }
            catch { }
        }

     


        


        

    
        // MessageBox.Show("hi");
        //Region myRegion = new Region(myPath);
        //e.Graphics.DrawRectangle(Pens.Black, cloneRect2);
    }



   

    public class LockBitmap
    {
        Bitmap source = null;
        IntPtr Iptr = IntPtr.Zero;
        System.Drawing.Imaging.BitmapData bitmapData = null;

        public byte[] Pixels { get; set; }
        public int Depth { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public LockBitmap(Bitmap source)
        {
            this.source = source;
        }

        /// <summary>
        /// Lock bitmap data
        /// </summary>
        public void LockBits()
        {
            try
            {
                // Get width and height of bitmap
                Width = source.Width;
                Height = source.Height;

                // get total locked pixels count
                int PixelCount = Width * Height;

                // Create rectangle to lock
                Rectangle rect = new Rectangle(0, 0, Width, Height);

                // get source bitmap pixel format size
                Depth = System.Drawing.Bitmap.GetPixelFormatSize(source.PixelFormat);

                // Check if bpp (Bits Per Pixel) is 8, 24, or 32
                if (Depth != 8 && Depth != 24 && Depth != 32)
                {
                    throw new ArgumentException("Only 8, 24 and 32 bpp images are supported.");
                }

                // Lock bitmap and return bitmap data
                bitmapData = source.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                                             source.PixelFormat);

                // create byte array to copy pixel values
                int step = Depth / 8;
                Pixels = new byte[PixelCount * step];
                Iptr = bitmapData.Scan0;

                // Copy data from pointer to array
                System.Runtime.InteropServices.Marshal.Copy(Iptr, Pixels, 0, Pixels.Length);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Unlock bitmap data
        /// </summary>
        public void UnlockBits()
        {
            try
            {
                // Copy data from byte array to pointer
                System.Runtime.InteropServices.Marshal.Copy(Pixels, 0, Iptr, Pixels.Length);

                // Unlock bitmap data
                source.UnlockBits(bitmapData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get the color of the specified pixel
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Color GetPixel(int x, int y)
        {
            Color clr = Color.Empty;

            // Get color components count
            int cCount = Depth / 8;

            // Get start index of the specified pixel
            int i = ((y * Width) + x) * cCount;

            if (i > Pixels.Length - cCount)
                throw new IndexOutOfRangeException();

            if (Depth == 32) // For 32 bpp get Red, Green, Blue and Alpha
            {
                byte b = Pixels[i];
                byte g = Pixels[i + 1];
                byte r = Pixels[i + 2];
                byte a = Pixels[i + 3]; // a
                clr = Color.FromArgb(a, r, g, b);
            }
            if (Depth == 24) // For 24 bpp get Red, Green and Blue
            {
                byte b = Pixels[i];
                byte g = Pixels[i + 1];
                byte r = Pixels[i + 2];
                clr = Color.FromArgb(r, g, b);
            }
            if (Depth == 8)
            // For 8 bpp get color value (Red, Green and Blue values are the same)
            {
                byte c = Pixels[i];
                clr = Color.FromArgb(c, c, c);
            }
            return clr;
        }

        /// <summary>
        /// Set the color of the specified pixel
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        public void SetPixel(int x, int y, Color color)
        {
            // Get color components count
            int cCount = Depth / 8;

            // Get start index of the specified pixel
            int i = ((y * Width) + x) * cCount;

            if (Depth == 32) // For 32 bpp set Red, Green, Blue and Alpha
            {
                Pixels[i] = color.B;
                Pixels[i + 1] = color.G;
                Pixels[i + 2] = color.R;
                Pixels[i + 3] = color.A;
            }
            if (Depth == 24) // For 24 bpp set Red, Green and Blue
            {
                Pixels[i] = color.B;
                Pixels[i + 1] = color.G;
                Pixels[i + 2] = color.R;
            }
            if (Depth == 8)
            // For 8 bpp set color value (Red, Green and Blue values are the same)
            {
                Pixels[i] = color.B;
            }
        }
    }
}

//=============================================================================
// $Log: not supported by cvs2svn $
// Revision 1.3  2011/02/02 17:52:47  soowei
// [1] Handle grab errors in the grab loop
//
// Revision 1.2  2011/02/02 01:20:16  soowei
// [1] Add some more information to GUI
//
// Revision 1.1  2011/02/01 23:10:35  soowei
// [1] Adding FlyCapture2SimpleGUI_CSharp example
//
//=============================================================================
