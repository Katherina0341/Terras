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
using Intranet;
using database;
using authorDatabase;
using authormodel;
using MySql.Data.MySqlClient;

namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for emededeling.xaml
    /// </summary>
    public partial class emededeling : Window
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        public List<notemededeling> NewCombo { get; set; }
        private combomededeling _combomededeling = new combomededeling();

        public List<notemededeling> LoadList { get; set; }
        private mededelDB _staffObj = new mededelDB();

        public emededeling()
        {
            NewCombo = _combomededeling.fetchAuthor();
          //  LoadList = _staffObj.fetchingstuff("SELECT * FROM  terras_mededelingen");
            DataContext = this;
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection myConnection = dbHelper.initiallizeDB();
            var staffObj = ((notemededeling)dataComboBox.SelectedItem).title; // Here I take the value's name into a variable will need this for my query!           
            foreach (var item in LoadList)
            {
                // Update each user individually
                var query = $"UPDATE terras_mededelingen SET title = '{item.title}', author = '{item.author}', text = '{item.text}' WHERE ID = '{item.ID}'";
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


        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var staffObj = ((notemededeling)dataComboBox.SelectedItem).title; // Here I take the value's name into a variable will need this for my query!              
            string querywhere = "SELECT * FROM terras_mededelingen WHERE title = '" + staffObj + "'";
            mededelDB db = new mededelDB();
            LoadList = db.fetchingstuff(querywhere);
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = LoadList;
            dataGrid.Items.Refresh();
        }




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


     

        private void dataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
