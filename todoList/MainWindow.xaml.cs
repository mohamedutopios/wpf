using Microsoft.VisualBasic;
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
using todoList.Model;
using Task = todoList.Model.Task;

namespace todoList
{
    public partial class MainWindow : Window
    {
        
        ObservableCollection<Task> tasks = new ObservableCollection<Task>();

       
        public MainWindow()
        {
            InitializeComponent();
            taskListView.ItemsSource = tasks;
        }

        
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            Task newTask = new Task() { Description = taskTextBox.Text, Status = "Non complété" };
            tasks.Add(newTask);
        }

       
        private void UpdateTask_Click(object sender, RoutedEventArgs e)
        {
            if (taskListView.SelectedIndex != -1)
            {
                Task selectedTask = (Task)taskListView.SelectedItem;
                selectedTask.Status = "Complété";
            }
        }

        
        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {   
            if (taskListView.SelectedIndex != -1)
            { 
                Task selectedTask = (Task)taskListView.SelectedItem;  
                tasks.Remove(selectedTask);
            }
        }
    }
}
