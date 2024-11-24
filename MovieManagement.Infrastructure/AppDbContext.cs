using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;

namespace MovieManagement.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Teacher>? Teachers { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Subject>? Subjects { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many-to-Many Relationship between Students and Subjects
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Subjects)
                .WithMany(s => s.Students);

            // Many-to-Many Relationship between Teachers and Subjects
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Subjects)
                .WithMany(s => s.Teachers);

            // One-to-Many Relationship between Teachers and Students
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Students)
                .WithOne(s => s.Teacher)
                .HasForeignKey(s => s.TeacherId);
        }
    }
}
