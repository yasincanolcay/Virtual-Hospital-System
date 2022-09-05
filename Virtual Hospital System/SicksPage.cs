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
    public partial class SicksPage : Form
    {
        bool isAdded = false;
        public int loginId = 0;
        public Panel viewerPanel = new Panel();
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public SicksPage()
        {
            InitializeComponent();
        }

        private void SicksPage_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            flowLayoutPanel1.BackColor = backgroundColor;
            loadSickCard(false);
        }
        private void loadSickCard(bool search)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using(SqlCommand command = new SqlCommand("SELECT * From [Sicks] where LoginId='"+loginId+"'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SickCard card = new SickCard();
                    card.TopLevel = false;
                    card.loginId = loginId;
                    card.backgroundColor = backgroundColor;
                    card.panelColor = panelColor;
                    if (!search)
                    {
                        if (!isAdded)
                        {
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Name"].ToString().ToLower() + " " + reader["Surname"].ToString().ToLower());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Name"].ToString().ToUpper() + " " + reader["Surname"].ToString().ToUpper());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Name"].ToString());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["Surname"].ToString());
                            searchTextbox.AutoCompleteCustomSource.Add(reader["TcNo"].ToString());
                        }
                        card.Id = Convert.ToInt32(reader["Id"]);
                        card.nameLabel.Text = reader["Name"].ToString()+" "+reader["Surname"].ToString();
                        card.tcLabel.Text = reader["TcNo"].ToString();
                        card.savedLabel.Text = "Kayıt: " + reader["SavedDate"].ToString();
                        card.ageLabel.Text = "Yaş: " + reader["Age"].ToString();
                        card.kgLabel.Text = "Kilo: " + reader["Kg"].ToString();
                        card.cmLabel.Text = "Boy: " + reader["Cm"].ToString();
                        Byte[] data = new Byte[0];
                        data = (Byte[])(reader["Photo"]);
                        card.photoByte = data;
                        card.refreshButton = refreshButton;
                        card.page = this;
                        card.viewerPanel = viewerPanel;
                        flowLayoutPanel1.Controls.Add(card);
                        card.Show();
                    }
                    else
                    {
                        if(searchTextbox.Text.ToLower()==reader["Name"].ToString().ToLower()+" "+reader["Surname"].ToString().ToLower()||searchTextbox.Text.ToLower() == reader["Name"].ToString().ToLower() || searchTextbox.Text.ToLower() == reader["Surname"].ToString().ToLower() || searchTextbox.Text == reader["TcNo"].ToString())
                        {
                            card.Id = Convert.ToInt32(reader["Id"]);
                            card.nameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                            card.tcLabel.Text = reader["TcNo"].ToString();
                            card.savedLabel.Text = "Kayıt: " + reader["SavedDate"].ToString();
                            card.ageLabel.Text = "Yaş: " + reader["Age"].ToString();
                            card.kgLabel.Text = "Kilo: " + reader["Kg"].ToString();
                            card.cmLabel.Text = "Boy: " + reader["Cm"].ToString();
                            Byte[] data = new Byte[0];
                            data = (Byte[])(reader["Photo"]);
                            card.photoByte = data;
                            card.refreshButton = refreshButton;
                            card.page = this;
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
            flowLayoutPanel1.Controls.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using (SqlCommand command = new SqlCommand("SELECT * From [Sicks] where LoginId='"+loginId+"'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(DateTime.Parse(reader["SavedDate"].ToString()).Month == DateTime.Now.Month && DateTime.Parse(reader["SavedDate"].ToString()).Year == DateTime.Now.Year && DateTime.Parse(reader["SavedDate"].ToString()).Day + DateTime.Now.Day <= 20)
                    {
                        SickCard card = new SickCard();
                        card.TopLevel = false;
                        card.Id = Convert.ToInt32(reader["Id"]);
                        card.loginId = loginId;
                        card.nameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                        card.tcLabel.Text = reader["TcNo"].ToString();
                        card.savedLabel.Text = "Kayıt: " + reader["SavedDate"].ToString();
                        card.ageLabel.Text = "Yaş: " + reader["Age"].ToString();
                        card.kgLabel.Text = "Kilo: " + reader["Kg"].ToString();
                        card.cmLabel.Text = "Boy: " + reader["Cm"].ToString();
                        Byte[] data = new Byte[0];
                        data = (Byte[])(reader["Photo"]);
                        card.photoByte = data;
                        card.refreshButton = refreshButton;
                        card.page = this;
                        card.viewerPanel = viewerPanel;
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
            using (SqlCommand command = new SqlCommand("SELECT * From [Sicks] where LoginId='" + loginId + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (DateTime.Parse(reader["SavedDate"].ToString()).Month <= DateTime.Now.Month || DateTime.Parse(reader["SavedDate"].ToString()).Year <= DateTime.Now.Year || DateTime.Parse(reader["SavedDate"].ToString()).Month == DateTime.Now.Month || DateTime.Parse(reader["SavedDate"].ToString()).Year == DateTime.Now.Year)
                    {
                        if (DateTime.Parse(reader["SavedDate"].ToString()).Day < DateTime.Now.Day || DateTime.Parse(reader["SavedDate"].ToString()).Month < DateTime.Now.Month || DateTime.Parse(reader["SavedDate"].ToString()).Year < DateTime.Now.Year)
                        {
                            SickCard card = new SickCard();
                            card.TopLevel = false;
                            card.Id = Convert.ToInt32(reader["Id"]);
                            card.loginId = loginId;
                            card.nameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                            card.tcLabel.Text = reader["TcNo"].ToString();
                            card.savedLabel.Text = "Kayıt: " + reader["SavedDate"].ToString();
                            card.ageLabel.Text = "Yaş: " + reader["Age"].ToString();
                            card.kgLabel.Text = "Kilo: " + reader["Kg"].ToString();
                            card.cmLabel.Text = "Boy: " + reader["Cm"].ToString();
                            Byte[] data = new Byte[0];
                            data = (Byte[])(reader["Photo"]);
                            card.photoByte = data;
                            card.refreshButton = refreshButton;
                            card.page = this;
                            card.viewerPanel = viewerPanel;
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
        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextbox.Text != string.Empty)
            {
                loadSickCard(true);
            }
            else
            {
                loadSickCard(false);
            }
        }

        private void searchPic_Click(object sender, EventArgs e)
        {
            if (searchTextbox.Text != string.Empty)
            {
                loadSickCard(true);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            allButton.BackColor = Color.FromArgb(50, 0, 125, 140);
            newButton.BackColor = Color.CadetBlue;
            lossButton.BackColor = Color.CadetBlue;
            searchTextbox.Clear();
            loadSickCard(false);
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
            loadSickCard(false);
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
