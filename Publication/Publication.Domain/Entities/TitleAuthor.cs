
namespace Publication.Domain.Entities
{
    public class TitleAuthor
    {
        public string AuthorId { get; set; }
        public string TitleId { get; set; }
        public int? AuthorOrder { get; set; }
        public int? RoyaltyPercentage { get; set; }
    }
}
