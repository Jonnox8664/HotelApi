using System.ComponentModel.DataAnnotations;

namespace DBAccess.DataModel
{
    public class RoomType
    {
        public ulong Id { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public uint Level { get; set; }
    }
}