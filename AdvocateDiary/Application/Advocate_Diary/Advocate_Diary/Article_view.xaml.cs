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
    public sealed partial class Article_view : Page
    {
        public Article_view()
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
            article_pass_value pv = (article_pass_value)e.Parameter;
            tblName.Text = pv.article_name;
            tbl1.Text = pv.username;
            string a = tblName.Text;
            string b = tbl1.Text;

            var db = new SQLite.SQLiteConnection(App.DBPath);
            try
            {
                var emptab = (db.Table<Article_Forum>().Where(em => em.article_name == a)).Single();

                tblBy.Text = emptab.lawyername;
                tblDescription.Text = emptab.description;
            }
            catch (Exception ex)
            {

            }
            
            var r1 = (db.Table<registration>().Where(em1 => em1.username == b)).Single();
            if (r1.type == "lawyer")
            {
                btn1.Visibility = Visibility.Visible;
            }
            else if (r1.type == "consumer")
            {
                btn1.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string a = tbl1.Text;
            this.Frame.Navigate(typeof(list_of_articles), a);
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string a = tbl1.Text;
            this.Frame.Navigate(typeof(Add_article),a);
        }
    }
}
