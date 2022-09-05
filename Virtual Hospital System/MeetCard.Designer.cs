
namespace Virtual_Hospital_System
{
    partial class MeetCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetCard));
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmLabel = new System.Windows.Forms.Label();
            this.kgLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.deletePic = new System.Windows.Forms.PictureBox();
            this.showPic = new System.Windows.Forms.PictureBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.meetDateLabel = new System.Windows.Forms.Label();
            this.tcLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.profileBox = new System.Windows.Forms.PictureBox();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.panel12.Controls.Add(this.panel1);
            this.panel12.Controls.Add(this.idLabel);
            this.panel12.Controls.Add(this.meetDateLabel);
            this.panel12.Controls.Add(this.tcLabel);
            this.panel12.Controls.Add(this.nameLabel);
            this.panel12.Controls.Add(this.profileBox);
            this.panel12.Location = new System.Drawing.Point(20, 3);
            this.panel12.Margin = new System.Windows.Forms.Padding(30, 30, 5, 15);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(347, 110);
            this.panel12.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.cmLabel);
            this.panel1.Controls.Add(this.kgLabel);
            this.panel1.Controls.Add(this.ageLabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.deletePic);
            this.panel1.Controls.Add(this.showPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 30);
            this.panel1.TabIndex = 19;
            // 
            // cmLabel
            // 
            this.cmLabel.AutoEllipsis = true;
            this.cmLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.cmLabel.Location = new System.Drawing.Point(143, 6);
            this.cmLabel.Name = "cmLabel";
            this.cmLabel.Size = new System.Drawing.Size(60, 19);
            this.cmLabel.TabIndex = 24;
            this.cmLabel.Text = "Boy: 171";
            // 
            // kgLabel
            // 
            this.kgLabel.AutoEllipsis = true;
            this.kgLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kgLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.kgLabel.Location = new System.Drawing.Point(67, 6);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(60, 19);
            this.kgLabel.TabIndex = 23;
            this.kgLabel.Text = "Kilo: 75";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoEllipsis = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ageLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.ageLabel.Location = new System.Drawing.Point(1, 6);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(60, 19);
            this.ageLabel.TabIndex = 22;
            this.ageLabel.Text = "Yaş: 28";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(262, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // deletePic
            // 
            this.deletePic.Image = ((System.Drawing.Image)(resources.GetObject("deletePic.Image")));
            this.deletePic.Location = new System.Drawing.Point(292, 3);
            this.deletePic.Name = "deletePic";
            this.deletePic.Size = new System.Drawing.Size(24, 24);
            this.deletePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deletePic.TabIndex = 20;
            this.deletePic.TabStop = false;
            this.deletePic.Click += new System.EventHandler(this.deletePic_Click);
            // 
            // showPic
            // 
            this.showPic.Image = ((System.Drawing.Image)(resources.GetObject("showPic.Image")));
            this.showPic.Location = new System.Drawing.Point(322, 3);
            this.showPic.Name = "showPic";
            this.showPic.Size = new System.Drawing.Size(24, 24);
            this.showPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPic.TabIndex = 19;
            this.showPic.TabStop = false;
            this.showPic.Click += new System.EventHandler(this.showPic_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoEllipsis = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.idLabel.Location = new System.Drawing.Point(214, 58);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(130, 19);
            this.idLabel.TabIndex = 18;
            this.idLabel.Text = "ID: jkmhdğişönna";
            // 
            // meetDateLabel
            // 
            this.meetDateLabel.AutoEllipsis = true;
            this.meetDateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.meetDateLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.meetDateLabel.Location = new System.Drawing.Point(0, 58);
            this.meetDateLabel.Name = "meetDateLabel";
            this.meetDateLabel.Size = new System.Drawing.Size(208, 19);
            this.meetDateLabel.TabIndex = 17;
            this.meetDateLabel.Text = "Randevu: 28/08/2022  10:45";
            // 
            // tcLabel
            // 
            this.tcLabel.AutoEllipsis = true;
            this.tcLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.tcLabel.Location = new System.Drawing.Point(59, 33);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(132, 19);
            this.tcLabel.TabIndex = 16;
            this.tcLabel.Text = "TC: 30750312345";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(55, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(223, 26);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Abdulzarrak BinbirTaşşak";
            // 
            // profileBox
            // 
            this.profileBox.Image = ((System.Drawing.Image)(resources.GetObject("profileBox.Image")));
            this.profileBox.Location = new System.Drawing.Point(3, 3);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(50, 50);
            this.profileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileBox.TabIndex = 14;
            this.profileBox.TabStop = false;
            // 
            // MeetCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(374, 131);
            this.Controls.Add(this.panel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeetCard";
            this.Text = "MeetCard";
            this.Load += new System.EventHandler(this.MeetCard_Load);
            this.panel12.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox deletePic;
        private System.Windows.Forms.PictureBox showPic;
        private System.Windows.Forms.PictureBox profileBox;
        public System.Windows.Forms.Label tcLabel;
        public System.Windows.Forms.Label nameLabel;
        public System.Windows.Forms.Label cmLabel;
        public System.Windows.Forms.Label kgLabel;
        public System.Windows.Forms.Label ageLabel;
        public System.Windows.Forms.Label idLabel;
        public System.Windows.Forms.Label meetDateLabel;
    }
}