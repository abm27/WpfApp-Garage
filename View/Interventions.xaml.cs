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

namespace WpfApp_Garage.View
{
    /// <summary>
    /// Logique d'interaction pour Interventions.xaml
    /// </summary>
    public partial class Interventions : Window
    {
        public Interventions()
        {
            InitializeComponent();
        }

        private void dataGridInterventions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
