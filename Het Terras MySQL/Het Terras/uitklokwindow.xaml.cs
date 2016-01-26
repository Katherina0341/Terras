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
            checkAdmin();
            dpDate.SelectedDate = DateTime.Today;
            //  label1.Content = DateTime.Now.ToString();
            label1.Content = DateTime.Now.ToString("HH:mm");
        }


        public void checkAdmin()
        {
            var name = Properties.Settings.Default.username;
            if (name != "admin")
            {
                comboBox.Items.Add(name);
                comboBox.SelectedIndex = 0;
            }

            else
            {
                comboBox.ItemsSource = MyList;
                comboBox.DisplayMemberPath = "Firstname";
            }
        }
        private void vergeten_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Functie niet uitgeschreven, excuses!");
        }
        
        private void klokButton_Click(object sender, RoutedEventArgs e)
         {
            string firstnamez = comboBox.Text;
            string datum = DateTime.Today.ToString();
            dpDate.SelectedDate = DateTime.Today;


            Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
            MySqlConnection connection = dbHelper.initiallizeDB();

            string query = "Select * from event where firstname=@firstnamez and date=@datum";
            MySqlCommand sqlCommand = new MySqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@firstnamez", firstnamez);
            sqlCommand.Parameters.AddWithValue("@datum", dpDate.Text);
            MySqlDataReader events = sqlCommand.ExecuteReader();
            if (events.Read())
            {
                
                Het_Terras.dbclass dbhelper1 = new Het_Terras.dbclass();
                MySqlConnection connection1 = dbHelper.initiallizeDB();
                //string insert = "INSERT INTO event (eindtijd) VALUES (" + label1.Content + ") WHERE firstname=" + firstnamez +" AND date=" + dpDate.Text +"";
              //  string insert = "UPDATE event SET eindtijd='"+ label1.Content +"' WHERE firstname='" + firstnamez + "' AND date='" + dpDate.Text + "";
                string insert = "UPDATE event SET eindtijd = '"+label1.Content+"' WHERE firstname = '"+firstnamez+"' AND date ='" +dpDate.Text +"'";
                //can you print this string ?
                Console.Write(insert);
                Console.WriteLine(insert);
                MySqlCommand sqlCommand1 = new MySqlCommand(insert, connection1);
                int rows_inserted = sqlCommand1.ExecuteNonQuery();
                if (rows_inserted > 0)
                {
                    Console.Write("Saved");
                    var dashboard = new MainWindow();
                    dashboard.Owner = this;
                    dashboard.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Kan niet uitklokken! Was je wel ingeklokt vandaag?");
                } 
     
            }

            else
            {
                MessageBox.Show("Er gaat iets fout " + firstnamez + " Was je zeker weten ingeklokt?" );
            }

            events.Close();
        }



    }
}
