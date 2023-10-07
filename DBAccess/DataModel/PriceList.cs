using System.ComponentModel.DataAnnotations;
using static DBAccess.DataModel.RoomType;

namespace DBAccess.DataModel
{
    public class PriceList
    {
        public ulong Id { get; set; }
        [Required]
        public DateOnly StartingDate { get; set; }
        [Required]
        public RoomType? RoomType { get; set; }
        [Required]
        public float Price { get; set; }
    }
}