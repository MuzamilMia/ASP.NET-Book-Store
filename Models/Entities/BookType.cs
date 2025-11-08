
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Entities
{
    public class BookType
    {
        [Key]
        public int TypeId { get; set; }  // PK

        [Required, StringLength(150)]
        public string TypeName { get; set; } = string.Empty;

        public string? Description { get; set; }

        // Navigation
        public ICollection<Models.MyBook>? Books { get; set; }
    }
}
