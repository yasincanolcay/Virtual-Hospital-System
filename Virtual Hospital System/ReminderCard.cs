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
    public partial class ReminderCard : Form
    {
        public int loginId = 0;
        private int id = 0;
        public Button refreshButton = new Button();
        public RemindersPage page = new RemindersPage();
        public Panel viewerPanel = new Panel();
        public DateTime date = DateTime.Now;
        public string time = "";
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public int Id { get => id; set => id = value; }
        public ReminderCard()
        {
            InitializeComponent();
        }

        private void deletePic_Click(object sender, EventArgs e)
        {
            WarningCard warning = new WarningCard();
            warning.headerLabel.Text = "HATIRLATICIYI SİL";
            warning.detailLabel.Text = "Bu hatırlatıcı kalıcı olarak silinecektir, hatırlatıcıyı silmek istediğinize emin misiniz?";
            warning.Id = id;
            warning.parameters = "Reminders";
            warning.refreshButton = refreshButton;
            warning.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            editAndShow();
        }

        private void showPic_Click(object sender, EventArgs e)
        {
            editAndShow();
        }
        private void editAndShow()
        {
            viewerPanel.Controls.Clear();
            AddReminders reminders = new AddReminders();
            reminders.TopLevel = false;
            reminders.Dock = DockStyle.Fill;
            reminders.loginId = loginId;
            reminders.editMode = true;
            reminders.pageMode = true;
            reminders.page = page;
            reminders.viewerPanel = viewerPanel;
            reminders.headerTextbox.Text = headerLabel.Text;
            reminders.detailsTextbox.Text = detailsLabel.Text;
            reminders.dateTimePicker1.Value = date;
            reminders.dateTimePicker2.Text = time;
            reminders.id = id;
            reminders.backgroundColor = backgroundColor;
            viewerPanel.Controls.Add(reminders);
            reminders.Show();
        }

        private void ReminderCard_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            panel12.BackColor = panelColor;
        }
    }
}
