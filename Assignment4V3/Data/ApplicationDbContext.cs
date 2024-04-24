using Assignment4V3.Models;
using Assignment4V3.ModelView;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;

namespace Assignment4V3.Data
{
      public class ApplicationDbContext : IdentityDbContext<AppUser>
  // public partial class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppUser> Users { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ServiceTask> Services { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<RoomViewModel>();

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.Property(e => e.Email).IsRequired().HasMaxLength(250);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.RoomNumber).IsRequired();
                entity.Property(e => e.RoomType).IsRequired().HasMaxLength(50);
                entity.Property(e => e.NumBeds).IsRequired();
                entity.Property(e => e.Price).IsRequired().HasColumnType("decimal(18,2)");
                entity.Property(e => e.AvailableFrom).IsRequired();
                entity.Property(e => e.AvailableTo).IsRequired();
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.User)
                    .WithMany(c => c.Resrvations)
                    .HasForeignKey(e => e.UserId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Room)
                    .WithMany()
                    .HasForeignKey(e => e.RoomId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.Property(e => e.CheckInDate)
                    .IsRequired();

                entity.Property(e => e.CheckOutDate)
                    .IsRequired();
            });

            modelBuilder.Entity<ServiceTask>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.Room)
                    .WithMany(r => r.ServiceTasks)
                    .HasForeignKey(e => e.RoomId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.Property(e => e.RequestType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateRequested)
                    .IsRequired();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DateCompleted);
            });

            base.OnModelCreating(modelBuilder);

        }
    }
}
