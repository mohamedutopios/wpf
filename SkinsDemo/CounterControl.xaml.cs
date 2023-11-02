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

namespace SkinsDemo
{
    /// <summary>
    /// Logique d'interaction pour CounterControl.xaml
    /// </summary>
    public partial class CounterControl : UserControl
    {
        public static readonly DependencyProperty CounterValueProperty =
           DependencyProperty.Register(
               "CounterValue",
               typeof(int),
               typeof(CounterControl),
               new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
           );

        public int CounterValue
        {
            get { return (int)GetValue(CounterValueProperty); }
            set { SetValue(CounterValueProperty, value); }
        }

        public CounterControl()
        {
            InitializeComponent();
        }

        private void IncreaseButton_Click(object sender, RoutedEventArgs e)
        {
            CounterValue++;
        }

        private void DecreaseButton_Click(object sender, RoutedEventArgs e)
        {
            CounterValue--;
        }
    }
}
