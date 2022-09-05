using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Virtual_Hospital_System
{
    public partial class DasboardPage : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");

        public int loginId = 0;
        private int totalSicks = 0;
        private int totalReminders = 0;
        private int totalPills = 0;
        private int totalMeets = 0;
        private int totalTodayMeets = 0;
        private int totalNotes = 0;
        public string weatherCity = "";
        string weatherStatu = "";
        public bool weather = false;
        public List<int> meetsId = new List<int>();
        int meetIndex = 0;
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public Color labelColor = Color.Gainsboro;
        public Button backPageButton = new Button();
        public Panel viewerPanel = new Panel();
        public DasboardPage()
        {
            InitializeComponent();
        }

        private void DasboardPage_Load(object sender, EventArgs e)
        {
            loadSicks();
            flowLayoutPanel1.BackColor = backgroundColor;
            panel13.BackColor = panelColor;
            panel12.BackColor = panelColor;
            panel10.BackColor = panelColor;
            panel9.BackColor = panelColor;
            panel8.BackColor = panelColor;
            panel7.BackColor = panelColor;
            panel6.BackColor = panelColor;
            panel5.BackColor = panelColor;
        }
        private void loadSicks()
        {
            using (SqlCommand command = new SqlCommand("SELECT * From [Sicks] where LoginId='"+loginId+"'",connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    totalSicks++;
                }
                reader.Close();
                connection.Close();
                totalSicksLabel.Text = totalSicks.ToString();
            }
            loadReminders();
        }
        private void loadReminders()
        {
            using (SqlCommand command = new SqlCommand("SELECT * From [Reminders] where LoginId='" + loginId + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    totalReminders++;
                }
                reader.Close();
                connection.Close();
                totalRemindersLabel.Text = totalReminders.ToString();
            }
            loadPills();
        }
        private void loadPills()
        {
            using (SqlCommand command = new SqlCommand("SELECT * From [Pills] where LoginId='" + loginId + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    totalPills++;
                }
                reader.Close();
                connection.Close();
                totalPillsLabel.Text = totalPills.ToString();
            }
            loadMeets();
        }
        private void loadMeets()
        {
            using (SqlCommand command = new SqlCommand("SELECT * From [Meets] where LoginId='" + loginId + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    totalMeets++;
                    DateTime date = DateTime.Parse(reader["Datetime"].ToString());
                    if (date.Day==DateTime.Now.Day&&date.Month==DateTime.Now.Month&&date.Year==DateTime.Now.Year)
                    {
                        totalTodayMeets++;
                        meetsId.Add(Convert.ToInt32(reader["Id"]));
                        DashboardMeetsCard meets = new DashboardMeetsCard();
                        meets.TopLevel = false;
                        meets.Dock = DockStyle.Fill;
                        meets.id = meetsId[meetIndex];
                        meets.LoginId = loginId;
                        meets.backPageButton = backPageButton;
                        meets.viewerPanel = viewerPanel;
                        meets.panelColor = panelColor;
                        meets.backgroundColor = backgroundColor;
                        meetViewerPanel.Controls.Clear();
                        meetViewerPanel.Controls.Add(meets);
                        meets.Show();
                    }
                }
                reader.Close();
                connection.Close();
                totalMeetsLabel.Text = totalMeets.ToString();
                totalTodayMeetsLabel.Text = totalTodayMeets.ToString();
            }
            loadNotes();
        }
        private void loadNotes()
        {
            using (SqlCommand command = new SqlCommand("SELECT * From [Notes] where LoginId='" + loginId + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    totalNotes++;
                }
                reader.Close();
                connection.Close();
                totalNotesLabel.Text = totalNotes.ToString();
            }
            if (weather)
            {
                GetWeather();
            }
        }

        private void GetWeather()
        {
            try
            {
                //havadurumu kodları
                //http://api.openweathermap.org/data/2.5/weather?q=izmir&appid=
                //"e7d2c6c38b9ae7616ec4a3579c9313cf&lang=tr"
                string api = "e7d2c6c38b9ae7616ec4a3579c9313cf";
                string url = "https://api.openweathermap.org/data/2.5/weather?q=" + weatherCity + "&mode=xml&lang=en&units=metric&appid=" + api;
                XDocument weather = XDocument.Load(url);
                var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                var weatherstatu = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
                var feels = weather.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
                var hum = weather.Descendants("humidity").ElementAt(0).Attribute("value").Value;
                var clouds = weather.Descendants("clouds").ElementAt(0).Attribute("value").Value;
                var wind_speed = weather.Descendants("speed").ElementAt(0).Attribute("value").Value;
                var precipitation = weather.Descendants("precipitation").ElementAt(0).Attribute("mode").Value;
                weatherStatu = weatherCity.ToLower() + "/" + weatherstatu + " " + clouds;
                weatherTempLabel.Text = temp + "°";
                weatherStatuLabel.Text = weatherStatu;
            }
            catch
            {
                weatherStatu = "BAGLANTI YOK";
                weatherStatuLabel.Text = weatherStatu;

            }
        }

        private void nextPic_Click(object sender, EventArgs e)
        {
            if (meetIndex < meetsId.Count - 1)
            {
                meetIndex++;
                DashboardMeetsCard meets = new DashboardMeetsCard();
                meets.TopLevel = false;
                meets.Dock = DockStyle.Fill;
                meets.id = meetsId[meetIndex];
                meets.LoginId = loginId;
                meets.backPageButton = backPageButton;
                meets.viewerPanel = viewerPanel;
                meets.panelColor = panelColor;
                meets.backgroundColor = backgroundColor;
                meetViewerPanel.Controls.Clear();
                meetViewerPanel.Controls.Add(meets);
                meets.Show();
            }
        }

        private void backPic_Click(object sender, EventArgs e)
        {
            if (meetIndex > 0)
            {
                meetIndex--;
                DashboardMeetsCard meets = new DashboardMeetsCard();
                meets.TopLevel = false;
                meets.Dock = DockStyle.Fill;
                meets.id = meetsId[meetIndex];
                meets.LoginId = loginId;
                meets.backPageButton = backPageButton;
                meets.viewerPanel = viewerPanel;
                meets.panelColor = panelColor;
                meets.backgroundColor = backgroundColor;
                meetViewerPanel.Controls.Clear();
                meetViewerPanel.Controls.Add(meets);
                meets.Show();
            }
        }
    }
}
