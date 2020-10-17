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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project02_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            resultLabel.Content = "33";

        }

        private void acLabel_Click(object sender, RoutedEventArgs e)
        {
            if(resultLabel.Content != "0")
            {
                resultLabel.Content = "0";
            }
        }

        private void sevenLabel_Click(object sender, RoutedEventArgs e)
        {
            if (sevenLabel.Content != "0")
            {
                resultLabel.Content = $"{resultLabel.Content}7";
            }
            else
            {
                resultLabel.Content = "7";
            }
        }
    }
}
