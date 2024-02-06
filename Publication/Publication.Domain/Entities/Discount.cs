
using System.ComponentModel.DataAnnotations;

namespace Publication.Domain.Entities
{
    public class Discount
    {
        [Key]
        public int StoreId { get; set; }
        public string DiscountType { get; set; }
        public int LowQuantity { get; set; }
        public int HighQuantity { get; set; } 
        public double Discount_ { get; set; }
    }
}
