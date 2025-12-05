using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleWpfEventApp
{
    /// <summary>
    /// Interaction logic for WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindow()
        {
            InitializeComponent();


            btnClickMe.Click += Handler1;
            btnClickMe.Click += Handler2;
            btnClickMe.Click += Handler2;
            btnClickMe.Click -= Handler2;

        }

        //void RoutedEventHandler(object sender, RoutedEventArgs e);
        void Handler1(object sender, RoutedEventArgs e) {

            MessageBox.Show("God is listening...!!");
        }

        void Handler2(object sender, RoutedEventArgs e) {
            MessageBox.Show("Devil is listening..!!");
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WelcomeWindow welcomeWindow = new WelcomeWindow();
            welcomeWindow.Show();
        }
    }
}
