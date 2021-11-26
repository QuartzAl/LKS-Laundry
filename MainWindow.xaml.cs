using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using LKS_Laundry_NET_Framework;

namespace LKS_Laundry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProgrammingClassDataContext db = new ProgrammingClassDataContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_click(object sender, RoutedEventArgs e)
        {
            Employee st = (from s in db.Employees
                           where s.Email == txtUsername.Text
                           select s).FirstOrDefault();
            if (st != null && txtPassword.Password == st.Password)
            {
                MainMenu window = new MainMenu(st.Name);
                window.Show();
                Close();
            }
            else
            {
                _ = MessageBox.Show("Password or Email incorrect!");
            }

        }


    }
}

