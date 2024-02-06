
using System.ComponentModel.DataAnnotations;

namespace Publication.Domain.Entities
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public string Description { get; set; }
        public int MaximumLevel { get; set; }
        public int MinimumLevel { get; set; }
    }
}
