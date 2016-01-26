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
namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for personeel.xaml
    /// </summary>
    public partial class personeel : Window
    {
        public List<staff> MyList { get; set; }
        private staffDB _staffDB = new staffDB();

        public personeel()
        {
            InitializeComponent();
            MyList = _staffDB.fetchStaff();
            DataContext = this;
            welkomLabel.Content = "Welkom " + Properties.Settings.Default.username + " u bent succesvol ingelogd";

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

        private void editpersoneelButton_Click(object sender, RoutedEventArgs e)
        {
            var editpersoneel = new edituser();
            editpersoneel.Owner = this;
            editpersoneel.Show();
            this.Hide();
        }

        private void nieuwButton_Click(object sender, RoutedEventArgs e)
        {
            var addpersoneel = new personeelwindow();
            addpersoneel.Owner = this;
            addpersoneel.Show();
            //this.Hide();
        }

        private void roosterButton_Click_1(object sender, RoutedEventArgs e)
        {
            var rooster = new rooster();
            rooster.Owner = this;
            rooster.Show();
        }

        private void dataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
