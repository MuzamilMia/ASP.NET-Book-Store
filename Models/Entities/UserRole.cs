using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.Entities
{
    public class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }  // PK

        [Required, StringLength(30)]
        public string RoleName { get; set; } = string.Empty;

        public string? Description { get; set; }

        // Navigation
        public ICollection<User>? Users { get; set; }
    }
}
