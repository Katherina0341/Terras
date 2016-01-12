using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using MySql.Data.MySqlClient;
using Het_Terras; // is this even possible?!
using staffmodel;
using System.Data;
using System.Data.SqlClient;
using authorDatabase;
using authormodel;
using database;


namespace authorDatabase
{
    class combomededeling
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        // <access> <return type> <method name> (param1, param2, ..){ sey}
        public List<notemededeling> fetchAuthor() // why is this wrong
        {
            var listOfAuthor = new List<notemededeling>();
            // Populate this list from the db
            // wait what? Where do I even start? Alright
            MySqlConnection connection = dbHelper.initiallizeDB();
            string command = "select * from terras_mededelingen";
            using (MySqlCommand cmd = new MySqlCommand(command, connection))
            {
                // connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check is the reader has any rows at all before starting to read.
                    if (reader.HasRows)
                    {
                        // Read advances to the next row.
                        while (reader.Read())
                        {
                            notemededeling note = new notemededeling();
                            // To avoid unexpected bugs access columns by name.
                             note.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            note.title = reader.GetString(reader.GetOrdinal("title"));
                            note.author = reader.GetString(reader.GetOrdinal("author"));
                            note.text = reader.GetString(reader.GetOrdinal("text"));
                            // int middleNameIndex = reader.GetOrdinal("MiddleName");
                            //  note.MiddleName = reader.GetString(middleNameIndex);
                            //  note.Surname = reader.GetString(reader.GetOrdinal("surname"));
                            //  note.Telefoon = reader.GetString(reader.GetOrdinal("telefoon"));
                            //  note.Email = reader.GetString(reader.GetOrdinal("email"));
                            //  note.Username = reader.GetString(reader.GetOrdinal("username"));
                            //  note.Brutoloon = reader.GetString(reader.GetOrdinal("brutoloon"));
                            listOfAuthor.Add(note);
                        }
                    }
                }
            }

            return listOfAuthor;

        }


    }


}