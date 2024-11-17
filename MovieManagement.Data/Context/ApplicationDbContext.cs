using Microsoft.EntityFrameworkCore;
using MovieManagement.Core.Entities;

namespace MovieManagement.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Actor>? Actors { get; set; }
        public DbSet<Movie>? Movies { get; set; }
        public DbSet<Genre>? Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Many-to-Many Relationship
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Actors)
                .WithMany(a => a.Movies);
        }
    }
}
