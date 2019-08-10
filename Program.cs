using System;
using System.Linq.Dynamic.Core;
using ConsoleAppTestForEFDateTime.EntityFrameworkCore;

namespace ConsoleAppTestForEFDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            var f = new MyHotelContextFactory();
            var c = f.CreateDbContext(new [] { "" });

            var reservations = c.Reservations.Select<DateTime>("DateTime(CheckinDate.Year,1,1)");

            foreach (var reservation in reservations)
            {
                Console.WriteLine(reservation);
            }
        }
    }
}

// output is like:

//start
//2019-01-01 00:00:00
//2019-01-01 00:00:00
//2018-01-01 00:00:00
//Press any key to continue . . .