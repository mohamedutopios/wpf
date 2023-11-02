using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoList.Model
{
    // Cette classe représente un modèle de tâche (Task) qui implémente l'interface INotifyPropertyChanged.
    // Cela déclare une classe publique appelée Task qui implémente l'interface INotifyPropertyChanged.
    // Cela signifie que les objets de cette classe seront capables de notifier lorsqu'une de leurs propriétés change.
    public class Task : INotifyPropertyChanged
    {
        // Cet événement est déclenché lorsqu'une propriété de cette classe change.
        public event PropertyChangedEventHandler PropertyChanged;

        // Déclaration de la propriété 'Description' de type string.
        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                // Lorsque la valeur de 'Description' change, la propriété est mise à jour,
                // et l'événement PropertyChanged est déclenché.
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        // Déclaration de la propriété 'Status' de type string.
        private string status;
        public string Status
        {
            get { return status; }
            set
            {
                // Lorsque la valeur de 'Status' change, la propriété est mise à jour,
                // et l'événement PropertyChanged est déclenché.
                status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        // Cette méthode est appelée lorsqu'une propriété change. Elle déclenche l'événement PropertyChanged.
        protected virtual void OnPropertyChanged(string propertyName)
        {
            // Vérifie si quelqu'un est abonné à l'événement PropertyChanged,
            // et si oui, déclenche l'événement en lui passant le nom de la propriété qui a changé.
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
