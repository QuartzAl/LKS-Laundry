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

namespace LKS_Laundry_NET_Framework
{
    /// <summary>
    /// Interaction logic for Empty.xaml
    /// </summary>
    public partial class Prompt : Window
    {
        public Prompt()
        {
            InitializeComponent();
        }

        private void Ok_click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
