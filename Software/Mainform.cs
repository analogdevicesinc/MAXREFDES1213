/*******************************************************************************
* Copyright (C) Maxim Integrated Products, Inc., All Rights Reserved.
*
* Permission is hereby granted, free of charge, to any person obtaining a
* copy of this software and associated documentation files (the "Software"),
* to deal in the Software without restriction, including without limitation
* the rights to use, copy, modify, merge, publish, distribute, sublicense,
* and/or sell copies of the Software, and to permit persons to whom the
* Software is furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included
* in all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
* OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
* MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
* IN NO EVENT SHALL MAXIM INTEGRATED BE LIABLE FOR ANY CLAIM, DAMAGES
* OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
* ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
* OTHER DEALINGS IN THE SOFTWARE.
*
* Except as contained in this notice, the name of Maxim Integrated
* Products, Inc. shall not be used except as stated in the Maxim Integrated
* Products, Inc. Branding Policy.
*
* The mere transfer of this software does not imply any licenses
* of trade secrets, proprietary technology, copyrights, patents,
* trademarks, maskwork rights, or any other form of intellectual
* property whatsoever. Maxim Integrated Products, Inc. retains all
* ownership rights.
*******************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaximStyle;  // This includes all the definitions for the Maxim visual components like Analog meter, Maxim splash screen 
using System.IO.Ports;
using System.Threading;

namespace MAXREFDES1213
{


    
    public partial class Mainform : Form
    {

        public static int SECONDS_3 = 3; //According to Maxim standard as soon as the GUI is launched the Splash screen should run for 3 seconds and this variable is created as a function argument 
        MaximSplashScreenForm msc; // A form object to allow the user to select the spash screen form
        SerialUSBForm com; //Com is a form object to allow the user to select the Serial port
        string InputData = String.Empty; // String to store the data from the Serial port
        public delegate void AddDataDelegate(string analog_in); // Adding a delegate to receive the data from the micro controller
        public AddDataDelegate mySerialPortDelegate;
        public Mainform()
        {
            InitializeComponent(); //Initializing th form
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

            // setup delegate
            this.mySerialPortDelegate = new AddDataDelegate(AddSerialPortData);
            msc = new MaximSplashScreenForm(3);      // Instantiating the splash screen and making it run for 3 seconds      
            msc.disableCheckBoxValue = Properties.Settings.Default.DisableSplashValue; // Setting up the properties to enable/disable the splash screen          
            msc.showOK_Click(false);
            
            com = new SerialUSBForm(serialPort1);// Instantiating the serial port selection form/window and passing th eserial port object to it
           
            // Setting up the default values on the visual components on the main form
            MaximRadio_Button_CC_LR.Checked = true; //Setting this as default condition
            TransientLowCurrentRadioButton.Checked = true; // Setting this as default condition
            maxim_Load_ON_OFF_CC.Checked = false; //Setting default as load off condition
            maximStatusIndicator_Green_CC.IndicatorColor = StatusIndicatorColor.Gray; //Setting default color conditions
            maximStatusIndicator_Red_CC.IndicatorColor = StatusIndicatorColor.Red; //Setting default color conditions
            maximLoad_transientToggleButton.Checked = false;
            maximTransientStatusIndicatorGreen.IndicatorColor = StatusIndicatorColor.Gray; //Setting default color conditions
            maximTransientStatusIndicatorRed.IndicatorColor = StatusIndicatorColor.Red;
            Maxim_NumericUpDown_LR_CC.ValueFloat = 0.00;
            Maxim_NumericUpDown_HR_CC.ValueFloat = 0.00;          

            
            this.maximtabcontrol.SelectedIndexChanged += new System.EventHandler(this.maximtabcontrol1_SelectedIndexChanged);

            //H CURRENT METER DEFAULT VALUES Constant mode
           
            maximHCurrentMeter1_CC.UnitsText = "A";
            maximHCurrentMeter1_CC.MinorTickInc = 1;
            maximHCurrentMeter1_CC.MajorTickModulos = 1;
            maximHCurrentMeter1_CC.Maximum = 10;
            maximHCurrentMeter1_CC.Step = 1;
            maximVoltageAnalogMeter1_CC.Initialize(this);
            maximVoltageAnalogMeter1_CC.DrawColor = true;            
            maximLCurrentMeter1_CC.Initialize(this);
            maximLCurrentMeter1_CC.DrawColor = true;
            maximHCurrentMeter1_CC.Initialize(this);
            maximHCurrentMeter1_CC.DrawColor = true;
            MaximAnalogVoltMeter_Transient.Initialize(this);
            MaximAnalogVoltMeter_Transient.DrawColor = true;


            if (!msc.disableCheckBoxValue)// Checks to see if splash screen should be shown
            {
                msc.ShowDialog(); // Shows the splash screen
            }
            com.ShowDialog(); //Show the screen for port selection           

        }
      
        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            //user can set his own properties like do not show the Splash screen in the next launch of GUI the following setting enables the system to remember the properties
            Properties.Settings.Default.DisableSplashValue = msc.disableCheckBoxValue;
            Properties.Settings.Default.Save();            
            serialPort1.Close();
            Application.Exit();
        }


        //================================================================================================================================================
        //Reading the Serial Port in both Constant current and Transient modes
        //================================================================================================================================================
        public void AddSerialPortData(string analog_in)
        {
           
            if (maximtabcontrol.SelectedTab == tabPage_CC) // Checking if tab page 1 which represents constant current mode
            {
              
                
                try
                {
                    if (analog_in.Substring(0, 2) == "VR") // Reading the version of the firmware
                    {
                        maximStatusStrip1.SectionDetails1.Text = analog_in.Substring(2);
                    }
                     if (analog_in.Substring(0, 2) == "VL") //Reading the value of the voltage
                    {
                        maximVoltageAnalogMeter1_CC.Value = float.Parse(analog_in.Substring(2));
                        MaximAnalogVoltMeter_Transient.Value = 0;
                    }

                     //NOTE:  Currents are only read in Constant mode
                    else if (analog_in.Substring(0, 2) == "LC") //Reading low currentvalue
                    {
                        if (MaximRadio_Button_CC_LR.Checked == true)
                        {

                            maximLCurrentMeter1_CC.Value = (float.Parse(analog_in.Substring(2))) * 1000;
                            maximHCurrentMeter1_CC.Value = 0;

                        }

                       

                    }
                    else if (analog_in.Substring(0, 2) == "HC")// Reading high current values
                    {
                        if (MaximRadioButton_CC_HR.Checked == true)
                        {
                            maximHCurrentMeter1_CC.Value = (float.Parse(analog_in.Substring(2)));
                            maximLCurrentMeter1_CC.Value = 0;
                        }

                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The  buffer is full. Please reset the board.");
                }
            }
            else if (maximtabcontrol.SelectedTab == tabPage_Transient) // Making sure it is tab page2 which is Transient mode
            {
              
                try
                {
                    if (analog_in.Substring(0, 2) == "VL") //Reading voltage value
                    {
                        MaximAnalogVoltMeter_Transient.Value = float.Parse(analog_in.Substring(2));
                        maximVoltageAnalogMeter1_CC.Value = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The buffer is full. Please reset the board.");
                }

            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e) // Reading the data from the Serial port
        {
            try
            {
                InputData = serialPort1.ReadLine();
                if (InputData != String.Empty)
                {

                    maximVoltageAnalogMeter1_CC.Invoke(this.mySerialPortDelegate, new Object[] { InputData }); //Invoking the data 
                }
            }
            catch (System.IO.IOException error)
            {
                return;
            }
            catch (System.InvalidOperationException error)
            {
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Port is disconnected");
            }

        }

        //================================================================================================================================================
        //Constant Current Mode
        //================================================================================================================================================
        private void MaximRadio_Button_CC_LR_CheckedChanged(object sender, EventArgs e) //Looks for the selection of the radio button
        {
            if (MaximRadio_Button_CC_LR.Checked == true) //Checks whether the low range radio button is selected
            {
                Maxim_NumericUpDown_HR_CC.Enabled = false; //Disables the high range counter
                Maxim_NumericUpDown_HR_CC.ValueFloat = 0.00;
                Maxim_NumericUpDown_LR_CC.Enabled = true; //Enables the low range counter
                //Sets the default values
                maximLCurrentMeter1_CC.UnitsText = "mA";
                maximLCurrentMeter1_CC.MinorTickInc = 10;
                maximLCurrentMeter1_CC.MajorTickModulos = 20;
                maximLCurrentMeter1_CC.Maximum = 100;
                maximLCurrentMeter1_CC.Step = 10;
                maximHCurrentMeter1_CC.Enabled = false;
                maximLCurrentMeter1_CC.Enabled = true;

                maximHCurrentMeter1_CC.DrawColorOutline = false;
                maximHCurrentMeter1_CC.DrawDefaultBackground = false;


                maximLCurrentMeter1_CC.DrawColorOutline = true;
                maximLCurrentMeter1_CC.DrawDefaultBackground = true;

                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine("CMSV"); // Astring is sent to the firmware
                }


            }
        }


        private void MaximRadioButton_CC_HR_CheckedChanged(object sender, EventArgs e) 
        {
            if (MaximRadioButton_CC_HR.Checked == true) //Checks whether the high range radio button is selected
            {
                Maxim_NumericUpDown_HR_CC.Enabled = true; //High range numeri  counter is enabled
                Maxim_NumericUpDown_LR_CC.Enabled = false; //Low range numeric counter is disabled
                Maxim_NumericUpDown_LR_CC.ValueFloat = 0.00;
                maximHCurrentMeter1_CC.Enabled = true;

                //Sets the default values
                maximLCurrentMeter1_CC.Enabled = false;
                maximHCurrentMeter1_CC.UnitsText = "A";
                maximHCurrentMeter1_CC.MinorTickInc = 1;
                maximHCurrentMeter1_CC.MajorTickModulos = 1;
                maximHCurrentMeter1_CC.Maximum = 10;
                maximHCurrentMeter1_CC.Step = 1;
                maximHCurrentMeter1_CC.DrawColorOutline = true;
                maximHCurrentMeter1_CC.DrawDefaultBackground = true;
                maximLCurrentMeter1_CC.DrawColorOutline = false;
                maximLCurrentMeter1_CC.DrawDefaultBackground = false;

                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine("CMSV");
                }
            }
        }

       


     
        
        private void maximToggleButton2_CheckedChanged(object sender, EventArgs e) //Load button
        {



            if (maxim_Load_ON_OFF_CC.Checked == true) //Checks for the load button to be ON or OFF
            {

                maximStatusIndicator_Green_CC.IndicatorColor = StatusIndicatorColor.Green;
                maximStatusIndicator_Red_CC.IndicatorColor = StatusIndicatorColor.Gray;
                try
                {
                    serialPort1.WriteLine("CMGV");   //Give values: Reads values from the Micro controller
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Port Closed");
                    maximStatusStrip1.SectionStatus.Text = "Disconnected";
                }



            }
            else if (maxim_Load_ON_OFF_CC.Checked == false)  // If the load button is off the Status indicator turns gray
            {

              
                maximStatusIndicator_Green_CC.IndicatorColor = StatusIndicatorColor.Gray;
                maximStatusIndicator_Red_CC.IndicatorColor = StatusIndicatorColor.Red;

                try
                {
                    serialPort1.WriteLine("CMSV");   //Stop values
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Port Closed");
                    maximStatusStrip1.SectionStatus.Text = "Disconnected";
                }
            }
        }

        private void Constant_Load_button_Click(object sender, EventArgs e) // It is going to load the values to the micro controller
        {
            if (maximtabcontrol.SelectedTab == tabPage_CC) // Checks whether the constant current tab is selected
            {

                if (MaximRadio_Button_CC_LR.Checked == true) //Checks if the Low range current 0 to 100mA radio button is selected
                {
                    Maxim_NumericUpDown_HR_CC.Enabled = false; //Making sure the high range numeric updown counter is greyed out
                    Maxim_NumericUpDown_HR_CC.ValueFloat = 0.00; //The default value of the low range updown counter is set 
                    Maxim_NumericUpDown_LR_CC.Enabled = true; //The low range updown counter is enabled


                    if (maxim_Load_ON_OFF_CC.Checked == true) // Checks fo the Load button to be ON 


                    {

                    
                            // Transferes the constant current mode low range current value 
                            try
                            {
                                serialPort1.WriteLine("CMLR" + Maxim_NumericUpDown_LR_CC.ValueFloat.ToString("F3"));
                                serialPort1.WriteLine("CMLR" + Maxim_NumericUpDown_LR_CC.ValueFloat.ToString("F3"));
                                

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Port Closed");
                                maximStatusStrip1.SectionStatus.Text = "Disconnected";

                            }
                       

                    }

                    else
                    {
                        MessageBox.Show("Turn ON the load to set current values");
                    }
                }
                else if (MaximRadioButton_CC_HR.Checked == true) // Checks whether high range radio button is selected
                {
                    Maxim_NumericUpDown_HR_CC.Enabled = true; //Enables the high range current numeric up down counter
                    Maxim_NumericUpDown_LR_CC.Enabled = false; //Disables the low range current numeric up down counter
                    Maxim_NumericUpDown_LR_CC.ValueFloat = 0.000; //The default vale if the updown counter is set

                    if (maxim_Load_ON_OFF_CC.Checked == true)//Checks whether the Load button is ON or OFF
                    {

                        if (Maxim_NumericUpDown_HR_CC.ValueFloat > (100 / maximVoltageAnalogMeter1_CC.Value))
                        {
                            MessageBox.Show("Make sure the product of your applied input voltage and load current does not exceed 100 Watts");
                        }
                        else
                        {
                            // Transferes high range current data
                            try
                            {
                                serialPort1.WriteLine("CMHR" + Maxim_NumericUpDown_HR_CC.ValueFloat.ToString("F3"));
                                serialPort1.WriteLine("CMHR" + Maxim_NumericUpDown_HR_CC.ValueFloat.ToString("F3"));
                                

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Port Closed");
                                maximStatusStrip1.SectionStatus.Text = "Disconnected";
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Turn ON the load to set current values");
                    }

                }
            }
        }
        //============================================================================================================================
        //Transient mode
        //============================================================================================================================

        public void Low_transmission() //This is method defined to transfer data in transient mode when low range current radio button is selected 0 to 100mA
        {
            if (maximtabcontrol.SelectedTab == tabPage_Transient) //First we need to make sure the Transient tab is selected
            {
                 
                        
                    if (TransientLowCurrentRadioButton.Checked == true) //Checks whether the low range transient current button is selected
                    {
                       
                    //Couple of conditions are cheecked below making sure the user does not enter values that are out of range
                    if (top_currentNumericUpDown1_Transient.ValueFloat > (100) || Valley_CurrentNumericUpDown1_Transient.ValueFloat > 100)

                    {
                        MessageBox.Show("Make sure the value doesnot exceed 100 mA");
                    }
                    else if (Ramp_up_NumericUpDown_Transient.ValueFloat > 500)
                    {
                        MessageBox.Show("Make sure the Ramp up value doesnot exceed 500 mA/ms");
                    }

                    else if (Ramp_downNumericUpDown_Transient.ValueFloat < -500)
                    {
                        MessageBox.Show("Make sure the Ramp down value doesnot exceed -500 mA/ms");
                    }

                    else if (MaximT_ONUpDown_Transient.ValueFloat > 10000)
                    {
                        MessageBox.Show("Make sure the ON time doesnot exceed 100 seconds or 100,000 milli seconds");
                    }
                    else if (MaximT_ONUpDown_Transient.ValueFloat < 1)
                    {
                        MessageBox.Show("The minimum value of ON_Time is 1 milli second");
                    }
                    else if (MaximT_OFFUpDown_Transient.ValueFloat > 10000)
                    {
                        MessageBox.Show("Make sure the OFF time does not exceed 100 seconds or 100,000 milli seconds");
                    }
                    else if (MaximT_OFFUpDown_Transient.ValueFloat < 1)
                    {
                        MessageBox.Show("The minimum value of OFF_Time is 1 milli second");
                    }


                    else
                        {
                            // Once all the above conditions are satisfied the Transient low range values are transferred. First the Lenght of the data and the 
                            //actual value is transmitted
                            try
                            {
                                serialPort1.WriteLine("TMLR" + Valley_CurrentNumericUpDown1_Transient.ValueFloat.ToString("F3").Length + Valley_CurrentNumericUpDown1_Transient.ValueFloat.ToString("F3") + top_currentNumericUpDown1_Transient.ValueFloat.ToString("F3").Length
                                    + top_currentNumericUpDown1_Transient.ValueFloat.ToString("F3") + MaximT_ONUpDown_Transient.ValueFloat.ToString("F3").Length + MaximT_ONUpDown_Transient.ValueFloat.ToString("F3") +
                                    MaximT_OFFUpDown_Transient.ValueFloat.ToString("F3").Length + MaximT_OFFUpDown_Transient.ValueFloat.ToString("F3") + Ramp_up_NumericUpDown_Transient.ValueFloat.ToString("F3").Length +
                                    Ramp_up_NumericUpDown_Transient.ValueFloat.ToString("F3") + Ramp_downNumericUpDown_Transient.ValueFloat.ToString("F3").Length + Ramp_downNumericUpDown_Transient.ValueFloat.ToString("F3"));

                                
                            }
                            catch (Exception ex)
                            {
                            MessageBox.Show("Port Closed");
                            maximStatusStrip1.SectionStatus.Text = "Disconnected";
                        }
                        }
                    }
                                
            }
        }

        public void High_transmission() //This is method defined to transfer data in transient mode when high range current radio button is selected 0 to 10A
        {
            if (maximtabcontrol.SelectedTab == tabPage_Transient)//First we need to make sure the Transient tab is selected
            {
                
                 
                if (TransientHighCurrentradioButton.Checked == true) //Checks whether the high range transient current button is selected
                {
                    //Couple of conditions are cheecked below making sure the user does not enter values that sre out of range
                    
                        if (top_currentNumericUpDown1_Transient.ValueFloat > (10) || Valley_CurrentNumericUpDown1_Transient.ValueFloat > 10)

                        {
                            MessageBox.Show("Make sure the value doesnot exceed 10 A");
                        }
                        else if (Ramp_up_NumericUpDown_Transient.ValueFloat > 50)
                        {
                            MessageBox.Show("Make sure the Ramp up value doesnot exceed 50 A/ms");
                        }

                        else if (Ramp_downNumericUpDown_Transient.ValueFloat < -50)
                        {
                            MessageBox.Show("Make sure the Ramp down value doesnot exceed -50 A/ms");
                        }

                        else if (MaximT_ONUpDown_Transient.ValueFloat > 10000)
                        {
                            MessageBox.Show("Make sure the ON time doesnot exceed 100 seconds or 100,000 milli seconds");
                        }
                        else if (MaximT_ONUpDown_Transient.ValueFloat < 1)
                        {
                        MessageBox.Show("The minimum value of ON_Time is 1 milli second");
                        }
                        else if (MaximT_OFFUpDown_Transient.ValueFloat > 10000)
                        {
                            MessageBox.Show("Make sure the OFF time doesnot exceed 100 seconds or 100,000 milli seconds");
                        }
                        else if (MaximT_OFFUpDown_Transient.ValueFloat < 1)
                        {
                        MessageBox.Show("The minimum value of OFF_Time is 1 milli second");
                        }


                else
                        {
                        // Once all the above conditions are satisfied the Transient low range values are transferred. First the Lenght of the data and the 
                        //actual value is transmitted
                        try
                        {
                                serialPort1.WriteLine("TMHR" + Valley_CurrentNumericUpDown1_Transient.ValueFloat.ToString("F3").Length + Valley_CurrentNumericUpDown1_Transient.ValueFloat.ToString("F3") + top_currentNumericUpDown1_Transient.ValueFloat.ToString("F3").Length
                                    + top_currentNumericUpDown1_Transient.ValueFloat.ToString("F3") + MaximT_ONUpDown_Transient.ValueFloat.ToString("F3").Length + MaximT_ONUpDown_Transient.ValueFloat.ToString("F3") +
                                    MaximT_OFFUpDown_Transient.ValueFloat.ToString("F3").Length + MaximT_OFFUpDown_Transient.ValueFloat.ToString("F3") + Ramp_up_NumericUpDown_Transient.ValueFloat.ToString("F3").Length +
                                   Ramp_up_NumericUpDown_Transient.ValueFloat.ToString("F3") + Ramp_downNumericUpDown_Transient.ValueFloat.ToString("F3").Length + Ramp_downNumericUpDown_Transient.ValueFloat.ToString("F3"));
                                                 

                            }
                            catch (Exception ex)
                            {
                            MessageBox.Show("Port Closed");
                            maximStatusStrip1.SectionStatus.Text = "Disconnected";
                        }
                        } }
                
            }
        }

       

        private void maximT_ONUpDown_Click(object sender, EventArgs e) //Event called when ON time numeric up down counter is clicked
        {
    

             if (MaximT_ONUpDown_Transient.ValueFloat > 10000)
            {
                MessageBox.Show("Make sure the ON time doesnot exceed 100 seconds or 100,000 milli seconds");
            }
            else if (MaximT_ONUpDown_Transient.ValueFloat < 1)
            {
                MessageBox.Show("The minimum value of ON_Time is 1 milli second");
            }
         
        }

      

        private void maximT_OFFUpDown_Click(object sender, EventArgs e) //Event called when OFF time numeric up down counter is clicked
        {
       
             if (MaximT_OFFUpDown_Transient.ValueFloat > 10000)
            {
                MessageBox.Show("Make sure the OFF time doesnot exceed 100 seconds or 100,000 milli seconds");
            }
            else if (MaximT_OFFUpDown_Transient.ValueFloat < 1)
            {
                MessageBox.Show("The minimum value of OFF_Time is 1 milli second");
            }
        }

       

     

        private void Transient_Load_Button_Click(object sender, EventArgs e) // The data is only when Trasient load button is clicked
        {
            if (maximLoad_transientToggleButton.Checked == true) //It checks whether the transient load toggle button is checked
            {
                //Now both the funcitons are called but each funciton has a check of radio button selection and depending on that eithger high or low range data is 
                //transmitted
                Low_transmission(); 
                High_transmission();
            }
            else
            {
                MessageBox.Show("Please turn on Load transient Settings to set the values");
            }
        }

        private void TransientLowCurrentRadioButton_CheckedChanged(object sender, EventArgs e) // Once the low range radio button is selected the default values of all the paramteres are changed as below
        {
         

            Ramp_up_NumericUpDown_Transient.Enabled = true;
            Ramp_downNumericUpDown_Transient.Enabled = true;

            MaximT_ONUpDown_Transient.ValueFloat = 500;
            MaximT_OFFUpDown_Transient.ValueFloat = 500;


            Ramp_up_NumericUpDown_Transient.ValueFloat = 500;
            Ramp_downNumericUpDown_Transient.ValueFloat = -500;

            Ramp_up_NumericUpDown_Transient.MaximumFloat = 500;
            Ramp_up_NumericUpDown_Transient.MinimumFloat = 2.440;

            Ramp_downNumericUpDown_Transient.MaximumFloat = -2.440;
            Ramp_downNumericUpDown_Transient.MinimumFloat = -500;


            Valley_CurrentNumericUpDown1_Transient.ValueFloat = 0.000;
            top_currentNumericUpDown1_Transient.ValueFloat = 0.000;

            top_currentNumericUpDown1_Transient.MaximumFloat = 100;
            Valley_CurrentNumericUpDown1_Transient.MinimumFloat = 0;

            label2.Text = "T_Rise (mA/ms)";
            label3.Text = "T_Fall (mA/ms)";


            label5.Text = "I_High (mA)";
            label6.Text = "I_Low (mA)";
        }

        private void TransientHighCurrentradioButton_CheckedChanged(object sender, EventArgs e)// Once the high range radio button is selected the default values of all the paramteres are changed as below
        {
            Ramp_up_NumericUpDown_Transient.Enabled = true;
            Ramp_downNumericUpDown_Transient.Enabled = true;          

            Ramp_up_NumericUpDown_Transient.ValueFloat = 50;
            Ramp_downNumericUpDown_Transient.ValueFloat = -50;

            Ramp_up_NumericUpDown_Transient.MaximumFloat = 50;
            Ramp_up_NumericUpDown_Transient.MinimumFloat = 0.244;

            Ramp_downNumericUpDown_Transient.MaximumFloat = -0.244;
            Ramp_downNumericUpDown_Transient.MinimumFloat = -50;

            Valley_CurrentNumericUpDown1_Transient.ValueFloat = 0.000;
            top_currentNumericUpDown1_Transient.ValueFloat = 0.000;

            top_currentNumericUpDown1_Transient.MaximumFloat = 10;
            Valley_CurrentNumericUpDown1_Transient.MinimumFloat = 0;

            label2.Text = "T_Rise (A/ms)";
            label3.Text = "T_Fall (A/ms)";

            label5.Text = "I_High (A)";
            label6.Text = "I_Low (A)";
        }

       

        private void maximLoad_transientToggleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (maximLoad_transientToggleButton.Checked == true) //Checks whether the transient load toggle button is true
            {
                //If the toggle button is checked the status indicator turns from red to green
                maximTransientStatusIndicatorGreen.IndicatorColor = StatusIndicatorColor.Green;
                maximTransientStatusIndicatorRed.IndicatorColor = StatusIndicatorColor.Gray;
                try
                {
                    serialPort1.WriteLine("CMGV");   //Give values
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Port Closed");
                    maximStatusStrip1.SectionStatus.Text = "Disconnected";
                }



            }
            else if (maximLoad_transientToggleButton.Checked == false)//Checks whether the transient load toggle button is false
            {

                //If the toggle button is checked the status indicator turns from green to red
                maximTransientStatusIndicatorGreen.IndicatorColor = StatusIndicatorColor.Gray;
                maximTransientStatusIndicatorRed.IndicatorColor = StatusIndicatorColor.Red;

                try
                {

                    serialPort1.WriteLine("CMSV");   //Stop values
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Port Closed");
                    maximStatusStrip1.SectionStatus.Text = "Disconnected";
                    
                }
            }
        }


        //================================================================================================================================
        //Tab control
        //================================================================================================================================
        //This is the constant current control tab for Select Index changed 
        private void maximtabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (maximtabcontrol.SelectedTab == tabPage_CC) //Checks whether the CC mode is selected
            {

                maximtabcontrol.SelectedTab = tabPage_CC; //Makes the CC tab as the present tab
                maximLoad_transientToggleButton.Checked = false; //Makes sure the Load_ON button of the transient mode as OFF 

            }
            else if (maximtabcontrol.SelectedTab == tabPage_Transient)//Checks whether the transient mode is selected
            {
                maximtabcontrol.SelectedTab = tabPage_Transient;//Makes the transient tab as the present tab                
                maxim_Load_ON_OFF_CC.Checked = false;//Makes sure the Load_ON button of the constant mode as OFF

            }


        }

        //============================================================================================================================
        //Menu bar contents
        //============================================================================================================================

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //Exit click event
        {
            Application.Exit(); //Exits the application
        }

        private void aboutToolStripMenuItem_Click_2(object sender, EventArgs e) //About click event
        {
            msc.Disable_splash_screen_timer(); //Show the splash screen for 3 seconds and dissappears
            msc.showOK_Click(true);
            msc.ShowDialog();
            
            
        }

        private void Mainform_Shown(object sender, EventArgs e) //Status bar
        {
            
            maximStatusStrip1.SectionMessages.Text = "";
          


            if (serialPort1.IsOpen) //Checks if the serial port is open
            {
                //If open displays the com port and the baud rate
                maximStatusStrip1.SectionStatus.Text = "Connected to " + serialPort1.PortName.ToString() + " @" + serialPort1.BaudRate.ToString();

            }
            else
            {
                maximStatusStrip1.SectionStatus.Text = "Disconnected";
            }

        }
        private void connectToolStripMenuItem_Click_1(object sender, EventArgs e)// The connect click is used to reconnect the GUI to the micro contoller if the connection is lost
        {
            
            com.ShowDialog(); // Shows the serial port connect form
            if (serialPort1.IsOpen)
            {
               
                maximStatusStrip1.SectionStatus.Text = "Connected to " + serialPort1.PortName.ToString() + " @" + serialPort1.BaudRate.ToString();             
                
            }
            else
            {
                maximStatusStrip1.SectionStatus.Text = "Disconnected";
            }
        }
        //===========================================================================================================
        //Other tab events
        //===========================================================================================================
                          
       
    

        private void serialPort1_PinChanged(object sender, SerialPinChangedEventArgs e) // This event is triggered when the Serial port is broke suddenly and it looses connection 
        {
            MessageBox.Show("Pin changed");
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Port disconnected");
                maximStatusStrip1.SectionStatus.Text = "Disconnected";
            }
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e) //This event is triggered whenever error is received at serial port 
        {
            MessageBox.Show("Error coming through");
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Port disconnected");
                maximStatusStrip1.SectionStatus.Text = "Disconnected";
            }
        }

      

        private void maximtabcontrol1_Selected(object sender, TabControlEventArgs e) //Tab control event to control the load currents, when switching tabs the load are turned OFF
        {
            if (maximtabcontrol.SelectedTab == tabPage_CC) 
            {
                MessageBox.Show("Notice: All loads are turned OFF when switching tabs.");
            }
            else if (maximtabcontrol.SelectedTab == tabPage_Transient)
            {
                MessageBox.Show("Notice: All loads are turned OFF when switching tabs.");
            }
        }

     

       

       
    }
}





       
      

