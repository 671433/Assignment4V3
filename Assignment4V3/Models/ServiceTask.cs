namespace Assignment4V3.Models
{
    public partial class ServiceTask
    {
        public int Id { get; set; }
        public string? RequestType { get; set; }
        public DateTime DateRequested { get; set; }
        public string? Description { get; set; }
        public DateTime? DateCompleted { get; set; }

        public int RoomId { get; set; }
        public Room? Room { get; set; }
    }
}
