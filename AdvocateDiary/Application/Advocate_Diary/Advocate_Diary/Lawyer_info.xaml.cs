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
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Advocate_Diary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Lawyer_info : Page
    {
        public Lawyer_info()
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
            passvalue pv = (passvalue)e.Parameter;
            tbl3.Text = pv.lawyername;
            tbl.Text = pv.username;

            string a = tbl3.Text;

            var db = new SQLite.SQLiteConnection(App.DBPath);
            var emptab = (db.Table<lawyer>().Where(em => em.username == a)).Single();
            try
            {
                StorageFile rfile = await ApplicationData.Current.LocalFolder.GetFileAsync(emptab.username + ".jpg");
                using (IRandomAccessStream fileStream = await rfile.OpenAsync(Windows.Storage.FileAccessMode.Read))
                {
                    // Set the image source to the selected bitmap
                    BitmapImage bitmapImage = new BitmapImage();

                    await bitmapImage.SetSourceAsync(fileStream);
                    Show_image.Source = bitmapImage;
                }
            }
            catch (Exception ex)
            {
                var var_name = new MessageDialog("Unable to load pic");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }

            //string s1 = "ms:appx///" + emptab.image;
            //string s1 = emptab.image;

            tbl2.Text = emptab.working_field;
            tbl5.Text = emptab.exp;
            tbl7.Text = emptab.about;
            tbl8.Text = emptab.contactno;
            tbl9.Text = emptab.email;
            tbl10.Text = emptab.location;
            //Show_image.Source = new BitmapImage(new Uri(s1, UriKind.RelativeOrAbsolute));

            //BitmapImage image = new BitmapImage();
            //image.SetSource(s1);
            
            //txtImg1.Text = emptab.image.ToString();

            //StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri(("ms-appx:///" + emptab.image),UriKind.RelativeOrAbsolute));
            //using (IRandomAccessStream filestream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
            //{
            //    BitmapImage image = new BitmapImage();
            //    image.SetSource(filestream);
            //    Show_image.Source = image;
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string lawyername;
            lawyername = tbl.Text;
            this.Frame.Navigate(typeof(search_page),lawyername);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string username1 = tbl.Text;
            var db = new SQLite.SQLiteConnection(App.DBPath);
            var emptab = (db.Table<registration>().Where(em => em.username == username1)).Single();
            if (emptab.type == "lawyer")
            {
                string a = tbl.Text.ToString();
                this.Frame.Navigate(typeof(lawyer_homepage), a);
            }
            else if (emptab.type == "consumer")
            {
                string a = tbl.Text.ToString();
                this.Frame.Navigate(typeof(consumer_homepage), a);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string a = tbl.Text;
            this.Frame.Navigate(typeof(message), a);
        }
    }
}
