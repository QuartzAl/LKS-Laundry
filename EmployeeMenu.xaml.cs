using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Data.Entity.Core.Objects;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using LKS_Laundry_NET_Framework;

namespace LKS_Laundry
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class EmployeeMenu : Page
    {
        ProgrammingClassDataContext db = new ProgrammingClassDataContext();
        public EmployeeMenu()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IQueryable<Employee> st = from s in db.Employees select s;
            dataGridEmployee.DataContext = st;
            var columns = dataGridEmployee.Columns;
            IQueryable<Job> ss = from s in db.Jobs select s;
            jobs.ItemsSource = ss;
            jobs.DisplayMemberPath = "Name";
            jobs.SelectedValuePath = "Id";

        }

        private void Insert_click(object sender, RoutedEventArgs e)
        {

            Save_button.IsEnabled = true;
            Cancel_button.IsEnabled = true;
            Update_button.IsEnabled = false;
            Delete_button.IsEnabled = false;
            Insert_button.IsEnabled = false;
            EnableFields();
            ClearFields();

        }

        private void ClearFields()
        {
            employeeID.Clear();
            name.Clear();
            email.Clear();
            phoneNumber.Clear();
            dateOfBirth.Text = "";
            address.Clear();
            jobs.Text = "";
            salary.Clear();
            password.Clear();
            confirmPassword.Clear();
        }

        private void EnableFields()
        {
            employeeID.IsEnabled = true;
            name.IsEnabled = true;
            email.IsEnabled = true;
            phoneNumber.IsEnabled = true;
            dateOfBirth.IsEnabled = true;
            address.IsEnabled = true;
            jobs.IsEnabled = true;
            salary.IsEnabled = true;
            password.IsEnabled = true;
            confirmPassword.IsEnabled = true;
        }

        private void Update_click(object sender, RoutedEventArgs e)
        {
            if (dataGridEmployee.SelectedItem is Employee p)
            {
                Save_button.IsEnabled = true;
                Cancel_button.IsEnabled = true;
                Update_button.IsEnabled = false;
                Delete_button.IsEnabled = false;
                Insert_button.IsEnabled = false;
                EnableFields();
            }
            else
            {
                _ = MessageBox.Show("You haven't selected a row in the data yet!");
            }
        }

        private void Delete_click(object sender, RoutedEventArgs e)
        {
            if (dataGridEmployee.SelectedItem is Employee p)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?",
                                    "Delete Record",
                                    MessageBoxButton.YesNo,
                                    MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Employee st = (from s in db.Employees
                                   where s.Id == p.Id
                                   select s).First();
                    db.Employees.DeleteOnSubmit(st);
                    db.SubmitChanges();
                }
            }
            else
            {
                _ = MessageBox.Show("You haven't selected a row in the data yet!");
            }
            Window_Loaded(null, null);
        }

        private void Save_click(object sender, RoutedEventArgs e)
        {
            bool valid = Validate();
            if (valid)
            {
                Employee st = (from s in db.Employees 
                                     where s.Id == int.Parse(employeeID.Text) 
                                     select s).FirstOrDefault();
                if (st == null)
                {
                    st = new Employee { };
                    db.Employees.InsertOnSubmit(st);
                }
                st.Name = name.Text;
                st.Password = password.Password;
                st.Email = email.Text;
                st.Address = address.Text;
                st.PhoneNumber = phoneNumber.Text;
                st.DateOfBirth = DateTime.Parse(dateOfBirth.Text);
                st.IdJob = (int)jobs.SelectedValue;
                st.Salary = decimal.Parse(salary.Text);
                
                db.SubmitChanges();
                _ = MessageBox.Show("Success!");
                
                Window_Loaded(null, null);
                employeeID.Clear();
                name.Clear();
                email.Clear();
                phoneNumber.Clear();
                dateOfBirth.Text = "";
                address.Clear();
                jobs.Text = "";
                salary.Clear();
                password.Clear();
                confirmPassword.Clear();
                Cancel_click(null, null);
            }
        }

        private bool Validate()
        {
            bool IsEmpty = false;
            if (employeeID.Text == "")
            {
                IsEmpty = true;
            }
            if (name.Text == "")
            {
                IsEmpty = true;
            }
            if (email.Text == "")
            {
                IsEmpty = true;
            }
            if (phoneNumber.Text == "")
            {
                IsEmpty = true;
            }
            if (dateOfBirth.Text == "")
            {
                IsEmpty = true;
            }
            if (address.Text == "")
            {
                IsEmpty = true;
            }
            if (jobs.Text == "")
            {
                IsEmpty = true;
            }
            if (salary.Text == "")
            {
                IsEmpty = true;
            }
            if (password.Password == "")
            {
                IsEmpty = true;
            }
            bool ValidPassword =
                password.Password.Any(c => char.IsLetter(c)) &&
                password.Password.Any(c => char.IsDigit(c)) &&
                password.Password.Any(c => char.IsSymbol(c));

            if (IsEmpty)
            {
                _ = MessageBox.Show("There are Empty Values that need to be filled!");
            }
            else if (confirmPassword.Password != password.Password)
            {
                _ = MessageBox.Show("Password and confirm password aren't the same!");
            }
            else if (!email.Text.Contains("@"))
            {
                _ = MessageBox.Show("Not a valid email adress!");
            }
            else if (ValidPassword)
            {
                _ = MessageBox.Show("Password needs to contain at least one letter, one number, and a symbol");
            }
            else if (!phoneNumber.Text.StartsWith("+"))
            {
                _ = MessageBox.Show("Phone number must start with '+'");
            }
            else
            {
                return true;
            }
            return false;
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            Save_button.IsEnabled = false;
            Cancel_button.IsEnabled = false;
            Update_button.IsEnabled = true;
            Delete_button.IsEnabled = true;
            Insert_button.IsEnabled = true;

            employeeID.IsEnabled = false;
            name.IsEnabled = false;
            email.IsEnabled = false;
            phoneNumber.IsEnabled = false;
            dateOfBirth.IsEnabled = false;
            address.IsEnabled = false;
            jobs.IsEnabled = false;
            salary.IsEnabled = false;
            password.IsEnabled = false;
            confirmPassword.IsEnabled = false;
        }

        private void SalaryPreviewInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text != "")
            {
                IQueryable<Employee> st = from s in db.Employees where s.Name.Contains(textBox.Text) || s.Email.Contains(textBox.Text) || s.PhoneNumber.Contains(textBox.Text) select s;
                dataGridEmployee.DataContext = st;

            }
            else
            {
                Window_Loaded(null, null);
            }
        }

        private void dataGridEmployee_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Employee p = dataGridEmployee.SelectedItem as Employee;
            employeeID.Text = p.Id.ToString();
            name.Text = p.Name;
            email.Text = p.Email;
            phoneNumber.Text = p.PhoneNumber;
            dateOfBirth.Text = p.DateOfBirth.ToString();
            address.Text = p.Address;
            jobs.Text = p.Job.Name;
            salary.Text = p.Salary.ToString();
            password.Password = p.Password;
            confirmPassword.Password = p.Password;
        }
    }
}
