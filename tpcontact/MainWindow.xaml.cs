using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace tpcontact
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Contact> Contacts { get; set; } = new ObservableCollection<Contact>();

        public MainWindow()
        {
            InitializeComponent();
            ContactsListView.ItemsSource = Contacts;
        }

        private void OnAddClick(object sender, RoutedEventArgs e)
        {
            var contact = new Contact
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text,
                Type = (TypeComboBox.SelectedItem as ComboBoxItem).Content.ToString()
            };

            Contacts.Add(contact);
            ClearInputs();
        }

        private void OnDeleteClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.DataContext is Contact contact)
            {
                Contacts.Remove(contact);
            }
        }

        private void ClearInputs()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            TypeComboBox.SelectedIndex = -1;
        }
    }
}
