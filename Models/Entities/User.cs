using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }  // PK

        [Required, StringLength(30)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty; // hashed password storage

        [Required, StringLength(30)]
        public string Email { get; set; } = string.Empty;

        [StringLength(15)]
        public string? Phone { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        // Foreign key to UserRole
        public int UserRoleId { get; set; }
        public UserRole? UserRole { get; set; }

        // Navigation
        public ICollection<Models.MyBook>? Books { get; set; } // 1 user can create many books
        public ICollection<Recipt>? Recipts { get; set; } // 1 user can have many receipts
    }
}
