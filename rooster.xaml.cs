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


namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for Rooster.xaml
    /// </summary>
    public partial class rooster : Window
    {
        public List<staff> MyList { get; set; }
        private newstaffDBcs _staffDB = new newstaffDBcs();

        public rooster()
        {
            InitializeComponent();
            MyList = _staffDB.fetchStaff();
            DataContext = this;
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
    }
  }

