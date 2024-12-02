using PRN212Assignment01_WPF__LINQ.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PRN212Assignment01_WPF__LINQ
{
    /// <summary>
    /// Interaction logic for CustomerBooking.xaml
    /// </summary>
    public partial class CustomerBooking : Window
    {
        private int customerId;
        public CustomerBooking(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            BookingReservation booking = getBookingReservation();
            if (booking == null) return;

            FuminiHotelManagementContext.Ins.BookingReservations.Add(booking);
            FuminiHotelManagementContext.Ins.SaveChanges();
            MessageBox.Show("Booking Successfully!");
        }

        private BookingReservation getBookingReservation()
        {
            BookingReservation booking = new BookingReservation();
            try
            {
                booking.BookingDate = dpkStartDate.SelectedDate.HasValue ? DateOnly.FromDateTime(dpkStartDate.SelectedDate.Value) : (DateOnly?)null;
                booking.TotalPrice = decimal.TryParse(txtTotalPrice.Text, out decimal price) ? price : (decimal?)null;
                booking.CustomerId = customerId;
                booking.BookingStatus = 1;
                return booking;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return null;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // LINQ query to get RoomTypes from the database
            cbxRoomType.ItemsSource = (from roomType in FuminiHotelManagementContext.Ins.RoomTypes
                                       select roomType).ToList();
        }

        private void cbxRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RoomType roomType = (RoomType)cbxRoomType.SelectedItem;

            // LINQ query to get RoomInformation based on selected RoomType
            cbxRoomNumber.ItemsSource = (from room in FuminiHotelManagementContext.Ins.RoomInformations
                                         where room.RoomTypeId == roomType.RoomTypeId
                                         select room).ToList();
        }

        private void count()
        {
            try
            {
                if (cbxRoomNumber.SelectedItem == null) throw new Exception("Room not selected");

                RoomInformation room = (RoomInformation)cbxRoomNumber.SelectedItem;
                DateTime startDate = dpkStartDate.SelectedDate ?? DateTime.Today;
                DateTime endDate = dpkEndDate.SelectedDate ?? DateTime.Today;

                // Calculate the difference
                TimeSpan difference = endDate - startDate;

                // Access different components of the TimeSpan
                int differenceInDays = (int)difference.TotalDays + 1;

                if (differenceInDays < 0)
                {
                    txtTotalPrice.Text = "Wrong EndDate";
                    return;
                }

                if (room == null) throw new Exception("Room not selected");

                decimal total = (decimal)(differenceInDays * room.RoomPricePerDay);
                txtTotalPrice.Text = total.ToString();
            }
            catch (Exception ex)
            {
                if (txtTotalPrice != null)
                    txtTotalPrice.Text = "Fill Input";
            }
        }

        private void cbxRoomNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            count();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            CustomerInfo customerinfo = new CustomerInfo(customerId);
            customerinfo.Show();
            this.Close();
        }
    }
}
