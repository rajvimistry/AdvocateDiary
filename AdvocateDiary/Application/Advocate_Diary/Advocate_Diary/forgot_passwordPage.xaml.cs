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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Advocate_Diary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class forgot_passwordPage : Page
    {
        public forgot_passwordPage()
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
            var db = new SQLite.SQLiteConnection(App.DBPath);
            var emptab = (db.Table<registration>().Where(em => em.username == t1.Text)).Single();
            t2.Text = emptab.seq_qes;
            if (emptab.answer != t3.Text)
            {
                var z = new MessageDialog("Answer does not match");
                z.Commands.Add(new UICommand("OK"));
                z.ShowAsync();
            }
            else
            {
                if (p1.Password != p2.Password)
                {
                    var var_name = new MessageDialog("Password does not match");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();
                }
                if (emptab != null)
                {
                    emptab.password = p1.Password;
                    emptab.confirm_password = p2.Password;

                    db.Update(emptab);  

                    var var_name = new MessageDialog("Password Change successfully");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();

                    t1.Text = "";
                    t2.Text = "";
                    t3.Text = "";
                    p1.Password = "";
                    p2.Password = "";
                }
            }
            }
                catch(Exception ex)
                {
                    t1.Text = ex.Message;
                    var var_name = new MessageDialog("Something went wrong.. Please try again");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();

                    //t1.Text = "";
                    //t2.Text = "";
                    //t3.Text = "";
                    //p1.Password = "";
                    //p2.Password = "";
                }
            }

        private void t1_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void t2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                var emptab = (db.Table<registration>().Where(em => em.username == t1.Text)).Single();
                t2.Text = emptab.seq_qes;
            }
            catch (Exception ex)
            {
                var var_name = new MessageDialog("Invalid Username");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        }
    }
