using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class DashboardMeetsCard : Form
    {
        public int id = 0;
        int meetId = 0;
        public int LoginId = 0;
        byte[] photoByte = { };
        public Button backPageButton = new Button();
        public Panel viewerPanel = new Panel();
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        string name = "";
        string surname = "";
        string tc = "";
        DateTime date = DateTime.Now;
        string time = "";
        public DashboardMeetsCard()
        {
            InitializeComponent();
        }

        private void DashboardMeetsCard_Load(object sender, EventArgs e)
        {
            loadMeets();
        }
        private void loadMeets()
        {
            panel13.BackColor = panelColor;
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using(SqlCommand command = new SqlCommand("SELECT * From [Meets] where Id='"+id+"'",connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    fullnameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                    tcLabel.Text = "TC: " + reader["TcNo"].ToString();
                    meetDateLabel.Text = "RANDEVU: "+reader["Datetime"].ToString() + "  " + reader["Time"].ToString();
                    meetIdLabel.Text = reader["MeetNo"].ToString();
                    name = reader["Name"].ToString();
                    surname = reader["Surname"].ToString();
                    tc = reader["TcNo"].ToString();
                    time = reader["Time"].ToString();
                    date = DateTime.Parse(reader["Datetime"].ToString()).Date;
                    meetId = Convert.ToInt32(reader["IdNo"]);
                    Byte[] data = new Byte[0];
                    data = (Byte[])(reader["Photo"]);
                    photoByte = data;
                    MemoryStream mem = new MemoryStream(data);
                    profileBox.Image = Image.FromStream(mem);
                }
                reader.Close();
                connection.Close();
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream(photoByte);
            AddMeet meet = new AddMeet();
            meet.pageBtn = backPageButton;
            meet.loginId = LoginId;
            meet.TopLevel = false;
            meet.Dock = DockStyle.Fill;
            meet.editMode = true;
            meet.meetId = meetId;
            meet.tcTextbox.Text = tc;
            meet.profileBox.Image = Image.FromStream(mem);
            meet.meetNumberLabel.Text = meetIdLabel.Text;
            meet.dateTimePicker1.Value = date;
            meet.dateTimePicker2.Text = time;
            meet.groupBox3.Visible = true;
            meet.nameLabel.Text = name;
            meet.tcLabel.Text = tc;
            meet.backgroundColor = backgroundColor;
            meet.viewerPanel = viewerPanel;
            meet.onDashboard = true;
            viewerPanel.Controls.Clear();
            viewerPanel.Controls.Add(meet);
            meet.Show();
        }
    }
}
