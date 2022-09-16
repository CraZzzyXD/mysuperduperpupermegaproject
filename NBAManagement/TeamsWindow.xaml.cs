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
    /// Логика взаимодействия для TeamsWindow.xaml
    /// </summary>
    public partial class TeamsWindow : Window
    {
        public TeamsWindow()
        {
            InitializeComponent();
        }
        private void BackToMainWindow(object sender, RoutedEventArgs e)
        {
            new MainWindow().ShowDialog();
            this.Close();
        }
    }
}
