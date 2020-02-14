namespace MAXREFDES1213
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maximStatusStrip1 = new MaximStyle.MaximStatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.maximtabcontrol = new MaximStyle.MaximTabControl();
            this.tabPage_CC = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.maxim_Load_ON_OFF_CC = new MaximStyle.MaximToggleButton();
            this.ConstantCurrentGroupBox = new MaximStyle.MaximGroupBox();
            this.Constant_Set_button = new MaximStyle.MaximButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maximHCurrentMeter1_CC = new MaximStyle.MaximAnalogMeter();
            this.label1 = new System.Windows.Forms.Label();
            this.MaximRadio_Button_CC_LR = new MaximStyle.MaximRadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.Maxim_NumericUpDown_LR_CC = new MaximStyle.MaximNumericUpDown();
            this.Maxim_NumericUpDown_HR_CC = new MaximStyle.MaximNumericUpDown();
            this.MaximRadioButton_CC_HR = new MaximStyle.MaximRadioButton();
            this.maximLCurrentMeter1_CC = new MaximStyle.MaximAnalogMeter();
            this.maximStatusIndicator_Red_CC = new MaximStyle.MaximStatusIndicator();
            this.maximStatusIndicator_Green_CC = new MaximStyle.MaximStatusIndicator();
            this.maximVoltageAnalogMeter1_CC = new MaximStyle.MaximAnalogMeter();
            this.tabPage_Transient = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.maximGroupBox_Transient_tab = new MaximStyle.MaximGroupBox();
            this.Transient_Load_Button = new MaximStyle.MaximButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1_Transient = new System.Windows.Forms.PictureBox();
            this.T_ON_label = new System.Windows.Forms.Label();
            this.MaximT_ONUpDown_Transient = new MaximStyle.MaximNumericUpDown();
            this.Ramp_up_NumericUpDown_Transient = new MaximStyle.MaximNumericUpDown();
            this.Ramp_downNumericUpDown_Transient = new MaximStyle.MaximNumericUpDown();
            this.T_OFF = new System.Windows.Forms.Label();
            this.MaximT_OFFUpDown_Transient = new MaximStyle.MaximNumericUpDown();
            this.Valley_CurrentNumericUpDown1_Transient = new MaximStyle.MaximNumericUpDown();
            this.top_currentNumericUpDown1_Transient = new MaximStyle.MaximNumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TransientCurrentSelectionGroupBox1 = new MaximStyle.MaximGroupBox();
            this.TransientHighCurrentradioButton = new MaximStyle.MaximRadioButton();
            this.TransientLowCurrentRadioButton = new MaximStyle.MaximRadioButton();
            this.maximTransientStatusIndicatorRed = new MaximStyle.MaximStatusIndicator();
            this.maximTransientStatusIndicatorGreen = new MaximStyle.MaximStatusIndicator();
            this.maximLoad_transientToggleButton = new MaximStyle.MaximToggleButton();
            this.MaximAnalogVoltMeter_Transient = new MaximStyle.MaximAnalogMeter();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.maximtabcontrol.SuspendLayout();
            this.tabPage_CC.SuspendLayout();
            this.ConstantCurrentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximStatusIndicator_Red_CC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximStatusIndicator_Green_CC)).BeginInit();
            this.tabPage_Transient.SuspendLayout();
            this.maximGroupBox_Transient_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Transient)).BeginInit();
            this.TransientCurrentSelectionGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximTransientStatusIndicatorRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximTransientStatusIndicatorGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
          //  this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.deviceToolStripMenuItem.Text = "&Device";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "&Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_2);
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort1_PinChanged);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // maximStatusStrip1
            // 
            this.maximStatusStrip1.Location = new System.Drawing.Point(0, 499);
            this.maximStatusStrip1.Name = "maximStatusStrip1";
            this.maximStatusStrip1.SectionsNumberOf = 3;
            this.maximStatusStrip1.SectionUseStatusProgressBar = false;
            this.maximStatusStrip1.Size = new System.Drawing.Size(983, 22);
            this.maximStatusStrip1.TabIndex = 3;
            this.maximStatusStrip1.Text = "maximStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
           // this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // maximtabcontrol
            // 
            this.maximtabcontrol.Controls.Add(this.tabPage_CC);
            this.maximtabcontrol.Controls.Add(this.tabPage_Transient);
            this.maximtabcontrol.Font = new System.Drawing.Font("Arial", 9F);
            this.maximtabcontrol.Location = new System.Drawing.Point(21, 42);
            this.maximtabcontrol.Name = "maximtabcontrol";
            this.maximtabcontrol.SelectedIndex = 0;
            this.maximtabcontrol.Size = new System.Drawing.Size(950, 416);
            this.maximtabcontrol.TabIndex = 36;
            this.maximtabcontrol.SelectedIndexChanged += new System.EventHandler(this.maximtabcontrol1_SelectedIndexChanged);
          //  this.maximtabcontrol.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.maximtabcontrol1_Selecting);
            this.maximtabcontrol.Selected += new System.Windows.Forms.TabControlEventHandler(this.maximtabcontrol1_Selected);
            // 
            // tabPage_CC
            // 
            this.tabPage_CC.Controls.Add(this.label7);
            this.tabPage_CC.Controls.Add(this.maxim_Load_ON_OFF_CC);
            this.tabPage_CC.Controls.Add(this.ConstantCurrentGroupBox);
            this.tabPage_CC.Controls.Add(this.maximStatusIndicator_Red_CC);
            this.tabPage_CC.Controls.Add(this.maximStatusIndicator_Green_CC);
            this.tabPage_CC.Controls.Add(this.maximVoltageAnalogMeter1_CC);
            this.tabPage_CC.Location = new System.Drawing.Point(4, 25);
            this.tabPage_CC.Name = "tabPage_CC";
            this.tabPage_CC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CC.Size = new System.Drawing.Size(942, 387);
            this.tabPage_CC.TabIndex = 0;
            this.tabPage_CC.Text = "Constant Current Mode";
            this.tabPage_CC.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(762, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 63;
            this.label7.Text = "Voltmeter";
            // 
            // maxim_Load_ON_OFF_CC
            // 
            this.maxim_Load_ON_OFF_CC.AutoSize = true;
            this.maxim_Load_ON_OFF_CC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxim_Load_ON_OFF_CC.Location = new System.Drawing.Point(695, 346);
            this.maxim_Load_ON_OFF_CC.Name = "maxim_Load_ON_OFF_CC";
            this.maxim_Load_ON_OFF_CC.Size = new System.Drawing.Size(104, 17);
            this.maxim_Load_ON_OFF_CC.TabIndex = 40;
            this.maxim_Load_ON_OFF_CC.Text = "Load-On/Off";
            this.maxim_Load_ON_OFF_CC.UseVisualStyleBackColor = true;
            this.maxim_Load_ON_OFF_CC.CheckedChanged += new System.EventHandler(this.maximToggleButton2_CheckedChanged);
            // 
            // ConstantCurrentGroupBox
            // 
            this.ConstantCurrentGroupBox.BackgroundColor = System.Drawing.Color.White;
            this.ConstantCurrentGroupBox.Controls.Add(this.Constant_Set_button);
            this.ConstantCurrentGroupBox.Controls.Add(this.label4);
            this.ConstantCurrentGroupBox.Controls.Add(this.label11);
            this.ConstantCurrentGroupBox.Controls.Add(this.maximHCurrentMeter1_CC);
            this.ConstantCurrentGroupBox.Controls.Add(this.label1);
            this.ConstantCurrentGroupBox.Controls.Add(this.MaximRadio_Button_CC_LR);
            this.ConstantCurrentGroupBox.Controls.Add(this.label10);
            this.ConstantCurrentGroupBox.Controls.Add(this.Maxim_NumericUpDown_LR_CC);
            this.ConstantCurrentGroupBox.Controls.Add(this.Maxim_NumericUpDown_HR_CC);
            this.ConstantCurrentGroupBox.Controls.Add(this.MaximRadioButton_CC_HR);
            this.ConstantCurrentGroupBox.Controls.Add(this.maximLCurrentMeter1_CC);
            this.ConstantCurrentGroupBox.Location = new System.Drawing.Point(18, 41);
            this.ConstantCurrentGroupBox.Name = "ConstantCurrentGroupBox";
            this.ConstantCurrentGroupBox.Size = new System.Drawing.Size(599, 325);
            this.ConstantCurrentGroupBox.TabIndex = 59;
            this.ConstantCurrentGroupBox.TabStop = false;
            this.ConstantCurrentGroupBox.Text = "Constant Current Selection";
            // 
            // Constant_Set_button
            // 
            this.Constant_Set_button.Location = new System.Drawing.Point(237, 230);
            this.Constant_Set_button.Name = "Constant_Set_button";
            this.Constant_Set_button.Size = new System.Drawing.Size(88, 23);
            this.Constant_Set_button.TabIndex = 56;
            this.Constant_Set_button.Text = "Set-values";
            this.Constant_Set_button.UseVisualStyleBackColor = true;
            this.Constant_Set_button.Click += new System.EventHandler(this.Constant_Load_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "High Current Ammeter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 15);
            this.label11.TabIndex = 55;
            this.label11.Text = "Resolution is 10 mA";
            // 
            // maximHCurrentMeter1_CC
            // 
            this.maximHCurrentMeter1_CC.ControlStyle = MaximStyle.MaximAnalogMeter.eControlStyle.Large;
            this.maximHCurrentMeter1_CC.DrawColor = false;
            this.maximHCurrentMeter1_CC.DrawMajorTicks = true;
            this.maximHCurrentMeter1_CC.DrawMinorTicks = true;
            this.maximHCurrentMeter1_CC.Location = new System.Drawing.Point(357, 195);
            this.maximHCurrentMeter1_CC.MajorTickModulos = 1F;
            this.maximHCurrentMeter1_CC.Maximum = 10F;
            this.maximHCurrentMeter1_CC.Minimum = 0F;
            this.maximHCurrentMeter1_CC.MinorTickInc = 1F;
            this.maximHCurrentMeter1_CC.Name = "maximHCurrentMeter1_CC";
            this.maximHCurrentMeter1_CC.NumberOfDivisions = 0;
            this.maximHCurrentMeter1_CC.Size = new System.Drawing.Size(212, 106);
            this.maximHCurrentMeter1_CC.Step = 1;
            this.maximHCurrentMeter1_CC.TabIndex = 60;
            this.maximHCurrentMeter1_CC.Text = "maximAnalogMeter1";
            this.maximHCurrentMeter1_CC.UnitsText = "A";
            this.maximHCurrentMeter1_CC.UnitsTextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximHCurrentMeter1_CC.Value = 0F;
            this.maximHCurrentMeter1_CC.ValueTextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          //  this.maximHCurrentMeter1_CC.Click += new System.EventHandler(this.maximHCurrentMeter1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 61;
            this.label1.Text = "Low Current Ammeter";
            // 
            // MaximRadio_Button_CC_LR
            // 
            this.MaximRadio_Button_CC_LR.AutoSize = true;
            this.MaximRadio_Button_CC_LR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximRadio_Button_CC_LR.Location = new System.Drawing.Point(25, 122);
            this.MaximRadio_Button_CC_LR.Name = "MaximRadio_Button_CC_LR";
            this.MaximRadio_Button_CC_LR.Size = new System.Drawing.Size(89, 17);
            this.MaximRadio_Button_CC_LR.TabIndex = 52;
            this.MaximRadio_Button_CC_LR.TabStop = true;
            this.MaximRadio_Button_CC_LR.Text = "0 to 100 mA\r\n";
            this.MaximRadio_Button_CC_LR.UseVisualStyleBackColor = true;
            this.MaximRadio_Button_CC_LR.CheckedChanged += new System.EventHandler(this.MaximRadio_Button_CC_LR_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 15);
            this.label10.TabIndex = 54;
            this.label10.Text = "Resolution is 0.1 mA";
            // 
            // Maxim_NumericUpDown_LR_CC
            // 
            this.Maxim_NumericUpDown_LR_CC.DecimalPlaces = 3;
            this.Maxim_NumericUpDown_LR_CC.EnforceMultiple = true;
            this.Maxim_NumericUpDown_LR_CC.Font = new System.Drawing.Font("Arial", 8F);
            this.Maxim_NumericUpDown_LR_CC.Increment = 1;
            this.Maxim_NumericUpDown_LR_CC.IncrementFloat = 0.1D;
            this.Maxim_NumericUpDown_LR_CC.Location = new System.Drawing.Point(117, 116);
            this.Maxim_NumericUpDown_LR_CC.Maximum = 100;
            this.Maxim_NumericUpDown_LR_CC.MaximumFloat = 100D;
            this.Maxim_NumericUpDown_LR_CC.Minimum = 0;
            this.Maxim_NumericUpDown_LR_CC.MinimumFloat = 0D;
            this.Maxim_NumericUpDown_LR_CC.Name = "Maxim_NumericUpDown_LR_CC";
            this.Maxim_NumericUpDown_LR_CC.Size = new System.Drawing.Size(75, 23);
            this.Maxim_NumericUpDown_LR_CC.TabIndex = 50;
            this.Maxim_NumericUpDown_LR_CC.Text = "maximNumericUpDown1";
            this.Maxim_NumericUpDown_LR_CC.Thousands = false;
            this.Maxim_NumericUpDown_LR_CC.Value = 0;
            this.Maxim_NumericUpDown_LR_CC.ValueFloat = 0D;
            this.Maxim_NumericUpDown_LR_CC.ValueType = MaximStyle.Common.Helpers.eValueType.Float;
          //  this.Maxim_NumericUpDown_LR_CC.Click += new System.EventHandler(this.Current_rangeUp_NumericUpDown1_Click);
            // 
            // Maxim_NumericUpDown_HR_CC
            // 
            this.Maxim_NumericUpDown_HR_CC.DecimalPlaces = 3;
            this.Maxim_NumericUpDown_HR_CC.EnforceMultiple = false;
            this.Maxim_NumericUpDown_HR_CC.Font = new System.Drawing.Font("Arial", 8F);
            this.Maxim_NumericUpDown_HR_CC.Increment = 1;
            this.Maxim_NumericUpDown_HR_CC.IncrementFloat = 0.01D;
            this.Maxim_NumericUpDown_HR_CC.Location = new System.Drawing.Point(117, 186);
            this.Maxim_NumericUpDown_HR_CC.Maximum = 100;
            this.Maxim_NumericUpDown_HR_CC.MaximumFloat = 10D;
            this.Maxim_NumericUpDown_HR_CC.Minimum = 0;
            this.Maxim_NumericUpDown_HR_CC.MinimumFloat = 0D;
            this.Maxim_NumericUpDown_HR_CC.Name = "Maxim_NumericUpDown_HR_CC";
            this.Maxim_NumericUpDown_HR_CC.Size = new System.Drawing.Size(75, 23);
            this.Maxim_NumericUpDown_HR_CC.TabIndex = 51;
            this.Maxim_NumericUpDown_HR_CC.Text = "maximNumericUpDown1";
            this.Maxim_NumericUpDown_HR_CC.Thousands = false;
            this.Maxim_NumericUpDown_HR_CC.Value = 0;
            this.Maxim_NumericUpDown_HR_CC.ValueFloat = 0D;
            this.Maxim_NumericUpDown_HR_CC.ValueType = MaximStyle.Common.Helpers.eValueType.Float;
           // this.Maxim_NumericUpDown_HR_CC.Click += new System.EventHandler(this.Current_set_pointmaximNumericUpDown1_Click);
            // 
            // MaximRadioButton_CC_HR
            // 
            this.MaximRadioButton_CC_HR.AutoSize = true;
            this.MaximRadioButton_CC_HR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximRadioButton_CC_HR.Location = new System.Drawing.Point(25, 186);
            this.MaximRadioButton_CC_HR.Name = "MaximRadioButton_CC_HR";
            this.MaximRadioButton_CC_HR.Size = new System.Drawing.Size(72, 17);
            this.MaximRadioButton_CC_HR.TabIndex = 53;
            this.MaximRadioButton_CC_HR.TabStop = true;
            this.MaximRadioButton_CC_HR.Text = "0 to 10 A";
            this.MaximRadioButton_CC_HR.UseVisualStyleBackColor = true;
            this.MaximRadioButton_CC_HR.CheckedChanged += new System.EventHandler(this.MaximRadioButton_CC_HR_CheckedChanged);
            // 
            // maximLCurrentMeter1_CC
            // 
            this.maximLCurrentMeter1_CC.ControlStyle = MaximStyle.MaximAnalogMeter.eControlStyle.Large;
            this.maximLCurrentMeter1_CC.DrawColor = false;
            this.maximLCurrentMeter1_CC.DrawMajorTicks = true;
            this.maximLCurrentMeter1_CC.DrawMinorTicks = true;
            this.maximLCurrentMeter1_CC.Location = new System.Drawing.Point(357, 56);
            this.maximLCurrentMeter1_CC.MajorTickModulos = 20F;
            this.maximLCurrentMeter1_CC.Maximum = 100F;
            this.maximLCurrentMeter1_CC.Minimum = 0F;
            this.maximLCurrentMeter1_CC.MinorTickInc = 10F;
            this.maximLCurrentMeter1_CC.Name = "maximLCurrentMeter1_CC";
            this.maximLCurrentMeter1_CC.NumberOfDivisions = 0;
            this.maximLCurrentMeter1_CC.Size = new System.Drawing.Size(212, 106);
            this.maximLCurrentMeter1_CC.TabIndex = 57;
            this.maximLCurrentMeter1_CC.Text = "maximLCurrentMeter1";
            this.maximLCurrentMeter1_CC.UnitsText = "mA";
            this.maximLCurrentMeter1_CC.UnitsTextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximLCurrentMeter1_CC.Value = 0F;
            this.maximLCurrentMeter1_CC.ValueTextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // maximStatusIndicator_Red_CC
            // 
            this.maximStatusIndicator_Red_CC.Image = ((System.Drawing.Image)(resources.GetObject("maximStatusIndicator_Red_CC.Image")));
            this.maximStatusIndicator_Red_CC.IndicatorColor = MaximStyle.StatusIndicatorColor.Red;
            this.maximStatusIndicator_Red_CC.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.maximStatusIndicator_Red_CC.Location = new System.Drawing.Point(887, 346);
            this.maximStatusIndicator_Red_CC.Name = "maximStatusIndicator_Red_CC";
            this.maximStatusIndicator_Red_CC.Size = new System.Drawing.Size(20, 20);
            this.maximStatusIndicator_Red_CC.TabIndex = 43;
            this.maximStatusIndicator_Red_CC.TabStop = false;
            // 
            // maximStatusIndicator_Green_CC
            // 
            this.maximStatusIndicator_Green_CC.Image = ((System.Drawing.Image)(resources.GetObject("maximStatusIndicator_Green_CC.Image")));
            this.maximStatusIndicator_Green_CC.IndicatorColor = MaximStyle.StatusIndicatorColor.Green;
            this.maximStatusIndicator_Green_CC.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.maximStatusIndicator_Green_CC.Location = new System.Drawing.Point(843, 346);
            this.maximStatusIndicator_Green_CC.Name = "maximStatusIndicator_Green_CC";
            this.maximStatusIndicator_Green_CC.Size = new System.Drawing.Size(20, 20);
            this.maximStatusIndicator_Green_CC.TabIndex = 42;
            this.maximStatusIndicator_Green_CC.TabStop = false;
            // 
            // maximVoltageAnalogMeter1_CC
            // 
            this.maximVoltageAnalogMeter1_CC.ControlStyle = MaximStyle.MaximAnalogMeter.eControlStyle.Large;
            this.maximVoltageAnalogMeter1_CC.DrawColor = false;
            this.maximVoltageAnalogMeter1_CC.DrawMajorTicks = true;
            this.maximVoltageAnalogMeter1_CC.DrawMinorTicks = true;
            this.maximVoltageAnalogMeter1_CC.Location = new System.Drawing.Point(685, 157);
            this.maximVoltageAnalogMeter1_CC.MajorTickModulos = 1F;
            this.maximVoltageAnalogMeter1_CC.Maximum = 40F;
            this.maximVoltageAnalogMeter1_CC.Minimum = 0F;
            this.maximVoltageAnalogMeter1_CC.MinorTickInc = 10F;
            this.maximVoltageAnalogMeter1_CC.Name = "maximVoltageAnalogMeter1_CC";
            this.maximVoltageAnalogMeter1_CC.NumberOfDivisions = 10;
            this.maximVoltageAnalogMeter1_CC.Size = new System.Drawing.Size(212, 106);
            this.maximVoltageAnalogMeter1_CC.Step = 1;
            this.maximVoltageAnalogMeter1_CC.TabIndex = 55;
            this.maximVoltageAnalogMeter1_CC.Text = "maximVoltageAnalogMeter1";
            this.maximVoltageAnalogMeter1_CC.UnitsText = "V";
            this.maximVoltageAnalogMeter1_CC.UnitsTextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximVoltageAnalogMeter1_CC.Value = 0F;
            this.maximVoltageAnalogMeter1_CC.ValueTextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tabPage_Transient
            // 
            this.tabPage_Transient.Controls.Add(this.label8);
            this.tabPage_Transient.Controls.Add(this.maximGroupBox_Transient_tab);
            this.tabPage_Transient.Controls.Add(this.TransientCurrentSelectionGroupBox1);
            this.tabPage_Transient.Controls.Add(this.maximTransientStatusIndicatorRed);
            this.tabPage_Transient.Controls.Add(this.maximTransientStatusIndicatorGreen);
            this.tabPage_Transient.Controls.Add(this.maximLoad_transientToggleButton);
            this.tabPage_Transient.Controls.Add(this.MaximAnalogVoltMeter_Transient);
            this.tabPage_Transient.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Transient.Name = "tabPage_Transient";
            this.tabPage_Transient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Transient.Size = new System.Drawing.Size(942, 387);
            this.tabPage_Transient.TabIndex = 1;
            this.tabPage_Transient.Text = "Load Transient Mode ";
            this.tabPage_Transient.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(771, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 82;
            this.label8.Text = "Voltmeter";
            // 
            // maximGroupBox_Transient_tab
            // 
            this.maximGroupBox_Transient_tab.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox_Transient_tab.Controls.Add(this.Transient_Load_Button);
            this.maximGroupBox_Transient_tab.Controls.Add(this.label3);
            this.maximGroupBox_Transient_tab.Controls.Add(this.label2);
            this.maximGroupBox_Transient_tab.Controls.Add(this.pictureBox1_Transient);
            this.maximGroupBox_Transient_tab.Controls.Add(this.T_ON_label);
            this.maximGroupBox_Transient_tab.Controls.Add(this.MaximT_ONUpDown_Transient);
            this.maximGroupBox_Transient_tab.Controls.Add(this.Ramp_up_NumericUpDown_Transient);
            this.maximGroupBox_Transient_tab.Controls.Add(this.Ramp_downNumericUpDown_Transient);
            this.maximGroupBox_Transient_tab.Controls.Add(this.T_OFF);
            this.maximGroupBox_Transient_tab.Controls.Add(this.MaximT_OFFUpDown_Transient);
            this.maximGroupBox_Transient_tab.Controls.Add(this.Valley_CurrentNumericUpDown1_Transient);
            this.maximGroupBox_Transient_tab.Controls.Add(this.top_currentNumericUpDown1_Transient);
            this.maximGroupBox_Transient_tab.Controls.Add(this.label6);
            this.maximGroupBox_Transient_tab.Controls.Add(this.label5);
            this.maximGroupBox_Transient_tab.Location = new System.Drawing.Point(6, 14);
            this.maximGroupBox_Transient_tab.Name = "maximGroupBox_Transient_tab";
            this.maximGroupBox_Transient_tab.Size = new System.Drawing.Size(655, 324);
            this.maximGroupBox_Transient_tab.TabIndex = 81;
            this.maximGroupBox_Transient_tab.TabStop = false;
            this.maximGroupBox_Transient_tab.Text = "Load Transient";
            // 
            // Transient_Load_Button
            // 
            this.Transient_Load_Button.Location = new System.Drawing.Point(551, 283);
            this.Transient_Load_Button.Name = "Transient_Load_Button";
            this.Transient_Load_Button.Size = new System.Drawing.Size(88, 23);
            this.Transient_Load_Button.TabIndex = 69;
            this.Transient_Load_Button.Text = "Set-Values";
            this.Transient_Load_Button.UseVisualStyleBackColor = true;
            this.Transient_Load_Button.Click += new System.EventHandler(this.Transient_Load_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "T-Fall (mA/ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 67;
            this.label2.Text = "T-Rise (mA/ms)";
            // 
            // pictureBox1_Transient
            // 
            this.pictureBox1_Transient.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1_Transient.Image")));
            this.pictureBox1_Transient.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1_Transient.InitialImage")));
            this.pictureBox1_Transient.Location = new System.Drawing.Point(6, 41);
            this.pictureBox1_Transient.Name = "pictureBox1_Transient";
            this.pictureBox1_Transient.Size = new System.Drawing.Size(542, 187);
            this.pictureBox1_Transient.TabIndex = 62;
            this.pictureBox1_Transient.TabStop = false;
            // 
            // T_ON_label
            // 
            this.T_ON_label.AutoSize = true;
            this.T_ON_label.Location = new System.Drawing.Point(153, 242);
            this.T_ON_label.Name = "T_ON_label";
            this.T_ON_label.Size = new System.Drawing.Size(62, 15);
            this.T_ON_label.TabIndex = 66;
            this.T_ON_label.Text = "T-On (ms)";
            // 
            // MaximT_ONUpDown_Transient
            // 
            this.MaximT_ONUpDown_Transient.DecimalPlaces = 3;
            this.MaximT_ONUpDown_Transient.EnforceMultiple = false;
            this.MaximT_ONUpDown_Transient.Font = new System.Drawing.Font("Arial", 8F);
            this.MaximT_ONUpDown_Transient.Increment = 1;
            this.MaximT_ONUpDown_Transient.IncrementFloat = 0.5D;
            this.MaximT_ONUpDown_Transient.Location = new System.Drawing.Point(156, 270);
            this.MaximT_ONUpDown_Transient.Maximum = 100000;
            this.MaximT_ONUpDown_Transient.MaximumFloat = 100000D;
            this.MaximT_ONUpDown_Transient.Minimum = 1;
            this.MaximT_ONUpDown_Transient.MinimumFloat = 1D;
            this.MaximT_ONUpDown_Transient.Name = "MaximT_ONUpDown_Transient";
            this.MaximT_ONUpDown_Transient.Size = new System.Drawing.Size(75, 23);
            this.MaximT_ONUpDown_Transient.TabIndex = 65;
            this.MaximT_ONUpDown_Transient.Text = "T_ON";
            this.MaximT_ONUpDown_Transient.Thousands = false;
            this.MaximT_ONUpDown_Transient.Value = 0;
            this.MaximT_ONUpDown_Transient.ValueFloat = 0D;
            this.MaximT_ONUpDown_Transient.ValueType = MaximStyle.Common.Helpers.eValueType.Float;
            this.MaximT_ONUpDown_Transient.Click += new System.EventHandler(this.maximT_ONUpDown_Click);
            // 
            // Ramp_up_NumericUpDown_Transient
            // 
            this.Ramp_up_NumericUpDown_Transient.DecimalPlaces = 3;
            this.Ramp_up_NumericUpDown_Transient.EnforceMultiple = false;
            this.Ramp_up_NumericUpDown_Transient.Font = new System.Drawing.Font("Arial", 8F);
            this.Ramp_up_NumericUpDown_Transient.Increment = 1;
            this.Ramp_up_NumericUpDown_Transient.IncrementFloat = 0.5D;
            this.Ramp_up_NumericUpDown_Transient.Location = new System.Drawing.Point(31, 270);
            this.Ramp_up_NumericUpDown_Transient.Maximum = 100;
            this.Ramp_up_NumericUpDown_Transient.MaximumFloat = 500D;
            this.Ramp_up_NumericUpDown_Transient.Minimum = 0;
            this.Ramp_up_NumericUpDown_Transient.MinimumFloat = 2.44D;
            this.Ramp_up_NumericUpDown_Transient.Name = "Ramp_up_NumericUpDown_Transient";
            this.Ramp_up_NumericUpDown_Transient.Size = new System.Drawing.Size(75, 23);
            this.Ramp_up_NumericUpDown_Transient.TabIndex = 44;
            this.Ramp_up_NumericUpDown_Transient.Text = "Rise_time";
            this.Ramp_up_NumericUpDown_Transient.Thousands = false;
            this.Ramp_up_NumericUpDown_Transient.Value = 0;
            this.Ramp_up_NumericUpDown_Transient.ValueFloat = 2.44D;
            this.Ramp_up_NumericUpDown_Transient.ValueType = MaximStyle.Common.Helpers.eValueType.Float;
          //  this.Ramp_up_NumericUpDown_Transient.Click += new System.EventHandler(this.ram_up_NumericUpDown1_Click);
            // 
            // Ramp_downNumericUpDown_Transient
            // 
            this.Ramp_downNumericUpDown_Transient.DecimalPlaces = 3;
            this.Ramp_downNumericUpDown_Transient.EnforceMultiple = false;
            this.Ramp_downNumericUpDown_Transient.Font = new System.Drawing.Font("Arial", 8F);
            this.Ramp_downNumericUpDown_Transient.Increment = 1;
            this.Ramp_downNumericUpDown_Transient.IncrementFloat = 0.5D;
            this.Ramp_downNumericUpDown_Transient.Location = new System.Drawing.Point(271, 270);
            this.Ramp_downNumericUpDown_Transient.Maximum = 100;
            this.Ramp_downNumericUpDown_Transient.MaximumFloat = -2.44D;
            this.Ramp_downNumericUpDown_Transient.Minimum = 0;
            this.Ramp_downNumericUpDown_Transient.MinimumFloat = -500D;
            this.Ramp_downNumericUpDown_Transient.Name = "Ramp_downNumericUpDown_Transient";
            this.Ramp_downNumericUpDown_Transient.Size = new System.Drawing.Size(75, 23);
            this.Ramp_downNumericUpDown_Transient.TabIndex = 46;
            this.Ramp_downNumericUpDown_Transient.Text = "Fall_Time";
            this.Ramp_downNumericUpDown_Transient.Thousands = false;
            this.Ramp_downNumericUpDown_Transient.Value = 0;
            this.Ramp_downNumericUpDown_Transient.ValueFloat = -2.44D;
            this.Ramp_downNumericUpDown_Transient.ValueType = MaximStyle.Common.Helpers.eValueType.Float;
         //   this.Ramp_downNumericUpDown_Transient.Click += new System.EventHandler(this.Ramp_downNumericUpDown1_Click);
            // 
            // T_OFF
            // 
            this.T_OFF.AutoSize = true;
            this.T_OFF.Location = new System.Drawing.Point(383, 242);
            this.T_OFF.Name = "T_OFF";
            this.T_OFF.Size = new System.Drawing.Size(61, 15);
            this.T_OFF.TabIndex = 59;
            this.T_OFF.Text = "T-Off (ms)";
            // 
            // MaximT_OFFUpDown_Transient
            // 
            this.MaximT_OFFUpDown_Transient.DecimalPlaces = 3;
            this.MaximT_OFFUpDown_Transient.EnforceMultiple = false;
            this.MaximT_OFFUpDown_Transient.Font = new System.Drawing.Font("Arial", 8F);
            this.MaximT_OFFUpDown_Transient.Increment = 1;
            this.MaximT_OFFUpDown_Transient.IncrementFloat = 0.5D;
            this.MaximT_OFFUpDown_Transient.Location = new System.Drawing.Point(386, 270);
            this.MaximT_OFFUpDown_Transient.Maximum = 100000;
            this.MaximT_OFFUpDown_Transient.MaximumFloat = 100000D;
            this.MaximT_OFFUpDown_Transient.Minimum = 1;
            this.MaximT_OFFUpDown_Transient.MinimumFloat = 1D;
            this.MaximT_OFFUpDown_Transient.Name = "MaximT_OFFUpDown_Transient";
            this.MaximT_OFFUpDown_Transient.Size = new System.Drawing.Size(75, 23);
            this.MaximT_OFFUpDown_Transient.TabIndex = 64;
            this.MaximT_OFFUpDown_Transient.Text = "T_OFFUpDown";
            this.MaximT_OFFUpDown_Transient.Thousands = false;
            this.MaximT_OFFUpDown_Transient.Value = 0;
            this.MaximT_OFFUpDown_Transient.ValueFloat = 0D;
            this.MaximT_OFFUpDown_Transient.ValueType = MaximStyle.Common.Helpers.eValueType.Float;
            this.MaximT_OFFUpDown_Transient.Click += new System.EventHandler(this.maximT_OFFUpDown_Click);
            // 
            // Valley_CurrentNumericUpDown1_Transient
            // 
            this.Valley_CurrentNumericUpDown1_Transient.DecimalPlaces = 3;
            this.Valley_CurrentNumericUpDown1_Transient.EnforceMultiple = false;
            this.Valley_CurrentNumericUpDown1_Transient.Font = new System.Drawing.Font("Arial", 8F);
            this.Valley_CurrentNumericUpDown1_Transient.Increment = 1;
            this.Valley_CurrentNumericUpDown1_Transient.IncrementFloat = 0.5D;
            this.Valley_CurrentNumericUpDown1_Transient.Location = new System.Drawing.Point(564, 205);
            this.Valley_CurrentNumericUpDown1_Transient.Maximum = 100;
            this.Valley_CurrentNumericUpDown1_Transient.MaximumFloat = 100D;
            this.Valley_CurrentNumericUpDown1_Transient.Minimum = 0;
            this.Valley_CurrentNumericUpDown1_Transient.MinimumFloat = 0D;
            this.Valley_CurrentNumericUpDown1_Transient.Name = "Valley_CurrentNumericUpDown1_Transient";
            this.Valley_CurrentNumericUpDown1_Transient.Size = new System.Drawing.Size(75, 23);
            this.Valley_CurrentNumericUpDown1_Transient.TabIndex = 48;
            this.Valley_CurrentNumericUpDown1_Transient.Text = "Low_Current";
            this.Valley_CurrentNumericUpDown1_Transient.Thousands = false;
            this.Valley_CurrentNumericUpDown1_Transient.Value = 0;
            this.Valley_CurrentNumericUpDown1_Transient.ValueFloat = 0D;
            this.Valley_CurrentNumericUpDown1_Transient.ValueType = MaximStyle.Common.Helpers.eValueType.Float;
         //   this.Valley_CurrentNumericUpDown1_Transient.Click += new System.EventHandler(this.Valley_CurrentNumericUpDown1_Click);
            // 
            // top_currentNumericUpDown1_Transient
            // 
            this.top_currentNumericUpDown1_Transient.DecimalPlaces = 3;
            this.top_currentNumericUpDown1_Transient.EnforceMultiple = false;
            this.top_currentNumericUpDown1_Transient.Font = new System.Drawing.Font("Arial", 8F);
            this.top_currentNumericUpDown1_Transient.Increment = 1;
            this.top_currentNumericUpDown1_Transient.IncrementFloat = 0.5D;
            this.top_currentNumericUpDown1_Transient.Location = new System.Drawing.Point(564, 53);
            this.top_currentNumericUpDown1_Transient.Maximum = 100;
            this.top_currentNumericUpDown1_Transient.MaximumFloat = 5D;
            this.top_currentNumericUpDown1_Transient.Minimum = 0;
            this.top_currentNumericUpDown1_Transient.MinimumFloat = 0D;
            this.top_currentNumericUpDown1_Transient.Name = "top_currentNumericUpDown1_Transient";
            this.top_currentNumericUpDown1_Transient.Size = new System.Drawing.Size(75, 23);
            this.top_currentNumericUpDown1_Transient.TabIndex = 49;
            this.top_currentNumericUpDown1_Transient.Text = "High_Current";
            this.top_currentNumericUpDown1_Transient.Thousands = false;
            this.top_currentNumericUpDown1_Transient.Value = 0;
            this.top_currentNumericUpDown1_Transient.ValueFloat = 0D;
            this.top_currentNumericUpDown1_Transient.ValueType = MaximStyle.Common.Helpers.eValueType.Float;
         //   this.top_currentNumericUpDown1_Transient.Click += new System.EventHandler(this.top_currentNumericUpDown1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 57;
            this.label6.Text = "I-Low (mA)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 56;
            this.label5.Text = "I-High (mA)";
            // 
            // TransientCurrentSelectionGroupBox1
            // 
            this.TransientCurrentSelectionGroupBox1.BackColor = System.Drawing.Color.Wheat;
            this.TransientCurrentSelectionGroupBox1.BackgroundColor = System.Drawing.Color.White;
            this.TransientCurrentSelectionGroupBox1.Controls.Add(this.TransientHighCurrentradioButton);
            this.TransientCurrentSelectionGroupBox1.Controls.Add(this.TransientLowCurrentRadioButton);
            this.TransientCurrentSelectionGroupBox1.Location = new System.Drawing.Point(695, 14);
            this.TransientCurrentSelectionGroupBox1.Name = "TransientCurrentSelectionGroupBox1";
            this.TransientCurrentSelectionGroupBox1.Size = new System.Drawing.Size(212, 141);
            this.TransientCurrentSelectionGroupBox1.TabIndex = 70;
            this.TransientCurrentSelectionGroupBox1.TabStop = false;
            this.TransientCurrentSelectionGroupBox1.Text = "Transient Current Selection";
            // 
            // TransientHighCurrentradioButton
            // 
            this.TransientHighCurrentradioButton.AutoSize = true;
            this.TransientHighCurrentradioButton.BackColor = System.Drawing.Color.White;
            this.TransientHighCurrentradioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransientHighCurrentradioButton.Location = new System.Drawing.Point(65, 90);
            this.TransientHighCurrentradioButton.Name = "TransientHighCurrentradioButton";
            this.TransientHighCurrentradioButton.Size = new System.Drawing.Size(72, 17);
            this.TransientHighCurrentradioButton.TabIndex = 1;
            this.TransientHighCurrentradioButton.TabStop = true;
            this.TransientHighCurrentradioButton.Text = "0 to 10 A";
            this.TransientHighCurrentradioButton.UseVisualStyleBackColor = false;
            this.TransientHighCurrentradioButton.CheckedChanged += new System.EventHandler(this.TransientHighCurrentradioButton_CheckedChanged);
            // 
            // TransientLowCurrentRadioButton
            // 
            this.TransientLowCurrentRadioButton.AutoSize = true;
            this.TransientLowCurrentRadioButton.BackColor = System.Drawing.Color.White;
            this.TransientLowCurrentRadioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransientLowCurrentRadioButton.Location = new System.Drawing.Point(65, 59);
            this.TransientLowCurrentRadioButton.Name = "TransientLowCurrentRadioButton";
            this.TransientLowCurrentRadioButton.Size = new System.Drawing.Size(89, 17);
            this.TransientLowCurrentRadioButton.TabIndex = 0;
            this.TransientLowCurrentRadioButton.TabStop = true;
            this.TransientLowCurrentRadioButton.Text = "0 to 100 mA";
            this.TransientLowCurrentRadioButton.UseVisualStyleBackColor = false;
            this.TransientLowCurrentRadioButton.CheckedChanged += new System.EventHandler(this.TransientLowCurrentRadioButton_CheckedChanged);
            // 
            // maximTransientStatusIndicatorRed
            // 
            this.maximTransientStatusIndicatorRed.Image = ((System.Drawing.Image)(resources.GetObject("maximTransientStatusIndicatorRed.Image")));
            this.maximTransientStatusIndicatorRed.IndicatorColor = MaximStyle.StatusIndicatorColor.Red;
            this.maximTransientStatusIndicatorRed.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.maximTransientStatusIndicatorRed.Location = new System.Drawing.Point(887, 346);
            this.maximTransientStatusIndicatorRed.Name = "maximTransientStatusIndicatorRed";
            this.maximTransientStatusIndicatorRed.Size = new System.Drawing.Size(20, 20);
            this.maximTransientStatusIndicatorRed.TabIndex = 69;
            this.maximTransientStatusIndicatorRed.TabStop = false;
            // 
            // maximTransientStatusIndicatorGreen
            // 
            this.maximTransientStatusIndicatorGreen.Image = ((System.Drawing.Image)(resources.GetObject("maximTransientStatusIndicatorGreen.Image")));
            this.maximTransientStatusIndicatorGreen.IndicatorColor = MaximStyle.StatusIndicatorColor.Green;
            this.maximTransientStatusIndicatorGreen.IndicatorSize = MaximStyle.StatusIndicatorSize.Medium;
            this.maximTransientStatusIndicatorGreen.Location = new System.Drawing.Point(843, 346);
            this.maximTransientStatusIndicatorGreen.Name = "maximTransientStatusIndicatorGreen";
            this.maximTransientStatusIndicatorGreen.Size = new System.Drawing.Size(20, 20);
            this.maximTransientStatusIndicatorGreen.TabIndex = 68;
            this.maximTransientStatusIndicatorGreen.TabStop = false;
            // 
            // maximLoad_transientToggleButton
            // 
            this.maximLoad_transientToggleButton.AutoSize = true;
            this.maximLoad_transientToggleButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximLoad_transientToggleButton.Location = new System.Drawing.Point(695, 346);
            this.maximLoad_transientToggleButton.Name = "maximLoad_transientToggleButton";
            this.maximLoad_transientToggleButton.Size = new System.Drawing.Size(104, 17);
            this.maximLoad_transientToggleButton.TabIndex = 67;
            this.maximLoad_transientToggleButton.Text = "Load-On/Off";
            this.maximLoad_transientToggleButton.UseVisualStyleBackColor = true;
            this.maximLoad_transientToggleButton.CheckedChanged += new System.EventHandler(this.maximLoad_transientToggleButton_CheckedChanged);
            // 
            // MaximAnalogVoltMeter_Transient
            // 
            this.MaximAnalogVoltMeter_Transient.ControlStyle = MaximStyle.MaximAnalogMeter.eControlStyle.Large;
            this.MaximAnalogVoltMeter_Transient.DrawColor = false;
            this.MaximAnalogVoltMeter_Transient.DrawMajorTicks = true;
            this.MaximAnalogVoltMeter_Transient.DrawMinorTicks = true;
            this.MaximAnalogVoltMeter_Transient.Location = new System.Drawing.Point(695, 214);
            this.MaximAnalogVoltMeter_Transient.MajorTickModulos = 10F;
            this.MaximAnalogVoltMeter_Transient.Maximum = 40F;
            this.MaximAnalogVoltMeter_Transient.Minimum = 0F;
            this.MaximAnalogVoltMeter_Transient.MinorTickInc = 1F;
            this.MaximAnalogVoltMeter_Transient.Name = "MaximAnalogVoltMeter_Transient";
            this.MaximAnalogVoltMeter_Transient.NumberOfDivisions = 0;
            this.MaximAnalogVoltMeter_Transient.Size = new System.Drawing.Size(212, 106);
            this.MaximAnalogVoltMeter_Transient.TabIndex = 63;
            this.MaximAnalogVoltMeter_Transient.Text = "maximAnalog_transient_voltMeter1";
            this.MaximAnalogVoltMeter_Transient.UnitsText = "V";
            this.MaximAnalogVoltMeter_Transient.UnitsTextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximAnalogVoltMeter_Transient.Value = 0F;
            this.MaximAnalogVoltMeter_Transient.ValueTextFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 521);
            this.Controls.Add(this.maximtabcontrol);
            this.Controls.Add(this.maximStatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Text = "MAXREFDES1213 – Smart Electronic Load GUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.Shown += new System.EventHandler(this.Mainform_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.maximtabcontrol.ResumeLayout(false);
            this.tabPage_CC.ResumeLayout(false);
            this.tabPage_CC.PerformLayout();
            this.ConstantCurrentGroupBox.ResumeLayout(false);
            this.ConstantCurrentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximStatusIndicator_Red_CC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximStatusIndicator_Green_CC)).EndInit();
            this.tabPage_Transient.ResumeLayout(false);
            this.tabPage_Transient.PerformLayout();
            this.maximGroupBox_Transient_tab.ResumeLayout(false);
            this.maximGroupBox_Transient_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_Transient)).EndInit();
            this.TransientCurrentSelectionGroupBox1.ResumeLayout(false);
            this.TransientCurrentSelectionGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximTransientStatusIndicatorRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximTransientStatusIndicatorGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private MaximStyle.MaximStatusStrip maximStatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private MaximStyle.MaximTabControl maximtabcontrol;
        private System.Windows.Forms.TabPage tabPage_CC;
        private MaximStyle.MaximToggleButton maxim_Load_ON_OFF_CC;
        private MaximStyle.MaximGroupBox ConstantCurrentGroupBox;
        private System.Windows.Forms.Label label11;
        private MaximStyle.MaximRadioButton MaximRadio_Button_CC_LR;
        private System.Windows.Forms.Label label10;
        private MaximStyle.MaximNumericUpDown Maxim_NumericUpDown_LR_CC;
        private MaximStyle.MaximNumericUpDown Maxim_NumericUpDown_HR_CC;
        private MaximStyle.MaximRadioButton MaximRadioButton_CC_HR;
        private MaximStyle.MaximStatusIndicator maximStatusIndicator_Red_CC;
        private MaximStyle.MaximAnalogMeter maximLCurrentMeter1_CC;
        private MaximStyle.MaximStatusIndicator maximStatusIndicator_Green_CC;
        private MaximStyle.MaximAnalogMeter maximVoltageAnalogMeter1_CC;
        private System.Windows.Forms.TabPage tabPage_Transient;
        private MaximStyle.MaximGroupBox maximGroupBox_Transient_tab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1_Transient;
        private System.Windows.Forms.Label T_ON_label;
        private MaximStyle.MaximNumericUpDown MaximT_ONUpDown_Transient;
        private MaximStyle.MaximNumericUpDown Ramp_up_NumericUpDown_Transient;
        private MaximStyle.MaximNumericUpDown Ramp_downNumericUpDown_Transient;
        private System.Windows.Forms.Label T_OFF;
        private MaximStyle.MaximNumericUpDown MaximT_OFFUpDown_Transient;
        private MaximStyle.MaximNumericUpDown Valley_CurrentNumericUpDown1_Transient;
        private MaximStyle.MaximNumericUpDown top_currentNumericUpDown1_Transient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MaximStyle.MaximGroupBox TransientCurrentSelectionGroupBox1;
        private MaximStyle.MaximRadioButton TransientHighCurrentradioButton;
        private MaximStyle.MaximRadioButton TransientLowCurrentRadioButton;
        private MaximStyle.MaximStatusIndicator maximTransientStatusIndicatorRed;
        private MaximStyle.MaximStatusIndicator maximTransientStatusIndicatorGreen;
        private MaximStyle.MaximToggleButton maximLoad_transientToggleButton;
        private MaximStyle.MaximAnalogMeter MaximAnalogVoltMeter_Transient;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private MaximStyle.MaximAnalogMeter maximHCurrentMeter1_CC;
        private MaximStyle.MaximButton Constant_Set_button;
        private MaximStyle.MaximButton Transient_Load_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}