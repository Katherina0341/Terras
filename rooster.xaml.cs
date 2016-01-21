using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using staffmodel;
using staffDatabase;
using Intranet;
using Database;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for Rooster.xaml
    /// </summary>
    public partial class rooster : Window
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();

        public List<staff> MyList { get; set; }
        private newstaffDBcs _staffDB = new newstaffDBcs();

        public rooster()
        {
            InitializeComponent();
            testAdmin();
            currentWeek();
            GetFirstDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text));
            GetLastDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text));
            var begin = GetFirstDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text));
            var eind = GetLastDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text));                  
            label1.Content = "Maandag: " + GetFirstDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text)).ToShortDateString() + " En als laatste, Zondag: " + GetLastDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text)).ToShortDateString();
            MyList = _staffDB.fetchStaff();      
            EachDay(begin, eind);
            getMyDay(begin, eind);
            var test = TestDateStuff();
            var test1 = ConvertData(test);
            this.dataGrid.ItemsSource = test1;
            DataContext = this;
        }

        private void testAdmin()
        {
            if (Properties.Settings.Default.username == "admin")
            {
                personeelButton.IsEnabled = true;
                addDataButton.IsEnabled = true;
                editDataButton.IsEnabled = true;
                dataGrid.IsReadOnly = false;
            }

            else
            {
                personeelButton.IsEnabled = false;
                addDataButton.IsEnabled = false;
                editDataButton.IsEnabled = false;
                volgendeButton.IsEnabled = false;
                vorigButton.IsEnabled = false;
                dataGrid.IsReadOnly = true;
                // Remove Rows, CBA making foreach loop // Running outta time:) 
                dataGrid.Columns[0].Visibility = Visibility.Hidden;
                dataGrid.Columns[1].Visibility = Visibility.Hidden;
                dataGrid.Columns[2].Visibility = Visibility.Hidden;
                dataGrid.Columns[3].Visibility = Visibility.Hidden;
                dataGrid.Columns[4].Visibility = Visibility.Hidden;
                dataGrid.Columns[5].Visibility = Visibility.Hidden;
                dataGrid.Columns[6].Visibility = Visibility.Hidden;
                dataGrid.Columns[7].Visibility = Visibility.Hidden;
                dataGrid.Columns[8].Visibility = Visibility.Hidden;
                dataGrid.Columns[9].Visibility = Visibility.Hidden;
                dataGrid.Columns[10].Visibility = Visibility.Hidden;
            }
        }

        // Get current week function
        public void currentWeek()
        {
            object index = DateTime.Now;
            int res = 0;

            res = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
               Convert.ToDateTime(index), System.Globalization.CalendarWeekRule.FirstFullWeek, System.Globalization.DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);
               weekNummerTextBox.Text = res.ToString();

            int weekNumber = res;
        }
 
       
        // Vorige knop  -1 dus ||  Previous Week button 
        private void vorigButton_Click(object sender, RoutedEventArgs e)
        {
              var naarInt = Convert.ToInt32(weekNummerTextBox.Text);
              int toResult = naarInt - 1;
            // stopt dat gebruiker naar de - weken gaat :P 
              if(toResult < 1)
              {
                 toResult = 1;
                 MessageBox.Show("U bent al bij week 1!");
              }
              weekNummerTextBox.Text = toResult.ToString();
        }

        // Volgende knop ||| Next Week Button
        private void volgendeButton_Click(object sender, RoutedEventArgs e)
        {
            var naarInt = Convert.ToInt32(weekNummerTextBox.Text);
            int toResult = naarInt + 1;
            if(toResult > 53)
            {
                toResult = 53;
                MessageBox.Show("U bent al bij week 53");       
            }
            weekNummerTextBox.Text = toResult.ToString();            
        }

        // get  first day of weeknumber
        public static DateTime GetFirstDateOfWeekByWeekNumber(int weekNumber)
        {
        var year = DateTime.Today.Year;
        //var year = 2016;
        var date = new DateTime(year, 01, 01);
        var firstDayOfYear = date.DayOfWeek;
        var result = date.AddDays(weekNumber * 7);

        if (firstDayOfYear == DayOfWeek.Monday)
            return result.Date;
        if (firstDayOfYear == DayOfWeek.Tuesday)
            return result.AddDays(-1).Date;
        if (firstDayOfYear == DayOfWeek.Wednesday)
            return result.AddDays(-2).Date;
        if (firstDayOfYear == DayOfWeek.Thursday)
            return result.AddDays(-3).Date;
        if (firstDayOfYear == DayOfWeek.Friday)
            return result.AddDays(-4).Date;
        if (firstDayOfYear == DayOfWeek.Saturday)
            return result.AddDays(-5).Date;
        return result.AddDays(-6).Date;
       }
       // get last day of weeknumber 
      public static DateTime GetLastDateOfWeekByWeekNumber(int weekNumber)
        {
            DateTime ldowDate = GetFirstDateOfWeekByWeekNumber(weekNumber).AddDays(6);      
            return ldowDate;
        }
        // Get days between Start & End
        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;     
        }
       
        public void getMyDay(DateTime begin, DateTime eind)
        {
            List<DateTime> list = new List<DateTime>();
            foreach (DateTime days in EachDay(begin, eind))
            {
                list.Add(days);
            }
            list.ForEach(t =>  Console.WriteLine(t.ToShortDateString()));

        }

        


        // When change weeknumber:
        public void weekNummerTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           // currentWeek();
            GetFirstDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text));
            GetLastDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text));
            var begin123 = GetFirstDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text));
            var eind123 = GetLastDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text));
           // string query = "SELECT * FROM ingeroosterd WHERE date BETWEEN '" + begin123 + "'  AND '" + eind123 + "'";
            label1.Content = "Maandag: " + GetFirstDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text)).ToShortDateString() + " En als laatste, Zondag: " + GetLastDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text)).ToShortDateString();
            getMyDay(begin123, eind123);

            // When change you want to change the grid as well :) 
            var test = TestDateStuff();
            var test1 = ConvertData(test);
            this.dataGrid.ItemsSource = test1;
        }




        private void dashboardButton_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new MainWindow();
            dashboard.Owner = this;
            dashboard.Show();
            this.Hide();
           // this.Close();

        }

        private void roosterButton_Click(object sender, RoutedEventArgs e)
        {
            var form6 = new rooster();
            form6.Owner = this;
            form6.Show();
            this.Hide();
            // this.Close();

        }

        private void personeelButton_Click(object sender, RoutedEventArgs e)
        {
            var personeel = new personeel();
            personeel.Owner = this;
            personeel.Show();
             this.Hide();
            // this.Close();
        }

        private void roosterButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void personeelButton_Click_1(object sender, RoutedEventArgs e)
        {
            var personeel = new personeel();
            personeel.Owner = this;
            personeel.Show();
             this.Hide();
            // this.Close();
        }

        private void addDataButton_Click(object sender, RoutedEventArgs e)
        {
            var datawindow = new addDataWindow();
            datawindow.Owner = this;
            datawindow.Show();
            this.Hide();
        }

        private void editDataButton_Click(object sender, RoutedEventArgs e)
        {
            var editwindow = new editDataWindow();
            editwindow.Owner = this;
            editwindow.Show();
            this.Hide();
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void klokButton_Click(object sender, RoutedEventArgs e)
        {
            var klokwindow = new klokwindow();
            klokwindow.Owner = this;
            klokwindow.Show();
           // this.Hide();
        }

        private void uitklokButton_Click(object sender, RoutedEventArgs e)
        {
            var uitklokwindow = new uitklokwindow();
            uitklokwindow.Owner = this;
            uitklokwindow.Show();
            // this.Hide();
        }



        public List<activityUsers> TestDateStuff()
        {
            var result = new List<activityUsers>();
            var startdate = GetFirstDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text)).ToShortDateString();
            var enddate = GetLastDateOfWeekByWeekNumber(Convert.ToInt32(weekNummerTextBox.Text)).ToShortDateString();

            MySqlConnection myConnection = dbHelper.initiallizeDB();
            string query = "SELECT * FROM ingeroosterd WHERE date BETWEEN '" + startdate + "'  AND '" + enddate + "'";
            MySqlCommand sqlCommand = new MySqlCommand(query, myConnection);
            var reader  = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                var activity = new activityUsers();
                activity.ID = reader.GetInt32(0);
                activity.firstname = reader.GetString(1);
                activity.date = reader.GetString(2);
                activity.begintijd = reader.GetString(3);
                activity.eindtijd = reader.GetString(4);
                activity.omschrijving = reader.GetString(5);
                activity.totale_werkuren = reader.GetString(6);
                activity.pauze = reader.GetString(7);


                result.Add(activity);
            }
            reader.Close();
            myConnection.Close();

            return result;
        }

        private List<WeeklyActivity> ConvertData(List<activityUsers> activities) 
        {
            var result = new List<WeeklyActivity>();
            var tmp = activities.GroupBy(a => a.firstname);
            foreach (var item in tmp)
            {
                var r = new WeeklyActivity();
                r.User = item.Key;
                r.MondayActivity = GetActivity(item, DayOfWeek.Monday);
                r.TuesdayActivity = GetActivity(item, DayOfWeek.Tuesday );
                r.WednesdayActivity = GetActivity(item, DayOfWeek.Wednesday );
                r.ThursdayActivity = GetActivity(item, DayOfWeek.Thursday );
                r.FridayActivity = GetActivity(item, DayOfWeek.Friday );
                r.SaturdayActivity = GetActivity(item, DayOfWeek.Saturday );
                r.SundayActivity = GetActivity(item, DayOfWeek.Sunday);

                r.Breaks = item.Sum(x => double.Parse( x.pauze));
                r.TotalHours = item.Sum(x => double.Parse( x.totale_werkuren));
               
                result.Add(r);
            }


            return result;
        }

        private  string  GetActivity(IGrouping<string, activityUsers> item, DayOfWeek dayOfWeek)
        {
            var activity = item.FirstOrDefault(x => {
                var d = DateTime.Parse(x.date).DayOfWeek;
                return d== dayOfWeek;
            });

            if (activity != null)
            {
                return string.Format("{0} - {1}  {2}",activity.begintijd,activity.eindtijd, activity.omschrijving);
            }
            return string.Empty;
        }
    }
  }

