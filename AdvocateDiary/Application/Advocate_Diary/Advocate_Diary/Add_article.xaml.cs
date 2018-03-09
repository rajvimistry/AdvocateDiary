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
    public sealed partial class Add_article : Page
    {
        public Add_article()
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
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtArticle.Text == "" || txtDescription.Text == "")
            {
                var var_name = new MessageDialog("Insert all the details");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }
            else
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                Article_Forum af = new Article_Forum();
                af.lawyername = tbl1.Text;
                af.article_name = txtArticle.Text;
                af.description = txtDescription.Text;
                db.Insert(af);
                tblmessage.Text = "Article Added Successfully";
                //txtDescription.Text = "";
                //txtArticle.Text = "";
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string a = tbl1.Text;
            this.Frame.Navigate(typeof(list_of_articles), a);
        }
    }
}
