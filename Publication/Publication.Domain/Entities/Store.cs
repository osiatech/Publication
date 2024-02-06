

using Publication.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Publication.Domain.Entities
{
    public class Store : Place
    {
        [Key]
        public int StoreId { get; set; }
    }
}
