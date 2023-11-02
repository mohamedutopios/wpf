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

namespace tp2
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {
            string nom = NomTextBox.Text;
            string prenom = PrenomTextBox.Text;
            DateTime dateNaissance = DateNaissanceDatePicker.SelectedDate ?? DateTime.MinValue;
            int taille = int.Parse(TailleTextBox.Text);
            string adresse = AdresseTextBox.Text;
            string telephone = TelephoneTextBox.Text;
            string email = EmailTextBox.Text;

            ResultatTextBlock.Text = $"Nom: {nom}, Prénom: {prenom}, Date de Naissance: {dateNaissance}, Taille: {taille}, Adresse: {adresse}, Téléphone: {telephone}, Email: {email}";
            ResultatTextBlock.Visibility = Visibility.Visible;
        }
    }
}
