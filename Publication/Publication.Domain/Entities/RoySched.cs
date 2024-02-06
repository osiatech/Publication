
using System.ComponentModel.DataAnnotations;

namespace Publication.Domain.Entities
{
    public class RoySched
    {
        [Key]
        public int TitleId { get; set; }
        public int? Lorange { get; set; }
        public int? Hirange { get; set; }
        public int? Royalty { get; set; }
    }
}
