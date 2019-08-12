using System;
using System.Linq.Dynamic.Core;
using ConsoleAppTestForEF6DateTime.EF6;

namespace ConsoleAppTestForEF6DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            var c = new MyHotelDbContext();

            var config = new ParsingConfig();
            // config.EvaluateGroupByAtDatabase = false;

            var reservations = c.Reservations.Select(config, "DateTime(CheckinDate.Year,1,1)");

            foreach (var reservation in reservations)
            {
                Console.WriteLine(reservation);
            }
        }
    }
}
