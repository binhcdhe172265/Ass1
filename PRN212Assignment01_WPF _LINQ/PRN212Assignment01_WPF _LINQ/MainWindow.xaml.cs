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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnLoadCustomer(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new ListCustomer();
        }

        private void btnLoadRoom(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new RoomInfo();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Login loginWindow = new Login();
            loginWindow.Show();
            this.Close();
        }

        private void btnBooking_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Content = new BookingManage();

        }
    }
}
