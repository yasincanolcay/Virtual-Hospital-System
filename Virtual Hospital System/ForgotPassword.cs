using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class ForgotPassword : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int NLeftRect
    , int NRightRect, int NTopRect, int NBottomRect, int NWidthEllipse, int NHeightEllipse);
        public StartPage start = new StartPage();
        public ForgotPassword()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void closePic_Click(object sender, EventArgs e)
        {
            start.Show();
            this.Close();
        }

        private void nextLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (usernameBox.Text != string.Empty)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
                string query = "SELECT * From [Login] where Username='" + usernameBox.Text + "'";
                bool isExists = false;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isExists = true;
                    }
                    reader.Close();
                    connection.Close();
                }
                if (isExists)
                {
                    SecurityAnswer answer = new SecurityAnswer();
                    answer.username = usernameBox.Text;
                    answer.start = start;
                    answer.ShowDialog();
                    this.Close();
                }
                else
                {
                    WarningCard warning = new WarningCard();
                    warning.warningMode = true;
                    warning.headerLabel.Text = "KULLANICI BULUNAMADI";
                    warning.detailLabel.Text = "Girdiginiz bilgilerle eşleşen bir kullanıcı bulunamadı";
                    warning.ShowDialog();
                }
            }
            else
            {
                WarningCard warning = new WarningCard();
                warning.warningMode = true;
                warning.headerLabel.Text = "KULLANICI ADI BOŞ";
                warning.detailLabel.Text = "Kullanıcı adı boş bırakılamaz, lütfen kullanıcı adını yazın.";
                warning.ShowDialog();
            }
        }
    }
}
