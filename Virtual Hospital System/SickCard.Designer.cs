
namespace Virtual_Hospital_System
{
    partial class SickCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SickCard));
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmLabel = new System.Windows.Forms.Label();
            this.kgLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.deletePic = new System.Windows.Forms.PictureBox();
            this.showPic = new System.Windows.Forms.PictureBox();
            this.savedLabel = new System.Windows.Forms.Label();
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
            this.panel12.Controls.Add(this.savedLabel);
            this.panel12.Controls.Add(this.tcLabel);
            this.panel12.Controls.Add(this.nameLabel);
            this.panel12.Controls.Add(this.profileBox);
            this.panel12.Location = new System.Drawing.Point(21, 7);
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
            this.panel1.TabIndex = 20;
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
            // savedLabel
            // 
            this.savedLabel.AutoEllipsis = true;
            this.savedLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.savedLabel.ForeColor = System.Drawing.Color.LightBlue;
            this.savedLabel.Location = new System.Drawing.Point(3, 58);
            this.savedLabel.Name = "savedLabel";
            this.savedLabel.Size = new System.Drawing.Size(208, 19);
            this.savedLabel.TabIndex = 18;
            this.savedLabel.Text = "Kayıt: 28/08/2022  10:45";
            // 
            // tcLabel
            // 
            this.tcLabel.AutoEllipsis = true;
            this.tcLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.tcLabel.Location = new System.Drawing.Point(61, 35);
            this.tcLabel.Name = "tcLabel";
            this.tcLabel.Size = new System.Drawing.Size(283, 19);
            this.tcLabel.TabIndex = 14;
            this.tcLabel.Text = "TC: 30750312345";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoEllipsis = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(57, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(287, 26);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Abdulzarrak BinbirTaşşak";
            // 
            // profileBox
            // 
            this.profileBox.Image = ((System.Drawing.Image)(resources.GetObject("profileBox.Image")));
            this.profileBox.Location = new System.Drawing.Point(5, 5);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(50, 50);
            this.profileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileBox.TabIndex = 12;
            this.profileBox.TabStop = false;
            // 
            // SickCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(376, 140);
            this.Controls.Add(this.panel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SickCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SickCard";
            this.Load += new System.EventHandler(this.SickCard_Load);
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
        public System.Windows.Forms.Label cmLabel;
        public System.Windows.Forms.Label kgLabel;
        public System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox deletePic;
        private System.Windows.Forms.PictureBox showPic;
        public System.Windows.Forms.Label savedLabel;
        private System.Windows.Forms.PictureBox profileBox;
        public System.Windows.Forms.Label tcLabel;
        public System.Windows.Forms.Label nameLabel;
    }
}