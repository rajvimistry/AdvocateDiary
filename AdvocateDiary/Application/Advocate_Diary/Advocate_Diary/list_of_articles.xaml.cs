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
    public sealed partial class list_of_articles : Page
    {
        public list_of_articles()
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

            try
            {
                string username = tbl1.Text;
                var db = new SQLite.SQLiteConnection(App.DBPath);

                //var emptab = (db.Table<Article_Forum>().Where(em => em.lawyername == username)).Single();
                lv2.ItemsSource = db.Table<Article_Forum>();


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
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                string a;
                a = TextBox1.Text.ToString();
                var emptab = (db.Table<Article_Forum>().Where(em => em.article_name == a)).Single();

                if (emptab.article_name == a)
                {
                    if (TextBox1.Text != "")
                    {
                        article_pass_value pv = new article_pass_value { article_name = TextBox1.Text, username = tbl1.Text };
                        this.Frame.Navigate(typeof(Article_view), pv);
                    }
                    else
                    {
                        //tbl.Text = "";
                        tbl2.Text = "Match Not Found";
                    }
                }
            }
            catch (Exception ex)
            {
                tbl2.Text = "Match Not Found";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
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
    }
}
