using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Watchier
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySqlConnection Connection
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            string connectionString;
            server = "sql11.freemysqlhosting.net";
            database = "sql11194737";
            uid = "sql11194737";
            password = "cbzZKIaeaB";

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            Connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }


        //Close connection
        private bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void tryConnect()
        {
            if (this.OpenConnection() == true)
            {
                Console.WriteLine("Successfully connected");
                this.CloseConnection();
            }
        }

        //Insert into users statement
        public void Insert(string username, string email, byte[] salt, byte[] hash)
        {
            //string saltStr = string.Join(" ", salt.Select(x => x.ToString()).ToList());
            string query = "INSERT INTO users (username, email, salt, hash) VALUES(@username, @email, @bytesalt, @bytehash)";

            //open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, Connection);

                    cmd.Parameters.Add(new MySqlParameter("@username", username));
                    cmd.Parameters.Add(new MySqlParameter("@email", email));
                    cmd.Parameters.Add(new MySqlParameter("@bytesalt", salt)); // Gibberish in DB
                    cmd.Parameters.Add(new MySqlParameter("@bytehash", hash));  // Gibberish in DB

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();

                }
                catch (MySqlException ex)
                {
                    int errorcode = ex.Number;
                    Console.WriteLine("Error:" + ex.Message + errorcode.ToString());
                    throw;
                }

            }
        }

        //Insert into entries statement
        public void Insert(string infoGeneral, string infoUser, int userId)
        {
            string localDate = DateTime.Now.ToString();
            string query = "INSERT INTO entries (infoGeneral, infoUser, dateAdded, userId) VALUES(@infoGeneral, @infoUser, @localDate, @userId)";

            //open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, Connection);

                    cmd.Parameters.Add(new MySqlParameter("@infoGeneral", infoGeneral));
                    cmd.Parameters.Add(new MySqlParameter("@infoUser", infoUser));
                    cmd.Parameters.Add(new MySqlParameter("@localDate", localDate)); 
                    cmd.Parameters.Add(new MySqlParameter("@userId", userId));  

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();

                }
                catch (MySqlException ex)
                {
                    int errorcode = ex.Number;
                    Console.WriteLine("Error:" + ex.Message + errorcode.ToString());
                    throw;
                }

            }
        }

        //Update statement
        public void Update()
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE username='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = Connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete()
        {
            string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select users statement
        public List<string>[] SelectUsers()
        {
            string query = "SELECT * FROM sql11194737.users";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>(); // id
            list[1] = new List<string>(); // name 
            list[2] = new List<string>(); // password

            //Open connection
            if (this.OpenConnection() == true)
            {

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["username"] + "");
                    list[2].Add(dataReader["password"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Select statement Select Everything
        public List<string> SelectUserRow(string username)
        {
            string query = "SELECT * FROM sql11194737.users WHERE username=@name";

            //Create a list to store the result
            List<string> list = new List<string>();

            try
            {
                //Open connection
                if (this.OpenConnection() == true)
                {

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, Connection);
                    cmd.Parameters.Add(new MySqlParameter("@name", username));

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    //Read the data and store them in the list, ignore salt and Hash
                    list.Add(dataReader["id"] + "");
                    list.Add(dataReader["username"] + "");
                    list.Add(dataReader["email"] + "");

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return list;
                }
                else
                {
                    return list;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in SelectUserRow:" + ex);
                throw;
            }

        }

        //Select users statement
        public List<string>[] SelectEntries()
        {
            string query = "SELECT * FROM sql11194737.entries";

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>(); // entryId
            list[1] = new List<string>(); // infoGeneral 
            list[2] = new List<string>(); // infoUser
            list[3] = new List<string>(); // dateAdded
            list[4] = new List<string>(); // userId

            //Open connection
            if (this.OpenConnection() == true)
            {

                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["entryId"] + "");
                    list[1].Add(dataReader["infoGeneral"] + "");
                    list[2].Add(dataReader["infoUser"] + "");
                    list[3].Add(dataReader["dateAdded"] + "");
                    list[4].Add(dataReader["userId"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Select statement Select Everything
        public List<string>[] SelectEntryRow(int userId)
        {
            string query = "SELECT * FROM sql11194737.entries WHERE userId=@userId";

            //Create a list to store the result
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>(); // entryId Column
            list[1] = new List<string>(); // infoGene Column
            list[2] = new List<string>(); // infoUser Column
            list[3] = new List<string>(); // dateAdded Column
            list[4] = new List<string>(); // userId Column

            try
            {
                //Open connection
                if (this.OpenConnection() == true)
                {

                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, Connection);
                    cmd.Parameters.Add(new MySqlParameter("@userId", userId));

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();

                    //Read the data and store them in the list, ignore salt and Hash
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["entryId"] + "");
                        list[1].Add(dataReader["infoGeneral"] + "");
                        list[2].Add(dataReader["infoUser"] + "");
                        list[3].Add(dataReader["dateAdded"] + "");
                        list[4].Add(dataReader["userId"] + "");
                    }
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return list;
                }
                else
                {
                    return list;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in SelectEntryRow:" + ex);
                throw;
            }

        }


        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, Connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Select Hash and Salt statement
        public List<byte[]> SelectSaltAndHash(string username)
        {
            string query = "SELECT salt, hash FROM sql11194737.users WHERE username=@name";

            //Create a list to store the result
            List<byte[]> list = new List<byte[]>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, Connection);
                    cmd.Parameters.Add(new MySqlParameter("@name", username));

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    dataReader.Read();
                    byte[] salt = (byte[])dataReader["salt"];
                    byte[] hash = (byte[])dataReader["hash"];
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    list.Add(salt);
                    list.Add(hash);
                    //return list to be displayed
                    return list;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in SelectSaltAndHash:" + ex);
                    throw;
                }
            }
            else
            {
                return list;
            }
        }

        //Select Hash and Salt statement
        public bool UserExists(string username)
        {
            string query = "SELECT username FROM sql11194737.users WHERE BINARY username=@name"; // Binary für exaktes Match auf Binärer ebene.
            bool userExists = false;

            //Open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, Connection);
                    cmd.Parameters.Add(new MySqlParameter("@name", username));

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        userExists = true;
                    }
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                    return userExists;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in UserExists:" + ex);
                    throw;
                }
            }
            return userExists;

        }

        public bool EmailExists(string email)
        {
            string query = "SELECT username FROM sql11194737.users WHERE BINARY email=@email"; // Binary für exaktes Match auf Binärer ebene.
            bool userExists = false;

            //Open connection
            if (this.OpenConnection() == true)
            {
                try
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, Connection);
                    cmd.Parameters.Add(new MySqlParameter("@email", email));

                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        userExists = true;
                    }
                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();
                    Console.WriteLine(userExists);
                    return userExists;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in EmailExists:" + ex);
                    throw;
                }
            }
            return userExists;

        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }

    }
}