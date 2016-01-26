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

namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for personeelwindow.xaml
    /// </summary>
    public partial class personeelwindow : Window
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        public personeelwindow()
        {
            InitializeComponent();
        }

        private void personeelButton_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection myConnection = dbHelper.initiallizeDB();
            String query = "INSERT INTO intranet_users (firstname, surname, username, password, geboortedatum, email, telefoon, brutoloon) VALUES ('" + voornaamTextBox.Text + "','" + achternaamTextBox.Text + "','" + usernameTextBox.Text + "','" + passwordTextBox.Text + "','" + dateTextBox.Text + "','" + emailTextBox.Text + "','" + telefoonTextBox.Text + "','" + brutoloonTextBox.Text + "')";
            MySqlCommand sqlCommand = new MySqlCommand(query, myConnection);
            int rows_inserted = sqlCommand.ExecuteNonQuery();

            if (rows_inserted > 0)
            {
                confirmLabel.Content = "Mededeling is aangemaakt";
            }

            else
            {
                Console.Write("Oops! Something wrong!");

            }
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
