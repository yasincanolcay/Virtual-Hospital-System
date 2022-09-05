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
    public partial class PillsPage : Form
    {
        private bool isAdded = false;
        public int loginId = 0;
        public Panel viewerPanel = new Panel();
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public PillsPage()
        {
            InitializeComponent();
        }

        private void PillsPage_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            flowLayoutPanel1.BackColor = backgroundColor;
            loadPillCard(false);
        }

        private void loadPillCard(bool search)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using(SqlCommand command = new SqlCommand("SELECT * From [Pills] where LoginId='"+loginId+"'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PillCard card = new PillCard();
                    card.TopLevel = false;
                    card.loginId = loginId;
                    card.backgroundColor = backgroundColor;
                    card.panelColor = panelColor;
                    if (!search)
                    {
                        if (!isAdded)
                        {
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Name"].ToString());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["CompanyName"].ToString());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Name"].ToString().ToLower());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["CompanyName"].ToString().ToLower());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["CertificateNo"].ToString());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Mg"].ToString());
                        }
                        card.id = Convert.ToInt32(reader["Id"]);
                        card.refreshButton = refreshButton;
                        card.page = this;
                        card.viewerPanel = viewerPanel;
                        card.headerLabel.Text = reader["Name"].ToString();
                        card.detailsLabel.Text = reader["Details"].ToString();
                        card.dateLabel.Text = "Kayıt: " + reader["SavedDate"].ToString();
                        flowLayoutPanel1.Controls.Add(card);
                        card.Show();
                    }
                    else
                    {
                        if (searchTextbox.Text.ToLower() == reader["Name"].ToString().ToLower()||searchTextbox.Text.ToLower()== reader["CompanyName"].ToString().ToLower()||searchTextbox.Text== reader["CertificateNo"].ToString()||searchTextbox.Text== reader["Mg"].ToString())
                        {
                            card.id = Convert.ToInt32(reader["Id"]);
                            card.refreshButton = refreshButton;
                            card.page = this;
                            card.viewerPanel = viewerPanel;
                            card.headerLabel.Text = reader["Name"].ToString();
                            card.detailsLabel.Text = reader["Details"].ToString();
                            card.dateLabel.Text = "Kayıt: " + reader["SavedDate"].ToString();
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
            using (SqlCommand command = new SqlCommand("SELECT * From [Pills] where LoginId='"+loginId+"'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(DateTime.Parse(reader["SavedDate"].ToString()).Month == DateTime.Now.Month && DateTime.Parse(reader["SavedDate"].ToString()).Year == DateTime.Now.Year && DateTime.Parse(reader["SavedDate"].ToString()).Day + DateTime.Now.Day <= 20)
                    {
                        PillCard card = new PillCard();
                        card.TopLevel = false;
                        card.id = Convert.ToInt32(reader["Id"]);
                        card.loginId = loginId;
                        card.refreshButton = refreshButton;
                        card.page = this;
                        card.viewerPanel = viewerPanel;
                        card.headerLabel.Text = reader["Name"].ToString();
                        card.detailsLabel.Text = reader["Details"].ToString();
                        card.dateLabel.Text = "Kayıt: " + reader["SavedDate"].ToString(); 
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
        private void loadLoss()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using (SqlCommand command = new SqlCommand("SELECT * From [Pills] where LoginId='" + loginId + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (DateTime.Parse(reader["SavedDate"].ToString()).Month <= DateTime.Now.Month || DateTime.Parse(reader["SavedDate"].ToString()).Year <= DateTime.Now.Year || DateTime.Parse(reader["SavedDate"].ToString()).Month == DateTime.Now.Month || DateTime.Parse(reader["SavedDate"].ToString()).Year == DateTime.Now.Year)
                    {
                        if (DateTime.Parse(reader["SavedDate"].ToString()).Day < DateTime.Now.Day || DateTime.Parse(reader["SavedDate"].ToString()).Month < DateTime.Now.Month || DateTime.Parse(reader["SavedDate"].ToString()).Year < DateTime.Now.Year)
                        {
                            PillCard card = new PillCard();
                            card.TopLevel = false;
                            card.id = Convert.ToInt32(reader["Id"]);
                            card.loginId = loginId;
                            card.refreshButton = refreshButton;
                            card.page = this;
                            card.viewerPanel = viewerPanel;
                            card.headerLabel.Text = reader["Name"].ToString();
                            card.detailsLabel.Text = reader["Details"].ToString();
                            card.dateLabel.Text = "Kayıt: " + reader["SavedDate"].ToString(); 
                            card.backgroundColor = backgroundColor;
                            card.panelColor = panelColor;
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
            allButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            newButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
            searchTextbox.Clear();
            loadPillCard(false);
        }

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextbox.Text != string.Empty)
            {
                loadPillCard(true);
            }
            else
            {
                loadPillCard(false);
            }
        }

        private void searchPic_Click(object sender, EventArgs e)
        {
            if (searchTextbox.Text != string.Empty)
            {
                loadPillCard(true);
            }
        }

        private void searchTextbox_Click(object sender, EventArgs e)
        {
            searchTextbox.Clear();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            allButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            newButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
            loadPillCard(false);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            newButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            allButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
            loadNews();
        }

        private void lossButton_Click(object sender, EventArgs e)
        {
            lossButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            newButton.BackColor = Color.CadetBlue;
            allButton.BackColor = Color.CadetBlue;
            loadLoss();
        }
    }
}
