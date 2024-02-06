
using System.ComponentModel.DataAnnotations;

namespace Publication.Domain.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
