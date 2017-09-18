using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib.Client;

namespace Watchier
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private static string tmdbApiKey = "8d6f5e3ef9008fb0f47871820feafcec";

        public static string TmdbApiKey
        {
            get
            {
                return tmdbApiKey;
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private static User user;

        public static string localImagePath = Application.StartupPath + "\\Images\\";
        public static TMDbClient mdbClient = new TMDbClient("8d6f5e3ef9008fb0f47871820feafcec");

        internal static User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }


        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (ActiveForm != null)
                {
                    ActiveForm.Location = new Point((ActiveForm.Location.X - lastLocation.X) + e.X, (ActiveForm.Location.Y - lastLocation.Y) + e.Y);
                    ActiveForm.Update();
                }
            }

        }

        private void panel_header_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //userWindow1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Check Image Directory
            try
            {
                if (!Directory.Exists(localImagePath))
                {
                    Directory.CreateDirectory(localImagePath);
                }
            }
            catch (Exception exception){
                Console.WriteLine(exception);
                throw;
            }
          
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
            label_username.Text = "Welcome, " + user.name;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            searchView1.BringToFront();
        }

        private void button_list_Click(object sender, EventArgs e)
        {
            listWindow1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listWindow1_Load(object sender, EventArgs e)
        {

        }

        private void userWindow1_Load(object sender, EventArgs e)
        {

        }

        private void searchView1_Load(object sender, EventArgs e)
        {

        }

        private void picturebox_header_Click(object sender, EventArgs e)
        {

        }

        private void label_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
    }
}
