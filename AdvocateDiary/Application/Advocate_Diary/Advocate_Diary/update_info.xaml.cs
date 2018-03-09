using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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
using Windows.Storage.Pickers;
using Windows.Networking.BackgroundTransfer;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Advocate_Diary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class update_info : Page
    {
        public update_info()
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
            var name = e.Parameter.ToString();
            txt1.Text = name.ToString();
            string a = txt1.Text;

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
                    displayImage.Source = bitmapImage;
                }
            }
            catch (Exception ex)
            {
                //var var_name = new MessageDialog("Unable to load pic");
                //var_name.Commands.Add(new UICommand("OK"));
                //var_name.ShowAsync();
            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
                string a = txt1.Text;
                var db = new SQLite.SQLiteConnection(App.DBPath);
                lawyer lw = new lawyer();
                var d1 = (db.Table<lawyer>().Where(em => em.username == a)).SingleOrDefault();
                bool r = true;
                if (d1 != null)
                {
                    r = false;
                }
                if (d1 == null)
                {
                    r = true;
                }
            
            if (r == false)
            {
                //string a = txt1.Text;
                //var db = new SQLite.SQLiteConnection(App.DBPath);
                //lawyer lw = new lawyer();
                //var d1 = (db.Table<lawyer>().Where(em => em.username == a)).Single();
                lw.username = txt1.Text;
                lw.working_field = txt2.Text;
                lw.exp = txt3.Text;
                lw.about = txt4.Text;
                lw.location = txt5.Text;
                lw.contactno = txt6.Text;
                lw.email = txt7.Text;
                lw.image = txtPath.Text;
                db.Update(lw);
                tbl1.Text = "Information Updated Successfully";
            }

            if (r == true)
            {
                //var db = new SQLite.SQLiteConnection(App.DBPath);
                //lawyer lw = new lawyer();


                lw.username = txt1.Text;
                lw.working_field = txt2.Text;
                lw.exp = txt3.Text;
                lw.about = txt4.Text;
                lw.location = txt5.Text;
                lw.contactno = txt6.Text;
                lw.email = txt7.Text;
                lw.image = txtPath.Text;
                //string a = txt1.Text;
                //var db = new SQLite.SQLiteConnection(App.DBPath);
                //var d1 = (db.Table<lawyer>().Where(em => em.username == a)).Single();

                //var targetFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(d1.username + ".jpg");
                //if (targetFile != null)
                //{
                //    await file.MoveAndReplaceAsync(targetFile);
                //}
                db.InsertOrReplace(lw);
                tbl1.Text = "Information Added Successfully";
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            string username = txt1.Text;
            var db = new SQLite.SQLiteConnection(App.DBPath);
            var emptab = (db.Table<registration>().Where(em => em.username == username)).Single();
            if (emptab.type == "lawyer")
            {
                string a = txt1.Text.ToString();
                this.Frame.Navigate(typeof(lawyer_homepage), a);
            }
            else if (emptab.type == "consumer")
            {
                string a = txt1.Text.ToString();
                this.Frame.Navigate(typeof(consumer_homepage), a);
            }

            //string username;
            //username = txt1.Text.ToString();
            //this.Frame.Navigate(typeof(lawyer_homepage), username);
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            

            Windows.Storage.Pickers.FileOpenPicker openPicker = new Windows.Storage.Pickers.FileOpenPicker();
            openPicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            openPicker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;

            // Filter to include a sample subset of file types.
            openPicker.FileTypeFilter.Clear();
            openPicker.FileTypeFilter.Add(".bmp");
            openPicker.FileTypeFilter.Add(".png");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".jpg");

            // Open the file picker.
            Windows.Storage.StorageFile file = await openPicker.PickSingleFileAsync();

            // file is null if user cancels the file picker.
            if (file != null)
            {
                // Open a stream for the selected file.
                Windows.Storage.Streams.IRandomAccessStream fileStream =
                    await file.OpenAsync(Windows.Storage.FileAccessMode.Read);

                // Set the image source to the selected bitmap.
                Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage =
                    new Windows.UI.Xaml.Media.Imaging.BitmapImage();

                bitmapImage.SetSource(fileStream);
                displayImage.Source = bitmapImage;

                this.DataContext = file;
            }

            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                var emptab = (db.Table<lawyer>().Where(em => em.username == txt1.Text)).Single();

                var targetFile = await ApplicationData.Current.LocalFolder.CreateFileAsync(emptab.username + ".jpg");
                if (targetFile != null)
                {
                    //await file.MoveAndReplaceAsync(targetFile);
                    await file.CopyAndReplaceAsync(targetFile);
                }
            }
            catch (Exception ex)
            {
                var var_name = new MessageDialog("Unable to update profile picture\nPlease try after sometime.");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }

           // await file.CopyAsync(ApplicationData.Current.LocalFolder);
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
