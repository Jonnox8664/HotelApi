using System.ComponentModel.DataAnnotations;

namespace DBAccess.DataModel
{
    public class Accommodation
    {
        public long Id { get; set; }
        [Required]
        public DateOnly CheckIn { get; set; }
        [Required]
        public DateOnly CheckOut { get; set; }
        [Required]
        public List<PriceList>? PriceList { get; set; }
    }
}