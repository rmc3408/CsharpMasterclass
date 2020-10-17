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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project02_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double lastNum;
        double result;

        public MainWindow()
        {
            InitializeComponent();
            resultLabel.Content = "33";

            //instead to call event in xaml
            invertLabel.Click += InvertLabel_Click;
            percentLabel.Click += PercentLabel_Click;
            equalLabel.Click += EqualLabel_Click;

        }

        private void EqualLabel_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = result.ToString();
        }

        private void PercentLabel_Click(object sender, RoutedEventArgs e)
        {
            lastNum = double.Parse(resultLabel.Content.ToString());
            if (lastNum < 1)
            {
                lastNum = lastNum*100;
                resultLabel.Content = lastNum.ToString();
            }
            else
            {
                lastNum = lastNum / 100;
                resultLabel.Content = lastNum.ToString();
            }
            
        }

        private void InvertLabel_Click(object sender, RoutedEventArgs e)
        {
            lastNum = double.Parse(resultLabel.Content.ToString());
            lastNum = -lastNum;
            resultLabel.Content = lastNum.ToString();
        }

        private void acLabel_Click(object sender, RoutedEventArgs e)
        {
            if(resultLabel.Content.ToString() != "0")
            {
                resultLabel.Content = "0";
            }
        }

        private void sevenLabel_Click(object sender, RoutedEventArgs e)
        {
            if (sevenLabel.Content.ToString() != "0")
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
