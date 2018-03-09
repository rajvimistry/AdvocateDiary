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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Advocate_Diary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class search_page : Page
    {
        public search_page()
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
                username.Text = name.ToString();
            }
            catch (Exception ex)
            {
                username.Text = "";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string username1 = username.Text;
            var db = new SQLite.SQLiteConnection(App.DBPath);
            var emptab = (db.Table<registration>().Where(em => em.username == username1)).Single();
            if (emptab.type == "lawyer")
            {
                string a = username.Text.ToString();
                this.Frame.Navigate(typeof(lawyer_homepage), a);
            }
            else if (emptab.type == "consumer")
            {
                string a = username.Text.ToString();
                this.Frame.Navigate(typeof(consumer_homepage), a);
            }
            //string lawyername;
            //lawyername = username.Text;
            //this.Frame.Navigate(typeof(lawyer_homepage),lawyername);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                string a;
                a = TextBox1.Text.ToString();       
                var emptab = (db.Table<lawyer>().Where(em => em.username == a)).Single();

              if (emptab.username == a)
               {
                   if (TextBox1.Text != "")
                   {
                       passvalue pv = new passvalue() { lawyername = TextBox1.Text, username = username.Text };
                       this.Frame.Navigate(typeof(Lawyer_info), pv);
                   }
                   else
                   {
                       tbl.Text = "";
                       tbl2.Text = "Match Not Found";
                   }
               }
            }
            catch(Exception ex)
            {
                tbl.Text = "Insert Name here";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
              if (TextBox2.Text != "")
                {
                    string username;
                    username = TextBox2.Text.ToString();
                    var db = new SQLite.SQLiteConnection(App.DBPath);
                    var emptab = (db.Table<lawyer>().Where(em => em.username == username));
                    lv.ItemsSource = emptab;
                }

             if (TextBox3.Text != "")
                {
                    string area;
                    area = TextBox3.Text.ToString();
                    var db = new SQLite.SQLiteConnection(App.DBPath);
                    var emptab = (db.Table<lawyer>().Where(em => em.location == area));
                    lv.ItemsSource = emptab;
                }

             if (TextBox4.Text != "")
                {
                    string working_field;
                    working_field = TextBox4.Text.ToString();
                    var db = new SQLite.SQLiteConnection(App.DBPath);
                    var emptab = (db.Table<lawyer>().Where(em => em.working_field == working_field));
                    lv.ItemsSource = emptab;
                }
         }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var db = new SQLite.SQLiteConnection(App.DBPath);
            lv.ItemsSource = db.Table<lawyer>();
        }
    }
}