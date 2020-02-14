namespace MAXREFDES1213
{
    partial class MaximSplashScreenForm
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
            this.maximSplashScreen1 = new MaximStyle.MaximSplashScreen();
            this.OK = new MaximStyle.MaximButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // maximSplashScreen1
            // 
            this.maximSplashScreen1.ApplicationIconImage = null;
            this.maximSplashScreen1.ApplicationName = "MAXREFDES1213 – Smart Electronic Load GUI";
            this.maximSplashScreen1.BackColor = System.Drawing.Color.White;
            this.maximSplashScreen1.Checked = false;
            this.maximSplashScreen1.CopyrightString = "© Maxim Integrated Products, Inc.";
            this.maximSplashScreen1.Font = new System.Drawing.Font("Arial", 11F);
            this.maximSplashScreen1.Location = new System.Drawing.Point(0, 0);
            this.maximSplashScreen1.Margin = new System.Windows.Forms.Padding(4);
            this.maximSplashScreen1.Name = "maximSplashScreen1";
            this.maximSplashScreen1.NonMaximCopyrightString = "";
            this.maximSplashScreen1.Size = new System.Drawing.Size(400, 320);
            this.maximSplashScreen1.TabIndex = 0;
            this.maximSplashScreen1.VersionString = "Version 1.0";
            this.maximSplashScreen1.Load += new System.EventHandler(this.maximSplashScreen1_Load);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(289, 268);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MaximSplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.maximSplashScreen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaximSplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MaximStyle.MaximSplashScreen maximSplashScreen1;
        private MaximStyle.MaximButton OK;
        private System.Windows.Forms.Timer timer1;
    }
}