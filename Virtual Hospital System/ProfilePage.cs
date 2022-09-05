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
    public partial class ProfilePage : Form
    {
        public int loginId = 0;
        byte[] photoByte = { };
        public Panel viewerPanel = new Panel();
        public Form1 form = new Form1();
        private string name = "";
        private string Surname = "";
        private string age = "";
        private string bio = "";
        private DateTime saved = DateTime.Now;
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public ToolStripMenuItem item = new ToolStripMenuItem();
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            flowLayoutPanel1.BackColor = backgroundColor;
            panel1.BackColor = backgroundColor;
            panel2.BackColor = panelColor;
            panel3.BackColor = panelColor;
            panel4.BackColor = panelColor;
            panel5.BackColor = panelColor;
            panel6.BackColor = panelColor;
            panel7.BackColor = panelColor;
            panel8.BackColor = panelColor;
            panel9.BackColor = panelColor;
            panel10.BackColor = panelColor;
            panel11.BackColor = panelColor;
            panel12.BackColor = panelColor;
            panel13.BackColor = panelColor;
            panel14.BackColor = panelColor;
            loadProfileData();
        }
        private void loadProfileData()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using(SqlCommand command = new SqlCommand("SELECT * From [Login] where Id='"+loginId+"'",connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                    name = reader["Name"].ToString();
                    Surname = reader["Surname"].ToString();
                    statuLabel.Text = reader["Statu"].ToString();
                    ageAndLastloginLabel.Text = "Yaş: " + reader["Age"].ToString() + "    " + "Son Giriş: " + reader["LastLogin"].ToString();
                    age = reader["Age"].ToString();
                    schoolLabel.Text = reader["School"].ToString();
                    phoneLabel.Text = reader["PhoneNumber"].ToString();
                    addressLabel.Text = reader["Address"].ToString();
                    mailLabel.Text = reader["Mail"].ToString();
                    urlLabel.Text = reader["Web"].ToString();
                    savedDateLabel.Text = reader["SavedDate"].ToString();
                    saved = DateTime.Parse(reader["SavedDate"].ToString());
                    usernameLabel.Text = reader["Username"].ToString();
                    tokenLabel.Text = reader["TelegramToken"].ToString();
                    idLabel.Text = reader["TelegramId"].ToString();
                    hospitalLabel.Text = reader["HospitalName"].ToString();
                    policlinicLabel.Text = reader["Policlinic"].ToString();
                    bio = reader["Bio"].ToString();
                    bioLabel.Text = bio;
                    Byte[] data = new byte[0];
                    data = (Byte[])(reader["Photo"]);
                    photoByte = data;
                    MemoryStream mem = new MemoryStream(data);
                    profilePic.Image = Image.FromStream(mem);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Sildikten sonra çıkış yapılacak
            SecurityCard security = new SecurityCard();
            security.page = this;
            security.viewerPanel = viewerPanel;
            security.id = loginId;
            security.deleteMode = true;
            security.form = form;
            security.panelColor = panelColor;
            security.ShowDialog();

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            AddUser user = new AddUser();
            user.TopLevel = false;
            user.Dock = DockStyle.Fill;
            user.pageMode = true;
            user.viewerPanel = viewerPanel;
            user.page = this;
            user.editMode = true;
            user.nameTextbox.Text = name;
            user.surnameTextbox.Text = Surname;
            user.statuTextbox.Text = statuLabel.Text;
            user.ageTextbox.Text = age;
            user.schoolTextbox.Text = schoolLabel.Text;
            user.phoneTextbox.Text = phoneLabel.Text;
            user.addressTextbox.Text = addressLabel.Text;
            user.mailTextbox.Text = mailLabel.Text;
            user.weburlTextbox.Text = urlLabel.Text;
            user.photoByte = photoByte;
            user.usernameTextbox.Text = usernameLabel.Text;
            user.tokenTextbox.Text = tokenLabel.Text;
            user.idTextbox.Text = idLabel.Text;
            user.hospitalTextbox.Text = hospitalLabel.Text;
            user.policlinicTextbox.Text = policlinicLabel.Text;
            user.id = loginId;
            user.saved = saved;
            user.bioTextbox.Text = bio;
            SecurityCard security = new SecurityCard();
            security.page = this;
            security.viewerPanel = viewerPanel;
            security.user = user;
            security.id = loginId;
            security.panelColor = panelColor;
            security.ShowDialog();
        }

        private void urlLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(urlLabel.Text);
        }

        private void urlLabel_MouseDown(object sender, MouseEventArgs e)
        {
            urlLabel.ForeColor = Color.Indigo;
        }

        private void urlLabel_MouseUp(object sender, MouseEventArgs e)
        {
            urlLabel.ForeColor = Color.Silver;
        }

        private void urlLabel_MouseHover(object sender, EventArgs e)
        {
            urlLabel.ForeColor = Color.CadetBlue;
        }

        private void urlLabel_MouseLeave(object sender, EventArgs e)
        {
            urlLabel.ForeColor = Color.Silver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item.PerformClick();
        }
    }
}
