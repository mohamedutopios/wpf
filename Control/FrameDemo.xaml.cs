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

namespace Control
{
    /// <summary>
    /// Logique d'interaction pour FrameDemo.xaml
    /// </summary>
    public partial class FrameDemo : Window
    {
        public FrameDemo()
        {
            InitializeComponent();
        }

        private void btn_le_bon_coin(object sender, RoutedEventArgs e)
        {
            frame1.Visibility = System.Windows.Visibility.Hidden;
            frame.Visibility = System.Windows.Visibility.Visible;
        }

        private void btn_amazon(object sender, RoutedEventArgs e)
        {
            frame.Visibility = System.Windows.Visibility.Hidden;
            frame1.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
