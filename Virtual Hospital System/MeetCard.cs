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
    public partial class MeetCard : Form
    {
        public Button refreshButton = new Button();
        private string tc = "";
        public string meetNo = "";
        public string time = "";
        string name = "";
        public DateTime date = DateTime.Now;
        public int loginId = 0;
        private int id = 0;
        public int meetId = 0;
        private byte[] photoByte = { };
        public MeetsPage page = new MeetsPage();
        public Panel viewerPanel = new Panel();
        public Color backgroundColor = Color.CadetBlue;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public Color labelColor = Color.Gainsboro;
        public Button backPageButton = new Button();
        public int Id { get => id; set => id = value; }
        public byte[] PhotoByte { get => photoByte; set => photoByte = value; }

        public MeetCard()
        {
            InitializeComponent();
        }

        private void MeetCard_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            panel12.BackColor = panelColor;
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using(SqlCommand command = new SqlCommand("SELECT * From [Sicks] where Id='"+id+"'",connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(reader["Photo"]);
                    photoByte = data;
                    MemoryStream mem = new MemoryStream(data);
                    profileBox.Image = Image.FromStream(mem);
                    tc = reader["TcNo"].ToString();
                    name = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                }
                reader.Close();
                connection.Close();
            }
        }

        private void showPic_Click(object sender, EventArgs e)
        {
            editAndShow();
        }
        private void editAndShow()
        {
            MemoryStream mem = new MemoryStream(photoByte);
            AddMeet meet = new AddMeet();
            meet.loginId = loginId;
            meet.viewerPanel = viewerPanel;
            meet.pageBtn = backPageButton;
            meet.TopLevel = false;
            meet.Dock = DockStyle.Fill;
            meet.editMode = true;
            meet.meetId = meetId;
            meet.id = id;
            meet.tcTextbox.Text = tc;
            meet.profileBox.Image = Image.FromStream(mem);
            meet.meetNumberLabel.Text = meetNo;
            meet.dateTimePicker1.Value = date;
            meet.dateTimePicker2.Text = time;
            meet.groupBox3.Visible = true;
            meet.nameLabel.Text = name;
            meet.tcLabel.Text = tc;
            meet.backgroundColor = backgroundColor;
            viewerPanel.Controls.Clear();
            viewerPanel.Controls.Add(meet);
            meet.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            editAndShow();
        }

        private void deletePic_Click(object sender, EventArgs e)
        {
            WarningCard warning = new WarningCard();
            warning.Id = meetId;
            warning.parameters = "Meets";
            warning.headerLabel.Text = "RANDEVU SİLİNECEK";
            warning.detailLabel.Text = "Bu randevu kalıcı olarak silinecek, randevuyu silmek istediğinize emin misiniz?";
            warning.refreshButton = refreshButton;
            warning.ShowDialog();
        }
    }
}
