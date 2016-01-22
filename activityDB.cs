
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
using Intranet;
namespace Het_Terras
{
    class activityDB
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        public List<activityUsers> fetchNotes(string queryString)
        {
            var listOfNotes = new List<activityUsers>();
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
                            activityUsers note = new activityUsers();
                            note.ID = reader.GetInt32(reader.GetOrdinal("ID"));                       
                            note.firstname = reader.GetString(reader.GetOrdinal("firstname"));
                            note.date = reader.GetString(reader.GetOrdinal("date")); //uuhhhhhh 
                            // Voila! nn? 
                            note.begintijd = reader.GetString(reader.GetOrdinal("begintijd"));
                            note.eindtijd = reader.GetString(reader.GetOrdinal("eindtijd"));
                            //note.active = reader.GetInt32(reader.GetOrdinal("active"));
                            //note.geboortedatum = reader.GetDateTime(reader.GetOrdinal("geboortedatum"));
                            note.omschrijving = reader.GetString(reader.GetOrdinal("omschrijving"));
                            note.totale_werkuren = reader.GetString(reader.GetOrdinal("totale_werkuren"));
                            note.pauze = reader.GetString(reader.GetOrdinal("pauze"));
                            listOfNotes.Add(note);
                        }
                    }
                }
            }

            return listOfNotes;

        }
    }
}
