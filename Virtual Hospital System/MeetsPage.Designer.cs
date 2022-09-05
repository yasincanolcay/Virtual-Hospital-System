
namespace Virtual_Hospital_System
{
    partial class MeetsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetsPage));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.activeButton = new System.Windows.Forms.Button();
            this.lossButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.searchPic = new System.Windows.Forms.PictureBox();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(640, 441);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.activeButton);
            this.panel1.Controls.Add(this.lossButton);
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Controls.Add(this.allButton);
            this.panel1.Controls.Add(this.searchPic);
            this.panel1.Controls.Add(this.searchTextbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 42);
            this.panel1.TabIndex = 2;
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(285, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(32, 42);
            this.refreshButton.TabIndex = 33;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // activeButton
            // 
            this.activeButton.AutoSize = true;
            this.activeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.activeButton.FlatAppearance.BorderSize = 0;
            this.activeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.activeButton.ForeColor = System.Drawing.Color.White;
            this.activeButton.Location = new System.Drawing.Point(189, 0);
            this.activeButton.Name = "activeButton";
            this.activeButton.Size = new System.Drawing.Size(96, 42);
            this.activeButton.TabIndex = 32;
            this.activeButton.Tag = "";
            this.activeButton.Text = "Aktif Olanlar";
            this.activeButton.UseVisualStyleBackColor = true;
            this.activeButton.Click += new System.EventHandler(this.activeButton_Click);
            // 
            // lossButton
            // 
            this.lossButton.AutoSize = true;
            this.lossButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.lossButton.FlatAppearance.BorderSize = 0;
            this.lossButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lossButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lossButton.ForeColor = System.Drawing.Color.White;
            this.lossButton.Location = new System.Drawing.Point(125, 0);
            this.lossButton.Name = "lossButton";
            this.lossButton.Size = new System.Drawing.Size(64, 42);
            this.lossButton.TabIndex = 31;
            this.lossButton.Text = "Geçmiş";
            this.lossButton.UseVisualStyleBackColor = true;
            this.lossButton.Click += new System.EventHandler(this.lossButton_Click);
            // 
            // newButton
            // 
            this.newButton.AutoSize = true;
            this.newButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.newButton.FlatAppearance.BorderSize = 0;
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Location = new System.Drawing.Point(61, 0);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(64, 42);
            this.newButton.TabIndex = 30;
            this.newButton.Text = "En Yeni";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // allButton
            // 
            this.allButton.AutoSize = true;
            this.allButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.allButton.FlatAppearance.BorderSize = 0;
            this.allButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.allButton.ForeColor = System.Drawing.Color.White;
            this.allButton.Location = new System.Drawing.Point(0, 0);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(61, 42);
            this.allButton.TabIndex = 29;
            this.allButton.Text = "Tümü";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // searchPic
            // 
            this.searchPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPic.Image = ((System.Drawing.Image)(resources.GetObject("searchPic.Image")));
            this.searchPic.Location = new System.Drawing.Point(602, 5);
            this.searchPic.Name = "searchPic";
            this.searchPic.Size = new System.Drawing.Size(32, 32);
            this.searchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchPic.TabIndex = 16;
            this.searchPic.TabStop = false;
            this.searchPic.Click += new System.EventHandler(this.searchPic_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchTextbox.BackColor = System.Drawing.Color.CadetBlue;
            this.searchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTextbox.ForeColor = System.Drawing.Color.White;
            this.searchTextbox.Location = new System.Drawing.Point(331, 5);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(265, 32);
            this.searchTextbox.TabIndex = 34;
            this.searchTextbox.Text = "Ara...";
            this.searchTextbox.Click += new System.EventHandler(this.searchTextbox_Click);
            this.searchTextbox.TextChanged += new System.EventHandler(this.searchTextbox_TextChanged);
            // 
            // MeetsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(640, 483);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeetsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeetsPage";
            this.Load += new System.EventHandler(this.MeetsPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button activeButton;
        private System.Windows.Forms.Button lossButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.PictureBox searchPic;
        private System.Windows.Forms.TextBox searchTextbox;
    }
}