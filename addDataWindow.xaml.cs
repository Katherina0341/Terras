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
using Intranet;
using Database;
using MySql.Data.MySqlClient;

namespace Het_Terras
{
    /// <summary>
    /// Interaction logic for addDataWindow.xaml
    /// </summary>
    public partial class addDataWindow : Window
    {
        Het_Terras.dbclass dbHelper = new Het_Terras.dbclass();
        public List<staff> MyList { get; set; }
        private comboDB _combo = new comboDB();

        public addDataWindow()
        {
            MyList = _combo.fetchStaff();
            DataContext = this;
            InitializeComponent();         
        }

       public void activiteitButton_Click(object sender, RoutedEventArgs e)
        {
            var test = myCalendar.SelectedDate.Value.Date.ToShortDateString();
            var beginplus = beginUurCombo.Text + ':' + beginMinuutCombo.Text;
            var eindplus = eindUurCombo.Text + ':' + eindMinuutCombo.Text;
            // Start converting everything to int! 
            var beginuur = Convert.ToInt32(beginUurCombo.Text);
            var beginmin = Convert.ToInt32(beginMinuutCombo.Text);
            var einduur = Convert.ToInt32(eindUurCombo.Text);
            var eindminuut = Convert.ToInt32(eindMinuutCombo.Text);
            // those are now integers, now I want the hours * 60 I want the minutes.
            int beginuurnaarminuut = beginuur * 60;
            int einduurnaarminuut = einduur * 60;
            // we have them calculated to minutes now, now I add the rest of the minutes with them then we /60 to get both values to hours again
            int beginuitgerekend = beginuurnaarminuut + beginmin;
            int einduitgerekend = einduurnaarminuut + eindminuut;
            // Gay doen, moeten nu pas delen denk ik
            int begingedeeld = beginuitgerekend / 60;
            int eindgedeeld = einduitgerekend / 60;
            // We Calculate how many hours the employee has worked:
            int x = eindgedeeld - begingedeeld;
            Console.Write(x);
            // nu de pauzes verekenen: 
            double pauze = 0;
            if (beginuur == 8 && einduur == 17)
            {
                pauze = 0.30;                
            }
            else if (beginuur >= 12 && einduur <= 15)
            {
                pauze = 0;
            }
            else if (beginuur <= 8 && einduur < 12)
            {
                pauze = 0;
            }

            

                  

            if (omschrijvingTextBox.Text == "Omschrijving")
            {
                omschrijvingTextBox.Text = "";
            }

            if ((string.IsNullOrEmpty(comboBox.Text)) && (string.IsNullOrEmpty(beginplus) && (string.IsNullOrEmpty(eindplus))))
            {
                MessageBox.Show("U dient alle velden in te vullen");
            }

            else if ((string.IsNullOrEmpty(comboBox.Text)))
            {
                MessageBox.Show("U dient een werknemer te selecteren");
            }

            else if ((string.IsNullOrEmpty(beginUurCombo.Text)))
            {
                MessageBox.Show("U dient een begin tijd te selecteren");
            }

            else if ((string.IsNullOrEmpty(beginMinuutCombo.Text)))
            {
                MessageBox.Show("U dient een begin tijd te selecteren");
            }

            else if ((string.IsNullOrEmpty(eindUurCombo.Text)))
            {
                MessageBox.Show("U dient een eind tijd te selecteren");
            }

            else if ((string.IsNullOrEmpty(eindMinuutCombo.Text)))
            {
                MessageBox.Show("U dient een begin tijd te selecteren");
            }

            else
            {


                MySqlConnection myConnection = dbHelper.initiallizeDB();
                String query = "INSERT INTO ingeroosterd (firstname, date, begintijd, eindtijd, omschrijving, totale_werkuren, pauze) VALUES ('" + comboBox.Text + "','" + test + "','" + beginplus + "','" + eindplus + "','" + omschrijvingTextBox.Text + "','" +x+"','" +pauze+ "')";
                MySqlCommand sqlCommand = new MySqlCommand(query, myConnection);
                int rows_inserted = sqlCommand.ExecuteNonQuery();
                if (rows_inserted > 0)
                {
                    Console.Write("Saved");
                    MessageBox.Show("Activiteit aangemaakt op" + test + " Vanaf " + beginplus + " tot " + eindplus);
                }
                else
                {
                    Console.Write("Oops! Something wrong!");
                }

                if (omschrijvingTextBox.Text == "")
                {
                    omschrijvingTextBox.Text = "Omschrijving";
                }

                //Console.Write(plus);

            }
        }







        private void dashboardButton_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new MainWindow();
            dashboard.Owner = this;
            dashboard.Show();
            this.Hide();
            // this.Close();

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
            // this.Close();
        }

        private void roosterButton_Click_1(object sender, RoutedEventArgs e)
        {
            var rooster = new rooster();
            rooster.Owner = this;
            rooster.Show();
            this.Hide();
            // this.Close();
        }

        private void personeelButton_Click_1(object sender, RoutedEventArgs e)
        {
            var personeel = new personeel();
            personeel.Owner = this;
            personeel.Show();
            this.Hide();
            // this.Close();
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
