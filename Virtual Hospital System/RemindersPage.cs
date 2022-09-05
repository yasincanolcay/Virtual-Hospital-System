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

namespace Virtual_Hospital_System
{
    public partial class RemindersPage : Form
    {
        public int loginId = 0;
        bool isAdded = false;
        public Panel viewerPanel = new Panel();
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public RemindersPage()
        {
            InitializeComponent();
        }

        private void RemindersPage_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            flowLayoutPanel1.BackColor = backgroundColor;
            loadReminderCard(false);
            allButton.BackColor = Color.FromArgb(50, 0, 110, 130);
        }
        private void loadReminderCard(bool search)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            string query = "SELECT * From [Reminders] where LoginId='"+loginId+"'";
            using(SqlCommand command = new SqlCommand(query,connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReminderCard card = new ReminderCard();
                    card.TopLevel = false;
                    card.loginId = loginId;
                    card.backgroundColor = backgroundColor;
                    card.panelColor = panelColor;
                    if (!search)
                    {
                        if (!isAdded)
                        {
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Header"].ToString());
                        }
                        
                        card.refreshButton = refreshButton;
                        card.Id = Convert.ToInt32(reader["Id"]);
                        card.headerLabel.Text = reader["Header"].ToString();
                        card.detailsLabel.Text = reader["Details"].ToString();
                        DateTime date = DateTime.Parse(reader["Datetime"].ToString());
                        card.dateLabel.Text = date.Month.ToString() + "/" + date.Day + "/" + date.Year + " " + reader["Time"].ToString();
                        card.page = this;
                        card.viewerPanel = viewerPanel;
                        card.date = date;
                        card.time = reader["Time"].ToString();
                        flowLayoutPanel1.Controls.Add(card);
                        card.Show();
                    }
                    else
                    {
                        if(searchTextbox.Text.ToLower() == reader["Header"].ToString().ToLower())
                        {
                            card.refreshButton = refreshButton;
                            card.Id = Convert.ToInt32(reader["Id"]);
                            card.headerLabel.Text = reader["Header"].ToString();
                            card.detailsLabel.Text = reader["Details"].ToString();
                            DateTime date = DateTime.Parse(reader["Datetime"].ToString());
                            card.dateLabel.Text = date.Month.ToString() + "/" + date.Day + "/" + date.Year + " " + reader["Time"].ToString();
                            card.page = this;
                            card.viewerPanel = viewerPanel;
                            card.date = date;
                            card.time = reader["Time"].ToString();
                            flowLayoutPanel1.Controls.Add(card);
                            card.Show();
                        }
                    }
                }
                reader.Close();
                connection.Close();
                isAdded = true;
            }
        }
        private void loadNews()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            string query = "SELECT * From [Reminders] where LoginId='"+loginId+"'";
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (DateTime.Parse(reader["Datetime"].ToString()).Month==DateTime.Now.Month&& DateTime.Parse(reader["Datetime"].ToString()).Year==DateTime.Now.Year&& DateTime.Parse(reader["Datetime"].ToString()).Day+DateTime.Now.Day<=20)
                    {
                        ReminderCard card = new ReminderCard();
                        card.TopLevel = false;
                        card.refreshButton = refreshButton;
                        card.Id = Convert.ToInt32(reader["Id"]);
                        card.loginId = loginId;
                        card.headerLabel.Text = reader["Header"].ToString();
                        card.detailsLabel.Text = reader["Details"].ToString();
                        DateTime date = DateTime.Parse(reader["Datetime"].ToString());
                        card.dateLabel.Text = date.Month.ToString() + "/" + date.Day + "/" + date.Year + " " + reader["Time"].ToString();
                        card.page = this;
                        card.viewerPanel = viewerPanel;
                        card.date = date;
                        card.time = reader["Time"].ToString(); 
                        card.backgroundColor = backgroundColor;
                        card.panelColor = panelColor;
                        flowLayoutPanel1.Controls.Add(card);
                        card.Show();
                    }
                }
                reader.Close();
                connection.Close();
            }
        }
        private void loadLossOrActive(int isRead)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            string query = "SELECT * From [Reminders] where LoginId='" + loginId + "'";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["isRead"])==isRead)
                    {
                        ReminderCard card = new ReminderCard();
                        card.TopLevel = false;
                        card.refreshButton = refreshButton;
                        card.Id = Convert.ToInt32(reader["Id"]);
                        card.loginId = loginId;
                        card.headerLabel.Text = reader["Header"].ToString();
                        card.detailsLabel.Text = reader["Details"].ToString();
                        DateTime date = DateTime.Parse(reader["Datetime"].ToString());
                        card.dateLabel.Text = date.Month.ToString() + "/" + date.Day + "/" + date.Year + " " + reader["Time"].ToString();
                        card.page = this;
                        card.viewerPanel = viewerPanel;
                        card.date = date;
                        card.time = reader["Time"].ToString();
                        card.backgroundColor = backgroundColor;
                        card.panelColor = panelColor;
                        flowLayoutPanel1.Controls.Add(card);
                        card.Show();
                    }
                }
                reader.Close();
                connection.Close();
            }

        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            loadReminderCard(false);
            searchTextbox.Clear();
            allButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            newButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
            activeButton.BackColor = Color.CadetBlue;
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextbox.Text != string.Empty)
            {
                loadReminderCard(true);
            }
            else
            {
                loadReminderCard(false);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (searchTextbox.Text != string.Empty)
            {
                loadReminderCard(true);
            }
        }

        private void searchTextbox_Click(object sender, EventArgs e)
        {
            searchTextbox.Clear();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            loadReminderCard(false);
            allButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            newButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
            activeButton.BackColor = Color.CadetBlue;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            loadNews();
            newButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            allButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
            activeButton.BackColor = Color.CadetBlue;
        }

        private void lossButton_Click(object sender, EventArgs e)
        {
            loadLossOrActive(1);
            lossButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            allButton.BackColor = Color.CadetBlue;
            newButton.BackColor = Color.CadetBlue;
            activeButton.BackColor = Color.CadetBlue;
        }

        private void activeButton_Click(object sender, EventArgs e)
        {
            loadLossOrActive(0);
            activeButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            allButton.BackColor = Color.CadetBlue;
            newButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
        }
    }
}
