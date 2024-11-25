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

namespace Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            string username = Login.Text;
            string password = Password.Text;

            if (username == "admin" && password == "admin")
            {
                var window = new CalculateWindow();
                window.Title = "КАЛЬКУЛЯТОР";
                window.Owner = this;
                window.Show();
            }
            else if (username == null || password == null) 
            {
                Login.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                MessageBox.Show("Введите логин и пароль!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            else if (username != "admin" && password != "admin")
            {
                Login.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
                MessageBox.Show("Проверьте правильность ввода логина и пароля!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

        }
    }
}
