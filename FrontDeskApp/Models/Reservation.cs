using System;
using System.Collections.Generic;

namespace FrontDeskApp.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int RoomId { get; set; }

    public DateTime CheckInDate { get; set; }

    public DateTime CheckOutDate { get; set; }

    public virtual Room Room { get; set; } = null!;

    public virtual AspNetUser? User { get; set; }
}
