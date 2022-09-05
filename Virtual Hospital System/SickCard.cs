using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class SickCard : Form
    {
        public Button refreshButton = new Button();
        public SicksPage page = new SicksPage();
        public Panel viewerPanel = new Panel();
        public byte[] photoByte = { };
        public int loginId = 0;
        private int id = 0;
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public int Id { get => id; set => id = value; }
        public SickCard()
        {
            InitializeComponent();
        }

        private void SickCard_Load(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream(photoByte);
            profileBox.Image = Image.FromStream(mem);
            this.BackColor = backgroundColor;
            panel12.BackColor = panelColor;
        }

        private void deletePic_Click(object sender, EventArgs e)
        {
            WarningCard warning = new WarningCard();
            warning.parameters = "Sicks";
            warning.Id = id;
            warning.headerLabel.Text = "Hasta Silinecek";
            warning.detailLabel.Text = "Bu hastanın kaydı kalıcı olarak silinecek, kaydı silmek istediğinize emin misiniz?";
            warning.ShowDialog();
        }

        private void showPic_Click(object sender, EventArgs e)
        {
            editAndShow();
        }
        private void editAndShow()
        {
            AddSick sick = new AddSick();
            sick.TopLevel = false;
            sick.Dock = DockStyle.Fill;
            sick.loginId = loginId;
            sick.editMode = true;
            sick.id = id;
            sick.page = page;
            sick.viewerPanel = viewerPanel;
            sick.pageMode = true;
            sick.backgroundColor = backgroundColor;
            viewerPanel.Controls.Clear();
            viewerPanel.Controls.Add(sick);
            sick.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            editAndShow();
        }
    }
}
