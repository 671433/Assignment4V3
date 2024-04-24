namespace Assignment4V3.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public AppUser? User { get; set; }
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }


    }
}
