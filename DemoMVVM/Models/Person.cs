using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Models
{
    public class Person: INotifyPropertyChanged
    {
        private int id;
        private string firstName;
        private string lastName;


        public int Id { get => id; set => id = value;  }
        public string FirstName { get => firstName; set { firstName = value; RaisePorpertyChanged("FirstName"); } }
        public string LastName { get => lastName; set { lastName = value; RaisePorpertyChanged("LastName"); } }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePorpertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
