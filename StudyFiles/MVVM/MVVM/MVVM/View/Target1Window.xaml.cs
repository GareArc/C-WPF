﻿using System;
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

namespace MVVM.View
{
    /// <summary>
    /// Interaction logic for Target1.xaml
    /// </summary>
    public partial class Target1Window : Window
    {
        private Target1ViewModel mt;
        public Target1Window()
        {
            InitializeComponent();
            mt = new Target1ViewModel(new Action(() => Close()));
            this.DataContext = mt;
        }
    }
}
