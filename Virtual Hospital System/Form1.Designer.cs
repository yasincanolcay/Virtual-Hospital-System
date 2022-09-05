
namespace Virtual_Hospital_System
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftMenuPanel = new System.Windows.Forms.Panel();
            this.devonesoftLabel = new System.Windows.Forms.Label();
            this.navigatorPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.pilButton = new System.Windows.Forms.Button();
            this.sickButton = new System.Windows.Forms.Button();
            this.meetButton = new System.Windows.Forms.Button();
            this.reminderButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.menuAppPanel = new System.Windows.Forms.Panel();
            this.appName = new System.Windows.Forms.Label();
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.AppName2 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topActionPanel = new System.Windows.Forms.Panel();
            this.nightModeIcon = new System.Windows.Forms.PictureBox();
            this.nightModeToggle = new System.Windows.Forms.PictureBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.actionsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.addButton = new System.Windows.Forms.Button();
            this.addContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hastaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misafirEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.profilePhoto = new System.Windows.Forms.PictureBox();
            this.doctorStatuLabel = new System.Windows.Forms.Label();
            this.morePic = new System.Windows.Forms.PictureBox();
            this.moreContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PageViewerPanel = new System.Windows.Forms.Panel();
            this.notificationTimer = new System.Windows.Forms.Timer(this.components);
            this.leftMenuPanel.SuspendLayout();
            this.menuAppPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            this.topPanel.SuspendLayout();
            this.topActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightModeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightModeToggle)).BeginInit();
            this.helpContextMenu.SuspendLayout();
            this.actionsContextMenuStrip.SuspendLayout();
            this.addContextStrip.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.morePic)).BeginInit();
            this.moreContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftMenuPanel
            // 
            this.leftMenuPanel.AutoScroll = true;
            this.leftMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.leftMenuPanel.Controls.Add(this.devonesoftLabel);
            this.leftMenuPanel.Controls.Add(this.navigatorPanel);
            this.leftMenuPanel.Controls.Add(this.settingsButton);
            this.leftMenuPanel.Controls.Add(this.notesButton);
            this.leftMenuPanel.Controls.Add(this.profileButton);
            this.leftMenuPanel.Controls.Add(this.pilButton);
            this.leftMenuPanel.Controls.Add(this.sickButton);
            this.leftMenuPanel.Controls.Add(this.meetButton);
            this.leftMenuPanel.Controls.Add(this.reminderButton);
            this.leftMenuPanel.Controls.Add(this.dashboardButton);
            this.leftMenuPanel.Controls.Add(this.menuAppPanel);
            this.leftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMenuPanel.Name = "leftMenuPanel";
            this.leftMenuPanel.Size = new System.Drawing.Size(214, 552);
            this.leftMenuPanel.TabIndex = 0;
            // 
            // devonesoftLabel
            // 
            this.devonesoftLabel.BackColor = System.Drawing.Color.Transparent;
            this.devonesoftLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.devonesoftLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.devonesoftLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.devonesoftLabel.Location = new System.Drawing.Point(0, 520);
            this.devonesoftLabel.Name = "devonesoftLabel";
            this.devonesoftLabel.Size = new System.Drawing.Size(214, 32);
            this.devonesoftLabel.TabIndex = 22;
            this.devonesoftLabel.Text = "©DevoneSoft";
            this.devonesoftLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // navigatorPanel
            // 
            this.navigatorPanel.BackColor = System.Drawing.Color.White;
            this.navigatorPanel.Location = new System.Drawing.Point(0, 443);
            this.navigatorPanel.Name = "navigatorPanel";
            this.navigatorPanel.Size = new System.Drawing.Size(5, 48);
            this.navigatorPanel.TabIndex = 7;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsButton.Location = new System.Drawing.Point(0, 470);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(214, 48);
            this.settingsButton.TabIndex = 21;
            this.settingsButton.Text = "Ayarlar";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // notesButton
            // 
            this.notesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.notesButton.FlatAppearance.BorderSize = 0;
            this.notesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notesButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notesButton.ForeColor = System.Drawing.Color.White;
            this.notesButton.Image = ((System.Drawing.Image)(resources.GetObject("notesButton.Image")));
            this.notesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.notesButton.Location = new System.Drawing.Point(0, 422);
            this.notesButton.Name = "notesButton";
            this.notesButton.Size = new System.Drawing.Size(214, 48);
            this.notesButton.TabIndex = 20;
            this.notesButton.Text = "Notlar";
            this.notesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.notesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.notesButton.UseVisualStyleBackColor = true;
            this.notesButton.Click += new System.EventHandler(this.notesButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profileButton.ForeColor = System.Drawing.Color.White;
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileButton.Location = new System.Drawing.Point(0, 374);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(214, 48);
            this.profileButton.TabIndex = 19;
            this.profileButton.Text = "Profil";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.profileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // pilButton
            // 
            this.pilButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pilButton.FlatAppearance.BorderSize = 0;
            this.pilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pilButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pilButton.ForeColor = System.Drawing.Color.White;
            this.pilButton.Image = ((System.Drawing.Image)(resources.GetObject("pilButton.Image")));
            this.pilButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pilButton.Location = new System.Drawing.Point(0, 326);
            this.pilButton.Name = "pilButton";
            this.pilButton.Size = new System.Drawing.Size(214, 48);
            this.pilButton.TabIndex = 18;
            this.pilButton.Text = "İlaçlar";
            this.pilButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pilButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.pilButton.UseVisualStyleBackColor = true;
            this.pilButton.Click += new System.EventHandler(this.pilButton_Click);
            // 
            // sickButton
            // 
            this.sickButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sickButton.FlatAppearance.BorderSize = 0;
            this.sickButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sickButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sickButton.ForeColor = System.Drawing.Color.White;
            this.sickButton.Image = ((System.Drawing.Image)(resources.GetObject("sickButton.Image")));
            this.sickButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sickButton.Location = new System.Drawing.Point(0, 278);
            this.sickButton.Name = "sickButton";
            this.sickButton.Size = new System.Drawing.Size(214, 48);
            this.sickButton.TabIndex = 17;
            this.sickButton.Text = "Hastalar";
            this.sickButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sickButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.sickButton.UseVisualStyleBackColor = true;
            this.sickButton.Click += new System.EventHandler(this.sickButton_Click);
            // 
            // meetButton
            // 
            this.meetButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.meetButton.FlatAppearance.BorderSize = 0;
            this.meetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meetButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.meetButton.ForeColor = System.Drawing.Color.White;
            this.meetButton.Image = ((System.Drawing.Image)(resources.GetObject("meetButton.Image")));
            this.meetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.meetButton.Location = new System.Drawing.Point(0, 230);
            this.meetButton.Name = "meetButton";
            this.meetButton.Size = new System.Drawing.Size(214, 48);
            this.meetButton.TabIndex = 14;
            this.meetButton.Text = "Randevular";
            this.meetButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.meetButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.meetButton.UseVisualStyleBackColor = true;
            this.meetButton.Click += new System.EventHandler(this.meetButton_Click);
            // 
            // reminderButton
            // 
            this.reminderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reminderButton.FlatAppearance.BorderSize = 0;
            this.reminderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reminderButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reminderButton.ForeColor = System.Drawing.Color.White;
            this.reminderButton.Image = ((System.Drawing.Image)(resources.GetObject("reminderButton.Image")));
            this.reminderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reminderButton.Location = new System.Drawing.Point(0, 182);
            this.reminderButton.Name = "reminderButton";
            this.reminderButton.Size = new System.Drawing.Size(214, 48);
            this.reminderButton.TabIndex = 3;
            this.reminderButton.Text = "Hatırlatmalar";
            this.reminderButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reminderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.reminderButton.UseVisualStyleBackColor = true;
            this.reminderButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("dashboardButton.Image")));
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboardButton.Location = new System.Drawing.Point(0, 134);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Size = new System.Drawing.Size(214, 48);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Anasayfa";
            this.dashboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.dashboardButton.UseVisualStyleBackColor = true;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // menuAppPanel
            // 
            this.menuAppPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuAppPanel.Controls.Add(this.appName);
            this.menuAppPanel.Controls.Add(this.appIcon);
            this.menuAppPanel.Controls.Add(this.AppName2);
            this.menuAppPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuAppPanel.Location = new System.Drawing.Point(0, 0);
            this.menuAppPanel.Name = "menuAppPanel";
            this.menuAppPanel.Size = new System.Drawing.Size(214, 134);
            this.menuAppPanel.TabIndex = 0;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(47, 62);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(138, 22);
            this.appName.TabIndex = 2;
            this.appName.Text = "Virtual Hospital";
            // 
            // appIcon
            // 
            this.appIcon.Image = ((System.Drawing.Image)(resources.GetObject("appIcon.Image")));
            this.appIcon.Location = new System.Drawing.Point(82, 11);
            this.appIcon.Name = "appIcon";
            this.appIcon.Size = new System.Drawing.Size(50, 50);
            this.appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appIcon.TabIndex = 1;
            this.appIcon.TabStop = false;
            // 
            // AppName2
            // 
            this.AppName2.AutoSize = true;
            this.AppName2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AppName2.ForeColor = System.Drawing.Color.White;
            this.AppName2.Location = new System.Drawing.Point(126, 80);
            this.AppName2.Name = "AppName2";
            this.AppName2.Size = new System.Drawing.Size(56, 19);
            this.AppName2.TabIndex = 3;
            this.AppName2.Text = "System";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.topActionPanel);
            this.topPanel.Controls.Add(this.profilePanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(214, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(656, 35);
            this.topPanel.TabIndex = 1;
            // 
            // topActionPanel
            // 
            this.topActionPanel.Controls.Add(this.nightModeIcon);
            this.topActionPanel.Controls.Add(this.nightModeToggle);
            this.topActionPanel.Controls.Add(this.helpButton);
            this.topActionPanel.Controls.Add(this.analysisButton);
            this.topActionPanel.Controls.Add(this.button2);
            this.topActionPanel.Controls.Add(this.addButton);
            this.topActionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topActionPanel.Location = new System.Drawing.Point(217, 0);
            this.topActionPanel.Name = "topActionPanel";
            this.topActionPanel.Size = new System.Drawing.Size(439, 35);
            this.topActionPanel.TabIndex = 1;
            // 
            // nightModeIcon
            // 
            this.nightModeIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.nightModeIcon.Image = ((System.Drawing.Image)(resources.GetObject("nightModeIcon.Image")));
            this.nightModeIcon.Location = new System.Drawing.Point(358, 0);
            this.nightModeIcon.Name = "nightModeIcon";
            this.nightModeIcon.Size = new System.Drawing.Size(37, 35);
            this.nightModeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nightModeIcon.TabIndex = 10;
            this.nightModeIcon.TabStop = false;
            // 
            // nightModeToggle
            // 
            this.nightModeToggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.nightModeToggle.Image = ((System.Drawing.Image)(resources.GetObject("nightModeToggle.Image")));
            this.nightModeToggle.Location = new System.Drawing.Point(395, 0);
            this.nightModeToggle.Name = "nightModeToggle";
            this.nightModeToggle.Size = new System.Drawing.Size(44, 35);
            this.nightModeToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nightModeToggle.TabIndex = 9;
            this.nightModeToggle.TabStop = false;
            this.nightModeToggle.Click += new System.EventHandler(this.nightModeToggle_Click);
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = true;
            this.helpButton.ContextMenuStrip = this.helpContextMenu;
            this.helpButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(187, 0);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(69, 35);
            this.helpButton.TabIndex = 15;
            this.helpButton.Text = "Yardım";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // helpContextMenu
            // 
            this.helpContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.helpContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.helpContextMenu.Name = "addContextStrip";
            this.helpContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.helpContextMenu.Size = new System.Drawing.Size(164, 92);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem4.Text = "Sorun Bildir";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem7.Text = "İstek ve Öneri";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem8.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem8.Text = "Görüş bildir";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem9.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem9.Image")));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem9.Text = "Github sayfamız";
            // 
            // analysisButton
            // 
            this.analysisButton.AutoSize = true;
            this.analysisButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.analysisButton.FlatAppearance.BorderSize = 0;
            this.analysisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analysisButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.analysisButton.ForeColor = System.Drawing.Color.White;
            this.analysisButton.Location = new System.Drawing.Point(118, 0);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.Size = new System.Drawing.Size(69, 35);
            this.analysisButton.TabIndex = 13;
            this.analysisButton.Text = "Analiz";
            this.analysisButton.UseVisualStyleBackColor = true;
            this.analysisButton.Visible = false;
            this.analysisButton.Click += new System.EventHandler(this.analysisButton_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.ContextMenuStrip = this.actionsContextMenuStrip;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(49, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "İşlemler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // actionsContextMenuStrip
            // 
            this.actionsContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.actionsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem5});
            this.actionsContextMenuStrip.Name = "addContextStrip";
            this.actionsContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.actionsContextMenuStrip.Size = new System.Drawing.Size(155, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem1.Text = "Hatırlatıcı Ekle";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem3.Text = "Randevu Ekle";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "İlaç Ekle";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem5.Text = "Not Ekle";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.ContextMenuStrip = this.addContextStrip;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(49, 35);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Kayıt";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addContextStrip
            // 
            this.addContextStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.addContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayıtToolStripMenuItem,
            this.misafirEkleToolStripMenuItem});
            this.addContextStrip.Name = "addContextStrip";
            this.addContextStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.addContextStrip.Size = new System.Drawing.Size(139, 48);
            // 
            // hastaKayıtToolStripMenuItem
            // 
            this.hastaKayıtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaKayıtToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hastaKayıtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hastaKayıtToolStripMenuItem.Image")));
            this.hastaKayıtToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.hastaKayıtToolStripMenuItem.Name = "hastaKayıtToolStripMenuItem";
            this.hastaKayıtToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.hastaKayıtToolStripMenuItem.Text = "Hasta Kayıt";
            this.hastaKayıtToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtToolStripMenuItem_Click);
            // 
            // misafirEkleToolStripMenuItem
            // 
            this.misafirEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.misafirEkleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.misafirEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("misafirEkleToolStripMenuItem.Image")));
            this.misafirEkleToolStripMenuItem.Name = "misafirEkleToolStripMenuItem";
            this.misafirEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.misafirEkleToolStripMenuItem.Text = "Misafir Ekle";
            this.misafirEkleToolStripMenuItem.Click += new System.EventHandler(this.misafirEkleToolStripMenuItem_Click);
            // 
            // profilePanel
            // 
            this.profilePanel.Controls.Add(this.fullNameLabel);
            this.profilePanel.Controls.Add(this.profilePhoto);
            this.profilePanel.Controls.Add(this.doctorStatuLabel);
            this.profilePanel.Controls.Add(this.morePic);
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.profilePanel.Location = new System.Drawing.Point(0, 0);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(217, 35);
            this.profilePanel.TabIndex = 0;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoEllipsis = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fullNameLabel.ForeColor = System.Drawing.Color.White;
            this.fullNameLabel.Location = new System.Drawing.Point(35, 1);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(168, 19);
            this.fullNameLabel.TabIndex = 9;
            this.fullNameLabel.Text = "İsim Soyisim";
            // 
            // profilePhoto
            // 
            this.profilePhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.profilePhoto.Image = ((System.Drawing.Image)(resources.GetObject("profilePhoto.Image")));
            this.profilePhoto.Location = new System.Drawing.Point(0, 0);
            this.profilePhoto.Name = "profilePhoto";
            this.profilePhoto.Size = new System.Drawing.Size(35, 35);
            this.profilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePhoto.TabIndex = 8;
            this.profilePhoto.TabStop = false;
            // 
            // doctorStatuLabel
            // 
            this.doctorStatuLabel.AutoEllipsis = true;
            this.doctorStatuLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.doctorStatuLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.doctorStatuLabel.Location = new System.Drawing.Point(36, 16);
            this.doctorStatuLabel.Name = "doctorStatuLabel";
            this.doctorStatuLabel.Size = new System.Drawing.Size(168, 19);
            this.doctorStatuLabel.TabIndex = 10;
            this.doctorStatuLabel.Text = "Alanı";
            // 
            // morePic
            // 
            this.morePic.ContextMenuStrip = this.moreContextMenu;
            this.morePic.Image = ((System.Drawing.Image)(resources.GetObject("morePic.Image")));
            this.morePic.Location = new System.Drawing.Point(198, 5);
            this.morePic.Name = "morePic";
            this.morePic.Size = new System.Drawing.Size(24, 24);
            this.morePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.morePic.TabIndex = 16;
            this.morePic.TabStop = false;
            this.morePic.Click += new System.EventHandler(this.morePic_Click);
            // 
            // moreContextMenu
            // 
            this.moreContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.moreContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem6});
            this.moreContextMenu.Name = "addContextStrip";
            this.moreContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.moreContextMenu.Size = new System.Drawing.Size(132, 70);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem10.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem10.Image")));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem10.Text = "Yenile";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem11.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem11.Image")));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem11.Text = "Profili Gör";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem6.Image")));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem6.Text = "Çıkış Yap";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PageViewerPanel
            // 
            this.PageViewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageViewerPanel.Location = new System.Drawing.Point(214, 35);
            this.PageViewerPanel.Name = "PageViewerPanel";
            this.PageViewerPanel.Size = new System.Drawing.Size(656, 517);
            this.PageViewerPanel.TabIndex = 2;
            // 
            // notificationTimer
            // 
            this.notificationTimer.Interval = 30000;
            this.notificationTimer.Tick += new System.EventHandler(this.notificationTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(870, 552);
            this.Controls.Add(this.PageViewerPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftMenuPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Hospital";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.leftMenuPanel.ResumeLayout(false);
            this.menuAppPanel.ResumeLayout(false);
            this.menuAppPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topActionPanel.ResumeLayout(false);
            this.topActionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightModeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nightModeToggle)).EndInit();
            this.helpContextMenu.ResumeLayout(false);
            this.actionsContextMenuStrip.ResumeLayout(false);
            this.addContextStrip.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.morePic)).EndInit();
            this.moreContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftMenuPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel menuAppPanel;
        private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Label AppName2;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.Button reminderButton;
        private System.Windows.Forms.Panel navigatorPanel;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.PictureBox profilePhoto;
        private System.Windows.Forms.Label doctorStatuLabel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button pilButton;
        private System.Windows.Forms.Button sickButton;
        private System.Windows.Forms.Button meetButton;
        private System.Windows.Forms.Label devonesoftLabel;
        private System.Windows.Forms.PictureBox morePic;
        private System.Windows.Forms.Panel topActionPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox nightModeIcon;
        private System.Windows.Forms.PictureBox nightModeToggle;
        private System.Windows.Forms.Button analysisButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.ContextMenuStrip addContextStrip;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misafirEkleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip actionsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ContextMenuStrip helpContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ContextMenuStrip moreContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel PageViewerPanel;
        private System.Windows.Forms.Timer notificationTimer;
    }
}

