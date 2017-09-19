using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace Watchier
{
    public partial class listWindow : UserControl
    {
        List<Result> resultList = searchView.ResultList;
        // C:\Users\p.pradzinski\Documents\Visual Studio 2015\Projects\Watchier\Watchier\Settings
        public listWindow()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect dbservice = new DBConnect();
            var savedResults = new List<Result>();
            var columnLists = dbservice.SelectEntryRow(Form1.User.id);
            for (int i = 0; i < columnLists[0].Count; i++)
            {
                Result res = Result.getResultById(int.Parse(columnLists[1][i]));
                savedResults.Add(res);
            }

           
            datagrid.Columns[0].Width = 200;
            var d = datagrid.Columns[0] as DataGridViewImageColumn;
            d.ImageLayout = DataGridViewImageCellLayout.Stretch; // Funzt. Wallah geil

            /* Damit doch per Pixel Scroll?!
            PropertyInfo verticalOffset = datagrid.GetType().GetProperty("VerticalOffset", BindingFlags.NonPublic | BindingFlags.Instance);
            verticalOffset.SetValue(this.datagrid, 10, null);
            */

            int index = 0;
            foreach (var result in savedResults){
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(datagrid); // needed, Create Cells oder sind nicht da
                row.Height = 200;   // Seite Höhe der row
                row.Cells[0].Value = Image.FromFile(Form1.localImagePath + result.name + ".png");
                row.Cells[1].Value = result.name;
                row.Cells[2].Value = result.rating;
                row.Cells[3].Value = "4/6";

                datagrid.Rows.Insert(index, row);
                index++;
            }
           
            
            // datagrid.Columns[0].HeaderText = "Images";

            /*
            

            string query = $"SELECT * FROM sql11194737.entries WHERE userId={Form1.User.id}";

            var columnLists = dbservice.SelectEntryRow(Form1.User.id);

            // Doppelt gemoppelt mit resultById
         

            DataGridViewTextBoxColumn col0_textbox = new DataGridViewTextBoxColumn();
            col0_textbox.HeaderText = "Feld1";
            DataGridViewTextBoxColumn col1_textbox = new DataGridViewTextBoxColumn();
            col1_textbox.HeaderText = "Feld2";
            DataGridViewButtonColumn col2_button = new DataGridViewButtonColumn();
            col2_button.HeaderText = "Feld3";

            // Ich hasse dataGrid
            DataGridViewRow row0 = new DataGridViewRow();

            // new { Column1 = o., Column2 = o.SomeOtherValue }).ToList();
            using (conn)
            {
                using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet DS = new DataSet(); // to hold the table loaded by adapter
                    mySqlDataAdapter.Fill(DS); // fill DataSet now

                    datagrid.Columns.Add(col0_textbox);
                    datagrid.Columns.Add(col1_textbox);
                    datagrid.Columns.Add(col2_button);

                    datagrid.Rows.Add(row0);

                    /*datagrid.DataSource = DS.Tables[0];

                    DataGridViewColumn first = datagrid.Columns[0];
                    Console.WriteLine(first.ValueType); 
                    */


            //}

            //  }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnect dbservice = new DBConnect();
            var savedResults = new List<Result>();
            var columnLists = dbservice.SelectEntryRow(Form1.User.id);
            Console.WriteLine(columnLists[0].Count);
            for (int i = 0; i < columnLists[0].Count; i++)
            {
                Result res = Result.getResultById(int.Parse(columnLists[1][i]));
                savedResults.Add(res);
            }

            flowpanel1.Controls.Clear();

            foreach (var res in savedResults)
            {
                Panel newPan = new Panel();
                newPan.Width = 876;
                newPan.Height = 250;

                // Create Panel Dinge
                
                Image img = Image.FromFile(Form1.localImagePath + res.name + ".png");
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = img;
                pictureBox.Height = 250;
                pictureBox.Width = 170;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                newPan.Controls.Add(pictureBox);


                Label label_name = new Label();
                label_name.Text = res.name;
                Label label_rating = new Label();
                label_rating.Text = res.rating.ToString();
                newPan.Controls.Add(label_name);
                label_name.Location = new Point(230, 110);

                Console.WriteLine("adding new Panel!");
                newPan.Controls.Add(label_rating);





                flowpanel1.Controls.Add(newPan);
            }
            
        }
    }
}
