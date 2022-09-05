
namespace Virtual_Hospital_System
{
    partial class DashboardMeetsCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardMeetsCard));
            this.panel13 = new System.Windows.Forms.Panel();
            this.showButton = new System.Windows.Forms.PictureBox();
            this.meetDateLabel = new System.Windows.Forms.Label();
            this.meetIdLabel = new System.Windows.Forms.Label();
            this.tcLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.profileBox = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.panel13.Controls.Add(this.showButton);
            this.panel13.Controls.Add(this.meetDateLabel);
            this.panel13.Controls.Add(this.meetIdLabel);
            this.panel13.Controls.Add(this.tcLabel);
            this.panel13.Controls.Add(this.fullnameLabel);
            this.panel13.Controls.Add(this.profileBox);
            this.panel13.Controls.Add(this.label20);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Margin = new System.Windows.Forms.Padding(30, 30, 5, 15);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(569, 114);
            this.panel13.TabIndex = 10;
            // 
            // showButton
            // 
            this.showButton.Image = ((System.Drawing.Image)(resources.GetObject("showButton.Image")));
            this.showButton.Location = new System.Drawing.Point(543, 84);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(24, 24);
            this.showButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showButton.TabIndex = 14;
            this.showButton.TabStop = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // meetDateLabel
            // 
            this.meetDateLabel.AutoEllipsis = true;
            this.meetDateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.meetDateLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.meetDateLabel.Location = new System.Drawing.Point(20, 90);
            this.meetDateLabel.Name = "meetDateLabel";
            this.meetDateLabel.Size = new System.Drawing.Size(278, 19);
            this.meetDateLabel.TabIndex = 13;
            this.meetDateLabel.Text = "tarihi";
            // 
            // meetIdLabel
            // 
            this.meetIdLabel.AutoEllipsis = true;
            this.meetIdLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.meetIdLabel.ForeColor = System.Drawing.Color.White;
            this.meetIdLabel.Location = new System.Drawing.Point(325, 0);
            this.meetIdLabel.Name = "meetIdLabel";
            this.meetIdLabel.Size = new System.Drawing.Size(241, 114);
            this.meetIdLabel.TabIndex = 12;
            this.meetIdLabel.Text = "000000";
            this.meetIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcLabel
            // 
            this.tcLabel.AutoEllipsis = true;
            this.tcLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.tcLabel.Location = new System.Drawing.Point(79, 66);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(132, 19);
            this.tcLabel.TabIndex = 11;
            this.tcLabel.Text = "TC:00000";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoEllipsis = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullnameLabel.ForeColor = System.Drawing.Color.White;
            this.fullnameLabel.Location = new System.Drawing.Point(75, 40);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(223, 26);
            this.fullnameLabel.TabIndex = 8;
            this.fullnameLabel.Text = "İsim Soyisim";
            // 
            // profileBox
            // 
            this.profileBox.Image = ((System.Drawing.Image)(resources.GetObject("profileBox.Image")));
            this.profileBox.Location = new System.Drawing.Point(23, 36);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(50, 50);
            this.profileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileBox.TabIndex = 7;
            this.profileBox.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoEllipsis = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(19, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(168, 19);
            this.label20.TabIndex = 6;
            this.label20.Text = "SIRADAKİ HASTA";
            // 
            // DashboardMeetsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(569, 114);
            this.Controls.Add(this.panel13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardMeetsCard";
            this.Text = "DashboardMeetsCard";
            this.Load += new System.EventHandler(this.DashboardMeetsCard_Load);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox showButton;
        private System.Windows.Forms.Label meetDateLabel;
        private System.Windows.Forms.Label meetIdLabel;
        private System.Windows.Forms.Label tcLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.PictureBox profileBox;
        private System.Windows.Forms.Label label20;
    }
}