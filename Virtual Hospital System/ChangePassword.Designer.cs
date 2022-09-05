
namespace Virtual_Hospital_System
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.againPasswordTextbox = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.securityQuestionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // againPasswordTextbox
            // 
            this.againPasswordTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.againPasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.againPasswordTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.againPasswordTextbox.ForeColor = System.Drawing.Color.LightBlue;
            this.againPasswordTextbox.Location = new System.Drawing.Point(464, 145);
            this.againPasswordTextbox.Name = "againPasswordTextbox";
            this.againPasswordTextbox.Size = new System.Drawing.Size(264, 44);
            this.againPasswordTextbox.TabIndex = 57;
            // 
            // changeLabel
            // 
            this.changeLabel.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.White;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changeLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.changeLabel.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.changeLabel.Location = new System.Drawing.Point(672, 242);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(101, 26);
            this.changeLabel.TabIndex = 59;
            this.changeLabel.TabStop = true;
            this.changeLabel.Text = "DEĞİŞTİR";
            this.changeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changeLabel_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(607, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.LightBlue;
            this.passwordTextbox.Location = new System.Drawing.Point(464, 63);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(264, 44);
            this.passwordTextbox.TabIndex = 60;
            // 
            // securityQuestionLabel
            // 
            this.securityQuestionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.securityQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.securityQuestionLabel.Location = new System.Drawing.Point(459, 31);
            this.securityQuestionLabel.Name = "securityQuestionLabel";
            this.securityQuestionLabel.Size = new System.Drawing.Size(124, 29);
            this.securityQuestionLabel.TabIndex = 61;
            this.securityQuestionLabel.Text = "Yeni Şifre";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(459, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 62;
            this.label1.Text = "Yeni Şifre Tekrar";
            // 
            // closePic
            // 
            this.closePic.Image = ((System.Drawing.Image)(resources.GetObject("closePic.Image")));
            this.closePic.Location = new System.Drawing.Point(764, 0);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(30, 30);
            this.closePic.TabIndex = 63;
            this.closePic.TabStop = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(794, 314);
            this.Controls.Add(this.closePic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.securityQuestionLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.againPasswordTextbox);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifrenizi Değiştirin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox againPasswordTextbox;
        private System.Windows.Forms.LinkLabel changeLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label securityQuestionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closePic;
    }
}