using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDeskApp.Models
{
    public partial class AppUser : AspNetUser //IdentityUser
    {
        public string Id { get; set; }
        public  string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public virtual ICollection<Reservation>? Resrvations { get; set; }

        //public string ReservationsCount
        //{
        //    get
        //    {
        //        return Reservations != null ? Reservations.Count.ToString() : "0";
        //    }
        //}
    }
}
