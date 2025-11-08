using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Entities
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }  // PK

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Author { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        // FK to BookType
        public int TypeId { get; set; }
        public BookType? BookType { get; set; }

        // FK to User (creator)
        public int UserId { get; set; }
        public User? User { get; set; }

        // Navigation
        public ICollection<Recipt>? Recipts { get; set; }
    }
}
