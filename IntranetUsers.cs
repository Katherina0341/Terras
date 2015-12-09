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
namespace Intranet
{
    public class IntranetUsers
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        public int userRole { get; set; }
        public int language { get; set; }
        public int active { get; set; }
        public int brutoloon { get; set; }
        public DateTime geboortedatum { get; set; }
        public string telefoon { get; set; }
    }

}
