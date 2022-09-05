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
    public partial class AddPill : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
        public int loginId = 0;
        public PillsPage page = new PillsPage();
        public Panel viewerPanel = new Panel();
        public Button pageBtn = new Button();
        public bool editMode = false;
        public bool pageMode = false;
        public int id = 0;
        public Color backgroundColor = Color.CadetBlue;
        public AddPill()
        {
            InitializeComponent();
        }

        private void pageBack_Click(object sender, EventArgs e)
        {
            if (!editMode)
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
            if (pilNamebox.Text != string.Empty)
            {
                string query = "INSERT INTO [Pills] (Name,CompanyName,CertificateNo,Mg,Tablet,Details,SavedDate,Contact,LoginId) VALUES (@name,@company,@cer,@mg,@tb,@dt,@saved,@contact,@login)";
                if (editMode)
                {
                    query = "UPDATE Pills SET Name=@name,CompanyName=@company,CertificateNo=@cer,Mg=@mg,Tablet=@tb,Details=@dt,SavedDate=@saved,Contact=@contact,LoginId=@login where Id=@id";
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (editMode)
                    {
                        command.Parameters.AddWithValue("@id", id);
                    }
                    command.Parameters.AddWithValue("@name", pilNamebox.Text);
                    command.Parameters.AddWithValue("@company", companyBox.Text);
                    command.Parameters.AddWithValue("@cer", certificateBox.Text);
                    command.Parameters.AddWithValue("@mg", mgBox.Text);
                    command.Parameters.AddWithValue("@tb", numberBox.Text);
                    command.Parameters.AddWithValue("@dt", detailsBox.Text);
                    command.Parameters.AddWithValue("@saved", DateTime.Now);
                    command.Parameters.AddWithValue("@contact", contactBox.Text);
                    command.Parameters.AddWithValue("@login", loginId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                WarningCard warning = new WarningCard();
                warning.warningMode = true;
                warning.headerLabel.Text = "İLAÇ ADI BOŞ";
                warning.detailLabel.Text = "Lütfen ilaç adını yazın.";
                warning.ShowDialog();
            }
        }

        private void AddPill_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            if (editMode)
            {
                loadData();
            }
        }
        private void loadData()
        {
            using(SqlCommand command = new SqlCommand("SELECT * From [Pills] where Id='" + id + "'", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    pilNamebox.Text = reader["Name"].ToString();
                    certificateBox.Text = reader["CertificateNo"].ToString();
                    mgBox.Text = reader["Mg"].ToString();
                    numberBox.Text = reader["Tablet"].ToString();
                    detailsBox.Text = reader["Details"].ToString();
                    companyBox.Text = reader["CompanyName"].ToString();
                    contactBox.Text = reader["Contact"].ToString();
                }
                reader.Close();
                connection.Close();
            }
        }
    }
}
