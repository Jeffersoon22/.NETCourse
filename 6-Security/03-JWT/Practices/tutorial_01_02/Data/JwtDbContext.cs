using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practices.models;

namespace Practices.Data
{
    public class JwtDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Toys> Toy { get; set; }
        public JwtDbContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<Toys>().HasKey(x => x.Id);

            DataInitializer.seed(modelBuilder);

        }
    }
}
