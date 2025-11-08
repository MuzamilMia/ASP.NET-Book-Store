using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Entities
{
    public class Recipt
    {
        [Key]
        public int ReciptId { get; set; }  // PK

        [Required, StringLength(160)]
        public string BillNumber { get; set; } = string.Empty;

        // FKs
        public int UserId { get; set; }
        public User? User { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float TotalAmount { get; set; }

        public DateTime BillDate { get; set; } = DateTime.UtcNow;

        [Required, StringLength(100)]
        public string PaymentType { get; set; } = string.Empty;
    }
}
