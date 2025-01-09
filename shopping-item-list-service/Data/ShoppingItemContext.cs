using Microsoft.EntityFrameworkCore;
using ShoppingItemService.Models;

namespace ShoppingItemService.Data
{
    public class ShoppingItemContext : DbContext
    {
        public ShoppingItemContext(DbContextOptions<ShoppingItemContext> options) : base(options) { }

        public DbSet<ShoppingItem> ShoppingItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoppingItem>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<ShoppingItem>()
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
