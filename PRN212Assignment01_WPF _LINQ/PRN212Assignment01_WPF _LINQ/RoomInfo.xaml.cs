using Microsoft.EntityFrameworkCore;
using PRN212Assignment01_WPF__LINQ.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace PRN212Assignment01_WPF__LINQ
{
    /// <summary>
    /// Interaction logic for RoomInfo.xaml
    /// </summary>
    public partial class RoomInfo : UserControl
    {
        public RoomInfo()
        {
            InitializeComponent();
            LoadRoom();
        }

        // Use LINQ to load rooms
        private void LoadRoom()
        {
            using (var context = new FuminiHotelManagementContext())
            {
                // Directly query the RoomInformations table and bind to the DataGrid
                var list = context.RoomInformations.ToList();
                dvgDisplay.ItemsSource = list;
            }
        }

        // Insert a new room with LINQ
        private void Button_InsertClick(object sender, RoutedEventArgs e)
        {
            try
            {
                RoomInformation room = new RoomInformation
                {
                    RoomNumber = txtNumber.Text,
                    RoomDetailDescription = txtDetail.Text,
                    RoomMaxCapacity = int.Parse(txtMaxCapacity.Text),
                    RoomTypeId = int.Parse(txtRoomTypeId.Text),
                    RoomStatus = byte.Parse(txtStatus.Text),
                    RoomPricePerDay = decimal.TryParse(txtPrice.Text, out decimal price) ? price : 0
                };

                // Add the new room using LINQ (no need to call FuminiHotelManagementContext.Ins directly)
                using (var context = new FuminiHotelManagementContext())
                {
                    context.RoomInformations.Add(room);
                    context.SaveChanges();
                }

                MessageBox.Show("Insert room successfully!");
                LoadRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting room: {ex.Message}");
            }
        }

        // Update an existing room using LINQ
        private void Button_UpdateClick(object sender, RoutedEventArgs e)
        {
            var selectedRoom = dvgDisplay.SelectedItem as RoomInformation;
            if (selectedRoom == null)
            {
                MessageBox.Show("Please select a room to update.");
                return;
            }

            using (var context = new FuminiHotelManagementContext())
            {
                var roomToUpdate = context.RoomInformations
                                          .FirstOrDefault(r => r.RoomId == selectedRoom.RoomId);

                if (roomToUpdate == null)
                {
                    MessageBox.Show("Room not found in the database.");
                    return;
                }

                // Update the room details
                roomToUpdate.RoomNumber = txtNumber.Text;
                roomToUpdate.RoomDetailDescription = txtDetail.Text;
                roomToUpdate.RoomMaxCapacity = int.Parse(txtMaxCapacity.Text);
                roomToUpdate.RoomTypeId = int.Parse(txtRoomTypeId.Text);
                roomToUpdate.RoomStatus = byte.Parse(txtStatus.Text);
                roomToUpdate.RoomPricePerDay = decimal.TryParse(txtPrice.Text, out decimal price) ? price : 0;

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Room information updated successfully.");
                    LoadRoom();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating room information: {ex.Message}");
                }
            }
        }

     
        private void Button_DeleteClick(object sender, RoutedEventArgs e)
        {
            var selectedRoom = dvgDisplay.SelectedItem as RoomInformation;
            if (selectedRoom == null)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            using (var context = new FuminiHotelManagementContext())
            {
              
                var deleteRoom = context.RoomInformations
                                        .FirstOrDefault(r => r.RoomId == selectedRoom.RoomId);

                if (deleteRoom != null)
                {
                    context.RoomInformations.Remove(deleteRoom);
                    context.SaveChanges();
                    MessageBox.Show("Delete successfully!");
                    LoadRoom();
                }
                else
                {
                    MessageBox.Show("Room not found.");
                }
            }
        }
    }
}
