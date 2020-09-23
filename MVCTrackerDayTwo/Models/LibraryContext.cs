
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDAYTWO.Models
{
    public partial class LibraryContext: DbContext
    {                
        public LibraryContext()
        {

        }
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {

        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // If we aren't already configured.
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseMySql("server=localhost;port=3306;user=root;database=mvc_library", x => x.ServerVersion("10.4.14-MariaDB"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasData(
                    new Author() { ID = -1, Name = "Author One"},
                    new Author() { ID = -2, Name = "Author Two"},
                    new Author() { ID = -3, Name = "Author Three"},
                    new Author() { ID = -4, Name = "Author Four" },
                    new Author() { ID = -5, Name = "Author Five"}
                    );
            });

            // Declare advanced column configuration for our model.
            modelBuilder.Entity<Book>(entity =>
            {
                // If you have foreign keys, declare them here as "HasIndex".
                entity.HasIndex(e => e.AuthorID)
                    .HasName("FK_Of_Author");

                // PLEASE don't try to memorize this. Copy/paste it and change the column name.
                entity.Property(e => e.Title)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                
                entity.HasOne(child => child.Author)
                    // Specify the relationship between the parent and child(ren)
                    .WithMany(parent => parent.Books)
                    // Specify the property acting as the foreign key
                    .HasForeignKey(child => child.AuthorID)
                    // Specify delete behaviour
                    .OnDelete(DeleteBehavior.Cascade)
                    // Name the foreign key
                    .HasConstraintName("FK_Of_Author");

                entity.HasData(
                    new Book()
                    {
                        ID = -1,
                        Title = "Title One",
                        PublicationDate = new DateTime(2012, 12, 25),
                        CheckedOutDate = new DateTime(2018, 12, 25),
                        DueDate = new DateTime(2018, 12, 25),
                        ReturnedDate = new DateTime(2018, 12, 25),
                        AuthorID = -2
                    },
                    new Book()
                    {
                        ID = -2,
                        Title = "Title Two",
                        PublicationDate = new DateTime(2010, 12, 25),
                        CheckedOutDate = new DateTime(2018, 12, 25),
                        DueDate = new DateTime(2018, 12, 25),
                        ReturnedDate = null,
                        AuthorID = -2
                    },
                     new Book()
                     {
                         ID = -3,
                         Title = "Title Three",
                         PublicationDate = new DateTime(2008, 12, 25),
                         CheckedOutDate = new DateTime(2018, 12, 25),
                         DueDate = new DateTime(2018, 12, 25),
                         ReturnedDate = new DateTime(2018, 12, 25),
                         AuthorID = -2
                     });

            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
