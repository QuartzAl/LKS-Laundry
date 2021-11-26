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

namespace LKS_Laundry
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu(string User)
        {
            InitializeComponent();
            MainFrame.Content = new Welcome();
            DateTime now = DateTime.Now;
            DateLabel.Content = now.ToString("dddd, d MMMM yyyy");
            HelloUser.Content = "Hello, " + User;
        }

        private void Employee_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new EmployeeMenu();
        }

        private void Service_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Service();
        }

        private void Package_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Package();
        }

        private void Deposit_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new TransactionDeposit();
        }

        private void Transaction_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new TransactionDeposit();
        }

        private void MainMenu_click(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Content = new Welcome();
        }

        private void PrepaidPakcage_click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new PrepaidPackage();
        }

        private void Logout_click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
