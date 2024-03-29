﻿namespace XBMC_Remote
{
    partial class MainForm
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
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuOptions = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.senseHeaderCtrl = new StedySoft.SenseSDK.SenseHeaderControl();
            this.menuBack = new System.Windows.Forms.MenuItem();
            this.senseListCtrl = new StedySoft.SenseSDK.SenseListControl();
            this.SuspendLayout();
            // 
            // menuOptions
            // 
            this.menuOptions.Text = "Options";
            this.menuOptions.Click += new System.EventHandler(this.menuOptions_Click);
            // 
            // menuExit
            // 
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.menuExit);
            this.mainMenu.MenuItems.Add(this.menuOptions);
            // 
            // senseHeaderCtrl
            // 
            this.senseHeaderCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.senseHeaderCtrl.Location = new System.Drawing.Point(0, 0);
            this.senseHeaderCtrl.Name = "senseHeaderCtrl";
            this.senseHeaderCtrl.Size = new System.Drawing.Size(480, 25);
            this.senseHeaderCtrl.TabIndex = 2;
            this.senseHeaderCtrl.Text = "Main";
            // 
            // menuBack
            // 
            this.menuBack.Text = "Back";
            // 
            // senseListCtrl
            // 
            this.senseListCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.senseListCtrl.FocusedItem = null;
            this.senseListCtrl.IsSecondaryScrollType = false;
            this.senseListCtrl.Location = new System.Drawing.Point(0, 25);
            this.senseListCtrl.MinimumMovement = 15;
            this.senseListCtrl.Name = "senseListCtrl";
            this.senseListCtrl.ShowScrollIndicator = true;
            this.senseListCtrl.Size = new System.Drawing.Size(480, 723);
            this.senseListCtrl.Springback = 0.35F;
            this.senseListCtrl.TabIndex = 3;
            this.senseListCtrl.ThreadSleep = 100;
            this.senseListCtrl.TopIndex = 0;
            this.senseListCtrl.Velocity = 0.9F;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(480, 748);
            this.Controls.Add(this.senseListCtrl);
            this.Controls.Add(this.senseHeaderCtrl);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "XBMC Remote";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Closed += new System.EventHandler(this.MainForm_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.MenuItem menuOptions;
        protected System.Windows.Forms.MainMenu mainMenu;
        protected System.Windows.Forms.MenuItem menuExit;
        private StedySoft.SenseSDK.SenseHeaderControl senseHeaderCtrl;
        private System.Windows.Forms.MenuItem menuBack;
        private StedySoft.SenseSDK.SenseListControl senseListCtrl;






    }
}

