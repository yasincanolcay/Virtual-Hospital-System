
namespace Virtual_Hospital_System
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizePic = new System.Windows.Forms.PictureBox();
            this.maximizePic = new System.Windows.Forms.PictureBox();
            this.closePic = new System.Windows.Forms.PictureBox();
            this.appName = new System.Windows.Forms.Label();
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.AppName2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.githubLabel = new System.Windows.Forms.LinkLabel();
            this.registerLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // viewerPanel
            // 
            this.viewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerPanel.Location = new System.Drawing.Point(350, 31);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Size = new System.Drawing.Size(350, 405);
            this.viewerPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minimizePic);
            this.panel1.Controls.Add(this.maximizePic);
            this.panel1.Controls.Add(this.closePic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(350, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 31);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // minimizePic
            // 
            this.minimizePic.Image = ((System.Drawing.Image)(resources.GetObject("minimizePic.Image")));
            this.minimizePic.Location = new System.Drawing.Point(259, 0);
            this.minimizePic.Name = "minimizePic";
            this.minimizePic.Size = new System.Drawing.Size(30, 30);
            this.minimizePic.TabIndex = 2;
            this.minimizePic.TabStop = false;
            this.minimizePic.Click += new System.EventHandler(this.minimizePic_Click);
            this.minimizePic.MouseLeave += new System.EventHandler(this.minimizePic_MouseLeave);
            this.minimizePic.MouseHover += new System.EventHandler(this.minimizePic_MouseHover);
            // 
            // maximizePic
            // 
            this.maximizePic.Image = ((System.Drawing.Image)(resources.GetObject("maximizePic.Image")));
            this.maximizePic.Location = new System.Drawing.Point(289, 0);
            this.maximizePic.Name = "maximizePic";
            this.maximizePic.Size = new System.Drawing.Size(30, 30);
            this.maximizePic.TabIndex = 1;
            this.maximizePic.TabStop = false;
            // 
            // closePic
            // 
            this.closePic.Image = ((System.Drawing.Image)(resources.GetObject("closePic.Image")));
            this.closePic.Location = new System.Drawing.Point(319, 0);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(30, 30);
            this.closePic.TabIndex = 0;
            this.closePic.TabStop = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            this.closePic.MouseLeave += new System.EventHandler(this.closePic_MouseLeave);
            this.closePic.MouseHover += new System.EventHandler(this.closePic_MouseHover);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.BackColor = System.Drawing.Color.White;
            this.appName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appName.ForeColor = System.Drawing.Color.CadetBlue;
            this.appName.Location = new System.Drawing.Point(184, 63);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(164, 26);
            this.appName.TabIndex = 5;
            this.appName.Text = "Virtual Hospital";
            this.appName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appName_MouseDown);
            this.appName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.appName_MouseMove);
            this.appName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.appName_MouseUp);
            // 
            // appIcon
            // 
            this.appIcon.BackColor = System.Drawing.Color.White;
            this.appIcon.Image = ((System.Drawing.Image)(resources.GetObject("appIcon.Image")));
            this.appIcon.Location = new System.Drawing.Point(219, 12);
            this.appIcon.Name = "appIcon";
            this.appIcon.Size = new System.Drawing.Size(50, 50);
            this.appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appIcon.TabIndex = 4;
            this.appIcon.TabStop = false;
            this.appIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appIcon_MouseDown);
            this.appIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.appIcon_MouseMove);
            this.appIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.appIcon_MouseUp);
            // 
            // AppName2
            // 
            this.AppName2.AutoSize = true;
            this.AppName2.BackColor = System.Drawing.Color.White;
            this.AppName2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AppName2.ForeColor = System.Drawing.Color.CadetBlue;
            this.AppName2.Location = new System.Drawing.Point(263, 86);
            this.AppName2.Name = "AppName2";
            this.AppName2.Size = new System.Drawing.Size(64, 19);
            this.AppName2.TabIndex = 6;
            this.AppName2.Text = "System";
            this.AppName2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppName2_MouseDown);
            this.AppName2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AppName2_MouseMove);
            this.AppName2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AppName2_MouseUp);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.linkLabel1.Location = new System.Drawing.Point(12, 408);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 19);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Yardım";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.linkLabel2.Location = new System.Drawing.Point(70, 408);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(83, 19);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Geri Bildirim";
            // 
            // githubLabel
            // 
            this.githubLabel.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.githubLabel.AutoSize = true;
            this.githubLabel.BackColor = System.Drawing.Color.White;
            this.githubLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.githubLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.githubLabel.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.githubLabel.Location = new System.Drawing.Point(159, 408);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(53, 19);
            this.githubLabel.TabIndex = 9;
            this.githubLabel.TabStop = true;
            this.githubLabel.Text = "GitHub";
            this.githubLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLabel_LinkClicked);
            // 
            // registerLabel
            // 
            this.registerLabel.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.Color.White;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.registerLabel.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.registerLabel.Location = new System.Drawing.Point(218, 408);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(54, 19);
            this.registerLabel.TabIndex = 10;
            this.registerLabel.TabStop = true;
            this.registerLabel.Text = "Kayıt ol";
            this.registerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLabel_LinkClicked);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(700, 436);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.githubLabel);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.appIcon);
            this.Controls.Add(this.AppName2);
            this.Controls.Add(this.viewerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Hospital";
            this.Load += new System.EventHandler(this.StartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel viewerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox minimizePic;
        private System.Windows.Forms.PictureBox maximizePic;
        private System.Windows.Forms.PictureBox closePic;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.Label AppName2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel githubLabel;
        private System.Windows.Forms.LinkLabel registerLabel;
    }
}