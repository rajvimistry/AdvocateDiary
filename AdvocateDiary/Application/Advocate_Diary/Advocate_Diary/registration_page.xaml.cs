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
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Advocate_Diary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class registration_page : Page
    {
        public registration_page()
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
        }

        private void question_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                //ComboBoxItem cb = new ComboBoxItem();
                ////string a = cb.Content.ToString();

                //cb = (ComboBoxItem)question.SelectedItem;

                string uname = t3.Text.ToString();
                bool r = true;
                var db = new SQLite.SQLiteConnection(App.DBPath);

                var emptab = (db.Table<registration>().Where(em => em.username == t3.Text)).FirstOrDefault();
                if (emptab != null)
                {
                    r = true;
                }

                if (emptab == null)
                {
                    r = false;
                }

                if (r == true)
                {
                    var var_name = new MessageDialog("This username is already exist.\n Please choose another one.");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();
                }

                    if (r == false)
                    {
                        ComboBoxItem cb = new ComboBoxItem();
                        cb = (ComboBoxItem)question.SelectedItem;

                        registration rg = new registration();
                        //lawyer lw = new lawyer();
                        //lw.username = t3.Text;
                        rg.first_name = t1.Text;
                        rg.last_name = t2.Text;
                        rg.username = t3.Text;
                        rg.contactno = t4.Text;
                        rg.emailid = t5.Text;
                        //    rg.id = Convert.ToInt32(t6.Text);
                        rg.password = p1.Password;
                        rg.confirm_password = p2.Password;
                        rg.seq_qes = cb.Content.ToString();
                        rg.answer = t9.Text;
                        if (lawyer.IsChecked == true)
                        {
                            rg.type = "lawyer";
                        }
                        else if (consumer.IsChecked == true)
                        {
                            rg.type = "consumer";
                        }

                        db.Insert(rg);
                        var var_name = new MessageDialog("Registered Successfully");
                        var_name.Commands.Add(new UICommand("OK"));
                        var_name.ShowAsync();

                        t1.Text = "";
                        t2.Text = "";
                        t3.Text = "";
                        t4.Text = "";
                        t5.Text = "";
                        //t7.Text = "";
                        //t8.Text = "";
                        t9.Text = "";
                        p1.Password = "";
                        p2.Password = "";

                        // l1.Text = "Data Inserted Sucessfully";
                }
            }
            catch (Exception ex)
            {
                //t1.Text = ex.Message;
                var var_name = new MessageDialog("Insert all the details");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void lawyer_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void consumer_Checked(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            //t7.Text = "";
            //t8.Text = "";
            t9.Text = "";
            p1.Password = "";
            p2.Password = "";
        }

        private void t9_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (p1.Password != p2.Password)
            {
                var z = new MessageDialog("Password does not match");
                z.Commands.Add(new UICommand("OK"));
                z.ShowAsync();
            }
        }
    }
}