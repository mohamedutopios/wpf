using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContextDemo
{
    public class SampleData
    {

        public ObservableCollection<Employee> EmployeeList = new ObservableCollection<Employee>();
        

        public SampleData()
        {
            EmployeeList.Add(new Employee() { Name = "Michel Papin"});
            EmployeeList.Add(new Employee() { Name = "Pierre Poulin" });
            EmployeeList.Add(new Employee() { Name = "Albin Michel" });
            EmployeeList.Add(new Employee() { Name = "Tom Jerry" });
            EmployeeList.Add(new Employee() { Name = "Jim Jones" });
        }


    }
}
