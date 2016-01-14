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
            var selected = dpDateCalendar.SelectedDate;
           // var test = dpDateCalendar.SelectedDate.Value.Date.ToShortDateString();
           // var test1 = dpDateCalendar.SelectedDate.Value.Date.ToString();
            var staffObj = ((staff)datComboBox.SelectedItem).Firstname; // Here I take the value's name into a variable will need this for my query!  
          //  if (test1 == "" && staffObj != "")
          // {
                string querywhere = "SELECT * FROM ingeroosterd WHERE firstname = '" + staffObj + "'";
                activityDB db = new activityDB();
                MynewList = db.fetchNotes(querywhere);
                dataGrid.ItemsSource = null;
                dataGrid.ItemsSource = MynewList;
                dataGrid.Items.Refresh();
           // }

            

    

        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection myConnection = dbHelper.initiallizeDB();
            var staffObj = ((staff)datComboBox.SelectedItem).Firstname; // Here I take the value's name into a variable will need this for my query!  


            foreach (var item in MynewList)
            {
                // Update each user individually

                var query = $"UPDATE ingeroosterd SET firstname = '{item.firstname}', date = '{item.date}', begintijd = '{item.begintijd}', eindtijd = '{item.eindtijd}', omschrijving = '{item.omschrijving}', totale_werkuren = '{item.totale_werkuren}', pauze = '{item.pauze}' WHERE ID = '{item.ID}' LIMIT 1";
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
