using System;
using System.Collections.Generic;

namespace Staffapp.Models;

public partial class Room
{
    public int Id { get; set; }

    public int RoomNumber { get; set; }

    public string RoomType { get; set; } = null!;

    public int NumBeds { get; set; }

    public decimal Price { get; set; }

    public DateTime AvailableFrom { get; set; }

    public DateTime AvailableTo { get; set; }

    public bool Booked { get; set; }

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
