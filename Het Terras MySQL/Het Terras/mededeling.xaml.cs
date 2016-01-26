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
using System.IO;
using System.Windows.Markup;

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
        {/*
            RichTextBox mededelingRichTextBox = new RichTextBox();
            // Create a FlowDocument to contain content for the RichTextBox.
            FlowDocument myFlowDoc = new FlowDocument();
            // Add initial content to the RichTextBox.
            mededelingRichTextBox.Document = myFlowDoc;
            // Let's pretend the RichTextBox gets content magically ... 
            TextRange textRange = new TextRange(
              // TextPointer to the start of content in the RichTextBox.
              mededelingRichTextBox.Document.ContentStart,
              // TextPointer to the end of content in the RichTextBox.
              mededelingRichTextBox.Document.ContentEnd
            );
         */
         


            MySqlConnection myConnection = dbHelper.initiallizeDB();
            String query = "INSERT INTO terras_mededelingen (author, title, text) VALUES ('" + auteurTextBox.Text + "','" + titelTextBox.Text + "', '" + mededelingTextBox.Text + "')";
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
    }
}
