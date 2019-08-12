using System.Data.Entity;
using ConsoleAppTestForEF6DateTime.EF6.Entities;

namespace ConsoleAppTestForEF6DateTime.EF6
{
    public class MyHotelDbContext : DbContext
    {
        public MyHotelDbContext()
            : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyHotel;Trusted_Connection=True;MultipleActiveResultSets=true")
        {
        }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Guest> Guests { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomDetail> RoomDetails { get; set; }
    }
}