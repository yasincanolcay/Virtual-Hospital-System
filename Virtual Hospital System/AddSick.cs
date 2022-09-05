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
    public partial class AddSick : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
        public SicksPage page = new SicksPage();
        public Panel viewerPanel = new Panel();
        public bool pageMode = false;
        public Button pageBtn = new Button();
        public bool editMode = false;
        public int loginId = 0;
        public int id = 0;
        string defaultPhotoPath = "Assets/Images/default_profile.png";
        private byte[] photoByte = { };
        private string gender = "";
        public Color backgroundColor = Color.CadetBlue;

        public AddSick()
        {
            InitializeComponent();
        }
        private void AddSick_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            if (!editMode)
            {
                photoByte = ImageToStream(defaultPhotoPath);
                profilePicturebox.Image = Image.FromFile(defaultPhotoPath);
            }
            else
            {
                loadData();
            }
        }
        private void loadData()
        {
            using(SqlCommand command = new SqlCommand("SELECT * From [Sicks] where Id='" + id + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nameTextbox.Text = reader["Name"].ToString();
                    surnameTextbox.Text = reader["Surname"].ToString();
                    tcTextbox.Text = reader["TcNo"].ToString();
                    phoneTextbox.Text = reader["PhoneNumber"].ToString();
                    housePhoneTextbox.Text = reader["HousePhone"].ToString();
                    mailTextbox.Text = reader["Mail"].ToString();
                    addressTextbox.Text = reader["Address"].ToString();
                    detailsTextbox.Text = reader["Details"].ToString();
                    dianosisTextbox.Text = reader["Dianosis"].ToString();
                    rhTextbox.Text = reader["Rh"].ToString();
                    ageTextbox.Text = reader["Age"].ToString();
                    kgTextbox.Text = reader["Kg"].ToString();
                    cmTextBox.Text = reader["Cm"].ToString();
                    if (reader["Gender"].ToString() == "Erkek")
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton1.Checked = true;
                    }
                    Byte[] data = new Byte[0];
                    data = (Byte[])(reader["Photo"]);
                    photoByte = data;
                    MemoryStream mem = new MemoryStream(data);
                    profilePicturebox.Image = Image.FromStream(mem);
                }
                reader.Close();
                connection.Close();
            }
        }
        private void backPage_Click(object sender, EventArgs e)
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text != string.Empty && surnameTextbox.Text != string.Empty && tcTextbox.Text != string.Empty&&gender!=string.Empty)
            {
                string query = "INSERT INTO [Sicks] (Name,Surname,TcNo,Age,Kg,Cm,Rh,SavedDate,TotalMeets,TotalPills,Dianosis,Details,PanelColor,Photo,LossMeets,PhoneNumber,Mail,Address,HousePhone,Gender,LoginId) VALUES (@name,@surname,@tc,@age,@kg,@cm,@rh,@saveddate,@totalmeets,@totalpills,@dianosis,@details,@panelcolor,@photo,@lossmeets,@phone,@mail,@address,@housephone,@gender,@login)";
                if (editMode)
                {
                    query = "UPDATE Sicks SET Name=@name,Surname=@surname,TcNo=@tc,Age=@age,Kg=@kg,Cm=@cm,Rh=@rh,SavedDate=@saveddate,TotalMeets=@totalmeets,TotalPills=@totalpills,Dianosis=@dianosis,Details=@details,PanelColor=@panelcolor,Photo=@photo,LossMeets=@lossmeets,PhoneNumber=@phone,Mail=@mail,Address=@address,HousePhone=@housephone,Gender=@gender,LoginId=@login where Id=@id";
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (editMode)
                    {
                        command.Parameters.AddWithValue("@id", id);
                    }
                    command.Parameters.AddWithValue("@name", nameTextbox.Text);
                    command.Parameters.AddWithValue("@Surname", surnameTextbox.Text);
                    command.Parameters.AddWithValue("@Tc", tcTextbox.Text);
                    command.Parameters.AddWithValue("@age", ageTextbox.Text);
                    command.Parameters.AddWithValue("@kg", kgTextbox.Text);
                    command.Parameters.AddWithValue("@cm", cmTextBox.Text);
                    command.Parameters.AddWithValue("@rh", rhTextbox.Text);
                    command.Parameters.AddWithValue("@saveddate", DateTime.Now);
                    command.Parameters.AddWithValue("@totalmeets", 0);
                    command.Parameters.AddWithValue("@totalpills", 0);
                    command.Parameters.AddWithValue("@dianosis", dianosisTextbox.Text);
                    command.Parameters.AddWithValue("@details", detailsTextbox.Text);
                    command.Parameters.AddWithValue("@panelcolor", 0);
                    command.Parameters.AddWithValue("@photo", photoByte);
                    command.Parameters.AddWithValue("@lossmeets", 0);
                    command.Parameters.AddWithValue("@phone", phoneTextbox.Text);
                    command.Parameters.AddWithValue("@mail", mailTextbox.Text);
                    command.Parameters.AddWithValue("@address", addressTextbox.Text);
                    command.Parameters.AddWithValue("@housephone", housePhoneTextbox.Text);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@login", loginId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }
            else
            {
                WarningCard warning = new WarningCard();
                warning.warningMode = true;
                warning.headerLabel.Text = "BOŞ ALANLAR VAR";
                warning.detailLabel.Text = "Boş alanlar var, lütfen gerekli alanları doldurun!";
                warning.ShowDialog();
            }
        }

        private void profilePicturebox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ("Resim (*.jpg)|*.jpg|png (*.png)|*.png|gif (*.gif)|*.gif");
            openFileDialog1.Title = "Resim Dosyası Seçin";
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName!= "openFileDialog1" && openFileDialog1.FileName != string.Empty)
            {
                profilePicturebox.Image = Image.FromFile(openFileDialog1.FileName);
                photoByte = ImageToStream(openFileDialog1.FileName);
            }
        }
        private byte[] ImageToStream(string fileName)
        {
            MemoryStream stream = new MemoryStream();
            tryagain:
            try
            {
                Bitmap image = new Bitmap(fileName);
                var type = image.RawFormat;
                image.Save(stream, type);
            }
            catch
            {
                goto tryagain;
            }

            return stream.ToArray();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gender = radioButton3.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextbox.Clear();
            surnameTextbox.Clear();
            tcTextbox.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            phoneTextbox.Clear();
            housePhoneTextbox.Clear();
            mailTextbox.Clear();
            addressTextbox.Clear();
            detailsTextbox.Clear();
            dianosisTextbox.Clear();
            rhTextbox.Clear();
            cmTextBox.Clear();
            kgTextbox.Clear();
            ageTextbox.Clear();
            profilePicturebox.Image = Image.FromFile(defaultPhotoPath);
            photoByte = ImageToStream(defaultPhotoPath);
        }
    }
}
