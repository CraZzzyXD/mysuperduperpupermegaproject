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

namespace NBAManagement
{
    /// <summary>
    /// Логика взаимодействия для WindowVisitor.xaml
    /// </summary>
    public partial class WindowVisitor : Window
    {
        public WindowVisitor()
        {
            InitializeComponent();
            CreateDateText.Content = "The current season is 2020-2022, and the NBA already has a history of " + (DateTime.Now.Year - 1946) + " years";
        }

        private void BackToMainWindow(object sender, RoutedEventArgs e)
        {
            new MainWindow().ShowDialog();
            this.Close();
        }
        private void TeamsButton(object sender, RoutedEventArgs e)
        {
            new TeamsWindow().ShowDialog();
            this.Close();
        }
    }
}
