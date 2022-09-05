using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class SecurityAnswer : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int NLeftRect
, int NRightRect, int NTopRect, int NBottomRect, int NWidthEllipse, int NHeightEllipse);
        public string username = "";
        private string answer = "";
        private int id = 0;
        public StartPage start = new StartPage();
        public SecurityAnswer()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void closePic_Click(object sender, EventArgs e)
        {
            start.Show();
            this.Close();
        }

        private void SecurityAnswer_Load(object sender, EventArgs e)
        {
            readUserData();
        }
        private void readUserData()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            string query = "SELECT * From [Login] where Username='" + username + "'";
            bool isExists = false;
            string question = "";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    question = reader["SecurityQuestion"].ToString();
                    answer = reader["SecurityAnswer"].ToString();
                    isExists = true;
                }
                reader.Close();
                connection.Close();
            }
            if (isExists)
            {
                securityQuestionLabel.Text = question;
            }
        }

        private void nextLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (answerTextBox.Text != string.Empty)
            {
                if (Decrypt(answer).Equals(answerTextBox.Text))
                {
                    ChangePassword change = new ChangePassword();
                    change.id = id;
                    change.start = start;
                    change.ShowDialog();
                    this.Close();
                }
                else
                {
                    WarningCard warning = new WarningCard();
                    warning.warningMode = true;
                    warning.headerLabel.Text = "YANLIŞ CEVAP";
                    warning.detailLabel.Text = "Güvenlik sorusunu yanlış cevapladınız, lütfen tekrar deneyin.";
                    warning.ShowDialog();
                }
            }
            else
            {
                WarningCard warning = new WarningCard();
                warning.warningMode = true;
                warning.headerLabel.Text = "BOŞ CEVAP";
                warning.detailLabel.Text = "Cevap alanı boş bırakılamaz, lütfen sorunun cevabını yazın.";
                warning.ShowDialog();
            }
        }
        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio";  //we can change the code converstion key as per our requirement, but the decryption key should be same as encryption key    
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}
