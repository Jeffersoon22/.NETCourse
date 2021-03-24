using GymManagementSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystem.DAL
{
    public class GymDbContext : DbContext
    {
        public DbSet<Member> Members{ get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<FitnessAndMembers> FitnessAndMembers { get; set; }
        public DbSet<FitnessGroup> FitnessGroups { get; set; }

        public GymDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>()
            .Property(x => x.Date).HasDefaultValueSql("Getdate()");

            modelBuilder.Entity<Payment>()
                .HasOne(x => x.Member)
                .WithMany(x => x.Payments)
                .HasForeignKey(x => x.MemberId);

            //modelBuilder.Entity<FitnessGroup>().HasKey(x => x.Id);

            modelBuilder.Entity<FitnessAndMembers>().HasKey(x => new { x.MemberId, x.FitId });


            modelBuilder.Entity<FitnessAndMembers>()
                .HasOne(x => x.Member)
                .WithMany(x => x.FitnessAndMembers)
                .HasForeignKey(x => x.MemberId);

            modelBuilder.Entity<FitnessAndMembers>()
                .HasOne(x => x.FitnessGroup)
                .WithMany(x => x.FitnessAndMembers)
                .HasForeignKey(x => x.FitId);
            
            
        }
    }
    
}
