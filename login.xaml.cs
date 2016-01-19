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
using System.Windows.Markup;

namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        public bool validate_login(string user, string pass)
        {
            Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
            MySqlConnection connection = dbHelper.initiallizeDB();

            string query = "Select * from intranet_users where username=@username and password=@password";
            MySqlCommand sqlCommand = new MySqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@username", user);
            sqlCommand.Parameters.AddWithValue("@password", pass);
            // sqlCommand.Connection = Connect;
            MySqlDataReader intranet_users = sqlCommand.ExecuteReader();
            if (intranet_users.Read())
            {
                connection.Close();
                return true;
              //  string username = username.ToString();
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        public void loginButton_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new MainWindow();
            dashboard.Owner = this;
           // dashboard.Show();
           // this.Hide();
            string user = usernameTextBox.Text;
            string pass = passwordTextBox.Text;


            if (string.IsNullOrEmpty(usernameTextBox.Text) &&
                 string.IsNullOrEmpty(passwordTextBox.Text))
            {
                label3.Content = "U dient beide velden in te vullen";
            }

            else if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                label3.Content = "U dient een gebruiksnaam in te vullen";
            }

            else if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                label3.Content = "U dient een wachtwoord in te vullen";
            }

            // inlog verwerking
            bool r = validate_login(user, pass);
            if (r)
            {
                Properties.Settings.Default.username = user;
                Properties.Settings.Default.Save();
                var MainWindow = new MainWindow();
                MainWindow.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Incorrect Login Credentials");
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
