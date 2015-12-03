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


namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for edituser.xaml
    /// </summary>
    public partial class edituser : Window
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        public edituser()
        {
            InitializeComponent();
        }

        private void dashboardButton_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new MainWindow();
            dashboard.Owner = this;
            dashboard.Show();

        }

        private void roosterButton_Click_1(object sender, RoutedEventArgs e)
        {
            var form6 = new rooster();
            form6.Owner = this;
            form6.Show();
            // this.Hide();
            // this.Close();
        }

        private void personeelButton_Click_1(object sender, RoutedEventArgs e)
        {
            var personeel = new personeel();
            personeel.Owner = this;
            personeel.Show();
            // this.Hide();
            // this.Close();
        }

        private void dataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }


        public DataTable fillZone()
        {
            MySqlConnection myConnection = dbHelper.initiallizeDB();
            string command = "select firstname from intranet_users";
            MySqlDataAdapter data = new MySqlDataAdapter(command, myConnection);
            DataTable dt = new DataTable("data");
            data.Fill(dt);
            return dt;

        }



        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
 
        }
    }
}
