using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;

namespace MovieManagement.DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, FirstName = "Aslam", LastName = "Shaikh" },
                new Actor { Id = 2, FirstName = "Tayyab", LastName = "Shaikh" },
                new Actor { Id = 3, FirstName = "Maksud", LastName = "Shaikh" });

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "Wakanda Forever", Description = "Very Awesome", ActorId = 1 },
                new Movie { Id = 2, Name = "SpiderMan Forever", Description = "Too Awesome", ActorId = 2 },
                new Movie { Id = 3, Name = "BatMan Forever", Description = "Nice Awesome", ActorId = 3 });
        }
    }
}
