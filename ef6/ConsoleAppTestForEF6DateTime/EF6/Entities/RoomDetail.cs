using System.ComponentModel.DataAnnotations;

namespace ConsoleAppTestForEF6DateTime.EF6.Entities
{
    public class RoomDetail
    {
        [Key]
        public int Id { get; set; }

        public int Windows { get; set; }

        public int Beds  { get; set; }

        public RoomDetail()
        {
            
        }

        public RoomDetail(int windows, int beds)
        {
            Windows = windows;
            Beds = beds;
        }
    }
}