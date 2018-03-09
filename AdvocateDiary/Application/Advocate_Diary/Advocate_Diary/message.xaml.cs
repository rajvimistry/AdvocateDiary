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
using SQLite;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Advocate_Diary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class message : Page
    {
        public message()
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
                TextBox1.Text = name.ToString();
            }
            catch (Exception ex)
            {
                TextBox1.Text = "".ToString();
            }

            string username = TextBox1.Text;
           // string sendername = TextBox1.Text;

            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);

                var emptab = (db.Table<message1>().Where(em => em.sender_name == username));
                lv.ItemsSource = emptab;

                var emptab1 = (db.Table<message1>().Where(em => em.receiver_name == username));
                lv2.ItemsSource = emptab1;

                //if (emptab.sender_name == TextBox1.Text || emptab.receiver_name == TextBox1.Text)
                //{
                //    //lv.ItemsSource = emptab;
                //    lv.ItemsSource = db.Table<message1>();
                //}
            }
            catch (Exception ex)
            {
                TextBox3.Text = ex.Message;
            }
        }
           

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                string a;
                a = TextBox2.Text.ToString();
                var emptab = (db.Table<registration>().Where(em => em.username == a)).Single();

                if (TextBox2.Text == "" || TextBox3.Text == "")
                {
                    var var_name = new MessageDialog("Fill all the details");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();
                }
                else
                {
                    var db1 = new SQLite.SQLiteConnection(App.DBPath);
                    message1 m = new message1();

                    m.sender_name = TextBox1.Text;
                    m.receiver_name = TextBox2.Text;
                    m.message = TextBox3.Text;

                    db1.Insert(m);

                    var var_name = new MessageDialog("Message sent successfully");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();

                    TextBox2.Text = "";
                    TextBox3.Text = "";
                }
            }
            catch (Exception ex)
            {
                var var_name = new MessageDialog("Invalid username");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }

            //if (TextBox2.Text == "" || TextBox3.Text == "")
            //{
            //    var var_name = new MessageDialog("Fill all the details");
            //    var_name.Commands.Add(new UICommand("OK"));
            //    var_name.ShowAsync();
            //}
            //else
            //{
            //    var db1 = new SQLite.SQLiteConnection(App.DBPath);
            //    message1 m = new message1();

            //    m.sender_name = TextBox1.Text;
            //    m.receiver_name = TextBox2.Text;
            //    m.message = TextBox3.Text;

            //    db1.Insert(m);

            //    var var_name = new MessageDialog("Message sent successfully");
            //    var_name.Commands.Add(new UICommand("OK"));
            //    var_name.ShowAsync();
            //}
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string username = TextBox1.Text;
            var db = new SQLite.SQLiteConnection(App.DBPath);
            var emptab = (db.Table<registration>().Where(em => em.username == username)).Single();
            if (emptab.type == "lawyer")
            {
                string a = TextBox1.Text.ToString();
                this.Frame.Navigate(typeof(lawyer_homepage), a);
            }
            else if (emptab.type == "consumer")
            {
                string a = TextBox1.Text.ToString();
                this.Frame.Navigate(typeof(consumer_homepage), a);
            }
        }
    }
}
