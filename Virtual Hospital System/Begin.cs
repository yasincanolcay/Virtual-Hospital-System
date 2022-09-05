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
    public partial class Begin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int NLeftRect
    , int NRightRect, int NTopRect, int NBottomRect, int NWidthEllipse, int NHeightEllipse);

        int value = 0;
        public Begin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Begin_Load(object sender, EventArgs e)
        {
            startingTimer.Enabled = true;
            startingTimer.Start();
        }

        private void startingTimer_Tick(object sender, EventArgs e)
        {
            if (value<100)
            {
                circularProgressBar1.Value += value;
                circularProgressBar1.Text = value.ToString()+"%";
                value += 8;
            }
            else
            {
                StartPage start = new StartPage();
                start.Show();
                this.Hide();
                circularProgressBar1.Dispose();
                startingTimer.Enabled = false;
                startingTimer.Stop();
                startingTimer.Dispose();
            }
        }
    }
}
