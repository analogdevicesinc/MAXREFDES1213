namespace MAXREFDES1213
{
    partial class SerialUSBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialUSBForm));
            this.button_search_maxim = new MaximStyle.MaximButton();
            this.maximComboBox_port_select = new MaximStyle.MaximComboBox();
            this.maximButton_connect_serial = new MaximStyle.MaximButton();
            this.ComPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // button_search_maxim
            // 
            this.button_search_maxim.Location = new System.Drawing.Point(66, 40);
            this.button_search_maxim.Name = "button_search_maxim";
            this.button_search_maxim.Size = new System.Drawing.Size(104, 28);
            this.button_search_maxim.TabIndex = 0;
            this.button_search_maxim.Text = "Search";
            this.button_search_maxim.UseVisualStyleBackColor = true;
            this.button_search_maxim.Click += new System.EventHandler(this.button_search_maxim_Click);
            // 
            // maximComboBox_port_select
            // 
            this.maximComboBox_port_select.BackColor = System.Drawing.Color.White;
            this.maximComboBox_port_select.DropDownHeight = 200;
            this.maximComboBox_port_select.DropDownWidth = 0;
            this.maximComboBox_port_select.Location = new System.Drawing.Point(246, 47);
            this.maximComboBox_port_select.Name = "maximComboBox_port_select";
            this.maximComboBox_port_select.Size = new System.Drawing.Size(145, 21);
            this.maximComboBox_port_select.TabIndex = 2;
            this.maximComboBox_port_select.Text = "Port Selection";
            this.maximComboBox_port_select.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maximComboBox_port_select.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Left;
          //  this.maximComboBox_port_select.SelectedIndexChanged += new System.EventHandler(this.maximComboBox_port_select_SelectedIndexChanged);
            // 
            // maximButton_connect_serial
            // 
            this.maximButton_connect_serial.Location = new System.Drawing.Point(153, 106);
            this.maximButton_connect_serial.Name = "maximButton_connect_serial";
            this.maximButton_connect_serial.Size = new System.Drawing.Size(104, 28);
            this.maximButton_connect_serial.TabIndex = 3;
            this.maximButton_connect_serial.Text = "Connect";
            this.maximButton_connect_serial.UseVisualStyleBackColor = true;
            this.maximButton_connect_serial.Click += new System.EventHandler(this.maximButton_connect_serial_Click);
            // 
            // ComPort1
            // 
            this.ComPort1.PortName = "COM";
            // 
            // SerialUSBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(433, 168);
            this.Controls.Add(this.maximButton_connect_serial);
            this.Controls.Add(this.maximComboBox_port_select);
            this.Controls.Add(this.button_search_maxim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerialUSBForm";
            this.Text = "Connect to Device";
          //  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SerialUSBForm_FormClosing);
          //  this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SerialUSBForm_FormClosed);
          //  this.Load += new System.EventHandler(this.SerialUSB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaximStyle.MaximButton button_search_maxim;
        private MaximStyle.MaximComboBox maximComboBox_port_select;
        private MaximStyle.MaximButton maximButton_connect_serial;
        private System.IO.Ports.SerialPort ComPort1;
    }
}