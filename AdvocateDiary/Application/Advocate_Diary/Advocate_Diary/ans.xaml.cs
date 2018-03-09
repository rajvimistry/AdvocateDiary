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
    public sealed partial class ans : Page
    {
        public ans()
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
                qnavaluepass qv = (qnavaluepass)e.Parameter;
                tbl1.Text = qv.name;
                textbox1.Text = Convert.ToString(qv.qno);
            }
            catch (Exception ex)
            {
                tbl1.Text = ex.Message;
            }
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                int a = Convert.ToInt32(textbox1.Text);
                var emptab = (db.Table<qna>().Where(em => em.qno == a)).Single();
                textbox2.Text = emptab.question;
            }
            catch (Exception ex)
            {
                var var_name = new MessageDialog("Invalid question no.\n Please eneter a correct question no. \nClick on back button");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                qna qa = new qna();

                int a = Convert.ToInt32(textbox1.Text);
                var emptab = (db.Table<qna>().Where(em => em.qno == a)).Single();

                if (emptab.ans1 == null)
                {
                    qa.ans1 = textbox3.Text;
                    goto l3;
                }
                else if (emptab.ans2 == null)
                {
                    qa.ans2 = textbox3.Text;
                    goto l3;
                }
                else if (emptab.ans3 == null)
                {
                    qa.ans3 = textbox3.Text;
                    goto l3;
                }
                else if (emptab.ans4 == null)
                {
                    qa.ans4 = textbox3.Text;
                    goto l3;
                }
                else if (emptab.ans5 == null)
                {
                    qa.ans5 = textbox3.Text;
                    goto l3;
                }
                else if (emptab.ans6 == null)
                {
                    qa.ans6 = textbox3.Text;
                    goto l3;
                }
                else if (emptab.ans7 == null)
                {
                    qa.ans7 = textbox3.Text;
                    goto l3;
                }
                else if (emptab.ans8 == null)
                {
                    qa.ans8 = textbox3.Text;
                    goto l3;
                }
                else if (emptab.ans9 == null)
                {
                    qa.ans9 = textbox3.Text;
                    goto l3;
                }
                else if (emptab.ans10 == null)
                {
                    qa.ans10 = textbox3.Text;
                    goto l3;
                }
                else
                {
                    var var_name = new MessageDialog("Answer is not sent !! try again");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();
                }

             l3:   db.Insert(qa);
                var d = new MessageDialog("Your answer is send.Thank you");
                d.Commands.Add(new UICommand("OK"));
                d.ShowAsync();
            }
            catch (Exception ex)
            {
                textbox3.Text = ex.Message;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a = tbl1.Text.ToString();
            this.Frame.Navigate(typeof(MainPage), a);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string a = tbl1.Text.ToString();
            this.Frame.Navigate(typeof(QnA_forum), a);
        }
    }
}