using ConsoleAppTestForEFDateTime.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppTestForEFDateTime.EntityFrameworkCore
{
    public class MyHotelDbContext : DbContext
    {
        public MyHotelDbContext(DbContextOptions<MyHotelDbContext> options)
            : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Guest> Guests { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomDetail> RoomDetails { get; set; }
    }
}