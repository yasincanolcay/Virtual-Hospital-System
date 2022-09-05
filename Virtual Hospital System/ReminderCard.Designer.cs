
namespace Virtual_Hospital_System
{
    partial class ReminderCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderCard));
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.deletePic = new System.Windows.Forms.PictureBox();
            this.showPic = new System.Windows.Forms.PictureBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.detailsLabel);
            this.panel12.Controls.Add(this.pictureBox10);
            this.panel12.Controls.Add(this.headerLabel);
            this.panel12.Location = new System.Drawing.Point(16, 3);
            this.panel12.Margin = new System.Windows.Forms.Padding(30, 30, 5, 15);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(353, 132);
            this.panel12.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.deletePic);
            this.panel1.Controls.Add(this.showPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 28);
            this.panel1.TabIndex = 6;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoEllipsis = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(6, 3);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(255, 23);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "8/31/2022 03:33";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(267, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // deletePic
            // 
            this.deletePic.Image = ((System.Drawing.Image)(resources.GetObject("deletePic.Image")));
            this.deletePic.Location = new System.Drawing.Point(297, 2);
            this.deletePic.Name = "deletePic";
            this.deletePic.Size = new System.Drawing.Size(24, 24);
            this.deletePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletePic.TabIndex = 17;
            this.deletePic.TabStop = false;
            this.deletePic.Click += new System.EventHandler(this.deletePic_Click);
            // 
            // showPic
            // 
            this.showPic.Image = ((System.Drawing.Image)(resources.GetObject("showPic.Image")));
            this.showPic.Location = new System.Drawing.Point(327, 2);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(24, 24);
            this.showPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPic.TabIndex = 16;
            this.showPic.TabStop = false;
            this.showPic.Click += new System.EventHandler(this.showPic_Click);
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoEllipsis = true;
            this.detailsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.detailsLabel.ForeColor = System.Drawing.Color.White;
            this.detailsLabel.Location = new System.Drawing.Point(6, 31);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(247, 70);
            this.detailsLabel.TabIndex = 5;
            this.detailsLabel.Text = "Bu önemli bir hatırlatmadır";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(259, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(91, 101);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 4;
            this.pictureBox10.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoEllipsis = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(3, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(250, 31);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Önemli";
            // 
            // ReminderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(374, 150);
            this.Controls.Add(this.panel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReminderCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReminderCard";
            this.Load += new System.EventHandler(this.ReminderCard_Load);
            this.panel12.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox deletePic;
        private System.Windows.Forms.PictureBox showPic;
        private System.Windows.Forms.PictureBox pictureBox10;
        public System.Windows.Forms.Label detailsLabel;
        public System.Windows.Forms.Label headerLabel;
        public System.Windows.Forms.Label dateLabel;
    }
}