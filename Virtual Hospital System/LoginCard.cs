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
    public partial class LoginCard : Form
    {
        //FORM EKRANDA SURUKLEMEK ICIN INT KONUM DEGISKENLERI VE BOOL
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        //----------------------------------------//
        int PositionX = Cursor.Position.X;
        int PositionY = Cursor.Position.Y;
        //---------------------------------------//
        private int againLimited = 0;
        private int second = 20;
        bool clearTextBoxUsername = false;
        bool isClearUsername = false;
        bool clearTextBoxPassword = false;
        bool isClearPassword = false;
        public StartPage start = new StartPage();
        public LoginCard()
        {
            InitializeComponent();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            if (clearTextBoxUsername)
            {
                usernameBox.ForeColor = Color.White;
            }
        }

        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back) {
                if (usernameBox.Text == "")
                {
                    usernameBox.Text = "Kullanıcı adı";
                    usernameBox.ForeColor = Color.LightBlue;
                    clearTextBoxUsername = false;
                    isClearUsername = false;
                }
            }
            else if(e.KeyCode != Keys.Down)
            {
                clearTextBoxUsername = true;
                if (!isClearUsername)
                {
                    isClearUsername = true;
                    usernameBox.Clear();
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                passwordBox.Focus();
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (clearTextBoxPassword)
            {
                passwordBox.ForeColor = Color.White;
                string chr = "*";
                passwordBox.PasswordChar = chr.ToCharArray()[0];
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (passwordBox.Text == "")
                {
                    passwordBox.Text = "Şifre";
                    passwordBox.ForeColor = Color.LightBlue;
                    clearTextBoxPassword = false;
                    isClearPassword = false;
                    passwordBox.PasswordChar = default;
                }
            }
            else if(e.KeyCode != Keys.Up)
            {
                clearTextBoxPassword = true;
                if (!isClearPassword)
                {
                    isClearPassword = true;
                    passwordBox.Clear();
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                usernameBox.Focus();
            }
        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (usernameBox.Text != string.Empty && passwordBox.Text != string.Empty)
            {
                if (againLimited < 3)
                {
                    login();
                }
                else
                {
                    loginLabel.Enabled = false;
                    uyariLabel.Visible = true;
                    securityTimer.Enabled = true;
                    securityTimer.Start();
                }
            }
            else
            {
                uyariLabel.Visible = true;
                uyariLabel.Text = "Boş alanları doldurun!";
            }
        }
        private void login()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            string query = "SELECT * From [Login] where Username='" + usernameBox.Text + "'";
            bool isExists = false;
            string password = "";
            int id = 0;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    password = reader["Password"].ToString();
                    id = Convert.ToInt32(reader["Id"]);
                    isExists = true;
                }
                reader.Close();
                connection.Close();
            }
            if (isExists)
            {
                if (Decrypt(password).Equals(passwordBox.Text))
                {
                    Form1 form = new Form1();
                    form.loginId = id;
                    form.Show();
                    start.Hide();
                }
                else
                {
                    uyariLabel.Visible = true;
                    uyariLabel.Text = "Yanlış Şifre!";
                    againLimited++;
                }
            }
            else
            {
                uyariLabel.Visible = true;
                uyariLabel.Text = "Kullanıcı Bulunamadı";
                againLimited++;
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
                second--;
                uyariLabel.Text = "Kalan Zaman " + second + "sn";
            }
            else
            {
                second = 20;
                againLimited = 0;
                uyariLabel.Text = "";
                uyariLabel.Visible = false;
                loginLabel.Enabled = true;
                securityTimer.Enabled = false;
                securityTimer.Stop();
                usernameBox.Clear();
                passwordBox.Clear();
            }
        }

        private void loginPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = start.Location;
        }

        private void loginPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                start.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void loginPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = start.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                start.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void topLabel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = start.Location;
        }

        private void topLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                start.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void topLabel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //şifremi unuttum işlemleri
        private void forgotPasswordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            start.Hide();
            ForgotPassword forgot = new ForgotPassword();
            forgot.start = start;
            forgot.ShowDialog();
        }
    }
}
