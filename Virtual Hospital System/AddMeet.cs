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
    public partial class AddMeet : Form
    {
        public int loginId = 0;
        public Button pageBtn = new Button();
        public MeetsPage page = new MeetsPage();
        public Panel viewerPanel = new Panel();
        public bool pageMode = false;
        public bool editMode = false;
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
        public int id = 0;
        public int meetId = 0;
        private int totalMeets = 0;
        private string name = "";
        private string surname = "";
        private string tc = "";
        private string notes = "";
        private int age = 0;
        private float cm = 0f;
        private float kg = 0f;
        private string meetNo = "";
        public Color backgroundColor = Color.CadetBlue;
        byte[] photoByte = { };
        public bool onDashboard = false;
        public AddMeet()
        {
            InitializeComponent();
        }

        private void pageBack_Click(object sender, EventArgs e)
        {
            if (!pageMode)
            {
                pageBtn.PerformClick();
            }
            else
            {
                viewerPanel.Controls.Clear();
                viewerPanel.Controls.Add(page);
                page.Show();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (tcTextbox.Text != string.Empty)
            {
                bool isExists = false;
                using (SqlCommand command = new SqlCommand("SELECT * From [Sicks] where TcNo='" + tcTextbox.Text + "'", connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (loginId == Convert.ToInt32(reader["LoginId"]))
                        {
                            groupBox3.Visible = true;
                            id = Convert.ToInt32(reader["Id"]);
                            nameLabel.Text = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                            tcLabel.Text = "TC:" + " " + reader["TcNo"].ToString();
                            totalMeets = Convert.ToInt32(reader["TotalMeets"]);
                            name = reader["Name"].ToString();
                            surname = reader["Surname"].ToString();
                            tc = reader["TcNo"].ToString();
                            age = Convert.ToInt32(reader["Age"]);
                            kg = float.Parse(reader["Kg"].ToString());
                            cm = float.Parse(reader["Cm"].ToString());
                            Byte[] data = new Byte[0];
                            data = (Byte[])(reader["Photo"]);
                            photoByte = data;
                            MemoryStream mem = new MemoryStream(data);
                            profileBox.Image = Image.FromStream(mem);

                            StringBuilder builder = new StringBuilder();
                            Enumerable
                               .Range(65, 26)
                                .Select(a => ((char)a).ToString())
                                .Concat(Enumerable.Range(97, 26).Select(a => ((char)a).ToString()))
                                .Concat(Enumerable.Range(0, 10).Select(a => a.ToString()))
                                .OrderBy(a => Guid.NewGuid())
                                .Take(11)
                                .ToList().ForEach(a => builder.Append(a));
                            string meetId = builder.ToString();
                            meetNo = meetId;
                            meetNumberLabel.Text = meetId;
                            isExists = true;
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
                if (isExists)
                {
                    bool isReady = false;
                    string query = "INSERT INTO [Meets] (Name,Surname,TcNo,Datetime,Notes,IdNo,Age,Kg,Cm,MeetNo,Time,SavedDate,LoginId,Photo) VALUES (@name,@surname,@tc,@datetime,@notes,@id,@age,@kg,@cm,@meetNo,@time,@saved,@login,@photo)";
                    if (editMode)
                    {
                        query = "UPDATE Meets SET Name=@name,Surname=@surname,TcNo=@tc,Datetime=@datetime,Time=@time,IdNo=@id,Age=@age,Kg=@kg,Cm=@cm,MeetNo=@meetNo,Notes=@notes,LoginId=@login,Photo=@photo where Id=@rootId";
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (editMode)
                        {
                            command.Parameters.AddWithValue("@rootId", meetId);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@saved", DateTime.Now);
                        }
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@tc", tc);
                        command.Parameters.AddWithValue("@datetime", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@time", dateTimePicker2.Text);
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@age", age);
                        command.Parameters.AddWithValue("@kg", kg);
                        command.Parameters.AddWithValue("@cm", cm);
                        command.Parameters.AddWithValue("@meetNo", meetNo);
                        command.Parameters.AddWithValue("@notes", notes);
                        command.Parameters.AddWithValue("@login", loginId);
                        command.Parameters.AddWithValue("@photo", photoByte);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        isReady = true;
                    }
                    if (isReady)
                    {
                        query = "UPDATE Sicks SET TotalMeets=@meets where Id=@id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.Parameters.AddWithValue("@meets", totalMeets + 1);
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                }
                else
                {
                    meetNumberLabel.Text = "KAYITLI HASTA BULUNAMADI";
                }
            }
            else
            {
                meetNumberLabel.Text = "TC KİMLİK NUMARASI BOŞ!";

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            tcTextbox.Clear();
            groupBox3.Visible = false;
            meetNumberLabel.Text = "Randevu numaranız burada gösterilecek";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void AddMeet_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            using(SqlCommand command = new SqlCommand("SELECT * From [Sicks] where LoginId='"+loginId+"'",connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tcTextbox.AutoCompleteCustomSource.Add(reader["TcNo"].ToString());
                }
                reader.Close();
                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel2.AutoScroll = false;
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            doc.Print();
        }
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Panel grd = new Panel();
            grd = panel2;
            Bitmap bmp = new Bitmap(grd.Width, grd.Height, grd.CreateGraphics());
            grd.DrawToBitmap(bmp, new Rectangle(0, 0, grd.Width, grd.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
            panel2.AutoScroll = true;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void showProfile_Click(object sender, EventArgs e)
        {
            AddSick sick = new AddSick();
            sick.TopLevel = false;
            sick.Dock = DockStyle.Fill;
            sick.loginId = loginId;
            sick.editMode = true;
            if (onDashboard)
            {
                sick.id = meetId;
            }
            else
            {
                sick.id = id;
            }
            sick.pageBtn = pageBtn;
            sick.viewerPanel = viewerPanel;
            sick.backgroundColor = backgroundColor;
            viewerPanel.Controls.Clear();
            viewerPanel.Controls.Add(sick);
            sick.Show();
        }
    }
}
