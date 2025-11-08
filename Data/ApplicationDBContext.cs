using Microsoft.EntityFrameworkCore;
using BookStore.Models.Entities;

namespace BookStore.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = default!;
        public DbSet<BookType> BookTypes { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<UserRole> UserRoles { get; set; } = default!;
        public DbSet<Recipt> Recipts { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Book (M) -> (1) User
            modelBuilder.Entity<Book>()
                .HasOne(b => b.User)
                .WithMany(u => u.Books)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Book (M) -> (1) BookType
            modelBuilder.Entity<Book>()
                .HasOne(b => b.BookType)
                .WithMany(bt => bt.Books)
                .HasForeignKey(b => b.TypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // User (M) -> (1) UserRole
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserRole)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.UserRoleId)
                .OnDelete(DeleteBehavior.Restrict);

            // Recipt (M) -> (1) User
            modelBuilder.Entity<Recipt>()
                .HasOne(r => r.User)
                .WithMany(u => u.Recipts)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Recipt (M) -> (1) Book
            modelBuilder.Entity<Recipt>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Recipts)
                .HasForeignKey((object r) => r.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            // Unique constraints
            modelBuilder.Entity<User>()
                .HasIndex(u => u.UserName)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
