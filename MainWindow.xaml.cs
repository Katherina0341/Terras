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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Database;
using model;


namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<notes> MyList { get; set; }
        private NoteDB _noteDB = new NoteDB();

        public MainWindow()
        {
            InitializeComponent();
            MyList = _noteDB.fetchNotes();
            DataContext = this;
        }

        private void nieuwButton_Click(object sender, RoutedEventArgs e)
        {
            var form2 = new mededeling();
            form2.Show();
           // this.Hide();
            
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            var form3 = new emededeling();
            form3.Show();
            this.Hide();            
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
            //this.Close();
        }

      

        private void dataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            new NoteDB().fetchNotes();
        }

        private void fetchNotes(object sender, RoutedEventArgs e)
        {
            
        }

        private void dashboardButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
