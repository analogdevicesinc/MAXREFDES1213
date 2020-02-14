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
using MaximStyle;

namespace MAXREFDES1213
{
    public partial class MaximSplashScreenForm : Form
    {
        public bool disableCheckBoxValue = false;
        
      
        public MaximSplashScreenForm(int numberofSeconds) //This function is used in the main form to run the splash screen for 3 seconds
        {
            InitializeComponent();
            maximSplashScreen1.DismissTime = numberofSeconds;
        }
        public void  Disable_splash_screen_timer()
        {
            
            
            maximSplashScreen1.DismissTime = 1000000;
       
        }

        

        private void maximSplashScreen1_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick); //Starts a new event handler timer tick
            maximSplashScreen1.LinkClicked = new LinkLabelLinkClickedEventHandler(LinkClicked); //Event handler for the link on the splash screen
            maximSplashScreen1.DisableSplashScreenClicked = new EventHandler(DisableSplashScreenClicked); //Event handler for the diusable splash screen click
            maximSplashScreen1.Checked = disableCheckBoxValue;
            OK.Click += new EventHandler(OK_Click); //New event handler for OK click which hides the spash screen
            timer1.Interval = maximSplashScreen1.DismissTime*1000;
            timer1.Enabled = true;
            

        }

        void DisableSplashScreenClicked(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true) 
            {
                disableCheckBoxValue = maximSplashScreen1.Checked;
            }
            else
            {
                disableCheckBoxValue = maximSplashScreen1.Checked;
            }

        }

        void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            
            System.Diagnostics.Process.Start("http://" + linkLabel.Text);
        }
        private void OK_Click(object sender, EventArgs e)
        {
          
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Enabled = false;
            
                            
        }

        public void showOK_Click(bool dismiss)
        {

         OK.Visible = dismiss;
            
           
        }
    }
}
