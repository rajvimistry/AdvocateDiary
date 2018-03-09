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
    public sealed partial class add_client_detail : Page
    {
        public add_client_detail()
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
            tbl.Text = name.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                client_details cd = new client_details();

                cd.lawyername = tbl.Text;
                cd.clientname = TextBox1.Text;
                cd.address = TextBox2.Text;
                cd.contact = TextBox3.Text;
                cd.email = TextBox4.Text;
                cd.remark = TextBox5.Text;
                cd.case_details = TextBox6.Text;

                db.Insert(cd);
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";

                var var_name = new MessageDialog("Data Inserted Successfully");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }
            catch (Exception ex)
            {
                TextBox1.Text = ex.Message;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string a;
            a = tbl.Text;
            this.Frame.Navigate(typeof(lawyer_homepage), a);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string a;
            a = tbl.Text;
            this.Frame.Navigate(typeof(client_info), a);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new SQLite.SQLiteConnection(App.DBPath);
                string rid = TextBox1.Text;
                var stu = (db.Table<client_details>().Where(c => c.clientname == rid)).Single();

                if (stu != null)
                {
                    stu.clientname = TextBox1.Text;
                    stu.clientname = TextBox1.Text;
                    stu.address = TextBox2.Text;
                    stu.contact = TextBox3.Text;
                    stu.email = TextBox4.Text;
                    stu.remark = TextBox5.Text;
                    stu.case_details = TextBox6.Text;

                    db.Update(stu);
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";

                    var var_name = new MessageDialog("Data Updated Successfully");
                    var_name.Commands.Add(new UICommand("OK"));
                    var_name.ShowAsync();

                }
            }
            catch (Exception ex)
            {
                var var_name = new MessageDialog("Unable to update ! Make sure entered client name is in correct form.");
                var_name.Commands.Add(new UICommand("OK"));
                var_name.ShowAsync();
            }

            //l1.ItemsSource = db.Table<client_details>();
        }
    }
}