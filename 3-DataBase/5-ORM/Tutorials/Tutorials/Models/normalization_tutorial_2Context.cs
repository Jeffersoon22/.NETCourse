using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tutorials.Models
{
    public partial class normalization_tutorial_2Context : DbContext
    {
        public normalization_tutorial_2Context()
        {
        }

        public normalization_tutorial_2Context(DbContextOptions<normalization_tutorial_2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookAuthor> BookAuthor { get; set; }
        public virtual DbSet<Bookpicking> Bookpicking { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PBRRCE3\\SQLEXPRESS;Initial Catalog=normalization_tutorial_2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK__Book__BranchId__440B1D61");

                entity.HasOne(d => d.Publisher)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.PublisherId)
                    .HasConstraintName("FK__Book__PublisherI__4316F928");
            });

            modelBuilder.Entity<BookAuthor>(entity =>
            {
                entity.HasOne(d => d.Author)
                    .WithMany(p => p.BookAuthor)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK__BookAutho__Autho__47DBAE45");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BookAuthor)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__BookAutho__BookI__46E78A0C");
            });

            modelBuilder.Entity<Bookpicking>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Bookpicking)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__Bookpicki__BookI__4D94879B");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Bookpicking)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Bookpicki__Stude__4E88ABD4");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.FacultyId)
                    .HasConstraintName("FK__Student__Faculty__403A8C7D");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Warehouse)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK__Warehouse__BookI__4AB81AF0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
