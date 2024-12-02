using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Win32;
using PRN212Assignment01_WPF__LINQ.Models;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRN212Assignment01_WPF__LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly FuminiHotelManagementContext dbContext;
        private readonly IConfiguration configuration;
        private readonly string adminEmail;
        private readonly string adminPassword;

        public Login()
        {
            InitializeComponent();

            dbContext = new FuminiHotelManagementContext();

            configuration = LoadConfiguration();
            adminEmail = configuration["admincredentials:email"];
            adminPassword = configuration["admincredentials:password"];
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password;

            if (email == adminEmail && password == adminPassword)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                var user = IsValidUser(email, password);
                if (user != null)
                {
                    CustomerInfo customerViewInfo = new CustomerInfo(user.CustomerId);
                    customerViewInfo.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.");
                }
            }
        }

        private Customer IsValidUser(string email, string password)
        {
            return dbContext.Customers.FirstOrDefault(c => c.EmailAddress == email && c.Password == password);
        }

        private IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            return builder.Build();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }
    }
}