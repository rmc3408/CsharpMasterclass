using System.Windows;

namespace Project02_Calculator
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double lastNum;
        private double result;
        public enum OperatorSymbol { Addition, Substraction, Multiplication, Division };
        OperatorSymbol operatorSymbol;

        public MainWindow()
        {
            InitializeComponent();
            resultLabel.Content = "33";

            //instead to call event in xaml
            invertLabel.Click += InvertLabel_Click;
            percentLabel.Click += PercentLabel_Click;
            equalLabel.Click += EqualLabel_Click;
            commaLabel.Click += CommaLabel_Click;

        }

        private void CommaLabel_Click(object sender, RoutedEventArgs e)
        {
            if (!resultLabel.Content.ToString().Contains("."))
            {
                resultLabel.Content = $"{resultLabel.Content.ToString()}.";
            }
        }

        private void EqualLabel_Click(object sender, RoutedEventArgs e)
        {
            double newNum = double.Parse(resultLabel.Content.ToString());
            switch(operatorSymbol)
            {
                case OperatorSymbol.Addition:
                    result = myMath.Add(lastNum, newNum);
                    break;
                case OperatorSymbol.Substraction:
                    result = myMath.Minus(lastNum, newNum);
                    break;
                case OperatorSymbol.Multiplication:
                    result = myMath.Multi(lastNum, newNum);
                    break;
                case OperatorSymbol.Division:
                    result = myMath.Divide(lastNum, newNum);
                    break;
                default:
                    break;
            }
            resultLabel.Content = result.ToString();

        }

        private void PercentLabel_Click(object sender, RoutedEventArgs e)
        {

            double tempNum;
            tempNum = double.Parse(resultLabel.Content.ToString());
            if (tempNum <= 1)
            {
                tempNum = tempNum * 100;
                if (lastNum != 0)
                {
                    tempNum += lastNum;
                }
                resultLabel.Content = tempNum.ToString();
            }
            else
            {
                tempNum = tempNum / 100;
                if (lastNum != 0)
                {
                    tempNum *= lastNum;
                }
                resultLabel.Content = tempNum.ToString();
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
            resultLabel.Content = "0";
            lastNum = 0;
            result = 0;
        }

        private void number_Click(object sender, RoutedEventArgs e)
        {
            int selectedNum = 0;
            if (sender == oneLabel)
                selectedNum = 1;
            if (sender == twoLabel)
                selectedNum = 2;
            if (sender == threeLabel)
                selectedNum = 3;
            if (sender == fourLabel)
                selectedNum = 4;
            if (sender == fiveLabel)
                selectedNum = 5;
            if (sender == sixLabel)
                selectedNum = 6;
            if (sender == sevenLabel)
                selectedNum = 7;
            if (sender == eightLabel)
                selectedNum = 8;
            if (sender == nineLabel)
                selectedNum = 9;

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = selectedNum.ToString();
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedNum.ToString()}";
            }
        }
        private void operation_Click(object sender, RoutedEventArgs e)
        {
            lastNum = double.Parse(resultLabel.Content.ToString());
            resultLabel.Content = "0";

            if (sender == divideLabel)
                operatorSymbol = OperatorSymbol.Division;
            if (sender == multiLabel)
                operatorSymbol = OperatorSymbol.Multiplication;
            if (sender == sumLabel)
                operatorSymbol = OperatorSymbol.Addition;
            if (sender == minusLabel)
                operatorSymbol = OperatorSymbol.Substraction;
        }
    }

    public static class myMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Multi(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Minus(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Divide(double n1, double n2)
        {
            if(n2 == 0)
            {
                MessageBox.Show("cannot divide by zero!", "wrong operation", MessageBoxButton.OK);
                return 0;
            }
            return n1 / n2;
        }

    }

}