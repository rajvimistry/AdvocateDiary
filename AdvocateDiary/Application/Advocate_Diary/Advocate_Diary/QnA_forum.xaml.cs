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
    public sealed partial class QnA_forum : Page
    {
        public QnA_forum()
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
                tbl1.Text = ex.Message;
            }

            var db = new SQLite.SQLiteConnection(App.DBPath);
            lv1.ItemsSource = db.Table<qna>();
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
            if (tbx1.Text == "")
            {
                var var_name = new MessageDialog("Please add a question.");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }
            else
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                qna q = new qna();
                q.question = tbx1.Text;
                db.Insert(q);
                var var_name = new MessageDialog("Question added successfully");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
                tbx1.Text = "";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

                if (tbx2.Text == "")
                {
                    var var_name = new MessageDialog("Please add a question no. in a textbox");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();
                }

                else
                {
                    qnavaluepass qv = new qnavaluepass() { name = tbl1.Text, qno = Convert.ToInt32(tbx2.Text) };
                    this.Frame.Navigate(typeof(ans), qv);
                }
               

        }
    }
}