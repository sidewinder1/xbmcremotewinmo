﻿namespace XBMC_Remote
{
    partial class NowPlayingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NowPlayingForm));
            this.npArtist = new System.Windows.Forms.Label();
            this.NowPlayingImage = new System.Windows.Forms.PictureBox();
            this.butFForward = new System.Windows.Forms.PictureBox();
            this.butPlay = new System.Windows.Forms.PictureBox();
            this.butFBackward = new System.Windows.Forms.PictureBox();
            this.butStop = new System.Windows.Forms.PictureBox();
            this.butPause = new System.Windows.Forms.PictureBox();
            this.butNext = new System.Windows.Forms.PictureBox();
            this.butPrev = new System.Windows.Forms.PictureBox();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.npTitle = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.npAlbum = new System.Windows.Forms.Label();
            this.npRuntime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // npArtist
            // 
            this.npArtist.Location = new System.Drawing.Point(142, 4);
            this.npArtist.Name = "npArtist";
            this.npArtist.Size = new System.Drawing.Size(335, 31);
            this.npArtist.Text = "Loading....";
            this.npArtist.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NowPlayingImage
            // 
            this.NowPlayingImage.Location = new System.Drawing.Point(58, 144);
            this.NowPlayingImage.Name = "NowPlayingImage";
            this.NowPlayingImage.Size = new System.Drawing.Size(366, 371);
            this.NowPlayingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // butFForward
            // 
            this.butFForward.Image = ((System.Drawing.Image)(resources.GetObject("butFForward.Image")));
            this.butFForward.Location = new System.Drawing.Point(308, 521);
            this.butFForward.Name = "butFForward";
            this.butFForward.Size = new System.Drawing.Size(172, 112);
            this.butFForward.Click += new System.EventHandler(this.butFForward_Click);
            // 
            // butPlay
            // 
            this.butPlay.Image = ((System.Drawing.Image)(resources.GetObject("butPlay.Image")));
            this.butPlay.Location = new System.Drawing.Point(171, 521);
            this.butPlay.Name = "butPlay";
            this.butPlay.Size = new System.Drawing.Size(138, 112);
            this.butPlay.Click += new System.EventHandler(this.butPlay_Click);
            // 
            // butFBackward
            // 
            this.butFBackward.Image = ((System.Drawing.Image)(resources.GetObject("butFBackward.Image")));
            this.butFBackward.Location = new System.Drawing.Point(0, 521);
            this.butFBackward.Name = "butFBackward";
            this.butFBackward.Size = new System.Drawing.Size(172, 112);
            this.butFBackward.Click += new System.EventHandler(this.butFBackward_Click);
            // 
            // butStop
            // 
            this.butStop.Image = ((System.Drawing.Image)(resources.GetObject("butStop.Image")));
            this.butStop.Location = new System.Drawing.Point(142, 632);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(98, 116);
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // butPause
            // 
            this.butPause.Image = ((System.Drawing.Image)(resources.GetObject("butPause.Image")));
            this.butPause.Location = new System.Drawing.Point(240, 632);
            this.butPause.Name = "butPause";
            this.butPause.Size = new System.Drawing.Size(98, 120);
            this.butPause.Click += new System.EventHandler(this.butPause_Click);
            // 
            // butNext
            // 
            this.butNext.Image = ((System.Drawing.Image)(resources.GetObject("butNext.Image")));
            this.butNext.Location = new System.Drawing.Point(338, 632);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(142, 120);
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butPrev
            // 
            this.butPrev.Image = ((System.Drawing.Image)(resources.GetObject("butPrev.Image")));
            this.butPrev.Location = new System.Drawing.Point(0, 632);
            this.butPrev.Name = "butPrev";
            this.butPrev.Size = new System.Drawing.Size(142, 120);
            this.butPrev.Click += new System.EventHandler(this.butPrev_Click);
            // 
            // lbArtist
            // 
            this.lbArtist.Location = new System.Drawing.Point(4, 4);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(138, 27);
            this.lbArtist.Text = "Artist:";
            // 
            // lbTitle
            // 
            this.lbTitle.Location = new System.Drawing.Point(4, 35);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(138, 28);
            this.lbTitle.Text = "Title:";
            // 
            // npTitle
            // 
            this.npTitle.Location = new System.Drawing.Point(142, 35);
            this.npTitle.Name = "npTitle";
            this.npTitle.Size = new System.Drawing.Size(335, 31);
            this.npTitle.Text = "Loading....";
            this.npTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbAlbum
            // 
            this.lbAlbum.Location = new System.Drawing.Point(4, 69);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(138, 28);
            this.lbAlbum.Text = "Album:";
            // 
            // npAlbum
            // 
            this.npAlbum.Location = new System.Drawing.Point(142, 66);
            this.npAlbum.Name = "npAlbum";
            this.npAlbum.Size = new System.Drawing.Size(335, 31);
            this.npAlbum.Text = "Loading....";
            this.npAlbum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // npRuntime
            // 
            this.npRuntime.Location = new System.Drawing.Point(40, 101);
            this.npRuntime.Name = "npRuntime";
            this.npRuntime.Size = new System.Drawing.Size(400, 40);
            this.npRuntime.Text = "/";
            this.npRuntime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NowPlayingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(480, 748);
            this.Controls.Add(this.npRuntime);
            this.Controls.Add(this.npAlbum);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.npTitle);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.butFForward);
            this.Controls.Add(this.butPlay);
            this.Controls.Add(this.butFBackward);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butPause);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.butPrev);
            this.Controls.Add(this.NowPlayingImage);
            this.Controls.Add(this.npArtist);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 52);
            this.Name = "NowPlayingForm";
            this.Text = "Now Playing";
            this.Load += new System.EventHandler(this.NowPlayingForm_Load);
            this.LostFocus += new System.EventHandler(this.NowPlayingForm_LostFocus);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NowPlayingForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label npArtist;
        private System.Windows.Forms.PictureBox NowPlayingImage;
        private System.Windows.Forms.PictureBox butFForward;
        private System.Windows.Forms.PictureBox butPlay;
        private System.Windows.Forms.PictureBox butFBackward;
        private System.Windows.Forms.PictureBox butStop;
        private System.Windows.Forms.PictureBox butPause;
        private System.Windows.Forms.PictureBox butNext;
        private System.Windows.Forms.PictureBox butPrev;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label npTitle;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.Label npAlbum;
        private System.Windows.Forms.Label npRuntime;

    }
}