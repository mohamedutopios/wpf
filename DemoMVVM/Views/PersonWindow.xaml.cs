﻿using DemoMVVM.ViewModels;
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

namespace DemoMVVM.View
{

    public partial class PersonWindow : Window
    {
        public PersonWindow()
        {
            PersonViewModel personViewModel = new PersonViewModel();
            DataContext = personViewModel;
            InitializeComponent();
        }


    
        //private void OnDeleteClick(object sender, RoutedEventArgs e)
        //{
        //    if (DataContext is PersonViewModel personViewModel)
        //    {
        //        personViewModel.DeleteSelectedPerson();
        //    }
        //}
    }
}
