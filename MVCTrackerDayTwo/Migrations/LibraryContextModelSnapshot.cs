﻿// <auto-generated />
using System;
using MVCDAYTWO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCTrackerDayTwo.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MVCDAYTWO.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("ID");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            Name = "Author One"
                        },
                        new
                        {
                            ID = -2,
                            Name = "Author Two"
                        },
                        new
                        {
                            ID = -3,
                            Name = "Author Three"
                        },
                        new
                        {
                            ID = -4,
                            Name = "Author Four"
                        },
                        new
                        {
                            ID = -5,
                            Name = "Author Five"
                        });
                });

            modelBuilder.Entity("MVCDAYTWO.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int(10)");

                    b.Property<int>("AuthorID")
                        .HasColumnName("author_id")
                        .HasColumnType("int(10)");

                    b.Property<DateTime>("CheckedOutDate")
                        .HasColumnName("checkedoutdate")
                        .HasColumnType("date");

                    b.Property<DateTime>("DueDate")
                        .HasColumnName("duedate")
                        .HasColumnType("date");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnName("publicationdate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ReturnedDate")
                        .HasColumnName("returnedate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID")
                        .HasName("FK_Of_Author");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            AuthorID = -2,
                            CheckedOutDate = new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublicationDate = new DateTime(2012, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnedDate = new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Title One"
                        },
                        new
                        {
                            ID = -2,
                            AuthorID = -2,
                            CheckedOutDate = new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublicationDate = new DateTime(2010, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Title Two"
                        },
                        new
                        {
                            ID = -3,
                            AuthorID = -2,
                            CheckedOutDate = new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublicationDate = new DateTime(2008, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnedDate = new DateTime(2018, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Title Three"
                        });
                });

            modelBuilder.Entity("MVCDAYTWO.Models.Book", b =>
                {
                    b.HasOne("MVCDAYTWO.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID")
                        .HasConstraintName("FK_Of_Author")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
