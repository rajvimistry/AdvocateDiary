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
    public sealed partial class search_page_consumer : Page
    {
        public search_page_consumer()
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
            consumer_name.Text = name.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string consumername;
            consumername = consumer_name.Text.ToString();
            this.Frame.Navigate(typeof(consumer_homepage),consumername);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string lawyername;
            lawyername = TextBox1.Text;
            this.Frame.Navigate(typeof(Lawyer_info), lawyername);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
