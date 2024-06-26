﻿using System.ComponentModel.DataAnnotations;

namespace Assignment4V3.Models
{
    public partial class Room
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }

        [Required]
        [Display(Name = "Room Type")]
        public string? RoomType { get; set; }

        [Required]
        [Display(Name = "Number of Beds")]
        public int NumBeds { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Available From")]
        public DateTime AvailableFrom { get; set; }

        [Required]
        [Display(Name = "Available To")]
        public DateTime AvailableTo { get; set; }

        [Required]
        public bool Booked { get; set; }

        public ICollection<ServiceTask>? ServiceTasks { get; set; }
    }
}

