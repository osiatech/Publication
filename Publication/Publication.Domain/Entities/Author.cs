
using Publication.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Publication.Domain.Entities
{
    public class Author : Person
    {
        [Key]
        public int AuthorId { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public bool Contract { get; set; }
    }
}
