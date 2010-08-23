﻿namespace XBMC_Remote{
    partial class SongForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.senseHeaderCtrl = new StedySoft.SenseSDK.SenseHeaderControl();
            this.senseListCtrl = new StedySoft.SenseSDK.SenseListControl();
            this.mnuControls = new System.Windows.Forms.MenuItem();
            this.mnuDateTime = new System.Windows.Forms.MenuItem();
            this.sip = new Microsoft.WindowsCE.Forms.InputPanel(this.components);
            this.SuspendLayout();
            // 
            // senseHeaderCtrl
            // 
            this.senseHeaderCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.senseHeaderCtrl.Location = new System.Drawing.Point(0, 0);
            this.senseHeaderCtrl.Name = "senseHeaderCtrl";
            this.senseHeaderCtrl.Size = new System.Drawing.Size(480, 25);
            this.senseHeaderCtrl.TabIndex = 0;
            this.senseHeaderCtrl.Text = "Music";
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
            this.senseListCtrl.Size = new System.Drawing.Size(480, 775);
            this.senseListCtrl.Springback = 0.35F;
            this.senseListCtrl.TabIndex = 1;
            this.senseListCtrl.ThreadSleep = 100;
            this.senseListCtrl.TopIndex = 0;
            this.senseListCtrl.Velocity = 0.9F;
            // 
            // mnuControls
            // 
            this.mnuControls.Text = "";
            // 
            // mnuDateTime
            // 
            this.mnuDateTime.Text = "";
            // 
            // SongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 800);
            this.ControlBox = false;
            this.Controls.Add(this.senseListCtrl);
            this.Controls.Add(this.senseHeaderCtrl);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox = false;
            this.Name = "SongForm";
            this.Text = "Music";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListDemo_Load);
            this.Closed += new System.EventHandler(this.frmListDemo_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmListDemo_Closing);
            this.ResumeLayout(false);

        }
        #endregion

        private StedySoft.SenseSDK.SenseHeaderControl senseHeaderCtrl;
        private StedySoft.SenseSDK.SenseListControl senseListCtrl;
        private System.Windows.Forms.MenuItem mnuControls;
        private System.Windows.Forms.MenuItem mnuDateTime;
        private Microsoft.WindowsCE.Forms.InputPanel sip;
    }
}
