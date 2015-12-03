using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents; // Tadaa
using MySql.Data.MySqlClient;
using Het_Terras; // is this even possible?!
using model;
using System.Data;
using System.Data.SqlClient;


// I think so, check 
namespace Database
{
    class NoteDB
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        // <access> <return type> <method name> (param1, param2, ..){ sey}
        public List<notes> fetchNotes() // why is this wrong
        {
            var listOfNotes = new List<notes>();
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
                            notes note = new notes();
                            // To avoid unexpected bugs access columns by name.
                            note.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            note.Text = reader.GetString(reader.GetOrdinal("text"));
                            // int middleNameIndex = reader.GetOrdinal("MiddleName");
                            //  note.MiddleName = reader.GetString(middleNameIndex);
                            note.Author = reader.GetString(reader.GetOrdinal("Author"));
                            note.Title = reader.GetString(reader.GetOrdinal("Title"));
                            note.Date = reader.GetDateTime(reader.GetOrdinal("Date"));
                            listOfNotes.Add(note);
                        }
                    }
                }
            }

            return listOfNotes;
           
        }


    }


}
