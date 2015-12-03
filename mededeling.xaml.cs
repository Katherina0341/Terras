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
    /// Interaction logic for mededeling.xaml
    /// </summary>
    public partial class mededeling : Window
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        public mededeling()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            MySqlConnection myConnection = dbHelper.initiallizeDB();
            String query = "INSERT INTO terras_mededelingen (author, title, text) VALUES ('" + auteurTextBox.Text + "','" + titelTextBox.Text + "', '" + mededelingRichTextBox.Document.ContentEnd + "')";
            MySqlCommand sqlCommand = new MySqlCommand(query, myConnection);
            //MySqlCommand cmd = new MySqlCommand("select * from terras_mededelingen where korder = @korder", myConnection);
           // MySqlParameter param = new MySqlParameter();
           // param.ParameterName = "@korder";
           // param.Value = kordernrTextBox.Text;
            //cmd.Parameters.Add(param);
            
            //sqlCommand.Connection.Open();
           // MySqlDataReader reader = cmd.ExecuteReader();

            //if (reader.HasRows)
            //{
             //     label2.Text = "Order nummer bestaat al";
             //   return;

            //}
          //  else
         //   {
          //      reader.Close();
         //   }

            // opens execute non query 
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
    }
}
