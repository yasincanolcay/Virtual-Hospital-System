
namespace Virtual_Hospital_System
{
    partial class LoginCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCard));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.uyariLabel = new System.Windows.Forms.Label();
            this.forgotPasswordLabel = new System.Windows.Forms.LinkLabel();
            this.topLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.securityTimer = new System.Windows.Forms.Timer(this.components);
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.uyariLabel);
            this.loginPanel.Controls.Add(this.forgotPasswordLabel);
            this.loginPanel.Controls.Add(this.topLabel);
            this.loginPanel.Controls.Add(this.usernameBox);
            this.loginPanel.Controls.Add(this.passwordBox);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(350, 405);
            this.loginPanel.TabIndex = 2;
            this.loginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseDown);
            this.loginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseMove);
            this.loginPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginPanel_MouseUp);
            // 
            // uyariLabel
            // 
            this.uyariLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uyariLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uyariLabel.Location = new System.Drawing.Point(92, 260);
            this.uyariLabel.Name = "uyariLabel";
            this.uyariLabel.Size = new System.Drawing.Size(141, 22);
            this.uyariLabel.TabIndex = 51;
            this.uyariLabel.Text = "...";
            this.uyariLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uyariLabel.Visible = false;
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.forgotPasswordLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotPasswordLabel.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(198, 239);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(110, 19);
            this.forgotPasswordLabel.TabIndex = 50;
            this.forgotPasswordLabel.TabStop = true;
            this.forgotPasswordLabel.Text = "Şifremi unuttum";
            this.forgotPasswordLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPasswordLabel_LinkClicked);
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topLabel.ForeColor = System.Drawing.Color.White;
            this.topLabel.Location = new System.Drawing.Point(92, 69);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(170, 61);
            this.topLabel.TabIndex = 49;
            this.topLabel.Text = "VIRTUAL HOSPITAL GİRİŞ";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topLabel_MouseDown);
            this.topLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLabel_MouseMove);
            this.topLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topLabel_MouseUp);
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.CadetBlue;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameBox.ForeColor = System.Drawing.Color.LightBlue;
            this.usernameBox.Location = new System.Drawing.Point(44, 136);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(264, 44);
            this.usernameBox.TabIndex = 48;
            this.usernameBox.Text = "kullanıcı adı";
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            this.usernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameBox_KeyDown);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.CadetBlue;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordBox.ForeColor = System.Drawing.Color.LightBlue;
            this.passwordBox.Location = new System.Drawing.Point(44, 187);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(264, 44);
            this.passwordBox.TabIndex = 47;
            this.passwordBox.Text = "Şifre";
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // loginLabel
            // 
            this.loginLabel.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.White;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.loginLabel.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.loginLabel.Location = new System.Drawing.Point(245, 333);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(63, 26);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.TabStop = true;
            this.loginLabel.Text = "GİRİŞ";
            this.loginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 239);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // securityTimer
            // 
            this.securityTimer.Interval = 1000;
            this.securityTimer.Tick += new System.EventHandler(this.securityTimer_Tick);
            // 
            // LoginCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(350, 405);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginCard";
            this.Text = "LoginCard";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel loginLabel;
        public System.Windows.Forms.TextBox usernameBox;
        public System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.LinkLabel forgotPasswordLabel;
        private System.Windows.Forms.Label uyariLabel;
        private System.Windows.Forms.Timer securityTimer;
    }
}