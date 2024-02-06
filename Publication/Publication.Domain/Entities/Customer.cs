
using System.ComponentModel.DataAnnotations;

namespace Publication.Domain.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
    }
}
