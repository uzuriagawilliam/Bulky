using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {            
        }

        public DbSet<Category> Categories{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.NewGuid(), Name = "Action", DisplayOrder = 1 },
                new Category { Id = Guid.NewGuid(), Name = "Drama", DisplayOrder = 2 },
                new Category { Id = Guid.NewGuid(), Name = "Thriller", DisplayOrder = 3 }
            );
        }
    }
}
