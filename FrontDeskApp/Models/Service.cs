using System;
using System.Collections.Generic;

namespace FrontDeskApp.Models;

public partial class Service
{
    public int Id { get; set; }

    public string RequestType { get; set; } = null!;

    public DateTime DateRequested { get; set; }

    public string Description { get; set; } = null!;

    public DateTime? DateCompleted { get; set; }

    public int RoomId { get; set; }

    public virtual Room Room { get; set; } = null!;
}
