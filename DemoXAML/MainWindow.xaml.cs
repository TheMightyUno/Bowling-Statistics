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

namespace DemoXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string yourNameOutput;
        double mathNumber1;
        double mathNumber2;
        double mathFinaleAnswer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            yourNameOutput = yourName.Text;
            changeMe.Text = yourNameOutput;

            mathNumber1 = double.Parse(number1.Text);
            mathNumber2 = double.Parse(number2.Text);
            mathFinaleAnswer = mathNumber1 + mathNumber2;

            mathAnswer.Text = Convert.ToString(mathFinaleAnswer);

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            changeMe.Text = "";
            yourName.Text = "";
            yourName.Text = "";
            .Text = "";
            mathAnswer.Text = "";
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
