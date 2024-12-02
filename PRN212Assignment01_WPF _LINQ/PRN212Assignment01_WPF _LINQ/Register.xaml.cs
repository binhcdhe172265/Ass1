using PRN212Assignment01_WPF__LINQ.Models;
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

namespace PRN212Assignment01_WPF__LINQ
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Save(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerFullName = txtFullName.Text;
            customer.Telephone = txtTelephone.Text;
            customer.EmailAddress = txtEmailAddress.Text;
            customer.CustomerBirthday = DateOnly.Parse(dpkDate.Text);
            customer.CustomerStatus = 1;

            try
            {
                if (txtPassword.Text.Equals(txtConfirmPassword.Text))
                {
                    customer.Password = txtConfirmPassword.Text;
                    FuminiHotelManagementContext.Ins.Customers.Add(customer);
                    FuminiHotelManagementContext.Ins.SaveChanges();
                    MessageBox.Show("Register Successfully");
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords do not match!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
    }
}
