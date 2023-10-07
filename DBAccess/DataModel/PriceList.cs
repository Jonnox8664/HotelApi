using System.ComponentModel.DataAnnotations;

namespace DBAccess.DataModel
{
    public class PriceList
    {
        public long Id { get; set; }
        [Required]
        public DateOnly StartingDate { get; set; }
        [Required]
        public float SinglePrice { get; set; }
        public float DoublelePrice { get; set; }
        public float SuitePrice { get; set; }
        public float DeluxPrice { get; set; }
    }
}