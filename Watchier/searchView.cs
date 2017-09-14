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
using Serienlook;
using System.IO;

namespace Watchier
{
    public partial class searchView : UserControl
    {
        List<String> listSearchResults = new List<String>();
        string sApikey = "8d6f5e3ef9008fb0f47871820feafcec";
        string sTvRequest = string.Format(@"https://api.themoviedb.org/3/search/tv?api_key=8d6f5e3ef9008fb0f47871820feafcec&query=");
        string posterPath = (@"https://image.tmdb.org/t/p/w500/");
        static List<Result> resultList = new List<Result>();
        private int lastComboboxIndex = -1;
        private System.IO.StreamReader reader;
        private string lastComboBoxSearch = "OwlCatDestroyer";

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

                if (combobox_search.Text.ToLower().Contains(lastComboBoxSearch.ToLower()) || 
                    combobox_search.Text == "") return;
                

                ResultList.Clear();                                                     // Clear for each search
                combobox_search.DataSource = ResultList;                               // Clear ComboBox
                var html = String.Format(sTvRequest + combobox_search.Text);
                int overviewIndex = 0;
                int lastIndex = 0;

                WebRequest req = HttpWebRequest.Create(html);
                req.Method = "GET";

                string source;

                using (reader = new System.IO.StreamReader(req.GetResponse().GetResponseStream()))
                {
                    source = reader.ReadToEnd();
                }

                // Remove { and } at start and end
                source.Remove(0);
                source.Remove(source.Length - 1);

                List<String> resultsArray = source.Split('{').ToList();


                resultsArray.RemoveRange(0, 2);      // Remove first two Elements because one is empty and one is General

                foreach (var resultString in resultsArray)
                {
                    List<String> resultInformation = resultString.Split(',').ToList();
                    resultInformation.RemoveRange(8, 2);

                    // Check if last Element is empty or null, then remove
                    if (resultInformation.ElementAt(resultInformation.Count - 1) == "" ||
                        resultInformation.ElementAt(resultInformation.Count - 1) == " " ||
                        resultInformation.ElementAt(resultInformation.Count - 1) == null)
                    {
                        resultInformation.RemoveAt(resultInformation.Count - 1);
                    }

                    // Remove "Origin Country Entry"
                    resultInformation.RemoveAt(resultInformation.Count - 1);



                    // Here starts Info editing:
                    foreach (var info in resultInformation)
                    {
                        //Console.WriteLine("Index:{0}: {1}", resultInformation.IndexOf(info), info);
                        if (info.Contains("overview"))
                        {
                            overviewIndex = resultInformation.IndexOf(info);
                            lastIndex = resultInformation.Count - 1;
                            break;
                        }
                    }

                    StringBuilder description = new StringBuilder();

                    // Create Description out of Elements
                    for (int i = overviewIndex; i <= lastIndex; i++)
                    {
                        description.Append(resultInformation[i]);
                        lastIndex = lastIndex - 1;
                    }

                    // restore LastIndex to current State
                    lastIndex = resultInformation.Count - 1;

                    // Remove the last Index N Times so every Description gets removed
                    int timesToRemove = resultInformation.Count - overviewIndex;
                    for (int i = 1; i <= timesToRemove; i++)
                    {
                        resultInformation.RemoveAt(resultInformation.Count - 1);
                    }

                    // Then Add description back to List as a whole
                    resultInformation.Add(description.ToString());



                    Result result = new Result();

                    var idFirst = resultInformation.FirstOrDefault(element => element.Contains("\"id\""));
                    if (idFirst != null) result.resultId = int.Parse(idFirst.Split(':')[1].Replace("\"", ""));

                    var nameFirst = resultInformation.FirstOrDefault(element => element.Contains("\"name\""));
                    if (nameFirst != null) result.resultName = nameFirst.Split(':')[1].Replace("\"", "");

                    var countFirst = resultInformation.FirstOrDefault(element => element.Contains("\"vote_count\""));
                    if (countFirst != null) result.resultVotes = int.Parse(countFirst.Split(':')[1].Replace("\"", ""));

                    var averageFirst = resultInformation.FirstOrDefault(element => element.Contains("\"vote_average\""));
                    if (averageFirst != null) result.resultRating = float.Parse(averageFirst.Split(':')[1].Replace("\"", ""));

                    var posterPathFirst = resultInformation.FirstOrDefault(element => element.Contains("\"poster_path\""));
                    if (posterPathFirst != null) result.resultPosterPath = posterPathFirst.Split(':')[1].Replace("\"", "");

                    var overviewFirst = resultInformation.FirstOrDefault(element => element.Contains("\"overview\""));
                    if (overviewFirst != null) result.resultDescription = overviewFirst.Split(':')[1].Replace("\"", "");

                    ResultList.Add(result);
                }

                lastComboBoxSearch = combobox_search.Text;
                combobox_search.DataSource = ResultList.Select(element => element.resultName).ToList();
         
                combobox_search.DroppedDown = true;
                Cursor.Current = Cursors.Default; // restore mouse after dropDown
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
            

            Result result = ResultList[selectedIndex];
            int id = result.resultId;
            string name = result.resultName;
            int votes = result.resultVotes;
            string rating = result.resultRating.ToString().Insert(1, "."); // add a dot because parse removes it!
            string description = result.resultDescription;
            string imagePath = result.resultPosterPath;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label_rateNow.Visible = true;

            

            textbox_id.Visible = true;
            textbox_desc.Visible = true;
            textbox_rating.Visible = true;
            textbox_titel.Visible = true;
            textbox_votes.Visible = true;

            button_addToList.Visible = true;

            picturebox_search.Visible = true;

            textbox_titel.Text = name;
            textbox_votes.Text = votes.ToString();
            textbox_rating.Text = rating;
            textbox_id.Text = id.ToString();

            Console.WriteLine("Das Rating ist: " + rating);

            textbox_desc.Text = description;

            // PreviewFoto C:\Users\secto\Source\Repos\MediaWatch2\MediaWatch-master\Serienlook
            string localImagePath = @"C:\Users\p.pradzinski\Documents\Visual Studio 2015\Projects\Watchier\Watchier\Images\" + name+ ".png";
            string posterPathUrl = @"https://image.tmdb.org/t/p/w500/" + imagePath;

            // If File does not Exist, download. Else, skip!
            if (!File.Exists(localImagePath))
            {
                Console.WriteLine("Searching first time for it, downloading Poster now!");
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(posterPathUrl, localImagePath);
                }
            }
            
            picturebox_search.Image = Image.FromFile(localImagePath);
            picturebox_search.SizeMode = PictureBoxSizeMode.StretchImage; // Change to Stretch

            // If Result exists in our List already, set Button text to "Edit in my list", "Remove from my List"
            // "Check for new Episodes", "Rate"
            // else "Add to my List", "Rate"
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

            Result result = ResultList[selectedIndex];
            int id = result.resultId;
            string name = result.resultName;
            int votes = result.resultVotes;
            string rating = result.resultRating.ToString().Insert(1, "."); // add a dot because parse removes it!
            string description = result.resultDescription;
            string imagePath = result.resultPosterPath;

            string user = userWindow.loadedUsername == null ? "not logged in": userWindow.loadedUsername;

            string userSettingsPath = (userWindow.settingsPath + user + ".txt");
            if (!File.Exists(userSettingsPath))
            {


            }
            else
            {

            }
           
        }
    }
}
