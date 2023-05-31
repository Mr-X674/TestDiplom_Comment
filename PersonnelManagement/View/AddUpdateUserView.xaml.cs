﻿using PersonnelManagement.Model;
using PersonnelManagement.ViewModel;
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

namespace PersonnelManagement.View
{
    /// <summary>
    /// Логика взаимодействия для AddUpdateUserView.xaml
    /// </summary>
    public partial class AddUpdateUserView : Window
    {
        public AddUpdateUserView(DataModel data, Users users, string action)
        {
            InitializeComponent();
            AddUpdateUserViewModel model = new AddUpdateUserViewModel(data, users, action);
            this.DataContext = model;

            if (model.Close == null)
                model.Close = new Action(this.Close);
        }
    }
}
