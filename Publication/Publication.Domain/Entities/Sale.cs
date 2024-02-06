
using System;

namespace Publication.Domain.Entities
{
    public class Sale
    {
        public int StoreId { get; set; }    
        public string OrderNumber { get; set; } 
        public DateTime OrderDate { get; set; } 
        public int Quantity { get; set; }
        public string PaymentTerms { get; set; }
        public int TitleId { get; set; }
    }
}
