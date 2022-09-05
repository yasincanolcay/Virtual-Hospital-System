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
    public partial class ChangePassword : Form
    {
        public int id = 0;
        public StartPage start = new StartPage();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void changeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (passwordTextbox.Text != string.Empty && againPasswordTextbox.Text != string.Empty && passwordTextbox.Text == againPasswordTextbox.Text)
            {
                bool isReady = false;
                string query = "UPDATE Login SET Password=@password where Id=@id";
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    string password = Encrypt(passwordTextbox.Text);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    isReady = true;
                }
                if (isReady)
                {
                    this.Hide();
                    WarningCard warning = new WarningCard();
                    warning.warningMode = true;
                    warning.headerLabel.Text = "ŞİFRENİZ DEĞİŞTİRİLDİ";
                    warning.detailLabel.Text = "Şifreniz başarılı bir şekilde değiştirildi, sağlıklı günler dileriz";
                    warning.ShowDialog();
                    start.Show();
                    this.Close();
                }
            }
            else
            {
                WarningCard warning = new WarningCard();
                warning.warningMode = true;
                warning.headerLabel.Text = "GEÇERSİZ BİLGİLER";
                warning.detailLabel.Text = "Girdiğiniz bilgiler boş veya eşleşmiyor, lütfen tekrar deneyin.";
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

        private void closePic_Click(object sender, EventArgs e)
        {
            start.Show();
            this.Close();
        }
    }
}
