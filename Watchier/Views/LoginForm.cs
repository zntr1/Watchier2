using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;

namespace Watchier
{
    public partial class LoginForm : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        public static DialogResult result;



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

            // Check if exists, DAS HIER NOCH ÄNDERN ZU ERROR PROVIDER
            if (!dbservice.UserExists(username))
            {
                label_loginstatus.Text = "Fehler: User nicht registriert!";
                label_loginstatus.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(username))
            {
                label_loginstatus.Text = "Fehler: Bitte Username eingeben";
                label_loginstatus.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                label_loginstatus.Text = "Fehler: Bitte Password eingeben";
                label_loginstatus.ForeColor = Color.Red;
                return;
            }

            // Für Auth
            var saltAndHash = dbservice.SelectSaltAndHash(username);

            // If user not authed!
            if (!Encryption.checkUserAuth(password, saltAndHash.ElementAt(1), saltAndHash.ElementAt(0)))
            {
                label_loginstatus.Text = "Fehler: Passwort falsch!";
                label_loginstatus.ForeColor = Color.Red;
                return;
            }

            label_loginstatus.Text = "Erfolg, User authenticated!";
            label_loginstatus.ForeColor = Color.Black;

            var userData = dbservice.SelectUserRow(username);

            int userId = int.Parse(userData.ElementAt(0));
            string userName = userData.ElementAt(1);
            string userEmail = userData.ElementAt(2);

            byte[] userSalt = saltAndHash.ElementAt(0);
            byte[] userPasswordHash = saltAndHash.ElementAt(1);

            Form1.User = new User(userId, userName, userEmail, userSalt, userPasswordHash);
            Close();
        }


        /*
        // Kann deleted werden
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
        }*/

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

        private void button_register_Click(object sender, EventArgs e)
        {
            button_encrypt.Visible = false;
            textbox_userCreate.Visible = true;
            textbox_passwordCreate.Visible = true;
            textbox_passwordCreate2.Visible = true;
            textbox_emailCreate.Visible = true;
            label_userCreate.Visible = true;
            label_password.Visible = true;
            label_password2.Visible = true;
            label_email.Visible = true;
            button_register.Visible = true;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login.PerformClick();
            }
        }

        private void button_register_Click_1(object sender, EventArgs e)
        {
            string newUsername = textbox_userCreate.Text;
            string newPassword = textbox_passwordCreate.Text;
            string newEmail = textbox_emailCreate.Text;

            byte[] newSalt = Encryption.generateSalt();
            byte[] newHash = Encryption.generateHash(newPassword, newSalt);

            DBConnect dbservice = new DBConnect();
            dbservice.Insert(newUsername, newEmail, newSalt, newHash);
        }

        public static bool IsValidatedPassword(string password)
        {
            const int MIN_LENGTH = 8;
            const int MAX_LENGTH = 15;

            if (password == null)
                throw new ArgumentNullException();

            bool meetsLengthRequirements = password.Length >= MIN_LENGTH && password.Length <= MAX_LENGTH;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                        hasUpperCaseLetter = true;
                    else if (char.IsLower(c))
                        hasLowerCaseLetter = true;
                    else if (char.IsDigit(c))
                        hasDecimalDigit = true;
                }
            }

            bool isValid = meetsLengthRequirements
                           && hasUpperCaseLetter
                           && hasLowerCaseLetter
                           && hasDecimalDigit;
            return isValid;

        }

        public static bool IsUserNameAllowed(string userName)
        {
            // If Empty bitte andere Fehlermeldung!
            Regex sUserNameAllowedRegEx = new Regex(@"[(a-zA-Z0-9)]{8,15}", RegexOptions.Compiled);
            if (string.IsNullOrEmpty(userName) || !sUserNameAllowedRegEx.IsMatch(userName))
            {
                return false;
            }

            return true;
        }

        public bool IsEmailAllowed(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void textbox_passwordCreate_Leave(object sender, EventArgs e)
        {
            string input = textbox_passwordCreate.Text;

            if (!IsValidatedPassword(input))
            {
                label_password.ForeColor = Color.Red;
                errorProvider1.SetError(textbox_passwordCreate, "Password needs to consist of 8-15 Chars, atleast 1 Upper, 1 Lower, one Numerical and 1 Sign!");
                return;
            }

            if (IsValidatedPassword(input))
            {
                label_password.ForeColor = Color.FromArgb(26, 129, 229);
                errorProvider1.SetError(textbox_passwordCreate, "");
                return;
            }
        }

        private void textbox_passwordCreate2_Leave(object sender, EventArgs e)
        {
            string input = textbox_passwordCreate2.Text;

            if (!IsValidatedPassword(input))
            {
                label_password2.ForeColor = Color.Red;
                errorProvider1.SetError(textbox_passwordCreate2, "Password not matching!");
                return;
            }

            if (IsValidatedPassword(input))
            {
                label_password2.ForeColor = Color.FromArgb(26, 129, 229);
                errorProvider1.SetError(textbox_passwordCreate2, "");
                return;
            }
        }

        private void textbox_userCreate_Leave(object sender, EventArgs e)
        {
            DBConnect dbservice = new DBConnect();

            string input = textbox_userCreate.Text;

            if (dbservice.UserExists(input))
            {
                label_userCreate.ForeColor = Color.Red;
                errorProvider1.SetError(label_userCreate, "User already exists! Choose another one");
                return;
            }

            if (!IsUserNameAllowed(input))
            {
                label_userCreate.ForeColor = Color.Red;
                errorProvider1.SetError(label_userCreate, "8-15 Signs, Only A-Z, a-z and 0-9 Chars!");
                return;
            }



            if (IsValidatedPassword(input))
            {
                label_userCreate.ForeColor = Color.FromArgb(26, 129, 229);
                errorProvider1.SetError(label_userCreate, "");
            }

            if (!dbservice.UserExists(input))
            {
                label_userCreate.ForeColor = Color.FromArgb(26, 129, 229);
                errorProvider1.SetError(label_userCreate, "");
            }

            return;
        }

        private void textbox_emailCreate_Leave(object sender, EventArgs e)
        {
            DBConnect dbservice = new DBConnect();

            string input = textbox_emailCreate.Text;

            if (dbservice.EmailExists(input))
            {
                textbox_emailCreate.ForeColor = Color.Red;
                errorProvider1.SetError(textbox_emailCreate, "Email already used! Please use \"Forgot Password\"");
                return;
            }

            if (!IsEmailAllowed(input))
            {
                textbox_emailCreate.ForeColor = Color.Red;
                errorProvider1.SetError(textbox_emailCreate, "Not a Valid Email-Adress!");
                return;
            }



            if (IsEmailAllowed(input))
            {
                textbox_emailCreate.ForeColor = Color.FromArgb(26, 129, 229);
                errorProvider1.SetError(textbox_emailCreate, "");
            }

            if (!dbservice.EmailExists(input))
            {
                textbox_emailCreate.ForeColor = Color.FromArgb(26, 129, 229);
                errorProvider1.SetError(textbox_emailCreate, "");
            }

            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        //Check Info for Results
        private void button1_Click_1(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();

            Result res = Result.getResultByName(textbox_test.Text);
            if (res == null) return;

            var dump = ObjectDumper.Dump(res);
            Console.WriteLine(dump);

        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
