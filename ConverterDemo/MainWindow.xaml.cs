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

namespace ConverterDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }
        private void ThemeSelect_Checked(object sender, RoutedEventArgs e)
        {
            DarkModeTextBlock.Visibility = Visibility.Visible;
            LightModeTextBlock.Visibility = Visibility.Collapsed;
        }

        private void ThemeSelect_Unchecked(object sender, RoutedEventArgs e)
        {
            DarkModeTextBlock.Visibility = Visibility.Collapsed;
            LightModeTextBlock.Visibility = Visibility.Visible;
        }

    }
}
