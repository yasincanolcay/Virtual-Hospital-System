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
    public partial class WarningCard : Form
    {
        public bool warningMode = false;
        public string parameters = "";
        private int id = 0;
        public Button refreshButton = new Button();
        public int loginId = 0;
        public bool deleteLogin = false;
        public Form1 form = new Form1();
        public StartPage start = new StartPage();
        public int Id { get => id; set => id = value; }

        public WarningCard()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WarningCard_Load(object sender, EventArgs e)
        {
            if (warningMode)
            {
                actionButton.Text = "Tamam";
                cancelButton.Visible = false;
            }
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            if (!warningMode)
            {
                string query = "delete " + parameters + " where Id='" + Id + "'";
                SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                refreshButton.PerformClick();
                if (deleteLogin)
                {
                    form.Close();
                    start.Show();
                }
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
