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
    public sealed partial class post_feedback : Page
    {
        public post_feedback()
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
            try
            {
                var name = e.Parameter.ToString();
                t2.Text = name.ToString();
            }
            catch (Exception ex)
            {
                t2.Text = "".ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string a = t2.Text;
            this.Frame.Navigate(typeof(consumer_homepage),a);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a = t2.Text;
            this.Frame.Navigate(typeof(feedback_form),a);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                string a = t3.Text.ToString();
                var emptab = (db.Table<registration>().Where(em => em.username == a)).Single();

                if (t4.Text == "" || t3.Text == "")
                {
                    var var_name = new MessageDialog("Fill all the details");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();
                }
                else
                {
                    var db1 = new SQLite.SQLiteConnection(App.DBPath);
                    feedback fb = new feedback();

                    fb.consumer_name = t2.Text;
                    fb.lawyer_name = t3.Text;
                    fb.description = t4.Text;
                    db.Insert(fb);
                    l1.Text = "Thank You for your feedback.";
                    // t1.Text = "";
                    t2.Text = "";
                    t3.Text = "";
                    t4.Text = "";
                }
            }

            catch (Exception ex)
            {
                var var_name = new MessageDialog("Invalid username");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }

        }

        private void t2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
