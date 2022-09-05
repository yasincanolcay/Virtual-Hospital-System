using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Hospital_System
{
    public partial class StartPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int NLeftRect
            , int NRightRect, int NTopRect, int NBottomRect, int NWidthEllipse, int NHeightEllipse);
        //FORM EKRANDA SURUKLEMEK ICIN INT KONUM DEGISKENLERI VE BOOL
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        //----------------------------------------//
        int PositionX = Cursor.Position.X;
        int PositionY = Cursor.Position.Y;

        public int loginId = 0;

        public StartPage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void StartPage_Load(object sender, EventArgs e)
        {
            LoginCard login = new LoginCard();
            login.TopLevel = false;
            login.Dock = DockStyle.Fill;
            login.start = this;
            viewerPanel.Controls.Clear();
            viewerPanel.Controls.Add(login);
            login.Show();
        }
        private void closePic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closePic_MouseHover(object sender, EventArgs e)
        {
            closePic.BackColor = Color.FromArgb(50, 30, 30, 30);
        }

        private void closePic_MouseLeave(object sender, EventArgs e)
        {
            closePic.BackColor = Color.Transparent;
        }

        private void minimizePic_MouseHover(object sender, EventArgs e)
        {
            minimizePic.BackColor = Color.FromArgb(50, 30, 30, 30);
        }

        private void minimizePic_MouseLeave(object sender, EventArgs e)
        {
            minimizePic.BackColor = Color.Transparent;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void appIcon_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void appIcon_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void appIcon_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void appName_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void appName_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void appName_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void AppName2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void AppName2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void AppName2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterCard register = new RegisterCard();
            register.TopLevel = false;
            register.Dock = DockStyle.Fill;
            register.page = this;
            register.startPageViewerPanel = viewerPanel;
            viewerPanel.Controls.Clear();
            viewerPanel.Controls.Add(register);
            register.Show();
        }

        private void githubLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yasincanolcay?tab=repositories");
        }
    }
}
