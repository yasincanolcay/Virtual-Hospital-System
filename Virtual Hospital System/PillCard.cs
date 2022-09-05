using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class PillCard : Form
    {
        public int id = 0;
        public PillsPage page = new PillsPage();
        public Panel viewerPanel = new Panel();
        public int loginId = 0;
        public Button refreshButton = new Button();
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public PillCard()
        {
            InitializeComponent();
        }

        private void deletePic_Click(object sender, EventArgs e)
        {
            WarningCard warning = new WarningCard();
            warning.parameters = "Pills";
            warning.Id = id;
            warning.refreshButton = refreshButton;
            warning.headerLabel.Text = "İLAÇ SİLİNECEK";
            warning.detailLabel.Text = "Bu ilaç kalıcı olarak silinecek, ilacı silmek istediğinizden emin misiniz?";
            warning.ShowDialog();
        }

        private void showPic_Click(object sender, EventArgs e)
        {
            editAndShow();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            editAndShow();
        }
        private void editAndShow()
        {
            AddPill pill = new AddPill();
            pill.TopLevel = false;
            pill.Dock = DockStyle.Fill;
            pill.loginId = loginId;
            pill.viewerPanel = viewerPanel;
            pill.page = page;
            pill.id = id;
            pill.editMode = true;
            pill.pageMode = true;
            pill.backgroundColor = backgroundColor;
            viewerPanel.Controls.Clear();
            viewerPanel.Controls.Add(pill);
            pill.Show();
        }

        private void PillCard_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            panel12.BackColor = panelColor;
        }
    }
}
