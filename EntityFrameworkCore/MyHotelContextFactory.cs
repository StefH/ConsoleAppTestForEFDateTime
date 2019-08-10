using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ConsoleAppTestForEFDateTime.EntityFrameworkCore
{
    public class MyHotelContextFactory : IDesignTimeDbContextFactory<MyHotelDbContext>
    {
        public MyHotelDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyHotelDbContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyHotel;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new MyHotelDbContext(optionsBuilder.Options);
        }
    }
}