
namespace Virtual_Hospital_System
{
    partial class SecurityAnswer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityAnswer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closePic = new System.Windows.Forms.PictureBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.nextLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.securityQuestionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // closePic
            // 
            this.closePic.Image = ((System.Drawing.Image)(resources.GetObject("closePic.Image")));
            this.closePic.Location = new System.Drawing.Point(764, 0);
            this.closePic.Name = "closePic";
            this.closePic.Size = new System.Drawing.Size(30, 30);
            this.closePic.TabIndex = 3;
            this.closePic.TabStop = false;
            this.closePic.Click += new System.EventHandler(this.closePic_Click);
            // 
            // answerTextBox
            // 
            this.answerTextBox.BackColor = System.Drawing.Color.CadetBlue;
            this.answerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerTextBox.ForeColor = System.Drawing.Color.LightBlue;
            this.answerTextBox.Location = new System.Drawing.Point(465, 145);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(264, 44);
            this.answerTextBox.TabIndex = 54;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(444, 11);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(306, 46);
            this.headerLabel.TabIndex = 53;
            this.headerLabel.Text = "Güvenlik Sorusu";
            // 
            // nextLabel
            // 
            this.nextLabel.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.nextLabel.AutoSize = true;
            this.nextLabel.BackColor = System.Drawing.Color.White;
            this.nextLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nextLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.nextLabel.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.nextLabel.Location = new System.Drawing.Point(689, 242);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(73, 26);
            this.nextLabel.TabIndex = 56;
            this.nextLabel.TabStop = true;
            this.nextLabel.Text = "İLERLE";
            this.nextLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nextLabel_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(608, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 205);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // securityQuestionLabel
            // 
            this.securityQuestionLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.securityQuestionLabel.ForeColor = System.Drawing.Color.White;
            this.securityQuestionLabel.Location = new System.Drawing.Point(444, 57);
            this.securityQuestionLabel.Name = "securityQuestionLabel";
            this.securityQuestionLabel.Size = new System.Drawing.Size(306, 85);
            this.securityQuestionLabel.TabIndex = 57;
            this.securityQuestionLabel.Text = "Güvenlik Sorusu";
            this.securityQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecurityAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(794, 314);
            this.Controls.Add(this.securityQuestionLabel);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.nextLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.closePic);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecurityAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güvenlik Sorusu";
            this.Load += new System.EventHandler(this.SecurityAnswer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox closePic;
        public System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.LinkLabel nextLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label securityQuestionLabel;
    }
}