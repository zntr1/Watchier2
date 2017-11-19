using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Watchier
{
    public partial class searchView : UserControl
    {
        List<String> listSearchResults = new List<String>(); 
        string posterPath = (@"https://image.tmdb.org/t/p/w500/");
        static List<Result> resultList = new List<Result>();
        private string lastComboBoxSearch = "OwlCatDestroyer";
        Result result;

        Random rnd = new Random();

        internal static List<Result> ResultList
        {
            get
            {
                return resultList;
            }

            set
            {
                resultList = value;
            }
        }

        public searchView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combobox_search_KeyDown(object sender, KeyEventArgs e)
        {
            ComboBox combobox_search = sender as ComboBox;

            if (e.KeyCode == Keys.Enter)
            {
                // gegen Beeps und autoclose
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (combobox_search.Text == "") return;
                
                ResultList.Clear();
                combobox_search.DataSource = ResultList;                               

                // Logic Part!
                ResultList = Result.getAllResultsByName(combobox_search.Text);
                lastComboBoxSearch = combobox_search.Text;
                combobox_search.DataSource = ResultList.Select(element => element.name).ToList();
         
                combobox_search.DroppedDown = true;
                Cursor.Current = Cursors.Default; // restore mouse after dropDown
                textbox_description.BackColor = Color.FromArgb(37,37,38);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void combobox_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                e.SuppressKeyPress = false;
            }
        }

        private void combobox_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox_search = sender as ComboBox;
            if (combobox_search.SelectedIndex == -1)  return; 

            string selectedItem = (string)combobox_search.SelectedItem;
            int selectedIndex = combobox_search.SelectedIndex;
            

            result = ResultList[selectedIndex];

            picturebox_search.Visible = true;
            panel_info.Visible = true;

            label_titel.Text = result.name;
            label_votes.Text = result.votes.ToString();
            label_rating.Text = (result.rating*10).ToString().Substring(0,2)+"%";
            label_seasons.Text = result.numberOfSeasons.ToString();
            label_episodeCount.Text = result.numberOfEpisodes.ToString();
            label_runtime.Text = result.episodeTime.First().ToString()+"m";
            label_firstAired.Text = result.firstAirDate.ToString();
            label_inProduction.Text = result.inProduction.ToString();
            label_lastAired.Text = result.lastAirDate.ToString();
            label_homepage.Text = result.homepage;

            textbox_genres.Text = string.Join(",", result.genres.Select(genre => genre.Name).ToList());
            textbox_description.Text = result.overview;

            string localPath = Application.StartupPath; 
            string localImagePath = (localPath+"\\Images\\" + result.name + ".png");
           

            // If File does not Exist, download. Else, skip!
            if (!File.Exists(localImagePath))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(result.posterPath, localImagePath);
                }
            }
            
            picturebox_search.Image = Image.FromFile(localImagePath);
            picturebox_search.SizeMode = PictureBoxSizeMode.StretchImage; // Change to Stretch

            // If Result exists in our List already, set Button text to "Edit in my list", "Remove from my List"
            // "Check for new Episodes", "Rate"
            // else "Add to my List", "Rate"
            textbox_description.BackColor = Color.FromArgb(37, 37, 38);
        }

        private void combobox_search_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void combobox_search_DataSourceChanged(object sender, EventArgs e)
        {
           
        }

        private void combobox_search_TextUpdate(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_addToList_Click(object sender, EventArgs e)
        {
            string selectedItem = (string)combobox_search.SelectedItem;
            int selectedIndex = combobox_search.SelectedIndex;

            User user = Form1.User;
            DBConnect dbservice = new DBConnect();
            // string userImagePath = Form1.localImagePath; Not Needed I guess

            StringBuilder infoUserSB = new StringBuilder();
            StringBuilder infoGeneralSB = new StringBuilder();

            infoUserSB.Append("Empty"); // Weil noch nicht implementiert, gesehene Episoden etc.
            infoGeneralSB.Append(result.id); // Hier vielleicht noch speicherart: Serie, Film, season etc.

            string infoGen = infoGeneralSB.ToString();
            string infoUser = infoUserSB.ToString();

            // Hier weitermachen DB Connection umändern damit entries table accessible wird!

            dbservice.Insert(infoGen, infoUser, user.id, result.posterPath);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textbox_genres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_reset_Click(object sender, EventArgs e){

            ResultList.Clear();
            combobox_search.ResetText();
            combobox_search.DataSource = ResultList;
            panel_info.Visible = false;
            picturebox_search.Visible = false;
        }
    }
}
