using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic.Core;
using ConsoleAppTestForEF6DateTime.EF6;

namespace ConsoleAppTestForEF6DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            var ctx = new MyHotelDbContext();

            var dates = ctx.Reservations.Select(x => DbFunctions.CreateDateTime(x.CheckinDate.Year, 1, 1, 0, 0, 0));
            foreach (var date in dates)
            {
                Console.WriteLine("Normal:" + date);
            }

            var datesDynamic = ctx.Reservations.Select("DbFunctions.CreateDateTime(CheckinDate.Year, 1, 1, 0, 0, 0)");
            foreach (var date in datesDynamic)
            {
                Console.WriteLine("Dynamic:" + date);
            }
        }
    }
}
