namespace Assignment4V3.ModelView
{
    public enum BedOptions
    {
        Single1,
        Single2,
        Single3,
        DoubleSingle,
        Double2,
        KingSize
    }
    public enum RoomQuality
    {
        Economic,
        Business,
        Luxury
    }


    public class RoomViewModel
    {
        public int Id { get; set; }
        public DateTime? Checkin { get; set; }
        public DateTime? Checkout { get; set; }

        public BedOptions BedOption { get; set; }

        public decimal Price { get; set; }

        public int roomSize { get; set; } = 0;

      //  public RoomQuality Quality { get; set; }

        public bool Booked { get; set; }
    }
}
