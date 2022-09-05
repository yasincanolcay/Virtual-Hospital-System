using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class AddReminders : Form
    {
        public Button pageBtn = new Button();
        public RemindersPage page = new RemindersPage();
        public Panel viewerPanel = new Panel();
        public bool editMode = false;
        public bool pageMode = false;
        public int loginId = 0;
        public int id = 0;
        public Color backgroundColor = Color.CadetBlue;

        public AddReminders()
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            string query = "INSERT INTO [Reminders] (Header,Details,Datetime,Time,isRead,LoginId) VALUES (@header,@details,@datetime,@time,@isread,@login)";
            if (editMode)
            {
                query = "UPDATE Reminders SET Header=@header,Details=@details,Datetime=@datetime,Time=@time,isRead=@isread,LoginId=@login where Id=@id";
            }
            using(SqlCommand command = new SqlCommand(query,connection))
            {
                if (editMode)
                {
                    command.Parameters.AddWithValue("@id", id);
                }
                command.Parameters.AddWithValue("@header",headerTextbox.Text);
                command.Parameters.AddWithValue("@details",detailsTextbox.Text);
                command.Parameters.AddWithValue("@datetime",dateTimePicker1.Text);
                command.Parameters.AddWithValue("@time",dateTimePicker2.Text);
                command.Parameters.AddWithValue("@isread", 0);
                command.Parameters.AddWithValue("@login", loginId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void AddReminders_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
        }
    }
}
