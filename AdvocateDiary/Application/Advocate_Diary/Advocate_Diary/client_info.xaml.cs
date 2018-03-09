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
    public sealed partial class client_info : Page
    {
        public client_info()
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
            tbl.Text = name.ToString();
            string username = tbl.Text;
            var db = new SQLite.SQLiteConnection(App.DBPath);
            var emptab = (db.Table<client_details>().Where(em => em.lawyername == username));
            lv.ItemsSource = emptab;
            //lv.ItemsSource = db.Table<client_details>();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string a;
            a = tbl.Text;
            this.Frame.Navigate(typeof(add_client_detail),a);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a;
            a = tbl.Text;
            this.Frame.Navigate(typeof(lawyer_homepage), a);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "")
            {
                var var_name = new MessageDialog("Insert name in textbox");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }

            if (TextBox1.Text != "")
            {
                try
                {
                    var db = new SQLite.SQLiteConnection(App.DBPath);
                    string a = TextBox1.Text;
                    var d1 = (db.Table<client_details>().Where(em=>em.clientname == a)).Single();
                    db.Delete(d1);
                    lv.ItemsSource = db.Table<client_details>();
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string a;
            a = tbl.Text;
            this.Frame.Navigate(typeof(add_client_detail), a);
        }
    }
}