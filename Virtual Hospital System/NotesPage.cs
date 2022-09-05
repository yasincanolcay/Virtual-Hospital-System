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
    public partial class NotesPage : Form
    {
        public Panel viewerPanel = new Panel();
        public int loginId = 0;
        private bool isAdded = false;
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public Color labelColor = Color.Gainsboro;
        public bool darkMode = false;
        public NotesPage()
        {
            InitializeComponent();
        }

        private void NotesPage_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            flowLayoutPanel1.BackColor = backgroundColor;
            loadNotesCard(false);
        }
        private void loadNotesCard(bool search)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using (SqlCommand command = new SqlCommand("SELECT * From [Notes] where LoginId='"+loginId+"'",connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NoteCard card = new NoteCard();
                    card.TopLevel = false;
                    card.loginId = loginId;
                    card.panel2Color = panelColor;
                    card.backgroundColor = backgroundColor;
                    card.darkMode = darkMode;
                    if (!search)
                    {
                        if (!isAdded)
                        {
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Header"].ToString());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Header"].ToString().ToLower());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Header"].ToString().ToUpper());
                        }
                        card.id = Convert.ToInt32(reader["Id"]);
                        card.headerLabel.Text = reader["Header"].ToString();
                        card.detailsLabel.Text = reader["Note"].ToString();
                        card.dateLabel.Text = reader["SavedDate"].ToString();
                        card.panelColor = Color.FromArgb(Convert.ToInt32(reader["Colorİndex"]));
                        if (Convert.ToInt32(reader["Favorites"]) == 1)
                        {
                            card.fav = true;
                        }
                        card.page = this;
                        card.refreshButton = refreshButton;
                        card.viewerPanel = viewerPanel;
                        flowLayoutPanel1.Controls.Add(card);
                        card.Show();
                    }
                    else
                    {
                        if (searchTextbox.Text.ToLower() == reader["Header"].ToString().ToLower())
                        {
                            card.id = Convert.ToInt32(reader["Id"]);
                            card.headerLabel.Text = reader["Header"].ToString();
                            card.detailsLabel.Text = reader["Note"].ToString();
                            card.dateLabel.Text = reader["SavedDate"].ToString();
                            card.panelColor = Color.FromArgb(Convert.ToInt32(reader["Colorİndex"]));
                            if (Convert.ToInt32(reader["Favorites"]) == 1)
                            {
                                card.fav = true;
                            }
                            card.page = this;
                            card.refreshButton = refreshButton;
                            card.viewerPanel = viewerPanel;
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
            //DateTime.Parse(reader["Datetime"].ToString()).Month==DateTime.Now.Month&& DateTime.Parse(reader["Datetime"].ToString()).Year==DateTime.Now.Year&& DateTime.Parse(reader["Datetime"].ToString()).Day+DateTime.Now.Day<=20
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using (SqlCommand command = new SqlCommand("SELECT * From [Notes] where LoginId='"+loginId+"'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (DateTime.Parse(reader["SavedDate"].ToString()).Month == DateTime.Now.Month && DateTime.Parse(reader["SavedDate"].ToString()).Year == DateTime.Now.Year && DateTime.Parse(reader["SavedDate"].ToString()).Day + DateTime.Now.Day <= 20)
                    {
                        NoteCard card = new NoteCard();
                        card.TopLevel = false;
                        card.id = Convert.ToInt32(reader["Id"]);
                        card.loginId = loginId;
                        card.headerLabel.Text = reader["Header"].ToString();
                        card.detailsLabel.Text = reader["Note"].ToString();
                        card.dateLabel.Text = reader["SavedDate"].ToString();
                        card.panelColor = Color.FromArgb(Convert.ToInt32(reader["Colorİndex"]));
                        if (Convert.ToInt32(reader["Favorites"]) == 1)
                        {
                            card.fav = true;
                        }
                        card.page = this;
                        card.refreshButton = refreshButton;
                        card.viewerPanel = viewerPanel;
                        card.panel2Color = panelColor;
                        card.darkMode = darkMode;
                        card.backgroundColor = backgroundColor;
                        flowLayoutPanel1.Controls.Add(card);
                        card.Show();
                    }
                }
            }
        }
        private void loadLoss()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using (SqlCommand command = new SqlCommand("SELECT * From [Notes] where LoginId='" + loginId + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (DateTime.Parse(reader["SavedDate"].ToString()).Month <= DateTime.Now.Month || DateTime.Parse(reader["SavedDate"].ToString()).Year <= DateTime.Now.Year || DateTime.Parse(reader["SavedDate"].ToString()).Month == DateTime.Now.Month || DateTime.Parse(reader["SavedDate"].ToString()).Year == DateTime.Now.Year)
                    {
                        //
                        if (DateTime.Parse(reader["SavedDate"].ToString()).Day < DateTime.Now.Day || DateTime.Parse(reader["SavedDate"].ToString()).Month < DateTime.Now.Month || DateTime.Parse(reader["SavedDate"].ToString()).Year < DateTime.Now.Year)
                        {
                            NoteCard card = new NoteCard();
                            card.TopLevel = false;
                            card.id = Convert.ToInt32(reader["Id"]);
                            card.loginId = loginId;
                            card.headerLabel.Text = reader["Header"].ToString();
                            card.detailsLabel.Text = reader["Note"].ToString();
                            card.dateLabel.Text = reader["SavedDate"].ToString();
                            card.panelColor = Color.FromArgb(Convert.ToInt32(reader["Colorİndex"]));
                            if (Convert.ToInt32(reader["Favorites"]) == 1)
                            {
                                card.fav = true;
                            }
                            card.page = this;
                            card.refreshButton = refreshButton;
                            card.viewerPanel = viewerPanel;
                            card.panel2Color = panelColor;
                            card.darkMode = darkMode;
                            card.backgroundColor = backgroundColor;
                            flowLayoutPanel1.Controls.Add(card);
                            card.Show();
                        }
                    }
                }
            }
        }
        private void loadFav()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using (SqlCommand command = new SqlCommand("SELECT * From [Notes] where LoginId='" + loginId + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToInt32(reader["Favorites"]) == 1)
                    {
                        NoteCard card = new NoteCard();
                        card.TopLevel = false;
                        card.id = Convert.ToInt32(reader["Id"]);
                        card.loginId = loginId;
                        card.headerLabel.Text = reader["Header"].ToString();
                        card.detailsLabel.Text = reader["Note"].ToString();
                        card.dateLabel.Text = reader["SavedDate"].ToString();
                        card.panelColor = Color.FromArgb(Convert.ToInt32(reader["Colorİndex"]));
                        if (Convert.ToInt32(reader["Favorites"]) == 1)
                        {
                            card.fav = true;
                        }
                        card.page = this;
                        card.refreshButton = refreshButton;
                        card.viewerPanel = viewerPanel;
                        card.panel2Color = panelColor;
                        card.darkMode = darkMode;
                        card.backgroundColor = backgroundColor;
                        flowLayoutPanel1.Controls.Add(card);
                        card.Show();
                    }
                }
            }
        }
        private void refreshButton_Click(object sender, EventArgs e)
        {
            allButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            newButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
            favButton.BackColor = Color.CadetBlue;
            searchTextbox.Clear();
            loadNotesCard(false);
        }

        private void searchTextbox_Click(object sender, EventArgs e)
        {
            searchTextbox.Clear();
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextbox.Text != string.Empty)
            {
                loadNotesCard(true);
            }
            else
            {
                loadNotesCard(false);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (searchTextbox.Text != string.Empty)
            {
                loadNotesCard(true);
            }
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            refreshButton.PerformClick();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            newButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            allButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
            favButton.BackColor = Color.CadetBlue;
            loadNews();
        }

        private void lossButton_Click(object sender, EventArgs e)
        {
            lossButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            allButton.BackColor = Color.CadetBlue;
            newButton.BackColor = Color.CadetBlue;
            favButton.BackColor = Color.CadetBlue;
            loadLoss();
        }

        private void favButton_Click(object sender, EventArgs e)
        {
            favButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            allButton.BackColor = Color.CadetBlue;
            newButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
            loadFav();
        }
    }
}
