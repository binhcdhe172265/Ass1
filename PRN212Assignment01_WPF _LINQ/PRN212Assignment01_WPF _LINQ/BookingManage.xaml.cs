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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRN212Assignment01_WPF__LINQ
{
    /// <summary>
    /// Interaction logic for BookingManage.xaml
    /// </summary>
    public partial class BookingManage : UserControl
    {
        private FuminiHotelManagementContext context = new FuminiHotelManagementContext();
        public BookingManage()
        {
            InitializeComponent();
            loadBooking();
        }

        private void loadBooking()
        {
            var list = from booking in context.BookingReservations
                       select booking;

            dvgDisplay.ItemsSource = list.ToList();
        }

        private void Button_UpdateClick(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);

            var booking = (from b in context.BookingReservations
                           where b.BookingReservationId == id
                           select b).FirstOrDefault();

            if (booking != null)
            {
                booking.BookingStatus = byte.Parse(txtStatus.Text);

                context.SaveChanges();

                MessageBox.Show("Update successfully!");

                loadBooking();
            }
            else
            {
               
                MessageBox.Show("Booking not found.");
            }
        }
    }
}
