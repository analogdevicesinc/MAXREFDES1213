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
*******************************************************************************/using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;

namespace MAXREFDES1213
{
    
    public partial class SerialUSBForm : Form
    {
        SerialPort myserialport; // Creating Serial port component 
        
        public SerialUSBForm(SerialPort xyz) //This function is used in main form and the Serialport1 component initialized in the main form is used as the argument
        {
            InitializeComponent();
            myserialport = xyz;
            
        }

     

        private void button_search_maxim_Click(object sender, EventArgs e) 
        {
            try
            {
                maximComboBox_port_select.Items.Clear(); //Clears the Combo box
                maximComboBox_port_select.Text = "";
                string[] ArrayComPortsNames;
                int index = -1;
                string ComPortName = "";
                ArrayComPortsNames = SerialPort.GetPortNames(); //Fills the combo box all the available ports on the combo box
                do
                {
                    index += 1;
                    maximComboBox_port_select.Items.Add(ArrayComPortsNames[index]);
                }

                while (!((ArrayComPortsNames[index] == ComPortName)
                              || (index == ArrayComPortsNames.GetUpperBound(0))));
                Array.Sort(ArrayComPortsNames); //Sorts all the available com ports

                //want to get first out
                if (index == ArrayComPortsNames.GetUpperBound(0))
                {
                    ComPortName = ArrayComPortsNames[0];
                }
                maximComboBox_port_select.Text = ArrayComPortsNames[0]; //Displays all the available ports on the combo box
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }

            catch (System.IndexOutOfRangeException ex)
            {
                MessageBox.Show("No COM ports available");
            }



        }

       
   

        private void maximButton_connect_serial_Click(object sender, EventArgs e) //Connect button event on the COM port form
        {
            if (!(myserialport.IsOpen)) //Checks whether the serial port is not open
            {
                try
                {

                 
                    myserialport.PortName = Convert.ToString(maximComboBox_port_select.Text); //The serial com port slected in the combo  box is assigned as the port name                   
                    myserialport.BaudRate = 9600;
                    myserialport.Parity = System.IO.Ports.Parity.None;
                    myserialport.DataBits = 8;
                    myserialport.StopBits = System.IO.Ports.StopBits.One;
                    myserialport.Handshake = System.IO.Ports.Handshake.None;
                    myserialport.RtsEnable = true;
                    myserialport.DtrEnable = true;
                    
                    try
                    {

                        myserialport.Open(); //Opening the serial port

                    }
                    catch(System.ArgumentException ex)
                    {
                        MessageBox.Show("Please select the Valid COM port and click connect", "Error: COM Port Not Selected");
                        return;
                    }
                    catch(System.IO.IOException ex)
                    {
                        MessageBox.Show("Invalid COM port");
                    }
                   
                    this.Hide();
                    
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (myserialport.IsOpen) //If the serial port is already open 
            {

                myserialport.Close(); //Close the port
                maximComboBox_port_select.Items.Clear(); //Clear the combo box

                //Now reopen the serial port again
                try
                {


                    myserialport.PortName = Convert.ToString(maximComboBox_port_select.Text);
                    myserialport.BaudRate = 9600;
                    myserialport.Parity = System.IO.Ports.Parity.None;
                    myserialport.DataBits = 8;
                    myserialport.StopBits = System.IO.Ports.StopBits.One;
                    myserialport.Handshake = System.IO.Ports.Handshake.None;
                    myserialport.RtsEnable = true;
                    myserialport.DtrEnable = true;

                    try
                    {

                        myserialport.Open();

                    }
                    catch (System.ArgumentException ex)
                    {
                        MessageBox.Show("Please select the Valid COM port and click connect", "Error: COM Port Not Selected");
                        return;
                    }

                    this.Hide();

                }
                catch (UnauthorizedAccessException ex)
                {
                  
                }
                return;
               
            }
            
        }

 
    }
}
