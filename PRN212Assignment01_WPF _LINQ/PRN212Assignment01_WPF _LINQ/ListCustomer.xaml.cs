using Microsoft.EntityFrameworkCore;
using PRN212Assignment01_WPF__LINQ.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PRN212Assignment01_WPF__LINQ
{
    /// <summary>
    /// Interaction logic for ListCustomer.xaml
    /// </summary>
    public partial class ListCustomer : UserControl
    {
        private FuminiHotelManagementContext dbContext = new FuminiHotelManagementContext();

        public ListCustomer()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            // Using LINQ to fetch the list of customers
            var customerList = (from c in dbContext.Customers
                                select c).ToList();

            // Bind the fetched data to the DataGrid
            dvgDisplay.ItemsSource = customerList;
        }

        private void Button_InsertClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var newCustomer = new Customer
                {
                    CustomerFullName = txtName.Text,
                    Telephone = txtPhone.Text,
                    EmailAddress = txtEmail.Text,
                    CustomerBirthday = DateOnly.Parse(dpkDob.Text),
                    CustomerStatus = byte.Parse(txtStatus.Text),
                    Password = txtPassword.Text
                };

                // Using LINQ to add the new customer and save changes
                dbContext.Customers.Add(newCustomer);
                dbContext.SaveChanges();

                MessageBox.Show("Customer added successfully.");
                LoadCustomers();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Database update error: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting customer: {ex.Message}");
            }
        }

        private void Button_UpdateClick(object sender, RoutedEventArgs e)
        {
            if (dvgDisplay.SelectedItem != null)
            {
                try
                {
                    var selectedCustomer = (Customer)dvgDisplay.SelectedItem;

                    // Using LINQ to find the customer to update
                    var customerToUpdate = dbContext.Customers
                                                     .FirstOrDefault(c => c.CustomerId == selectedCustomer.CustomerId);

                    if (customerToUpdate != null)
                    {
                        customerToUpdate.CustomerFullName = txtName.Text;
                        customerToUpdate.Telephone = txtPhone.Text;
                        customerToUpdate.EmailAddress = txtEmail.Text;
                        customerToUpdate.CustomerBirthday = DateOnly.Parse(dpkDob.Text);
                        customerToUpdate.CustomerStatus = byte.Parse(txtStatus.Text);
                        customerToUpdate.Password = txtPassword.Text;

                        dbContext.SaveChanges();
                        MessageBox.Show("Customer information updated successfully.");
                        LoadCustomers();
                    }
                    else
                    {
                        MessageBox.Show("Customer not found in the database.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating customer: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to update.");
            }
        }

        private void Button_DeleteClick(object sender, RoutedEventArgs e)
        {
            if (dvgDisplay.SelectedItem != null)
            {
                try
                {
                    var selectedCustomer = (Customer)dvgDisplay.SelectedItem;

                    // Check if there are any bookings associated with the customer
                    var hasBookings = dbContext.BookingReservations
                                               .Any(br => br.CustomerId == selectedCustomer.CustomerId);

                    if (!hasBookings)
                    {
                        var customerToDelete = dbContext.Customers
                                                        .FirstOrDefault(c => c.CustomerId == selectedCustomer.CustomerId);

                        if (customerToDelete != null)
                        {
                            dbContext.Customers.Remove(customerToDelete);
                            dbContext.SaveChanges();
                            MessageBox.Show("Customer deleted successfully.");
                            LoadCustomers();
                        }
                        else
                        {
                            MessageBox.Show("Customer not found in the database.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete customer because there are associated bookings.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting customer: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }
    }
}
