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
    public partial class NotificationShow : Form
    {
        public int id = 0;
        public NotificationShow()
        {
            InitializeComponent();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotificationShow_Load(object sender, EventArgs e)
        {
            writeIsRead();
        }
        private void writeIsRead()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            string query = "UPDATE Reminders SET isRead=@isread where Id=@id";
            using(SqlCommand command = new SqlCommand(query,connection))
            {
                command.Parameters.AddWithValue("@id",id);
                command.Parameters.AddWithValue("@isread", 1);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
