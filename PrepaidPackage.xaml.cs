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
using System.Text.RegularExpressions;

namespace LKS_Laundry
{
    /// <summary>
    /// Interaction logic for PrepaidPackage.xaml
    /// </summary>
    public partial class PrepaidPackage : Page
    {
        public PrepaidPackage()
        {
            InitializeComponent();
        }

        private void Submit_click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void PricePreviewInput(object sender, TextCompositionEventArgs e)
        {
            Regex ex = new Regex("[^0-9]+");
            e.Handled = ex.IsMatch(e.Text);
        }

        private void AddCustomer_click(object sender, RoutedEventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }
    }
}
