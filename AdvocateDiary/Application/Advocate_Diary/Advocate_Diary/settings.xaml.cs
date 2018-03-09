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
    public sealed partial class settings : Page
    {
        public settings()
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
            var name = e.Parameter.ToString();
            tbl1.Text = name.ToString();
            string username = tbl1.Text;
            var db = new SQLite.SQLiteConnection(App.DBPath);

            var r1 = (db.Table<registration>().Where(em1 => em1.username == username)).Single();
            if (r1.type == "lawyer")
            {
                btnUpdate.Visibility = Visibility.Visible;
            }
            else if (r1.type == "consumer")
            {
                btnUpdate.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string username = tbl1.Text;
            var db = new SQLite.SQLiteConnection(App.DBPath);
            var emptab = (db.Table<registration>().Where(em => em.username == username)).Single();
            if (emptab.type == "lawyer")
            {
                string a = tbl1.Text.ToString();
                this.Frame.Navigate(typeof(lawyer_homepage), a);
            }
            else if (emptab.type == "consumer")
            {
                string a = tbl1.Text.ToString();
                this.Frame.Navigate(typeof(consumer_homepage), a);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a = tbl1.Text;
            this.Frame.Navigate(typeof(update_info), a);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                var emptab = (db.Table<registration>().Where(em => em.username == tbl1.Text)).Single();
                if (emptab.password != txtOld.Password)
                {
                    var z = new MessageDialog("Wrong Password");
                    z.Commands.Add(new UICommand("OK"));
                    z.ShowAsync();
                }
                else
                {
                    if (txtNew.Password != txtConfirm.Password)
                    {
                        var var_name = new MessageDialog("Both Password does not match");
                        var_name.Commands.Add(new UICommand("OK"));
                        var_name.ShowAsync();
                    }
                    else if (emptab != null)
                    {
                        emptab.password = txtNew.Password;
                        emptab.confirm_password = txtNew.Password;

                        db.Update(emptab);

                        txtConfirm.Password = "";
                        txtNew.Password = "";
                        txtOld.Password = "";


                        var var_name = new MessageDialog("Password Change successfully");
                        var_name.Commands.Add(new UICommand("OK"));
                        var_name.ShowAsync();
                    }
                }
            }

            catch (Exception ex)
            {
                //t1.Text = ex.Message;
                var var_name = new MessageDialog("Something went wrong.. Please try again later");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                var emptab = (db.Table<registration>().Where(em => em.username == tbl1.Text)).Single();
                if (emptab.password != txtPassword.Password)
                {
                    var z = new MessageDialog("Wrong Password");
                    z.Commands.Add(new UICommand("OK"));
                    z.ShowAsync();
                }
                else
                {
                    db.Delete(emptab);
                    var var_name = new MessageDialog("Your Account deleted successfulyy");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();
                    this.Frame.Navigate(typeof(MainPage));
                }
            }

            catch (Exception ex)
            {
                //TextBox1.Text = ex.Message;
                var var_name = new MessageDialog("Unable to delete");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }
        }
    }
}
