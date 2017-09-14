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
using MySql;
using MySql.Data.MySqlClient;

namespace Watchier
{
    public partial class LoginForm : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        public static DialogResult result;

        public static string settingsPath = @"C:\Users\p.pradzinski\Documents\Visual Studio 2015\Projects\Watchier\Watchier\Settings\";
        public static string loadedUsername;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button_close_login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button_login_Click(object sender, EventArgs e)
        {

            string username = textbox_username.Text;
            string password = textbox_password.Text;

            
            DBConnect dbservice = new DBConnect();

            // Check if exists
            if (!dbservice.UserExists(username))
            {
                label_loginstatus.Text = "Fehler: User nicht registriert!";
                label_loginstatus.ForeColor = Color.Red;
                return;
            }
            
            // Für Auth
            var saltAndHash = dbservice.SelectSaltAndHash(username);

            // If user not authed!
            if (!Encryption.checkUserAuth(textbox_password.Text, saltAndHash.ElementAt(1), saltAndHash.ElementAt(0)))
            {
                label_loginstatus.Text = "Fehler: Passwort falsch!";
                label_loginstatus.ForeColor = Color.Red;
                return;
            }

            label_loginstatus.Text = "Erfolg, User authenticated!";
            label_loginstatus.ForeColor = Color.Black;

            var userData = dbservice.SelectRow(username);

            int userId = int.Parse(userData.ElementAt(0));
            string userName = userData.ElementAt(1);
            string userEmail = userData.ElementAt(2);

            byte[] userSalt = saltAndHash.ElementAt(0);
            byte[] userPasswordHash = saltAndHash.ElementAt(1);

            Form1.User = new User(userId, userName, userEmail, userSalt, userPasswordHash);
            Close();
        }

        


        // Kann deleted werden, checked encryption und DB
        private void button_encrypt_Click(object sender, EventArgs e)
        {
            string username = textbox_userCreate.Text;
            DBConnect dbservice = new DBConnect();

            // Für User creation
            byte[] salt = Encryption.generateSalt();
            byte[] hash = Encryption.generateHash(textbox_passwordCreate.Text, salt);
            //dbservice.Insert(username, "", salt, hash);
            ////////////////////////////////////////////////

            // Für Auth
            var list = dbservice.SelectSaltAndHash(username);

            if (Encryption.checkUserAuth(textbox_passwordCreate.Text, list.ElementAt(1), list.ElementAt(0)))
            {
                label_loginstatus.Text = "Erfolg, User authenticated!";

            }
            else
            {
                label_loginstatus.Text = "Fehler, Nicht authenticated!";
            }



            //hash.ToList().ForEach(element => Console.Write(element));

        }

        private bool checkUsername(string username)
        {
            string user = username;
            DateTime localDate = DateTime.Now;
            string userSettingsPath = (settingsPath + user + ".txt");
            if (!File.Exists(userSettingsPath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(userSettingsPath))
                {
                    sw.WriteLine("user:" + user);
                    sw.WriteLine("lastLogin:" + localDate);
                }
                loadedUsername = user;
                return false;
            }
            else
            {
                loadedUsername = user;
                return true;
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(userSettingsPath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////
        // MouseMove Event
        #region mouseMove

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LoginForm_Move(object sender, EventArgs e)
        {

        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
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

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
        #endregion
    }
}
