
using Publication.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Publication.Domain.Entities
{
    public class Publisher : Place
    {
        [Key]
        public int PublisherId { get; set; }
        public string? Country { get; set; } 
    }
}
