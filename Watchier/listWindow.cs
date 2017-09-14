using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serienlook;
using MySql.Data.MySqlClient;

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
            /*
            DataGridViewTextBoxColumn nameCol;
            datagrid.Column
            nameCol.DataPropertyName = "name";

            datagrid.AutoGenerateColumns = false;
            datagrid.DataSource = null;

            var list = new BindingList<Result>();



            foreach (Result go in resultList)
            {
                Result dggo = new Result();
                dggo.resultName = go.resultName;
                list.Add(dggo);
            }
            datagrid.DataSource = list;
            datagrid.Invalidate();
            */

            /*DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            Image image = Image.FromFile(@"C:\Users\p.pradzinski\Documents\Visual Studio 2015\Projects\Watchier\Watchier\Images\Rick and Morty.png");
            imgCol.Image = image;
            datagrid.Columns.Add(imgCol);
            imgCol.HeaderText = "Image";
            imgCol.Name = "img";

            datagrid.ColumnCount = 3;
            datagrid.Columns[0].Name = "Preview";
            datagrid.Columns[1].Name = "Title";
            datagrid.Columns[2].Name = "Views";


            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataGridView1.DataSource = ds.Tables[0];




            string[] row = new string[] { "1", "Product 1", "1000" };
            datagrid.Rows.Add(row);
            row = new string[] { "2", "Product 2", "2000" };
            datagrid.Rows.Add(row);
            row = new string[] { "3", "Product 3", "3000" };
            datagrid.Rows.Add(row);
            row = new string[] { "4", "Product 4", "4000" };
            datagrid.Rows.Add(row);*/

            DBConnect dbservice = new DBConnect();
            MySqlConnection conn = dbservice.Connection;

            string query = "SELECT * FROM watchierdb.users";
        
            /*
            using (conn)
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                   

                    datagrid.DataSource = savedList.Select(o => new
                    { Column1 = o.SomeValue, Column2 = o.SomeOtherValue }).ToList();
                }
            }
            */
        }
    }
}
