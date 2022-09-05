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
    public partial class SecurityCard : Form
    {
        public int loginId = 0;
        public Panel viewerPanel = new Panel();
        public ProfilePage page = new ProfilePage();
        public AddUser user = new AddUser();
        public Form1 form = new Form1();
        public int id = 0;
        public bool deleteMode = false;
        private int againLimited = 0;
        private int second = 20;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public SecurityCard()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            if (againLimited < 3)
            {
                readData();
            }
            else
            {
                actionButton.Enabled = false;
                securityTimer.Enabled = true;
                securityTimer.Start();
            }
        }
        private void readData()
        {
            bool isReady = false;
            string password = "";
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using(SqlCommand command = new SqlCommand("SELECT * From [Login] where Id='"+id+"'",connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    password = reader["Password"].ToString();
                }
                reader.Close();
                connection.Close();
                isReady = true;
            }
            if (isReady)
            {
                if (Decrypt(password).Equals(passwordTextbox.Text))
                {
                    if (!deleteMode)
                    {
                        user.passwordTextbox.Text = passwordTextbox.Text;
                        viewerPanel.Controls.Clear();
                        viewerPanel.Controls.Add(user);
                        user.Show();
                        this.Close();
                    }
                    else
                    {
                        this.Hide();
                        WarningCard warning = new WarningCard();
                        warning.parameters = "Login";
                        warning.Id = id;
                        warning.headerLabel.Text = "KULLANICI SİLİNECEK";
                        warning.detailLabel.Text = "Bu kullanıcı silinecek ve hesapdan çıkış yapılacak, bu işlem geri döndürülemez!";
                        warning.deleteLogin = true;
                        warning.form = form;
                        warning.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    warningLabel.Visible = true;
                    warningLabel.Text = "Şifre Yanlış";
                    againLimited++;
                }
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

        private void securityTimer_Tick(object sender, EventArgs e)
        {
            if (second > 0)
            {
                warningLabel.Text = "Yanlış şifre " + second + "sn bekleyin";
                second--;
            }
            else
            {
                warningLabel.Text = "";
                warningLabel.Visible = false;
                second = 20;
                againLimited = 0;
                actionButton.Enabled = true;
                securityTimer.Enabled = false;
                securityTimer.Stop();
            }
        }

        private void SecurityCard_Load(object sender, EventArgs e)
        {
            panel1.BackColor = panelColor;
        }
    }
}
