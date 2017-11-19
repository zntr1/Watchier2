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
using System.Net;

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

        private void button1_Click(object sender, EventArgs e)
        {
            
            String direction = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                direction = stream.ReadToEnd();
            }

            //Search for the ip in the html
            int first = direction.IndexOf("Address: ") + 9;
            int last = direction.LastIndexOf("</body>");
            direction = direction.Substring(first, last - first);

            textbox_username.Text = direction.ToString();
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
