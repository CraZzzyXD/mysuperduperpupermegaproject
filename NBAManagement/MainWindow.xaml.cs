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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NBAManagement
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 1;
        int a = 2;
        int b = 3;
        public MainWindow()
        {
            InitializeComponent();
            CreateDateText.Content = "The current season is 2020-2022, and the NBA already has a history of " + (DateTime.Now.Year - 1946) + " years";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            i--;

            if (i < 1)
            {
                i = 18;
            }

            a--;

            if (a < 1)
            {
                a = 18;
            }

            b--;

            if (b < 1)
            {
                b = 18;
            }

            picHolderOne.Source = new BitmapImage(new Uri(@"images/" + i + ".jpg", UriKind.Relative));
            picHolderTwo.Source = new BitmapImage(new Uri(@"images/" + a + ".jpg", UriKind.Relative));
            picHolderThree.Source = new BitmapImage(new Uri(@"images/" + b + ".jpg", UriKind.Relative));
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            i++;

            if (i > 18)
            {
                i = 1;
            }

            a++;

            if (a > 18)
            {
                a = 1;
            }

            b++;

            if (b > 18)
            {
                b = 1;
            }

            picHolderOne.Source = new BitmapImage(new Uri(@"images/" + i + ".jpg", UriKind.Relative));
            picHolderTwo.Source = new BitmapImage(new Uri(@"images/" + a + ".jpg", UriKind.Relative));
            picHolderThree.Source = new BitmapImage(new Uri(@"images/" + b + ".jpg", UriKind.Relative));
        }

        private void VisitorButton(object sender, RoutedEventArgs e)
        {
            new WindowVisitor().ShowDialog();
            this.Close();
        }

        private void AdminButton(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
