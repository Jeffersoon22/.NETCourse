using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Practices.Models
{
    public partial class HorsesInRacesContext : DbContext
    {
        public HorsesInRacesContext()
        {
        }

        public HorsesInRacesContext(DbContextOptions<HorsesInRacesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HorseOnwers> HorseOnwers { get; set; }
        public virtual DbSet<Horses> Horses { get; set; }
        public virtual DbSet<Jockeys> Jockeys { get; set; }
        public virtual DbSet<RaceParticipations> RaceParticipations { get; set; }
        public virtual DbSet<Races> Races { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PBRRCE3\\SQLEXPRESS;Initial Catalog=HorsesInRaces;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HorseOnwers>(entity =>
            {
                entity.HasKey(e => e.OwnerId)
                    .HasName("PK__HorseOnw__819385B8FC79A3C8");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Horses>(entity =>
            {
                entity.HasKey(e => e.HorseId)
                    .HasName("PK__Horses__418B5DA8C76F366A");

                entity.Property(e => e.HorseAge)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HorseGender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HorseName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Owener)
                    .WithMany(p => p.Horses)
                    .HasForeignKey(d => d.OwenerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Horses__OwenerId__4316F928");
            });

            modelBuilder.Entity<Jockeys>(entity =>
            {
                entity.HasKey(e => e.JockeyId)
                    .HasName("PK__Jockeys__21C4CA45BAEA53FD");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RaceParticipations>(entity =>
            {
                entity.HasOne(d => d.Horse)
                    .WithMany(p => p.RaceParticipations)
                    .HasForeignKey(d => d.HorseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RaceParti__Horse__4F7CD00D");

                entity.HasOne(d => d.Jockey)
                    .WithMany(p => p.RaceParticipations)
                    .HasForeignKey(d => d.JockeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RaceParti__Jocke__5070F446");

                entity.HasOne(d => d.Race)
                    .WithMany(p => p.RaceParticipations)
                    .HasForeignKey(d => d.RaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RaceParti__RaceI__4E88ABD4");
            });

            modelBuilder.Entity<Races>(entity =>
            {
                entity.HasKey(e => e.RaceId)
                    .HasName("PK__Races__05FBD6B4304856F4");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
