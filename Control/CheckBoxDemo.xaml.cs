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
    /// Logique d'interaction pour CheckBoxDemo.xaml
    /// </summary>
    public partial class CheckBoxDemo : Window
    {
        public CheckBoxDemo()
        {
            InitializeComponent();
        }

        private void cbChoc_Checked(object sender, RoutedEventArgs e)
        {
            label1.Content = "Supplement chocolat selectionnée";
        }

        private void cbChoc_UnChecked(object sender, RoutedEventArgs e)
        {
            label1.Content = "";
        }

        private void cbSugar_Checked(object sender, RoutedEventArgs e)
        {
            label2.Content = "Pas de sucre";
        }

        private void cbSugar_UnChecked(object sender, RoutedEventArgs e)
        {
            label2.Content = "";
        }
    }
}
