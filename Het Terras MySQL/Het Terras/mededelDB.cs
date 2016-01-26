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
using Intranet;

namespace database
{
    class mededelDB
    {

        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        public List<notemededeling> fetchingstuff(string queryString)
        {
            var listOfNotes = new List<notemededeling>();
            // Populate this list from the db
            MySqlConnection connection = dbHelper.initiallizeDB();
            ///   string querywhere = "SELECT * FROM intranet_users WHERE firstname = '" + edituser.staffObj + "'";
            // string command = "select * from intranet_users WHERE firstname = ";
            using (MySqlCommand cmd = new MySqlCommand(queryString, connection))
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
                            note.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            note.title = reader.GetString(reader.GetOrdinal("title"));
                            note.author = reader.GetString(reader.GetOrdinal("author"));
                            note.text = reader.GetString(reader.GetOrdinal("text"));
                          

                            listOfNotes.Add(note);
                        }
                    }
                }
            }

            return listOfNotes;

        }


    }

}