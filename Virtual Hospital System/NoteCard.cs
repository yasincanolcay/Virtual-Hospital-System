using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class NoteCard : Form
    {
        public int id = 0;
        public Button refreshButton = new Button();
        public Panel viewerPanel = new Panel();
        public NotesPage page = new NotesPage();
        public Color panelColor = Color.FromArgb(0, 125, 140);
        public Color backgroundColor = Color.CadetBlue;
        public Color panel2Color = Color.FromArgb(0, 125, 140);
        public Color labelColor = Color.Gainsboro;
        public bool darkMode = false;
        public int loginId = 0;
        public bool fav = false;
        public NoteCard()
        {
            InitializeComponent();
        }
        private void NoteCard_Load(object sender, EventArgs e)
        {
            if (!darkMode)
            {
                panel12.BackColor = panelColor;
            }
            else {
                panel12.BackColor = panel2Color;
                panel1.BackColor = panelColor;
            }
            this.BackColor = backgroundColor;
            if (fav == true)
            {
                favoritesPic.Image = Image.FromFile("Assets/İcons/favorite_red_48px.png");
            }
        }

        private void favoritesPic_Click(object sender, EventArgs e)
        {
            if (fav)
            {
                updateFavorites(0);
                favoritesPic.Image = Image.FromFile("Assets/İcons/favorite_48px.png");
                fav = false;
            }
            else
            {
                updateFavorites(1);
                favoritesPic.Image = Image.FromFile("Assets/İcons/favorite_red_48px.png");
                fav = true;
            }
        }
        private void updateFavorites(int favorites)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\csharp projelerim\Virtual Hospital System\Virtual Hospital System\Database1.mdf';Integrated Security=True");
            using(SqlCommand command = new SqlCommand("UPDATE Notes SET Favorites=@fav where Id='"+id+"'",connection))
            {
                command.Parameters.AddWithValue("@fav", favorites);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void showPic_Click(object sender, EventArgs e)
        {
            editAndShow();
        }
        private void editAndShow()
        {
            AddNote note = new AddNote();
            note.TopLevel = false;
            note.Dock = DockStyle.Fill;
            note.loginId = loginId;
            note.page = page;
            note.viewerPanel = viewerPanel;
            note.editMode = true;
            note.pageMode = true;
            note.id = id;
            note.panelColor = panelColor;
            note.headerTextbox.Text = headerLabel.Text;
            note.noteTextbox.Text = detailsLabel.Text;
            if (fav)
            {
                note.fav = 1;
            }
            note.backgroundColor = backgroundColor;
            viewerPanel.Controls.Clear();
            viewerPanel.Controls.Add(note);
            note.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            editAndShow();
        }

        private void deletePic_Click(object sender, EventArgs e)
        {
            WarningCard warning = new WarningCard();
            warning.parameters = "Notes";
            warning.Id = id;
            warning.refreshButton = refreshButton;
            warning.headerLabel.Text = "NOT SİLİNECEK";
            warning.detailLabel.Text = "Bu not kalıcı olarak silinecek, notu silmek istediğinize emin misiniz?";
            warning.ShowDialog();
        }
    }
}
