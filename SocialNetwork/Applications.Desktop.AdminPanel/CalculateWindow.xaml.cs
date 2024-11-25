using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
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

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для CalculateWindow.xaml
    /// </summary>
    public partial class CalculateWindow : Window
    {
        public CalculateWindow()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            var ex = mainField.Text;
            DataTable dt = new DataTable();
            var result = dt.Compute(ex, string.Empty).ToString();
            mainField.Text = result;
        }


        private void AddValue1(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "1";
        }

        private void AddValue2(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "2";
        }
        private void AddValue3(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "3";
        }
        private void AddValue4(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "4";
        }
        private void AddValue5(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "5";
        }
        private void AddValue6(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "6";
        }
        private void AddValue7(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "7";
        }
        private void AddValue8(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "8";
        }
        private void AddValue9(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "9";
        }
        private void AddValue0(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "0";
        }
        private void AddValueUmn(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "*";
        }
        private void AddValueDel(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "/";
        }
        private void AddValuePlus(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "+";
        }
        private void AddValueMinus(object sender, RoutedEventArgs e)
        {
            mainField.Text = mainField.Text + "-";
        }
        
        private void AddValueReset(object sender, RoutedEventArgs e)
        {
            mainField.Text = "";
        }
    }
      

}
