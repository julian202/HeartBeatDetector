namespace HeartBeatDetector
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCameraControl = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFrameRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTimestamp = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSelection = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxTriggerOnMinimum = new System.Windows.Forms.CheckBox();
            this.checkBoxBackgroundCorrection = new System.Windows.Forms.CheckBox();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.UseSensitiveAlgorithmCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxDCMotor2Time = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBoxDCMotorTime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxGraph = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.NormalizationBoxCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CheckBoxRecordValues = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveMax = new System.Windows.Forms.CheckBox();
            this.OpenFolderButton = new System.Windows.Forms.Button();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4sPulses = new System.Windows.Forms.CheckBox();
            this.textBoxPulseInterval = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.PulseCountLabel = new System.Windows.Forms.Label();
            this.TimeSinceMaxLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckBoxAlgorithm2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMax = new System.Windows.Forms.Button();
            this.checkBoxMax = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.checkBoxSendSignal = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxTestMode = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timerDCMotor = new System.Windows.Forms.Timer(this.components);
            this.timerGraph = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.toolStripSeparator1,
            this.toolStripButtonCameraControl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1131, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStart.Text = "Play";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCameraControl
            // 
            this.toolStripButtonCameraControl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCameraControl.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCameraControl.Image")));
            this.toolStripButtonCameraControl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCameraControl.Name = "toolStripButtonCameraControl";
            this.toolStripButtonCameraControl.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCameraControl.Text = "Controls";
            this.toolStripButtonCameraControl.Click += new System.EventHandler(this.toolStripButtonCameraControl_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelImageSize,
            this.toolStripStatusLabelFrameRate,
            this.toolStripStatusLabelTimestamp,
            this.toolStripStatusLabel1,
            this.toolStripStatusSelection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1131, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelImageSize
            // 
            this.toolStripStatusLabelImageSize.Name = "toolStripStatusLabelImageSize";
            this.toolStripStatusLabelImageSize.Size = new System.Drawing.Size(24, 17);
            this.toolStripStatusLabelImageSize.Text = "0x0";
            // 
            // toolStripStatusLabelFrameRate
            // 
            this.toolStripStatusLabelFrameRate.Name = "toolStripStatusLabelFrameRate";
            this.toolStripStatusLabelFrameRate.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelFrameRate.Text = "0.00Hz";
            // 
            // toolStripStatusLabelTimestamp
            // 
            this.toolStripStatusLabelTimestamp.Name = "toolStripStatusLabelTimestamp";
            this.toolStripStatusLabelTimestamp.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabelTimestamp.Text = "-";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel1.Text = "Selection:";
            // 
            // toolStripStatusSelection
            // 
            this.toolStripStatusSelection.Name = "toolStripStatusSelection";
            this.toolStripStatusSelection.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusSelection.Text = "(0,0)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCameraToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCameraToolStripMenuItem
            // 
            this.newCameraToolStripMenuItem.Name = "newCameraToolStripMenuItem";
            this.newCameraToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newCameraToolStripMenuItem.Text = "New camera";
            this.newCameraToolStripMenuItem.Click += new System.EventHandler(this.OnNewCameraClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(137, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.checkBoxTriggerOnMinimum);
            this.panel1.Controls.Add(this.checkBoxBackgroundCorrection);
            this.panel1.Controls.Add(this.radioButtonDown);
            this.panel1.Controls.Add(this.radioButtonUp);
            this.panel1.Controls.Add(this.UseSensitiveAlgorithmCheckbox);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.checkBoxGraph);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.NormalizationBoxCheckbox);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CheckBoxAlgorithm2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 496);
            this.panel1.TabIndex = 3;
            // 
            // checkBoxTriggerOnMinimum
            // 
            this.checkBoxTriggerOnMinimum.AutoSize = true;
            this.checkBoxTriggerOnMinimum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxTriggerOnMinimum.Checked = true;
            this.checkBoxTriggerOnMinimum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTriggerOnMinimum.Location = new System.Drawing.Point(994, 246);
            this.checkBoxTriggerOnMinimum.Name = "checkBoxTriggerOnMinimum";
            this.checkBoxTriggerOnMinimum.Size = new System.Drawing.Size(117, 17);
            this.checkBoxTriggerOnMinimum.TabIndex = 57;
            this.checkBoxTriggerOnMinimum.Text = "Trigger on minimum";
            this.checkBoxTriggerOnMinimum.UseVisualStyleBackColor = false;
            // 
            // checkBoxBackgroundCorrection
            // 
            this.checkBoxBackgroundCorrection.AutoSize = true;
            this.checkBoxBackgroundCorrection.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxBackgroundCorrection.Checked = true;
            this.checkBoxBackgroundCorrection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBackgroundCorrection.Location = new System.Drawing.Point(985, 163);
            this.checkBoxBackgroundCorrection.Name = "checkBoxBackgroundCorrection";
            this.checkBoxBackgroundCorrection.Size = new System.Drawing.Size(134, 17);
            this.checkBoxBackgroundCorrection.TabIndex = 56;
            this.checkBoxBackgroundCorrection.Text = "Background correction";
            this.checkBoxBackgroundCorrection.UseVisualStyleBackColor = false;
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Location = new System.Drawing.Point(909, 246);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(79, 17);
            this.radioButtonDown.TabIndex = 55;
            this.radioButtonDown.Text = "downwards";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Checked = true;
            this.radioButtonUp.Location = new System.Drawing.Point(840, 246);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(65, 17);
            this.radioButtonUp.TabIndex = 54;
            this.radioButtonUp.TabStop = true;
            this.radioButtonUp.Text = "upwards";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // UseSensitiveAlgorithmCheckbox
            // 
            this.UseSensitiveAlgorithmCheckbox.AutoSize = true;
            this.UseSensitiveAlgorithmCheckbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UseSensitiveAlgorithmCheckbox.Checked = true;
            this.UseSensitiveAlgorithmCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UseSensitiveAlgorithmCheckbox.Location = new System.Drawing.Point(667, 247);
            this.UseSensitiveAlgorithmCheckbox.Name = "UseSensitiveAlgorithmCheckbox";
            this.UseSensitiveAlgorithmCheckbox.Size = new System.Drawing.Size(161, 17);
            this.UseSensitiveAlgorithmCheckbox.TabIndex = 53;
            this.UseSensitiveAlgorithmCheckbox.Text = "Trigger on crossing average:";
            this.UseSensitiveAlgorithmCheckbox.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.textBoxDCMotor2Time);
            this.groupBox5.Location = new System.Drawing.Point(802, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(167, 74);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motor 3 (DC)";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(10, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(42, 34);
            this.button11.TabIndex = 48;
            this.button11.Text = "Up";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(53, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(43, 34);
            this.button12.TabIndex = 47;
            this.button12.Text = "Down";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(128, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "mSecs";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 20);
            this.button4.TabIndex = 49;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxDCMotor2Time
            // 
            this.textBoxDCMotor2Time.Location = new System.Drawing.Point(101, 41);
            this.textBoxDCMotor2Time.Name = "textBoxDCMotor2Time";
            this.textBoxDCMotor2Time.Size = new System.Drawing.Size(26, 20);
            this.textBoxDCMotor2Time.TabIndex = 46;
            this.textBoxDCMotor2Time.Text = "2";
            this.textBoxDCMotor2Time.TextChanged += new System.EventHandler(this.textBoxDCMotor2Time_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.textBoxDCMotorTime);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(802, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 62);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motor 2  (DC)";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(10, 15);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 34);
            this.button9.TabIndex = 42;
            this.button9.Text = "In";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(53, 15);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(43, 34);
            this.button8.TabIndex = 41;
            this.button8.Text = "Out";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(103, 15);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(43, 20);
            this.button10.TabIndex = 43;
            this.button10.Text = "Stop";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBoxDCMotorTime
            // 
            this.textBoxDCMotorTime.Location = new System.Drawing.Point(100, 37);
            this.textBoxDCMotorTime.Name = "textBoxDCMotorTime";
            this.textBoxDCMotorTime.Size = new System.Drawing.Size(26, 20);
            this.textBoxDCMotorTime.TabIndex = 41;
            this.textBoxDCMotorTime.Text = "2";
            this.textBoxDCMotorTime.TextChanged += new System.EventHandler(this.textBoxDCMotorTime_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(127, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "mSecs";
            // 
            // checkBoxGraph
            // 
            this.checkBoxGraph.AutoSize = true;
            this.checkBoxGraph.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxGraph.Checked = true;
            this.checkBoxGraph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGraph.Location = new System.Drawing.Point(985, 196);
            this.checkBoxGraph.Name = "checkBoxGraph";
            this.checkBoxGraph.Size = new System.Drawing.Size(55, 17);
            this.checkBoxGraph.TabIndex = 30;
            this.checkBoxGraph.Text = "Graph";
            this.checkBoxGraph.UseVisualStyleBackColor = false;
            this.checkBoxGraph.CheckedChanged += new System.EventHandler(this.checkBoxGraph_CheckedChanged);
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(653, 275);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 202);
            this.chart1.TabIndex = 44;
            this.chart1.Text = "chart1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(243, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Camera Not Connected!";
            this.label14.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(802, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 78);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motor 1  (Servo)";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(117, 48);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(33, 21);
            this.button7.TabIndex = 40;
            this.button7.Text = "Go";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Goto (3-167):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 39;
            this.textBox2.Text = "176";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Step:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "2";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 29);
            this.button5.TabIndex = 35;
            this.button5.Text = "Left";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(54, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(43, 29);
            this.button6.TabIndex = 36;
            this.button6.Text = "Right";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // NormalizationBoxCheckbox
            // 
            this.NormalizationBoxCheckbox.AutoSize = true;
            this.NormalizationBoxCheckbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NormalizationBoxCheckbox.Location = new System.Drawing.Point(970, 418);
            this.NormalizationBoxCheckbox.Name = "NormalizationBoxCheckbox";
            this.NormalizationBoxCheckbox.Size = new System.Drawing.Size(140, 17);
            this.NormalizationBoxCheckbox.TabIndex = 33;
            this.NormalizationBoxCheckbox.Text = "Show Normalization Box";
            this.NormalizationBoxCheckbox.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.CheckBoxRecordValues);
            this.groupBox2.Controls.Add(this.checkBoxSaveMax);
            this.groupBox2.Controls.Add(this.OpenFolderButton);
            this.groupBox2.Controls.Add(this.checkBoxShow);
            this.groupBox2.Location = new System.Drawing.Point(961, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 111);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(73, 77);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(49, 21);
            this.DeleteButton.TabIndex = 31;
            this.DeleteButton.Text = "Delete Saved";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CheckBoxRecordValues
            // 
            this.CheckBoxRecordValues.AutoSize = true;
            this.CheckBoxRecordValues.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CheckBoxRecordValues.Location = new System.Drawing.Point(14, 15);
            this.CheckBoxRecordValues.Name = "CheckBoxRecordValues";
            this.CheckBoxRecordValues.Size = new System.Drawing.Size(110, 17);
            this.CheckBoxRecordValues.TabIndex = 19;
            this.CheckBoxRecordValues.Text = "Record All Values";
            this.CheckBoxRecordValues.UseVisualStyleBackColor = false;
            this.CheckBoxRecordValues.CheckedChanged += new System.EventHandler(this.CheckBoxRecordValues_CheckedChanged);
            // 
            // checkBoxSaveMax
            // 
            this.checkBoxSaveMax.AutoSize = true;
            this.checkBoxSaveMax.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxSaveMax.Location = new System.Drawing.Point(14, 32);
            this.checkBoxSaveMax.Name = "checkBoxSaveMax";
            this.checkBoxSaveMax.Size = new System.Drawing.Size(123, 17);
            this.checkBoxSaveMax.TabIndex = 17;
            this.checkBoxSaveMax.Text = "Save Images at Max";
            this.checkBoxSaveMax.UseVisualStyleBackColor = false;
            this.checkBoxSaveMax.CheckedChanged += new System.EventHandler(this.checkBoxSaveMax_CheckedChanged);
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Location = new System.Drawing.Point(15, 70);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Size = new System.Drawing.Size(47, 36);
            this.OpenFolderButton.TabIndex = 30;
            this.OpenFolderButton.Text = "Open Folder";
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxShow.Location = new System.Drawing.Point(14, 49);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(113, 17);
            this.checkBoxShow.TabIndex = 18;
            this.checkBoxShow.Text = "Show Max Images";
            this.checkBoxShow.UseVisualStyleBackColor = false;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4sPulses);
            this.groupBox1.Controls.Add(this.textBoxPulseInterval);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.PulseCountLabel);
            this.groupBox1.Controls.Add(this.TimeSinceMaxLabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(652, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 158);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // checkBox4sPulses
            // 
            this.checkBox4sPulses.AutoSize = true;
            this.checkBox4sPulses.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox4sPulses.Checked = true;
            this.checkBox4sPulses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4sPulses.Location = new System.Drawing.Point(12, 16);
            this.checkBox4sPulses.Name = "checkBox4sPulses";
            this.checkBox4sPulses.Size = new System.Drawing.Size(124, 17);
            this.checkBox4sPulses.TabIndex = 22;
            this.checkBox4sPulses.Text = " Pulse at least every:";
            this.checkBox4sPulses.UseVisualStyleBackColor = false;
            this.checkBox4sPulses.CheckedChanged += new System.EventHandler(this.checkBox4sPulses_CheckedChanged);
            // 
            // textBoxPulseInterval
            // 
            this.textBoxPulseInterval.Location = new System.Drawing.Point(30, 38);
            this.textBoxPulseInterval.Name = "textBoxPulseInterval";
            this.textBoxPulseInterval.Size = new System.Drawing.Size(24, 20);
            this.textBoxPulseInterval.TabIndex = 23;
            this.textBoxPulseInterval.Text = "2";
            this.textBoxPulseInterval.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(13, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Fake Pulse Count:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 21);
            this.button3.TabIndex = 29;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Secs";
            // 
            // PulseCountLabel
            // 
            this.PulseCountLabel.AutoSize = true;
            this.PulseCountLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PulseCountLabel.Location = new System.Drawing.Point(13, 134);
            this.PulseCountLabel.Name = "PulseCountLabel";
            this.PulseCountLabel.Size = new System.Drawing.Size(13, 13);
            this.PulseCountLabel.TabIndex = 26;
            this.PulseCountLabel.Text = "0";
            this.PulseCountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TimeSinceMaxLabel
            // 
            this.TimeSinceMaxLabel.AutoSize = true;
            this.TimeSinceMaxLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TimeSinceMaxLabel.Location = new System.Drawing.Point(13, 84);
            this.TimeSinceMaxLabel.Name = "TimeSinceMaxLabel";
            this.TimeSinceMaxLabel.Size = new System.Drawing.Size(13, 13);
            this.TimeSinceMaxLabel.TabIndex = 28;
            this.TimeSinceMaxLabel.Text = "0";
            this.TimeSinceMaxLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(13, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Time Since Last Pulse:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(674, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 21);
            this.button2.TabIndex = 21;
            this.button2.Text = "Add big box";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 21);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add small box";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckBoxAlgorithm2
            // 
            this.CheckBoxAlgorithm2.AutoSize = true;
            this.CheckBoxAlgorithm2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CheckBoxAlgorithm2.Location = new System.Drawing.Point(1013, 11);
            this.CheckBoxAlgorithm2.Name = "CheckBoxAlgorithm2";
            this.CheckBoxAlgorithm2.Size = new System.Drawing.Size(75, 17);
            this.CheckBoxAlgorithm2.TabIndex = 20;
            this.CheckBoxAlgorithm2.Text = "Algorithm2";
            this.CheckBoxAlgorithm2.UseVisualStyleBackColor = false;
            this.CheckBoxAlgorithm2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 480);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(231, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(133, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(101, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hertz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(182, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Average:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(375, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Interval:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(303, 2);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(42, 21);
            this.buttonMax.TabIndex = 6;
            this.buttonMax.Text = "Max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // checkBoxMax
            // 
            this.checkBoxMax.AutoSize = true;
            this.checkBoxMax.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxMax.Checked = true;
            this.checkBoxMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMax.Location = new System.Drawing.Point(288, 6);
            this.checkBoxMax.Name = "checkBoxMax";
            this.checkBoxMax.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMax.TabIndex = 10;
            this.checkBoxMax.UseVisualStyleBackColor = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // checkBoxSendSignal
            // 
            this.checkBoxSendSignal.AutoSize = true;
            this.checkBoxSendSignal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxSendSignal.Checked = true;
            this.checkBoxSendSignal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSendSignal.Location = new System.Drawing.Point(700, 5);
            this.checkBoxSendSignal.Name = "checkBoxSendSignal";
            this.checkBoxSendSignal.Size = new System.Drawing.Size(80, 17);
            this.checkBoxSendSignal.TabIndex = 11;
            this.checkBoxSendSignal.Text = "SendSignal";
            this.checkBoxSendSignal.UseVisualStyleBackColor = false;
            this.checkBoxSendSignal.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Com1",
            "Com2",
            "Com3",
            "Com4",
            "Com5",
            "Com6",
            "Com7",
            "Com8",
            "Com9",
            "Com10"});
            this.comboBox1.Location = new System.Drawing.Point(563, 521);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Select Port";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(470, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Select Com Port:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(418, 4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(34, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBoxTestMode
            // 
            this.checkBoxTestMode.AutoSize = true;
            this.checkBoxTestMode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBoxTestMode.Location = new System.Drawing.Point(488, 5);
            this.checkBoxTestMode.Name = "checkBoxTestMode";
            this.checkBoxTestMode.Size = new System.Drawing.Size(77, 17);
            this.checkBoxTestMode.TabIndex = 15;
            this.checkBoxTestMode.Text = "Test Mode";
            this.checkBoxTestMode.UseVisualStyleBackColor = false;
            this.checkBoxTestMode.CheckedChanged += new System.EventHandler(this.checkBoxTestMode_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(435, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "-";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(568, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Arduino Not Connected!";
            this.label10.Visible = false;
            // 
            // timerDCMotor
            // 
            this.timerDCMotor.Interval = 1000;
            this.timerDCMotor.Tick += new System.EventHandler(this.timerDCMotor_Tick);
            // 
            // timerGraph
            // 
            this.timerGraph.Interval = 30;
            this.timerGraph.Tick += new System.EventHandler(this.timerGraph_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 543);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxTestMode);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxSendSignal);
            this.Controls.Add(this.checkBoxMax);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Heart Beat Detector 2015";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimestamp;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCameraControl;
        private System.Windows.Forms.ToolStripMenuItem newCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelImageSize;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFrameRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.CheckBox checkBoxMax;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox checkBoxSendSignal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSelection;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxTestMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxSaveMax;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.CheckBox CheckBoxRecordValues;
        private System.Windows.Forms.CheckBox CheckBoxAlgorithm2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox4sPulses;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPulseInterval;
        private System.Windows.Forms.Label PulseCountLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TimeSinceMaxLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button OpenFolderButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.CheckBox NormalizationBoxCheckbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBoxDCMotorTime;
        private System.Windows.Forms.Timer timerDCMotor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkBoxGraph;
        private System.Windows.Forms.Timer timerGraph;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxDCMotor2Time;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox UseSensitiveAlgorithmCheckbox;
        private System.Windows.Forms.RadioButton radioButtonDown;
        private System.Windows.Forms.RadioButton radioButtonUp;
        private System.Windows.Forms.CheckBox checkBoxBackgroundCorrection;
        private System.Windows.Forms.CheckBox checkBoxTriggerOnMinimum;
    }
}

