using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Watchier
{
    public partial class userWindow : UserControl
    {

        public userWindow()
        {
            InitializeComponent();
        }

        private void button_check_Click(object sender, EventArgs e)
        {
        

        }

        /*
        private bool checkUsername(string username)
        {
            string user = username;
            DateTime localDate = DateTime.Now;
            string userSettingsPath = (settingsPath + user+".txt");
            if (!File.Exists(userSettingsPath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(userSettingsPath))
                {
                    sw.WriteLine("user:"+user);
                    sw.WriteLine("lastLogin:"+ localDate);
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
        */
    }
}
