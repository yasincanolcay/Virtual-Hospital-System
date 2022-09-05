using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class Form1 : Form
    {
        //USERS MOUSE CONTROLS

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]

        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;

        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");

        bool nightMode = false;
        bool AutoNightMode = false;
        bool weather = false;
        bool sendTelegram = false;
        string weatherCity = "";
        Button backPageButton = new Button();
        public int loginId = 0;
        bool isLogOut = false;
        Color backgroundColor = Color.CadetBlue;
        Color panelColor = Color.FromArgb(0, 125, 140);
        Color buttonColor = Color.FromArgb(0, 125, 140);
        Color labelColor = Color.Gainsboro;
        Color settingLabelColor = Color.DarkSlateBlue;
        SoundPlayer player = new SoundPlayer("Assets/notification/notification.wav");
        bool isReady = false;
        bool isread = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            navigatorPanel.Top = dashboardButton.Top;
            navigatorPanel.Height = dashboardButton.Height;
            dashboardButton.BackColor = Color.FromArgb(70, 60, 185, 180);
            backPageButton = dashboardButton;
            loadSettingsData();
            notificationTimer.Enabled = true;
            notificationTimer.Start();
        }
        private void loadSettingsData()
        {
            string query = "SELECT * From [Settings]";
            using (SqlCommand command = new SqlCommand(query,connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["StartNightmode"]) == 1)
                    {
                        nightMode = false;
                        nightModeCheck();
                    }
                    if (Convert.ToInt32(reader["AutoNightmode"]) == 1)
                    {
                        AutoNightMode = true;
                    }
                    if (Convert.ToInt32(reader["SendTelegram"]) == 1)
                    {
                        sendTelegram = true;
                    }
                    if (Convert.ToInt32(reader["Weather"]) == 1)
                    {
                        weather = true;
                    }
                    weatherCity = reader["WeatherCity"].ToString();
                }
                reader.Close();
                connection.Close();
            }
            loadUserData();
            timer1.Enabled = true;
            timer1.Start();
        }
        private void loadUserData()
        {
            using(SqlCommand command = new SqlCommand("SELECT * From [Login] where Id='"+loginId+"'",connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    fullNameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                    doctorStatuLabel.Text = reader["Statu"].ToString();
                    Byte[] data = new byte[0];
                    data = (Byte[])(reader["Photo"]);
                    MemoryStream mem = new MemoryStream(data);
                    profilePhoto.Image = Image.FromStream(mem);
                }
                reader.Close();
                connection.Close();
            }
            loadDasboardPage();
            isReady = true;
            isread = true;
        }
        private void loadDasboardPage()
        {
            PageViewerPanel.Controls.Clear();
            DasboardPage dasboard = new DasboardPage();
            dasboard.TopLevel = false;
            dasboard.Dock = DockStyle.Fill;
            dasboard.loginId = loginId;
            dasboard.weather = weather;
            dasboard.weatherCity = weatherCity;
            dasboard.backgroundColor = backgroundColor;
            dasboard.panelColor = panelColor;
            dasboard.labelColor = labelColor;
            dasboard.backPageButton = backPageButton;
            dasboard.viewerPanel = PageViewerPanel;
            PageViewerPanel.Controls.Add(dasboard);
            dasboard.Show();
        }
        private void loadRemindersPage()
        {
            PageViewerPanel.Controls.Clear();
            RemindersPage reminders = new RemindersPage();
            reminders.TopLevel = false;
            reminders.Dock = DockStyle.Fill;
            reminders.viewerPanel = PageViewerPanel;
            reminders.loginId = loginId;
            reminders.backgroundColor = backgroundColor;
            reminders.panelColor = panelColor;
            PageViewerPanel.Controls.Add(reminders);
            reminders.Show();
        }
        private void loadMeetsPage()
        {
            PageViewerPanel.Controls.Clear();
            MeetsPage meets = new MeetsPage();
            meets.TopLevel = false;
            meets.Dock = DockStyle.Fill;
            meets.viewerPanel = PageViewerPanel;
            meets.loginId = loginId;
            meets.backgroundColor = backgroundColor;
            meets.panelColor = panelColor;
            meets.backPageButton = backPageButton;
            PageViewerPanel.Controls.Add(meets);
            meets.Show();
        }
        private void loadSicksPage()
        {
            PageViewerPanel.Controls.Clear();
            SicksPage sicks = new SicksPage();
            sicks.TopLevel = false;
            sicks.Dock = DockStyle.Fill;
            sicks.viewerPanel = PageViewerPanel;
            sicks.loginId = loginId;
            sicks.backgroundColor = backgroundColor;
            sicks.panelColor = panelColor;
            PageViewerPanel.Controls.Add(sicks);
            sicks.Show();
        }
        private void loadPillsPage()
        {
            PageViewerPanel.Controls.Clear();
            PillsPage pills = new PillsPage();
            pills.TopLevel = false;
            pills.Dock = DockStyle.Fill;
            pills.viewerPanel = PageViewerPanel;
            pills.loginId = loginId;
            pills.backgroundColor = backgroundColor;
            pills.panelColor = panelColor;
            PageViewerPanel.Controls.Add(pills);
            pills.Show();
        }
        private void loadProfilePage()
        {
            PageViewerPanel.Controls.Clear();
            ProfilePage profile = new ProfilePage();
            profile.TopLevel = false;
            profile.Dock = DockStyle.Fill;
            profile.viewerPanel = PageViewerPanel;
            profile.loginId = loginId;
            profile.form = this;
            profile.backgroundColor = backgroundColor;
            profile.panelColor = panelColor;
            profile.item = toolStripMenuItem6;
            PageViewerPanel.Controls.Add(profile);
            profile.Show();
        }
        private void loadNotesPage()
        {
            PageViewerPanel.Controls.Clear();
            NotesPage notes = new NotesPage();
            notes.TopLevel = false;
            notes.Dock = DockStyle.Fill;
            notes.viewerPanel = PageViewerPanel;
            notes.loginId = loginId;
            notes.backgroundColor = backgroundColor;
            notes.panelColor = panelColor;
            notes.darkMode = nightMode;
            PageViewerPanel.Controls.Add(notes);
            notes.Show();
        }
        private void loadSettingsPage()
        {
            PageViewerPanel.Controls.Clear();
            SettingsPage settings = new SettingsPage();
            settings.TopLevel = false;
            settings.Dock = DockStyle.Fill;
            settings.loginId = loginId;
            settings.backgroundColor = backgroundColor;
            settings.labelColor = settingLabelColor;
            PageViewerPanel.Controls.Add(settings);
            settings.Show();
        }
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            navigatorPanel.Top = dashboardButton.Top;
            navigatorPanel.Height = dashboardButton.Height;
            dashboardButton.BackColor = Color.FromArgb(70,60, 185, 180);
            sickButton.BackColor = buttonColor;
            reminderButton.BackColor = buttonColor;
            pilButton.BackColor = buttonColor;
            profileButton.BackColor = buttonColor;
            settingsButton.BackColor = buttonColor;
            meetButton.BackColor = buttonColor;
            notesButton.BackColor = buttonColor;
            backPageButton = dashboardButton;
            loadDasboardPage();
        }

        private void sickButton_Click(object sender, EventArgs e)
        {
            navigatorPanel.Top = sickButton.Top;
            navigatorPanel.Height = sickButton.Height;
            sickButton.BackColor = Color.FromArgb(70, 60, 185, 180);
            dashboardButton.BackColor = buttonColor;
            reminderButton.BackColor = buttonColor;
            pilButton.BackColor = buttonColor;
            profileButton.BackColor = buttonColor;
            settingsButton.BackColor = buttonColor;
            meetButton.BackColor = buttonColor;
            notesButton.BackColor = buttonColor;
            backPageButton = sickButton;
            loadSicksPage();

        }
        //reminder button
        private void button2_Click(object sender, EventArgs e)
        {
            navigatorPanel.Top = reminderButton.Top;
            navigatorPanel.Height = reminderButton.Height;
            reminderButton.BackColor = Color.FromArgb(70, 60, 185, 180);
            dashboardButton.BackColor = buttonColor;
            sickButton.BackColor = buttonColor;
            pilButton.BackColor = buttonColor;
            profileButton.BackColor = buttonColor;
            settingsButton.BackColor = buttonColor;
            meetButton.BackColor = buttonColor;
            notesButton.BackColor = buttonColor;
            backPageButton = reminderButton;
            loadRemindersPage();
        }

        private void pilButton_Click(object sender, EventArgs e)
        {
            navigatorPanel.Top = pilButton.Top;
            navigatorPanel.Height = pilButton.Height;
            pilButton.BackColor = Color.FromArgb(70, 60, 185, 180);
            dashboardButton.BackColor = buttonColor;
            sickButton.BackColor = buttonColor;
            reminderButton.BackColor = buttonColor;
            profileButton.BackColor = buttonColor;
            settingsButton.BackColor = buttonColor;
            meetButton.BackColor = buttonColor;
            notesButton.BackColor = buttonColor;
            backPageButton = pilButton;
            loadPillsPage();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            navigatorPanel.Top = profileButton.Top;
            navigatorPanel.Height = profileButton.Height;
            profileButton.BackColor = Color.FromArgb(70, 60, 185, 180);
            dashboardButton.BackColor = buttonColor;
            sickButton.BackColor = buttonColor;
            reminderButton.BackColor = buttonColor;
            pilButton.BackColor = buttonColor;
            settingsButton.BackColor = buttonColor;
            meetButton.BackColor = buttonColor;
            notesButton.BackColor = buttonColor;
            backPageButton = profileButton;
            loadProfilePage();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            navigatorPanel.Top = settingsButton.Top;
            navigatorPanel.Height = settingsButton.Height;
            settingsButton.BackColor = Color.FromArgb(70, 60, 185, 180);
            dashboardButton.BackColor = buttonColor;
            sickButton.BackColor = buttonColor;
            reminderButton.BackColor = buttonColor;
            pilButton.BackColor = buttonColor;
            profileButton.BackColor = buttonColor;
            meetButton.BackColor = buttonColor;
            notesButton.BackColor = buttonColor;
            backPageButton = settingsButton;
            loadSettingsPage();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void meetButton_Click(object sender, EventArgs e)
        {
            navigatorPanel.Top = meetButton.Top;
            navigatorPanel.Height = meetButton.Height;
            meetButton.BackColor = Color.FromArgb(70, 60, 185, 180);
            dashboardButton.BackColor = buttonColor;
            sickButton.BackColor = buttonColor;
            reminderButton.BackColor = buttonColor;
            pilButton.BackColor = buttonColor;
            profileButton.BackColor = buttonColor;
            settingsButton.BackColor = buttonColor;
            notesButton.BackColor = buttonColor;
            backPageButton = meetButton;
            loadMeetsPage();
        }

        private void notesButton_Click(object sender, EventArgs e)
        {
            navigatorPanel.Top = notesButton.Top;
            navigatorPanel.Height = notesButton.Height;
            notesButton.BackColor = Color.FromArgb(70, 60, 185, 180);
            dashboardButton.BackColor = buttonColor;
            sickButton.BackColor = buttonColor;
            reminderButton.BackColor = buttonColor;
            pilButton.BackColor = buttonColor;
            profileButton.BackColor = buttonColor;
            settingsButton.BackColor = buttonColor;
            meetButton.BackColor = buttonColor;
            backPageButton = notesButton;
            loadNotesPage();
        }

        private void nightModeToggle_Click(object sender, EventArgs e)
        {
            nightModeCheck();
        }
        private void nightModeCheck()
        {
            if (!nightMode)
            {
                nightModeToggle.Image = Image.FromFile("Assets/İcons/switch_on_48px.png");
                nightMode = true;
                backgroundColor = Color.FromArgb(60,60,60);
                panelColor = Color.FromArgb(30,30,30);
                labelColor = Color.GhostWhite;
                buttonColor = Color.FromArgb(30, 30, 30);
                settingLabelColor = Color.Gainsboro;
            }
            else
            {
                nightModeToggle.Image = Image.FromFile("Assets/İcons/switch_off_48px.png");
                nightMode = false;
                backgroundColor = Color.CadetBlue;
                panelColor = Color.FromArgb(0, 125, 140);
                buttonColor = Color.FromArgb(0, 125, 140);
                labelColor = Color.GhostWhite;
                settingLabelColor = Color.DarkSlateBlue;
            }
            topPanel.BackColor = backgroundColor;
            leftMenuPanel.BackColor = panelColor;
            backPageButton.PerformClick();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hastaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageViewerPanel.Controls.Clear();
            AddSick sick = new AddSick();
            sick.TopLevel = false;
            sick.Dock = DockStyle.Fill;
            sick.pageBtn = backPageButton;
            sick.loginId = loginId;
            sick.backgroundColor = backgroundColor;
            PageViewerPanel.Controls.Add(sick);
            sick.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PageViewerPanel.Controls.Clear();
            AddReminders reminders = new AddReminders();
            reminders.TopLevel = false;
            reminders.Dock = DockStyle.Fill;
            reminders.pageBtn = backPageButton;
            reminders.loginId = loginId;
            reminders.backgroundColor = backgroundColor;
            PageViewerPanel.Controls.Add(reminders);
            reminders.Show();
        }

        private void misafirEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageViewerPanel.Controls.Clear();
            AddUser user = new AddUser();
            user.TopLevel = false;
            user.Dock = DockStyle.Fill;
            user.pageBtn = backPageButton;
            user.loginId = loginId;
            PageViewerPanel.Controls.Add(user);
            user.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PageViewerPanel.Controls.Clear();
            AddMeet meet = new AddMeet();
            meet.TopLevel = false;
            meet.Dock = DockStyle.Fill;
            meet.pageBtn = backPageButton;
            meet.loginId = loginId;
            meet.backgroundColor = backgroundColor;
            PageViewerPanel.Controls.Add(meet);
            meet.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PageViewerPanel.Controls.Clear();
            AddPill pill = new AddPill();
            pill.TopLevel = false;
            pill.Dock = DockStyle.Fill;
            pill.pageBtn = backPageButton;
            pill.loginId = loginId;
            pill.backgroundColor = backgroundColor;
            PageViewerPanel.Controls.Add(pill);
            pill.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PageViewerPanel.Controls.Clear();
            AddNote note = new AddNote();
            note.TopLevel = false;
            note.Dock = DockStyle.Fill;
            note.pageBtn = backPageButton;
            note.loginId = loginId;
            note.backgroundColor = backgroundColor;
            PageViewerPanel.Controls.Add(note);
            note.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogOut)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            loadSettingsData();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            profileButton.PerformClick();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            isLogOut = true;
            StartPage start = new StartPage();
            start.Show();
            this.Close();
        }
        private void readReminders()
        {
            SqlConnection connection2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");

            string query = "SELECT * From [Reminders]";
            using(SqlCommand command = new SqlCommand(query,connection2))
            {
                connection2.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(DateTime.Parse(reader["Datetime"].ToString()).Day == DateTime.Now.Day && DateTime.Parse(reader["Datetime"].ToString()).Month == DateTime.Now.Month && DateTime.Parse(reader["Datetime"].ToString()).Year == DateTime.Now.Year)
                    {
                        if (DateTime.Parse(reader["Time"].ToString()).Hour <= DateTime.Now.Hour && DateTime.Parse(reader["Time"].ToString()).Minute <= DateTime.Now.Minute)
                        {
                            if(Convert.ToInt32(reader["isRead"]) == 0)
                            {
                                NotificationShow show = new NotificationShow();
                                show.id = Convert.ToInt32(reader["Id"]);
                                show.headerLabel.Text = reader["Header"].ToString();
                                show.detailsLabel.Text = reader["Details"].ToString();
                                show.ShowDialog();
                            }
                        }
                    }
                }
                reader.Close();
                connection2.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AutoNightMode)
            {
                if(DateTime.Now.Hour > 18 || DateTime.Now.Hour < 6)
                {
                    if (!nightMode)
                    {
                        nightModeCheck();
                    }
                }
                else
                {
                    if (nightMode)
                    {
                        nightModeCheck();
                    }
                }
            }
        }
        public void MouseRightClick()
        {

            int X = Cursor.Position.X;

            int Y = Cursor.Position.Y;

            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Convert.ToUInt32(X), Convert.ToUInt32(Y), 0, 0);
        }

        private void morePic_Click(object sender, EventArgs e)
        {
            MouseRightClick();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            MouseRightClick();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MouseRightClick();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MouseRightClick();
        }

        private void analysisButton_Click(object sender, EventArgs e)
        {
            AnalysisPage analysis = new AnalysisPage();
            analysis.TopLevel = false;
            analysis.Dock = DockStyle.Fill;
            analysis.backPageButton = backPageButton;
            PageViewerPanel.Controls.Clear();
            PageViewerPanel.Controls.Add(analysis);
            analysis.Show();
        }

        private void notificationTimer_Tick(object sender, EventArgs e)
        {
            readReminders();
        }
    }
}