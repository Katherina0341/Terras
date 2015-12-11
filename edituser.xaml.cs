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
    /// Interaction logic for edituser.xaml
    /// </summary>
    public partial class edituser : Window
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        public List<staff> MyList { get; set; }  
        private comboDB _combo = new comboDB();

        public List<staff> MyList1 { get; set; }
        private staffDB _staffDB = new staffDB();

        public List<IntranetUsers> MynewList { get; set; }
        private IntraDB _staffObj = new IntraDB();

        public edituser()
        {
            
            MyList = _combo.fetchStaff();
            MynewList = _staffObj.fetchNotes();
            DataContext = this;          
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









        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var staffObj = ((staff)dataComboBox.SelectedItem).Firstname; // Here I take the value's name into a variable will need this for my query! 
                                                                         //debug   label2.Content = ((staff)dataComboBox.SelectedItem).Firstname;


            string querywhere = "SELECT * FROM intranet_users WHERE firstname = '" + staffObj + "'";
            IntraDB db = new IntraDB();
            List<IntranetUsers> users = db.fetchNotes(querywhere);

        }
    }
}
