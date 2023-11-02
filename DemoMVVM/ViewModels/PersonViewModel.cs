using DemoMVVM.Models;
using DemoMVVM.Repositories;
using DemoMVVM.Tools;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.ViewModels
{
    public class PersonViewModel : ViewModelBase
    {
        private string nom;
        private string prenom;
        private ObservableCollection<Person> personnes;
        private Person selectedPerson;
        private PersonRepository personRepository;
        public RelayCommand CommandAjouterPersonne {  get; set; }
        public RelayCommand CommandDeletePersonne { get; set; }
        public string Nom {  get { return nom; } set {  nom = value; RaisePropertyChanged(); } }
        public string Prenom { get { return prenom; } set {  prenom = value; RaisePropertyChanged(); } }
        public ObservableCollection<Person> Personnes { get {  return personnes; } set {  personnes = value;} }

        public Person SelectedPerson { get { return selectedPerson; }
            set { selectedPerson = value;
            if(SelectedPerson != null)
                {
                    Nom = selectedPerson.LastName;
                    Prenom = selectedPerson.FirstName;
                }
            
            } 
        }
    
        public PersonViewModel()
        {
            personRepository = new PersonRepository(Connection.GetMySqlConnection());
            Personnes = new ObservableCollection<Person>(personRepository.FindAll());
            CommandAjouterPersonne = new RelayCommand(ClickValidPerson);
            CommandDeletePersonne = new RelayCommand(DeleteSelectedPerson);
        }

        public void ClickValidPerson()
        {
            if(SelectedPerson == null)
            {
                Person p = new Person()
                {
                    FirstName = Prenom,
                    LastName = Nom
                };
                personRepository.Create(p);
                Personnes.Add(p);
            }
            else
            {
                SelectedPerson.LastName = Nom;
                SelectedPerson.FirstName = Prenom;

                SelectedPerson = null;
                Nom = null;
                Prenom = null;

            }
        }

       public void DeleteSelectedPerson()
        {
            if (SelectedPerson != null)
            {
               personRepository.Delete(SelectedPerson);
               Personnes.Remove(SelectedPerson);

                SelectedPerson = null;
                Nom = null;
                Prenom = null;

            }

        }



    }
}
