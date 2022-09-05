using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class AddUser : Form
    {
        public Button pageBtn = new Button();
        public ProfilePage page = new ProfilePage();
        public Panel viewerPanel = new Panel();
        public bool editMode = false;
        public bool pageMode = false;
        string defaultPhotoPath = "Assets/Images/default_profile.png";
        public byte[] photoByte = { };
        private string gender = "";
        public int loginId = 0;
        public int id = 0;
        public DateTime saved = DateTime.Now;
        public string userPassword = "";
        public AddUser()
        {
            InitializeComponent();
        }
        private void AddUser_Load(object sender, EventArgs e)
        {
            if (!editMode)
            {
                photoByte = ImageToStream(defaultPhotoPath);
                profilePicturebox.Image = Image.FromFile(defaultPhotoPath);
            }
            else
            {
                MemoryStream mem = new MemoryStream(photoByte);
                profilePicturebox.Image = Image.FromStream(mem);
                quickLogin.Text = "Çıkış";
            }
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

        private void profilePicturebox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ("Resim (*.jpg)|*.jpg|png (*.png)|*.png|gif (*.gif)|*.gif");
            openFileDialog1.Title = "Resim Dosyası Seçin";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "openFileDialog1" && openFileDialog1.FileName != string.Empty)
            {
                profilePicturebox.Image = Image.FromFile(openFileDialog1.FileName);
                photoByte = ImageToStream(openFileDialog1.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text != string.Empty && surnameTextbox.Text != string.Empty && statuTextbox.Text != string.Empty && questionCombobox.Text != string.Empty && answerTextbox.Text != string.Empty && usernameTextbox.Text != string.Empty && passwordTextbox.Text != string.Empty)
            {
                if (passwordTextbox.Text.Length > 8)
                {
                    saveData();
                }
                else
                {
                    WarningCard warning = new WarningCard();
                    warning.headerLabel.Text = "GÜÇSÜZ ŞİFRE";
                    warning.detailLabel.Text = "Güvenliğiniz için 8 karakterden uzun şifre girin!";
                    warning.warningMode = true;
                    warning.ShowDialog();
                }
            }
            else
            {
                WarningCard warning = new WarningCard();
                warning.headerLabel.Text = "BOŞ ALANLAR VAR";
                warning.detailLabel.Text = "Boş alanlar var, lütfen gerekli bilgileri yazın.";
                warning.warningMode = true;
                warning.ShowDialog();
            }
        }
        private void saveData()
        {
            bool isHave = false;
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            if (!editMode)
            {
                using (SqlCommand command = new SqlCommand("SELECT * From [Login] where Username='" + usernameTextbox.Text + "'", connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isHave = true;
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            if (!isHave)
            {
                string query = "INSERT INTO [Login] (Name,Surname,Statu,Age,School,PhoneNumber,Address,Mail,Web,Photo,SavedDate,Username,Password,TelegramToken,TelegramId,HospitalName,Policlinic,Bio,SecurityQuestion,SecurityAnswer) VALUES (@name,@surname,@statu,@age,@school,@phone,@address,@mail,@web,@photo,@saved,@username,@password,@token,@telegramId,@hospital,@policlinic,@bio,@question,@answer)";
                if (editMode)
                {
                    query = "UPDATE Login SET Name=@name,Surname=@surname,Statu=@statu,Age=@age,School=@school,PhoneNumber=@phone,Address=@address,Mail=@mail,Web=@web,Photo=@photo,SavedDate=@saved,Username=@username,Password=@password,TelegramToken=@token,TelegramId=@telegramId,HospitalName=@hospital,Policlinic=@policlinic,Bio=@bio,SecurityQuestion=@question,SecurityAnswer=@answer where Id=@id";
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (editMode)
                    {
                        command.Parameters.AddWithValue("@id", id);
                    }
                    command.Parameters.AddWithValue("@name", nameTextbox.Text);
                    command.Parameters.AddWithValue("@surname", surnameTextbox.Text);
                    command.Parameters.AddWithValue("@statu", statuTextbox.Text);
                    command.Parameters.AddWithValue("@age", ageTextbox.Text);
                    command.Parameters.AddWithValue("@school", schoolTextbox.Text);
                    command.Parameters.AddWithValue("@phone", phoneTextbox.Text);
                    command.Parameters.AddWithValue("@address", addressTextbox.Text);
                    command.Parameters.AddWithValue("@mail", mailTextbox.Text);
                    command.Parameters.AddWithValue("@web", weburlTextbox.Text);
                    command.Parameters.AddWithValue("@photo", photoByte);
                    command.Parameters.AddWithValue("@saved", saved);
                    string password = Encrypt(passwordTextbox.Text);
                    string answer = Encrypt(answerTextbox.Text);
                    command.Parameters.AddWithValue("@username", usernameTextbox.Text);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@token", tokenTextbox.Text);
                    command.Parameters.AddWithValue("@telegramId", idTextbox.Text);
                    command.Parameters.AddWithValue("@hospital", hospitalTextbox.Text);
                    command.Parameters.AddWithValue("@policlinic", policlinicTextbox.Text);
                    command.Parameters.AddWithValue("@bio", bioTextbox.Text);
                    command.Parameters.AddWithValue("@question", questionCombobox.Text);
                    command.Parameters.AddWithValue("@answer", answer);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                WarningCard warning = new WarningCard();
                warning.headerLabel.Text = "KAYIT YAPILAMIYOR";
                warning.detailLabel.Text = "Bu kullanıcı adı zaten kullanılıyor, lütfen başka bir kullanıcı adı alın.";
                warning.warningMode = true;
                warning.ShowDialog();
            }
        }
        public static string Encrypt(string encryptString)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement    
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptString = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptString;
        }
    }
}
