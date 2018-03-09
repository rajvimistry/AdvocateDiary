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
    public sealed partial class feedback_form : Page
    {
        public feedback_form()
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
                tbl1.Text = name.ToString();
            }
            catch (Exception ex)
            {
                tbl1.Text = "".ToString();
            }
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                lv.ItemsSource = db.Table<feedback>();
            }
            catch (Exception ex)
            {
                TextBox1.Text = ex.Message;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string a = tbl1.Text;
            this.Frame.Navigate(typeof(consumer_homepage),a);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a = tbl1.Text;
            this.Frame.Navigate(typeof(post_feedback),a);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                     if (TextBox1.Text != "")
                     {
                         var db = new SQLite.SQLiteConnection(App.DBPath);
                         string username = TextBox1.Text;
                         var emptab = (db.Table<feedback>().Where(em => em.lawyer_name == username));
                         lv.ItemsSource = emptab;
                     }
                     //string working_field;
                     //working_field = TextBox4.Text.ToString();
                     //var db = new SQLite.SQLiteConnection(App.DBPath);
                     //var emptab = (db.Table<lawyer>().Where(em => em.working_field == working_field));
                     //lv.ItemsSource = emptab;
            }
            catch (Exception ex)
            {
                TextBox1.Text = ex.Message;
            }
        }
    }
}
