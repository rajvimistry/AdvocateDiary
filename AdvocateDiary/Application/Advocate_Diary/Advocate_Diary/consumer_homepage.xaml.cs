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
using Windows.UI.Notifications;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Advocate_Diary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class consumer_homepage : Page
    {
        public consumer_homepage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                var name = e.Parameter.ToString();
                user_name.Text = name.ToString();
            }
            catch (Exception ex)
            {
                user_name.Text = "".ToString();
            }

            string username = user_name.Text;
            DateTime thisday = DateTime.Today;
            var db = new SQLite.SQLiteConnection(App.DBPath);
            var emptab = (db.Table<Event>().Where(em => em.username == username)).ToList();
            for (int t = 0; t < emptab.Count; t++)
            {
                if (thisday == emptab[t].date)
                {
                    var notificationXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);
                    var toeastElement = notificationXml.GetElementsByTagName("text");
                    toeastElement[0].AppendChild(notificationXml.CreateTextNode("1 Upcoming Event"));
                    toeastElement[1].AppendChild(notificationXml.CreateTextNode(emptab[t].event_name));
                    var toastNotification = new ToastNotification(notificationXml);
                    ToastNotificationManager.CreateToastNotifier().Show(toastNotification);
                }
            }
            string a = user_name.Text;

            var db1 = new SQLite.SQLiteConnection(App.DBPath);
            var emptab1 = (db1.Table<registration>().Where(em => em.username == a)).Single();
            try
            {
                StorageFile rfile = await ApplicationData.Current.LocalFolder.GetFileAsync(emptab1.username + ".jpg");
                using (IRandomAccessStream fileStream = await rfile.OpenAsync(Windows.Storage.FileAccessMode.Read))
                {
                    // Set the image source to the selected bitmap
                    BitmapImage bitmapImage = new BitmapImage();

                    await bitmapImage.SetSourceAsync(fileStream);
                    img.Source = bitmapImage;
                }
            }
            catch (Exception ex)
            {
                //var var_name = new MessageDialog("Unable to load pic");
                //var_name.Commands.Add(new UICommand("OK"));
                //var_name.ShowAsync();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {
            string consumername;
            consumername = user_name.Text.ToString();
            this.Frame.Navigate(typeof(search_page),consumername);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string consumername;
            consumername = user_name.Text.ToString();
            this.Frame.Navigate(typeof(feedback_form),consumername);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string a = user_name.Text.ToString();
            this.Frame.Navigate(typeof(message), a);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string a = user_name.Text.ToString();
            this.Frame.Navigate(typeof(list_of_articles), a);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string a;
            a = user_name.Text.ToString();
            this.Frame.Navigate(typeof(settings), a);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string a = user_name.Text.ToString();
            this.Frame.Navigate(typeof(Event1), a);
        }
    }
}
