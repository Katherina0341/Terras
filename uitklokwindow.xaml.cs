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
using MySql.Data.MySqlClient;
using Intranet;
using Database;

namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for uitklokwindow.xaml
    /// </summary>
    public partial class uitklokwindow : Window
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        public List<staff> MyList { get; set; }
        private comboDB _combo = new comboDB();

        public uitklokwindow()
        {
            MyList = _combo.fetchStaff();
            DataContext = this;
            InitializeComponent();
            dpDate.SelectedDate = DateTime.Today;
            //  label1.Content = DateTime.Now.ToString();
            label1.Content = DateTime.Now.ToString("HH:mm");
        }

        private void vergeten_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Functie niet uitgeschreven, excuses!");
        }
        
private void klokButton_Click(object sender, RoutedEventArgs e)
{
           /* 
   MySqlConnection myConnection = dbHelper.initiallizeDB();
   String query = "INSERT INTO event (firstname, date, begintijd) VALUES ('" + comboBox.Text + "','" + dpDate.Text + "','" + label1.Content + "')";
   MySqlCommand sqlCommand = new MySqlCommand(query, myConnection);
   int rows_inserted = sqlCommand.ExecuteNonQuery();
   if (rows_inserted > 0)
   {
       Console.Write("Saved");
       this.Close();
   }
   else
   {
       Console.Write("Oops! Something wrong!");
   }
   */

}



        }
    }
