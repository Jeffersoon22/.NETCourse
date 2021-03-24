using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practices
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        


        public DbSet<Company> Companies { get; set; }

        public CompanyDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Company)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.CompanyId);

            modelBuilder.Entity<Company>()
                .HasData(
                new Company() { Name = "natashkaKK", Id = 1 },
                new Company() { Name = "tataliX", Id = 2 },
                new Company() { Name = "ChaniX", Id = 3 }
                );

            modelBuilder.Entity<Employee>()
                .HasData(
                new Employee() { Name = "infinitally moonlight", Email = "n.jafaridze299@gmail.com", Phone = "123456789", CompanyId = 1, Id = 1 },
                new Employee() { Name = "Natali", Email = "jafara2299@gmail.com", Phone = "123456789", CompanyId = 2, Id = 2 },
                new Employee() { Name = "Chani", Email = "chanichani20@gmail.com", Phone = "123456789", CompanyId = 3, Id = 3 }
                );
        }
    }
}
