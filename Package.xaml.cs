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
    /// Interaction logic for Package.xaml
    /// </summary>
    public partial class Package : Page
    {
        public Package()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Insert_click(object sender, RoutedEventArgs e)
        {

        }

        private void Update_click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_click(object sender, RoutedEventArgs e)
        {

        }

        private void Save_click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {

        }

        private void TotalPreviewInput(object sender, TextCompositionEventArgs e)
        {
            Regex ex = new Regex("[^0-9]+");
            e.Handled = ex.IsMatch(e.Text);
        }

        private void PricePreviewInput(object sender, TextCompositionEventArgs e)
        {
            Regex ex = new Regex("[^0-9]+");
            e.Handled = ex.IsMatch(e.Text);
        }
    }
}
