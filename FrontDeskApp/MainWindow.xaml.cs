using FrontDeskApp.Data;
using FrontDeskApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.VisualBasic.ApplicationServices;
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


namespace FrontDeskApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Assignment4V3Context context = new();
        private readonly LocalView<Room> Rooms;
        private readonly LocalView<Reservation> Reservations;
        private readonly LocalView<AspNetUser> Users;
      //  private readonly LocalView<AppUser> Users;
        private readonly LocalView<Service> Services;


        public MainWindow()
        {
            InitializeComponent();

            Rooms = context.Rooms.Local;
            Reservations = context.Reservations.Local;
            Users = context.AspNetUsers.Local;
            //  var appUsers = context.AspNetUsers.Local.ToList();
            //  Users = new LocalView<AppUser>(appUsers);


            Services = context.Services.Local;

            context.Rooms.Load();
            context.Services.Load();
            context.Reservations.Load();
            context.AspNetUsers.Load();

            allRooms();

        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            context.Rooms.Load();
            context.Reservations.Load();
            context.AspNetUsers.Load();

            MessageBox.Show("");

            allRooms();
            allUser();

        }

        private void allUser()
        {
            context.AspNetUsers.Load();
            var allUsersList= context.AspNetUsers.ToList();

            CustumersList.ItemsSource = allUsersList;
        }



        private void allRooms()
        {
            context.Rooms.Load();
            context.Reservations.Load();
            context.AspNetUsers.Load();
            var filteredList = (from room in Rooms
                                join res in Reservations on room.Id equals res.RoomId into roomReservations
                                from rR in roomReservations.DefaultIfEmpty()
                                join user in Users on rR?.UserId equals user.Id into userReservations
                                from ur in userReservations.DefaultIfEmpty()
                                select new
                                {
                                    RoomNumber = room.RoomNumber,
                                    RoomType = room.RoomType,
                                    NumBeds = room.NumBeds,
                                    Price = room.Price,
                                    AvailableFrom = room.AvailableFrom,
                                    AvailableTo = room.AvailableTo,
                                    Booked = room.Booked,
                                    CustomerFirstName = ur != null ? ur.Email : "",
                                    CustomerLastName = ur != null ? ur.LastName : "",
                                    CheckInDate = rR != null ? rR.CheckInDate : (DateTime?)null

                                }).ToList();
            roomList.ItemsSource = filteredList;

        }

        private void bookingSearchButton_Click(object sender, RoutedEventArgs e)
        {
            context.AspNetUsers.Load();
            var allUsersList = context.AspNetUsers.ToList();

            CustumersList.ItemsSource = allUsersList;
        }

        private void addReservationButton_Click(object sender, RoutedEventArgs e)
        {
            var customerFN= customerFirstNameTextBox.Text;
            var customerLN = customerLastNameTextBoxR.Text;
            var customerEmail = customerEmailTextBox.Text;

            var checkInDate = (DateTime)checkInDatePicker.SelectedDate;
            var checkOutDate = (DateTime)checkOutDatePicker.SelectedDate;

            var roomNumber = int.Parse(roomNumberTextBox.Text);
            var aspNetUserId = "";

            var existingCustomer = context.AspNetUsers.FirstOrDefault(u => u.FirstName == customerFN &&
                                                                           u.LastName == customerLN &&
                                                                           u.Email == customerEmail);
            if (existingCustomer != null)
            {
                aspNetUserId = existingCustomer.Id;
            }
            else
            {
                var newCustomer = new AspNetUser
                { Id = Guid.NewGuid().ToString(),FirstName = customerFN, LastName = customerLN, Email = customerEmail };
                
                context.AspNetUsers.Add(newCustomer);
                context.SaveChanges();

                aspNetUserId = newCustomer.Id;

            }

           
            var room = context.Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (room == null)
            {
               
                addReservationResult.Text = "Room not found.";
                return;
            }

            var newReservation = new Reservation
            {
                RoomId = room.Id,
                UserId = aspNetUserId,
                CheckInDate = checkInDate,
                CheckOutDate = checkOutDate,

            };

            context.Reservations.Add(newReservation);

            room.Booked = true;

            context.SaveChanges();

            addReservationResult.Text = "Reservation added successfully!";

        }

        private void deleteReservationButton_Click(object sender, RoutedEventArgs e)
        {
            var customerLastName = deleteCustomerLastNameTextBox.Text;
            var roomNumber = int.Parse(deleteRoomNumberTextBox.Text);
            var checkinDate = deleteCheckInDatePicker.SelectedDate;

            // Find Reservation by room number, lastname, checkin
            var reservation = context.Reservations
                .Include(r => r.User)
                .Include(r => r.Room)
                .SingleOrDefault(r => r.User.LastName == customerLastName &&
                                      r.Room.RoomNumber == roomNumber &&
                                      r.CheckInDate == checkinDate);

            if (reservation == null)
            {
                deleteReservationResult.Text = "Booking not found.";
                return;
            }

            var room = reservation.Room;
            room.Booked = false;

            context.Reservations.Remove(reservation);
            context.SaveChanges();

            deleteReservationResult.Text = "Booking deleted successfully.";

        }

        private void checkinButton_Click(object sender, RoutedEventArgs e)
        {
            var customerLastName = checkinoutCustomerLastNameTextBox.Text;

            //Find user
            var customer = context.AspNetUsers.FirstOrDefault(c => c.LastName == customerLastName);
            if (customer == null)
            {
                checkinoutStatusTextBlock.Text = "Customer not found.";
                return;
            }

            //Find resvation 
            var reservation = context.Reservations.FirstOrDefault(r => r.UserId == customer.Id);
            if (reservation == null)
            {
                checkinoutStatusTextBlock.Text = "No booking found for customer.";
                return;
            }

            reservation.CheckInDate = DateTime.Now;

            var room = context.Rooms.FirstOrDefault( r => r.Id == reservation.RoomId);
            if (room != null)
            {
                room.Booked = true;
            }
            context.SaveChanges();

            checkinoutStatusTextBlock.Text = "Checked in successfully!";


        }

        private void checkoutButton_Click(object sender, RoutedEventArgs e)
        {
            var customerLastName = checkinoutCustomerLastNameTextBox.Text;

            //Find user
            var customer = context.AspNetUsers.FirstOrDefault(c => c.LastName == customerLastName);
            if (customer == null)
            {
                checkinoutStatusTextBlock.Text = "Customer not found.";
                return;
            }

            //Find resvation 
            var reservation = context.Reservations.FirstOrDefault(r => r.UserId == customer.Id);
            if (reservation == null)
            {
                checkinoutStatusTextBlock.Text = "No booking found for customer.";
                return;
            }

            reservation.CheckOutDate = DateTime.Now;

            var room = context.Rooms.FirstOrDefault(r => r.Id == reservation.RoomId);
            if (room != null)
            {
                room.Booked = false;
            }

            context.SaveChanges();

            checkinoutStatusTextBlock.Text = "Checked out successfully!";
        }

        private void changeRoomButton_Click(object sender, RoutedEventArgs e)
        {
            var customerLastName = changeRoomCLastName.Text;
            var oldRoomNumber = int.Parse(oldRoomNumberTextBox.Text);
            var newRoomNumber = int.Parse(newRoomNumberTextBox.Text);


            var oldRoom = context.Rooms.SingleOrDefault(r => r.RoomNumber == oldRoomNumber);
            if (oldRoom == null)
            {
                MessageBox.Show("Old room not found ");
                return;
            }

            var newRoom = context.Rooms.SingleOrDefault(r => r.RoomNumber == newRoomNumber);
            if (newRoom == null)
            {
                MessageBox.Show("New room not found ");
                return;
            }

            var reservation = context.Reservations.Include(r => r.User)
                .SingleOrDefault(r => r.RoomId == oldRoom.Id && r.User.LastName == customerLastName);
            if (reservation == null)
            {
                MessageBox.Show("Reservation not found ");
                return;
            }

            reservation.Room = newRoom;
            context.SaveChanges();

            roomChangeResult.Text = "Room Changed Sucessfully";
        }

        private void addServiceButton_Click(object sender, RoutedEventArgs e)
        {
 
            int roomNumber;
            try
            {
                roomNumber = int.Parse(serviceRoomNumberTextBox.Text);
            }
            catch (Exception ex)
            {
                serviceFeedbackTextBlock.Text = "Invalid room number.";
                return;
            }

           // string serviceType = serviceTypeTextBox.Text.Trim();
            string description = serviceDescriptionTextBox.Text.Trim();
            string serviceTypeCom = serviceTypeComboBox.Text.Trim();

            var room = context.Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (room == null)
            {
                serviceFeedbackTextBlock.Text = "Room not found.";
                return;
            }

            // Create a new service 
            var newServiceRequest = new Service
            {
                RoomId = room.Id,
                RequestType = serviceTypeCom,
                DateRequested = DateTime.Now,
                Description = description
            };

            context.Services.Add(newServiceRequest);
            context.SaveChanges();

            serviceRequestsDataGrid.ItemsSource = context.Services.ToList();

            serviceFeedbackTextBlock.Text = "Service request added successfully!";

        }

        private void showAllServiceButton_Click(object sender, RoutedEventArgs e)
        {
            serviceRequestsDataGrid.ItemsSource = context.Services.ToList();
        }
    }
}