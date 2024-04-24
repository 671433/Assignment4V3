using Microsoft.AspNetCore.Identity;

namespace Assignment4V3.Models
{
    public class AppUser : IdentityUser
    {


        public override string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public virtual ICollection<Reservation>? Resrvations { get; set; }
    }
}
