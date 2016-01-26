using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents; // Tadaa
using MySql.Data.MySqlClient;
using Het_Terras; // is this even possible?!
using staffmodel;
using System.Data;
using System.Data.SqlClient;
using staffDatabase;


namespace staffDatabase
{
    class comboDB
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        // <access> <return type> <method name> (param1, param2, ..){ sey}
        public List<staff> fetchStaff() // why is this wrong
        {
            var listOfStaff = new List<staff>();
            // Populate this list from the db
            // wait what? Where do I even start? Alright
            MySqlConnection connection = dbHelper.initiallizeDB();
            string command = "select * from intranet_users";
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
                            staff note = new staff();
                            // To avoid unexpected bugs access columns by name.
                            // note.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            note.Firstname = reader.GetString(reader.GetOrdinal("firstname"));
                            // int middleNameIndex = reader.GetOrdinal("MiddleName");
                            //  note.MiddleName = reader.GetString(middleNameIndex);
                          //  note.Surname = reader.GetString(reader.GetOrdinal("surname"));
                          //  note.Telefoon = reader.GetString(reader.GetOrdinal("telefoon"));
                          //  note.Email = reader.GetString(reader.GetOrdinal("email"));
                          //  note.Username = reader.GetString(reader.GetOrdinal("username"));
                          //  note.Brutoloon = reader.GetString(reader.GetOrdinal("brutoloon"));
                            listOfStaff.Add(note);
                        }
                    }
                }
            }

            return listOfStaff;

        }


    }


}
