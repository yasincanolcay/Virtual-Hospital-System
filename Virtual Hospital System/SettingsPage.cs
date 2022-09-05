using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class SettingsPage : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
        private int settingsId = 1;
        string toggleOn = "Assets/İcons/switch_on_48px.png";
        string toggleOff = "Assets/İcons/switch_off_48px.png";
        bool startToggleChecked = false;
        bool starNightModetToggleChecked = false;
        bool autoNightModetToggleChecked = false;
        bool sendTelegramToggleChecked = false;
        bool weatherToggleChecked = false;
        public int loginId = 0;
        bool isReady = false;
        public Color backgroundColor = Color.CadetBlue;
        public Color labelColor = Color.DarkSlateBlue;

        public SettingsPage()
        {
            InitializeComponent();
        }
        private void SettingsPage_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            readSettingsData();
            label2.ForeColor = labelColor;
            label3.ForeColor = labelColor;
            label5.ForeColor = labelColor;
            label7.ForeColor = labelColor;
            label9.ForeColor = labelColor;
            label11.ForeColor = labelColor;
            label13.ForeColor = labelColor;
            linkLabel1.LinkColor = labelColor;
            linkLabel2.LinkColor = labelColor;
            linkLabel3.LinkColor = labelColor;
            linkLabel4.LinkColor = labelColor;
        }
        private void readSettingsData()
        {
            using(SqlCommand command = new SqlCommand("SELECT * From [Settings]",connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    settingsId = Convert.ToInt32(reader["Id"]);
                    if (Convert.ToInt32(reader["Start"]) == 1)
                    {
                        startToggleChecked = true;
                        startToggle.Image = Image.FromFile(toggleOn);
                    }
                    if(Convert.ToInt32(reader["StartNightmode"]) == 1)
                    {
                        starNightModetToggleChecked = true;
                        startNightmodeToggle.Image = Image.FromFile(toggleOn);
                    }
                    if(Convert.ToInt32(reader["AutoNightmode"]) == 1)
                    {
                        autoNightModetToggleChecked = true;
                        autoNightmodeToggle.Image = Image.FromFile(toggleOn);
                    }
                    if(Convert.ToInt32(reader["SendTelegram"]) == 1)
                    {
                        sendTelegramToggleChecked = true;
                        sendTelegramToggle.Image = Image.FromFile(toggleOn);
                    }
                    if(Convert.ToInt32(reader["Weather"]) == 1)
                    {
                        weatherToggleChecked = true;
                        weatherToggle.Image = Image.FromFile(toggleOn);
                    }
                    cityComboBox.Text = reader["WeatherCity"].ToString();
                    dateTimePicker1.Value = DateTime.Parse(reader["FinishTime"].ToString());
                }
                reader.Close();
                connection.Close();
                isReady = true;
            }
        }
        private void startToggle_Click(object sender, EventArgs e)
        {
            if (!startToggleChecked)
            {
                startToggleChecked = true;
                startToggle.Image = Image.FromFile(toggleOn);
                //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("Virtual Hospital", "\"" + Application.ExecutablePath + "\"");
                updateSettings("Start", 1);
            }
            else
            {
                startToggleChecked = false;
                startToggle.Image = Image.FromFile(toggleOff);
                //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("Virtual Hospital");
                updateSettings("Start", 0);
            }
        }

        private void startNightmodeToggle_Click(object sender, EventArgs e)
        {
            if (!starNightModetToggleChecked)
            {
                starNightModetToggleChecked = true;
                startNightmodeToggle.Image = Image.FromFile(toggleOn);
                updateSettings("StartNightmode", 1);
            }
            else
            {
                starNightModetToggleChecked = false;
                startNightmodeToggle.Image = Image.FromFile(toggleOff);
                updateSettings("StartNightmode", 0);
            }
        }

        private void autoNightmodeToggle_Click(object sender, EventArgs e)
        {
            if (!autoNightModetToggleChecked)
            {
                autoNightModetToggleChecked = true;
                autoNightmodeToggle.Image = Image.FromFile(toggleOn);
                updateSettings("AutoNightmode", 1);
            }
            else
            {
                autoNightModetToggleChecked = false;
                autoNightmodeToggle.Image = Image.FromFile(toggleOff);
                updateSettings("AutoNightmode", 0);
            }
        }

        private void sendTelegramToggle_Click(object sender, EventArgs e)
        {
            if (!sendTelegramToggleChecked)
            {
                sendTelegramToggleChecked = true;
                sendTelegramToggle.Image = Image.FromFile(toggleOn);
                updateSettings("SendTelegram", 1);
            }
            else
            {
                sendTelegramToggleChecked = false;
                sendTelegramToggle.Image = Image.FromFile(toggleOff);
                updateSettings("SendTelegram", 0);
            }
        }

        private void weatherToggle_Click(object sender, EventArgs e)
        {
            if (!weatherToggleChecked)
            {
                weatherToggleChecked = true;
                weatherToggle.Image = Image.FromFile(toggleOn);
                updateSettings("Weather", 1);
            }
            else
            {
                weatherToggleChecked = false;
                weatherToggle.Image = Image.FromFile(toggleOff);
                updateSettings("Weather", 0);
            }
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSettings("WeatherCity", cityComboBox.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateSettings("FinishTime", dateTimePicker1.Text);
        }
        private void updateSettings(string parameters,dynamic value)
        {
            if (isReady)
            {
               
                string query = "UPDATE Settings SET " + parameters + "=@param where Id=@id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@id", settingsId);
                    command.Parameters.AddWithValue("@param", value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                

            }
        }
    }
}
