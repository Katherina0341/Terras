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


namespace Database
{
    class IntraDB
    {
               
         Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
         public List<IntranetUsers> fetchNotes(querywhere)
        {
            var listOfNotes = new List<IntranetUsers>();
            // Populate this list from the db
            MySqlConnection connection = dbHelper.initiallizeDB();
            string querywhere = "SELECT * FROM intranet_users WHERE firstname = '" +  staffObj() + "'";
            
           
            using (MySqlCommand cmd = new MySqlCommand(querywhere, connection))
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
                            IntranetUsers note = new IntranetUsers();
                            note.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                            note.username = reader.GetString(reader.GetOrdinal("username"));
                            note.password = reader.GetString(reader.GetOrdinal("password"));
                            note.email = reader.GetString(reader.GetOrdinal("email"));
                            note.firstname = reader.GetString(reader.GetOrdinal("firstname"));
                            note.surname = reader.GetString(reader.GetOrdinal("surname"));
                            note.userRole = reader.GetInt32(reader.GetOrdinal("user_role"));
                            note.language = reader.GetInt32(reader.GetOrdinal("language"));
                            note.active = reader.GetInt32(reader.GetOrdinal("active"));
                            note.brutoloon = reader.GetInt32(reader.GetOrdinal("brutoloon"));
                          //note.geboortedatum = reader.(reader.GetOrdinal("geboortedatum"));
                            note.telefoon = reader.GetString(reader.GetOrdinal("telefoon"));



                            listOfNotes.Add(note);
                        }
                    }
                }
            }

            return listOfNotes;

        }


    }

}

