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
    public partial class AddNote : Form
    {
        public int loginId = 0;
        public Button pageBtn = new Button();
        public Panel viewerPanel = new Panel();
        public NotesPage page = new NotesPage();
        public int id = 0;
        public bool pageMode = false;
        public bool editMode = false;
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public int fav = 0;
        public Color backgroundColor = Color.CadetBlue;
        public AddNote()
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            headerTextbox.Clear();
            noteTextbox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            string query = "INSERT INTO [Notes] (Header,Note,SavedDate,Colorİndex,Favorites,LoginId) VALUES (@header,@note,@saved,@color,@fav,@login)";
            if (editMode)
            {
                query = "UPDATE Notes SET Header=@header,Note=@note,SavedDate=@saved,Colorİndex=@color,Favorites=@fav,LoginId=@login where Id=@id";
            }
            using(SqlCommand command = new SqlCommand(query,connection))
            {
                if (editMode)
                {
                    command.Parameters.AddWithValue("@id", id);
                }
                command.Parameters.AddWithValue("@header", headerTextbox.Text);
                command.Parameters.AddWithValue("@note", noteTextbox.Text);
                command.Parameters.AddWithValue("@saved", DateTime.Now);
                command.Parameters.AddWithValue("@color", panelColor.ToArgb());
                command.Parameters.AddWithValue("@fav", fav);
                command.Parameters.AddWithValue("@login", loginId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panelColor = panel2.BackColor;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel4.BorderStyle = BorderStyle.None;
            panel5.BorderStyle = BorderStyle.None;
            panel6.BorderStyle = BorderStyle.None;
            panel7.BorderStyle = BorderStyle.None;
            panel8.BorderStyle = BorderStyle.None;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panelColor = panel4.BackColor;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel2.BorderStyle = BorderStyle.None;
            panel5.BorderStyle = BorderStyle.None;
            panel6.BorderStyle = BorderStyle.None;
            panel7.BorderStyle = BorderStyle.None;
            panel8.BorderStyle = BorderStyle.None;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            panelColor = panel5.BackColor;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel4.BorderStyle = BorderStyle.None;
            panel2.BorderStyle = BorderStyle.None;
            panel6.BorderStyle = BorderStyle.None;
            panel7.BorderStyle = BorderStyle.None;
            panel8.BorderStyle = BorderStyle.None;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            panelColor = panel6.BackColor;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel4.BorderStyle = BorderStyle.None;
            panel5.BorderStyle = BorderStyle.None;
            panel2.BorderStyle = BorderStyle.None;
            panel7.BorderStyle = BorderStyle.None;
            panel8.BorderStyle = BorderStyle.None;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            panelColor = panel7.BackColor;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel4.BorderStyle = BorderStyle.None;
            panel5.BorderStyle = BorderStyle.None;
            panel6.BorderStyle = BorderStyle.None;
            panel2.BorderStyle = BorderStyle.None;
            panel8.BorderStyle = BorderStyle.None;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            panelColor = panel8.BackColor;
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel4.BorderStyle = BorderStyle.None;
            panel5.BorderStyle = BorderStyle.None;
            panel6.BorderStyle = BorderStyle.None;
            panel7.BorderStyle = BorderStyle.None;
            panel2.BorderStyle = BorderStyle.None;
        }

        private void AddNote_Load(object sender, EventArgs e)
        {
            this.BackColor = backgroundColor;
            if (panelColor.ToArgb().ToString() == panel2.BackColor.ToArgb().ToString())
            {
                panel2.BorderStyle = BorderStyle.Fixed3D;
                panel4.BorderStyle = BorderStyle.None;
                panel5.BorderStyle = BorderStyle.None;
                panel6.BorderStyle = BorderStyle.None;
                panel7.BorderStyle = BorderStyle.None;
                panel8.BorderStyle = BorderStyle.None;
            }
            else if (panelColor.ToArgb().ToString() == panel4.BackColor.ToArgb().ToString())
            {
                panel4.BorderStyle = BorderStyle.Fixed3D;
                panel2.BorderStyle = BorderStyle.None;
                panel5.BorderStyle = BorderStyle.None;
                panel6.BorderStyle = BorderStyle.None;
                panel7.BorderStyle = BorderStyle.None;
                panel8.BorderStyle = BorderStyle.None;
            }
            else if (panelColor.ToArgb().ToString() == panel5.BackColor.ToArgb().ToString())
            {
                panel5.BorderStyle = BorderStyle.Fixed3D;
                panel4.BorderStyle = BorderStyle.None;
                panel2.BorderStyle = BorderStyle.None;
                panel6.BorderStyle = BorderStyle.None;
                panel7.BorderStyle = BorderStyle.None;
                panel8.BorderStyle = BorderStyle.None;
            }
            else if(panelColor.ToArgb().ToString() == panel6.BackColor.ToArgb().ToString())
            {
                panel6.BorderStyle = BorderStyle.Fixed3D;
                panel4.BorderStyle = BorderStyle.None;
                panel5.BorderStyle = BorderStyle.None;
                panel2.BorderStyle = BorderStyle.None;
                panel7.BorderStyle = BorderStyle.None;
                panel8.BorderStyle = BorderStyle.None;
            }
            else if (panelColor.ToArgb().ToString() == panel7.BackColor.ToArgb().ToString())
            {
                panel7.BorderStyle = BorderStyle.Fixed3D;
                panel4.BorderStyle = BorderStyle.None;
                panel5.BorderStyle = BorderStyle.None;
                panel6.BorderStyle = BorderStyle.None;
                panel2.BorderStyle = BorderStyle.None;
                panel8.BorderStyle = BorderStyle.None;
            }
            else if (panelColor.ToArgb().ToString() == panel8.BackColor.ToArgb().ToString())
            {
                panel8.BorderStyle = BorderStyle.Fixed3D;
                panel4.BorderStyle = BorderStyle.None;
                panel5.BorderStyle = BorderStyle.None;
                panel6.BorderStyle = BorderStyle.None;
                panel7.BorderStyle = BorderStyle.None;
                panel2.BorderStyle = BorderStyle.None;
            }
        }
    }
}
