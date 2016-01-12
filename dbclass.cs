using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Het_Terras
{
    class dbclass { 
        private MySqlConnection myConnection;

    public MySqlConnection initiallizeDB()
    {
        //   string connectionString = Properties.Settings.Default.testAppDBConnectionString;
        string mysqlconnect = Properties.Settings.Default.mysqlstr;
        //    myConnection = new SqlConnection(connectionString);
        myConnection = new MySqlConnection(mysqlconnect);
        try
        {
            myConnection.Open();
        }
        catch (Exception e)
        {
            //    Console.WriteLine(e.ToString());
            //myConnection = null;
        }

        // check connection?:3
        if (myConnection != null)
        {
            // Console.Write("Works!");

        }

        else
        {
            Console.Write("didn't work");
        }

        return this.myConnection;

    }
}
}
