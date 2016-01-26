using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Het_Terras
{
    public class activityUsers
    {
        public int ID { get; set; }
        public string firstname { get; set; }
        public string date { get; set; }
        public string begintijd { get; set; }
        public string eindtijd { get; set; }
        public string omschrijving { get; set; }
        public string totale_werkuren { get; set; }
        public string pauze { get; set; }
    }

    //je vais écrire ici, après à toi de géner :p
    public class WeeklyActivity
    {       
        public string User { get; set; }
        public string MondayActivity { get; set; }
        public string TuesdayActivity { get; set; }
        public string WednesdayActivity { get; set; }
        public string ThursdayActivity { get; set; }
        public string FridayActivity { get; set; }
        public string SaturdayActivity { get; set; }
        public string SundayActivity { get; set; }
        public double TotalHours { get; set; }
        public double Breaks { get; set; }
        public double PaidHours { get { return this.TotalHours - this.Breaks; } }
    }
}
