
using System.ComponentModel.DataAnnotations;

namespace Publication.Domain.Entities
{
    public class PublicationInformation
    {
        [Key]
        public int PublicationId { get; set; }
        public byte[]? Logo { get; set; }
        public string? PublicationInformation_ { get; set; }
    }
}
