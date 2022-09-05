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
    public partial class MeetsPage : Form
    {
        bool isAdded = false;
        public Panel viewerPanel = new Panel();
        public int loginId = 0;
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public Color labelColor = Color.Gainsboro;
        public Button backPageButton = new Button();
        public MeetsPage()
        {
            InitializeComponent();
        }

        private void MeetsPage_Load(object sender, EventArgs e)
        {
            loadMeetCard(false);
            allButton.BackColor = Color.FromArgb(50, 0, 110, 130);
            this.BackColor = backgroundColor;
            flowLayoutPanel1.BackColor = backgroundColor;
        }
        private void loadMeetCard(bool search)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using(SqlCommand command = new SqlCommand("SELECT * From [Meets] where LoginId='"+loginId+"'",connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MeetCard card = new MeetCard();
                    card.TopLevel = false;
                    card.backgroundColor = backgroundColor;
                    card.panelColor = panelColor;
                    card.backPageButton = backPageButton;
                    card.viewerPanel = viewerPanel;
                    if (!search)
                    {
                        if (!isAdded)
                        {
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Name"].ToString().ToLower() + " " + reader["Surname"].ToString().ToLower());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Name"].ToString().ToUpper() + " " + reader["Surname"].ToString().ToUpper());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["TcNo"].ToString());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["MeetNo"].ToString());
                        }
                        card.Id = Convert.ToInt32(reader["IdNo"]);
                        card.loginId = loginId;
                        card.nameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                        card.tcLabel.Text = "TC: " + reader["TcNo"].ToString();
                        DateTime date = DateTime.Parse(reader["Datetime"].ToString());
                        card.meetDateLabel.Text = date.Month + "/" + date.Day + "/" + date.Year + " " + reader["Time"].ToString();
                        card.idLabel.Text = "ID: " + reader["MeetNo"].ToString();
                        card.cmLabel.Text = "Boy: " + reader["Cm"].ToString();
                        card.kgLabel.Text = "KG: " + reader["Kg"].ToString();
                        card.ageLabel.Text = "Yaş: " + reader["Age"].ToString();
                        card.page = this;
                        card.viewerPanel = viewerPanel;
                        card.meetNo = reader["MeetNo"].ToString();
                        card.meetId = Convert.ToInt32(reader["Id"]);
                        card.date = date;
                        card.time = reader["Time"].ToString();
                        card.refreshButton = refreshButton;
                        flowLayoutPanel1.Controls.Add(card);
                        card.Show();
                    }
                    else
                    {
                        if(searchTextbox.Text==reader["MeetNo"].ToString() || searchTextbox.Text.ToLower()==reader["Name"].ToString().ToLower()+" " + reader["Surname"].ToString().ToLower() || searchTextbox.Text == reader["TcNo"].ToString())
                        {
                            card.Id = Convert.ToInt32(reader["IdNo"]);
                            card.loginId = loginId;
                            card.nameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                            card.tcLabel.Text = "TC: " + reader["TcNo"].ToString();
                            DateTime date = DateTime.Parse(reader["Datetime"].ToString());
                            card.meetDateLabel.Text = date.Month + "/" + date.Day + "/" + date.Year + " " + reader["Time"].ToString();
                            card.idLabel.Text = "ID: " + reader["MeetNo"].ToString();
                            card.cmLabel.Text = "Boy: " + reader["Cm"].ToString();
                            card.kgLabel.Text = "KG: " + reader["Kg"].ToString();
                            card.ageLabel.Text = "Yaş: " + reader["Age"].ToString();
                            card.page = this;
                            card.viewerPanel = viewerPanel;
                            card.meetNo = reader["MeetNo"].ToString();
                            card.meetId = Convert.ToInt32(reader["Id"]);
                            card.date = date;
                            card.time = reader["Time"].ToString();
                            card.refreshButton = refreshButton;
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
            using (SqlCommand command = new SqlCommand("SELECT * From [Meets] where LoginId='"+loginId+"'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(DateTime.Parse(reader["SavedDate"].ToString()).Month == DateTime.Now.Month && DateTime.Parse(reader["SavedDate"].ToString()).Year == DateTime.Now.Year && DateTime.Parse(reader["SavedDate"].ToString()).Day + DateTime.Now.Day <= 20)
                    {
                        MeetCard card = new MeetCard();
                        card.TopLevel = false;
                        card.Id = Convert.ToInt32(reader["IdNo"]);
                        card.loginId = loginId;
                        card.nameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                        card.tcLabel.Text = "TC: " + reader["TcNo"].ToString();
                        DateTime date = DateTime.Parse(reader["Datetime"].ToString());
                        card.meetDateLabel.Text = date.Month + "/" + date.Day + "/" + date.Year + " " + reader["Time"].ToString();
                        card.idLabel.Text = "ID: " + reader["MeetNo"].ToString();
                        card.cmLabel.Text = "Boy: " + reader["Cm"].ToString();
                        card.kgLabel.Text = "KG: " + reader["Kg"].ToString();
                        card.ageLabel.Text = "Yaş: " + reader["Age"].ToString();
                        card.page = this;
                        card.viewerPanel = viewerPanel;
                        card.meetNo = reader["MeetNo"].ToString();
                        card.meetId = Convert.ToInt32(reader["Id"]);
                        card.date = date;
                        card.time = reader["Time"].ToString();
                        card.refreshButton = refreshButton; 
                        card.backgroundColor = backgroundColor;
                        card.panelColor = panelColor;
                        card.backPageButton = backPageButton;
                        flowLayoutPanel1.Controls.Add(card);
                        card.Show();
                    }
                }
                reader.Close();
                connection.Close();
            }
        }
        private void loadLoss()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using (SqlCommand command = new SqlCommand("SELECT * From [Meets] where LoginId='" + loginId + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (DateTime.Parse(reader["Datetime"].ToString()).Month <= DateTime.Now.Month || DateTime.Parse(reader["Datetime"].ToString()).Year <= DateTime.Now.Year|| DateTime.Parse(reader["Datetime"].ToString()).Month == DateTime.Now.Month || DateTime.Parse(reader["Datetime"].ToString()).Year == DateTime.Now.Year)
                    {
                        if (DateTime.Parse(reader["Datetime"].ToString()).Day < DateTime.Now.Day|| DateTime.Parse(reader["Datetime"].ToString()).Month < DateTime.Now.Month|| DateTime.Parse(reader["Datetime"].ToString()).Year < DateTime.Now.Year) {
                            MeetCard card = new MeetCard();
                            card.TopLevel = false;
                            card.Id = Convert.ToInt32(reader["IdNo"]);
                            card.loginId = loginId;
                            card.nameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                            card.tcLabel.Text = "TC: " + reader["TcNo"].ToString();
                            DateTime date = DateTime.Parse(reader["Datetime"].ToString());
                            card.meetDateLabel.Text = date.Month + "/" + date.Day + "/" + date.Year + " " + reader["Time"].ToString();
                            card.idLabel.Text = "ID: " + reader["MeetNo"].ToString();
                            card.cmLabel.Text = "Boy: " + reader["Cm"].ToString();
                            card.kgLabel.Text = "KG: " + reader["Kg"].ToString();
                            card.ageLabel.Text = "Yaş: " + reader["Age"].ToString();
                            card.page = this;
                            card.viewerPanel = viewerPanel;
                            card.backPageButton = backPageButton;
                            card.meetNo = reader["MeetNo"].ToString();
                            card.meetId = Convert.ToInt32(reader["Id"]);
                            card.date = date;
                            card.time = reader["Time"].ToString();
                            card.backgroundColor = backgroundColor;
                            card.panelColor = panelColor;
                            card.refreshButton = refreshButton;
                            flowLayoutPanel1.Controls.Add(card);
                            card.Show();
                        }
                    }
                }
                reader.Close();
                connection.Close();
            }
        }
        private void loadActive()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using (SqlCommand command = new SqlCommand("SELECT * From [Meets] where LoginId='" + loginId + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (DateTime.Parse(reader["Datetime"].ToString()).Month >= DateTime.Now.Month || DateTime.Parse(reader["Datetime"].ToString()).Year >= DateTime.Now.Year || DateTime.Parse(reader["Datetime"].ToString()).Month == DateTime.Now.Month || DateTime.Parse(reader["Datetime"].ToString()).Year == DateTime.Now.Year)
                    {
                        if (DateTime.Parse(reader["Datetime"].ToString()).Day > DateTime.Now.Day && DateTime.Parse(reader["Datetime"].ToString()).Month >= DateTime.Now.Month && DateTime.Parse(reader["Datetime"].ToString()).Year >= DateTime.Now.Year)
                        {
                            MeetCard card = new MeetCard();
                            card.TopLevel = false;
                            card.Id = Convert.ToInt32(reader["IdNo"]);
                            card.loginId = loginId;
                            card.nameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                            card.tcLabel.Text = "TC: " + reader["TcNo"].ToString();
                            DateTime date = DateTime.Parse(reader["Datetime"].ToString());
                            card.meetDateLabel.Text = date.Month + "/" + date.Day + "/" + date.Year + " " + reader["Time"].ToString();
                            card.idLabel.Text = "ID: " + reader["MeetNo"].ToString();
                            card.cmLabel.Text = "Boy: " + reader["Cm"].ToString();
                            card.kgLabel.Text = "KG: " + reader["Kg"].ToString();
                            card.ageLabel.Text = "Yaş: " + reader["Age"].ToString();
                            card.page = this;
                            card.viewerPanel = viewerPanel;
                            card.backPageButton = backPageButton;
                            card.meetNo = reader["MeetNo"].ToString();
                            card.meetId = Convert.ToInt32(reader["Id"]);
                            card.date = date;
                            card.time = reader["Time"].ToString();
                            card.backgroundColor = backgroundColor;
                            card.panelColor = panelColor;
                            card.refreshButton = refreshButton;
                            flowLayoutPanel1.Controls.Add(card);
                            card.Show();
                        }
                    }
                }
                reader.Close();
                connection.Close();
            }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            searchTextbox.Clear();
            loadMeetCard(false);
            allButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            newButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
            activeButton.BackColor = Color.CadetBlue;
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextbox.Text != string.Empty)
            {
                loadMeetCard(true);
            }
            else
            {
                loadMeetCard(false);
            }
        }

        private void searchPic_Click(object sender, EventArgs e)
        {
            if (searchTextbox.Text != string.Empty)
            {
                loadMeetCard(true);
            }
        }

        private void searchTextbox_Click(object sender, EventArgs e)
        {
            searchTextbox.Clear();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            loadMeetCard(false);
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
            loadLoss();
            lossButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            allButton.BackColor = Color.CadetBlue;
            newButton.BackColor = Color.CadetBlue;
            activeButton.BackColor = Color.CadetBlue;
        }

        private void activeButton_Click(object sender, EventArgs e)
        {
            loadActive();
            activeButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            allButton.BackColor = Color.CadetBlue;
            newButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
        }
    }
}
