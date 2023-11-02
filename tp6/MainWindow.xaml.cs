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

namespace tp6
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSubmitButtonClick(object sender, RoutedEventArgs e)
        {
            bool isEmailValid = (bool)(new EmailValidationConverter().Convert(emailTextBox.Text, null, null, null));

            if (string.IsNullOrWhiteSpace(nameTextBox.Text) && isEmailValid)
            {
                validationLabel.Content = "Le nom est obligatoire!";
            }
            else if (!isEmailValid && !string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                validationLabel.Content = "L'email est invalide!";

            } else if (string.IsNullOrWhiteSpace(nameTextBox.Text) && !isEmailValid)
            {
                validationLabel.Content = "Le nom est obligatoire et l'email est invalide!";
            }
            else
            {
                validationLabel.Content = "Inscription réussie!";
                validationLabel.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Green);
            }
        }
    }
}
