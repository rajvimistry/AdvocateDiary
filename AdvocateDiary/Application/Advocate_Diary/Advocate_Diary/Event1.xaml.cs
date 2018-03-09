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
using SQLite;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Advocate_Diary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Event1 : Page
    {
        public Event1()
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

            string uname = TextBox1.Text;

            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);

                var emptab = (db.Table<Event>().Where(em => em.username == uname));
                lv.ItemsSource = emptab;

                //if (emptab.sender_name == TextBox1.Text || emptab.receiver_name == TextBox1.Text)
                //{
                //    //lv.ItemsSource = emptab;
                //    lv.ItemsSource = db.Table<message1>();
                //}
            }
            catch (Exception ex)
            {
                //TextBox3.Text = ex.Message;
            }
            var db1 = new SQLite.SQLiteConnection(App.DBPath);
            DateTime dt = DateTime.Today;
            var emptab1 = (db1.Table<Event>().Where(em1 => em1.username == uname)).ToList();
            //for (int t = 0; t < emptab1.Count; t++)
            //{
            //    if (dt < emptab1[t].date)
            //    {
            //        db1.Delete(emptab1);
            //    }
            //}

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var db = new SQLite.SQLiteConnection(App.DBPath);
            Event ev = new Event();

            ev.username = TextBox1.Text;
            ev.event_name = txtEventname.Text;
            ev.date = Convert.ToDateTime(txtEventdate.Text);
            ev.time = txtTime.Text;
            db.Insert(ev);
            t1.Text = "Event Added Successfully";
            txtTime.Text = "";
            txtEventname.Text = "";
            txtEventdate.Text = "";
        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

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
