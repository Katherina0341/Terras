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
using MySql.Data.MySqlClient;
using System.Data;
using staffmodel;
using staffDatabase;
using Intranet;
using Database;
namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for editDataWindow.xaml
    /// </summary>
    public partial class editDataWindow : Window
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        public List<staff> MyList { get; set; }
        private comboDB _combo = new comboDB();

        public List<activityUsers> MynewList { get; set; }
        private activityDB _staffObj = new activityDB();

        public editDataWindow()
        {
            MyList = _combo.fetchStaff();
            // MynewList = _staffObj.fetchNotes("SELECT * FROM  intranet_users ");
            DataContext = this;
            InitializeComponent();
            welkomLabel.Content = "Welkom " + Properties.Settings.Default.username + " u bent succesvol ingelogd";

        }


        //Begin Menu 

        private void dashboardButton_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new MainWindow();
            dashboard.Owner = this;
            dashboard.Show();
            this.Hide();
        }

        private void roosterButton_Click_1(object sender, RoutedEventArgs e)
        {
            var form6 = new rooster();
            form6.Owner = this;
            form6.Show();
            this.Hide();
            // this.Close();
        }

        private void personeelButton_Click_1(object sender, RoutedEventArgs e)
        {
            var personeel = new personeel();
            personeel.Owner = this;
            personeel.Show();
            this.Hide();
            // this.Close();
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void datComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                dpDateCalendar.Visibility = Visibility.Visible; 
                var staffObj = ((staff)datComboBox.SelectedItem).Firstname; // Here I take the value's name into a variable will need this for my query!      
                string querywhere = "SELECT * FROM ingeroosterd WHERE firstname = '" + staffObj + "'";
                activityDB db = new activityDB();
                MynewList = db.fetchNotes(querywhere);
                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = MynewList;
                dataGrid.Items.Refresh();         
        }

        private void dpdateCalendar_OnSelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var myDay = dpDateCalendar.SelectedDate.Value.Date.ToString("yyyy-MM-dd");
            var staffObj = ((staff)datComboBox.SelectedItem).Firstname; // Here I take the value's name into a variable will need this for my query!      
            string querywhere = "SELECT * FROM ingeroosterd WHERE firstname = '" + staffObj + "' AND date = '" + myDay + "'";
            activityDB db = new activityDB();
            MynewList = db.fetchNotes(querywhere);
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = MynewList;
            dataGrid.Items.Refresh();
        }
        /*
                private void dateCalender_OnSelectedDatesChanged(object sender, SelectionChangedEventArgs e)
                {
                    //    var myDate = dpDateCalendar.SelectedDate.Value.Date.ToShortDateString();    
                    var mydate1 = dateCalender.SelectedDate.Value.Date.ToShortDateString();
                    //var mydates = dateCalender.SelectedDates.Count.ToString();
                    //var mydates = dateCalender.SelectedDates.ToList();
                    string querywhere = "SELECT * FROM ingeroosterd WHERE date = '" + mydate1 + "'";
                  //  Console.WriteLine(mydates);

                    activityDB db = new activityDB();
                    MynewList = db.fetchNotes(querywhere);
                    dataGrid.ItemsSource = null;
                    dataGrid.ItemsSource = MynewList;
                    dataGrid.Items.Refresh();
                }
        */

        private void dateCalender_OnSelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var mydates = dateCalender.SelectedDates.ToList();

            foreach (DateTime currDate in dateCalender.SelectedDates)
            {
               // System.Diagnostics.Debug.Print(currDate.ToString());
                var firstDate = dateCalender.SelectedDates[0].ToString("yyyy-MM-dd");
                var secondDate = dateCalender.SelectedDates[dateCalender.SelectedDates.Count - 1].ToString("yyyy-MM-dd");
                // System.Diagnostics.Debug.Print(eerste.ToString());
                string query = "SELECT * FROM ingeroosterd WHERE date BETWEEN '" + firstDate + "' AND '" + secondDate +"'";
                activityDB db = new activityDB();
                MynewList = db.fetchNotes(query);
                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = MynewList;
                dataGrid.Items.Refresh();


            }



        }
        





        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            

          
            MySqlConnection myConnection = dbHelper.initiallizeDB();
         //   var staffObj = ((staff)datComboBox.SelectedItem).Firstname; // Here I take the value's name into a variable will need this for my query!  


            foreach (var item in MynewList)
            {
                // Update each user individually
                var d = DateTime.Parse(item.date);
                var query = $"UPDATE ingeroosterd SET firstname = '{item.firstname}', date = '{d.ToString("yyyy-MM-dd")}', begintijd = '{item.begintijd}', eindtijd = '{item.eindtijd}', omschrijving = '{item.omschrijving}', totale_werkuren = '{item.totale_werkuren}', pauze = '{item.pauze}' WHERE ID = '{item.ID}' LIMIT 1";
                // execute it...
                MySqlCommand sqlCommand = new MySqlCommand(query, myConnection);
                int rows_inserted = sqlCommand.ExecuteNonQuery();
                if (rows_inserted > 0)
                {
                    Console.Write("Saved");
                }
                else
                {
                    Console.Write("Oops! Something wrong!");
                }
                //db.Execute(query);
            }

        }


        // Eind Menu 
    }
}
