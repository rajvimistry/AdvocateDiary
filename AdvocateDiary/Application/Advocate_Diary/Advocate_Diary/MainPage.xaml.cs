using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using System.Windows;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Advocate_Diary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private object emailid;
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextBox1.Text != null && pwd.Password != null)
                {
                    var db = new SQLite.SQLiteConnection(App.DBPath);

                    string username;
                    string password;
                    string type1;

                    username = TextBox1.Text.ToString();
                    password = pwd.Password.ToString();

                    if (Lawyer.IsChecked == true)
                    {
                        type1 = "lawyer";
                    }
                    else
                    {
                        type1 = "consumer";
                    }

                    var emptab = (db.Table<registration>().Where(em => em.username == username)).Single();

                    if (emptab.password == password && emptab.type == type1 )
                    {
                        if (Lawyer.IsChecked == true)
                        {
                            this.Frame.Navigate(typeof(lawyer_homepage), username);
                        }
                        else if (Consumer.IsChecked == true)
                        {
                            this.Frame.Navigate(typeof(consumer_homepage), username);
                        }
                    }
                    else
                    {
                        var var_name = new MessageDialog("Invalid Id or Password");
                        var_name.Commands.Add(new UICommand("OK"));
                        var_name.ShowAsync();
                    }
                }
                else
                {
                    var var_name = new MessageDialog("Insert all the details");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();
                }
            }
            catch (Exception ex)
            {
                var var_name = new MessageDialog("Invalid Id or Password");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(registration_page));
        }

        private void Lawyer_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void Consumer_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(forgot_passwordPage));
        }
    }
}