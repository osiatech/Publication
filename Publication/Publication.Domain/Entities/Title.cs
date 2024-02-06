
using System;
using System.ComponentModel.DataAnnotations;

namespace Publication.Domain.Entities
{
    public class Title
    {
        [Key]
        public int TitleId { get; set; }   
        public string Title_ { get; set; }
        public string Type { get; set; }
        public string? PublisherId { get; set; }
        public double? Price { get; set; }
        public double? Advance { get; set; }
        public int? Royalty { get; set; }
        public int? YearToDateSales { get; set; }
        public string? Notes { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
