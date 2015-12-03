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

namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for personeel.xaml
    /// </summary>
    public partial class personeel : Window
    {
        public personeel()
        {
            InitializeComponent();
        }

        private void dashboardButton_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new MainWindow();
            dashboard.Owner = this;
            dashboard.Show();
            // this.Hide();
            // this.Close();

        }

        private void roosterButton_Click(object sender, RoutedEventArgs e)
        {
            var form6 = new rooster();
            form6.Owner = this;
            form6.Show();
            // this.Hide();
            // this.Close();

        }

        private void editpersoneelButton_Click(object sender, RoutedEventArgs e)
        {
            var editpersoneel = new edituser();
            editpersoneel.Owner = this;
            editpersoneel.Show();
        }

        private void nieuwButton_Click(object sender, RoutedEventArgs e)
        {
            var addpersoneel = new personeelwindow();
            addpersoneel.Owner = this;
            addpersoneel.Show();
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
    }
}
