using System.ComponentModel.DataAnnotations;

namespace DBAccess.DataModel
{
    public class RoomType
    {
        public long Id { get; set; }
        [Required]
        public RType Type { get; set; }

        public enum RType
        {
            Single,
            Double,
            Suite,
            Deluxe
        }
    }
}