﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Services.BookAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStore.Services.BookAPI.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<bool>("AreIllustrations")
                        .HasColumnType("bit");

                    b.Property<string>("Cover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InStock")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<DateTime>("YearOfPublication")
                        .HasColumnType("datetime2");

                    b.HasKey("BookId");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AreIllustrations = true,
                            Cover = "Soft",
                            Description = "Some Description",
                            GenreId = 3,
                            ImageUrl = "https://projectsbykostatuno.blob.core.windows.net/bookstore/abraham_lincoln_a_history_vol.i.jpg",
                            InStock = 21,
                            Name = "Abraham Lincoln: A History, Vol. I",
                            NumberOfPages = 152,
                            Price = 299m,
                            Weight = 699.0,
                            YearOfPublication = new DateTime(2009, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 2,
                            AreIllustrations = false,
                            Cover = "Soft",
                            Description = "Some Description",
                            GenreId = 7,
                            ImageUrl = "https://projectsbykostatuno.blob.core.windows.net/bookstore/the_book_of_awesome_humour.jpg",
                            InStock = 12,
                            Name = "The book of Awesome Humour",
                            NumberOfPages = 81,
                            Price = 159m,
                            Weight = 329.0,
                            YearOfPublication = new DateTime(2015, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 3,
                            AreIllustrations = true,
                            Cover = "Solid",
                            Description = "Some Description",
                            GenreId = 2,
                            ImageUrl = "https://projectsbykostatuno.blob.core.windows.net/bookstore/the_water_is_wide_pat_conroy.jpg",
                            InStock = 51,
                            Name = "The water is wide",
                            NumberOfPages = 187,
                            Price = 512m,
                            Weight = 999.0,
                            YearOfPublication = new DateTime(2007, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 4,
                            AreIllustrations = false,
                            Cover = "Solid",
                            Description = "Some Description",
                            GenreId = 1,
                            ImageUrl = "https://projectsbykostatuno.blob.core.windows.net/bookstore/war_and_peace.jpg",
                            InStock = 71,
                            Name = "War and Peace",
                            NumberOfPages = 132,
                            Price = 499m,
                            Weight = 699.0,
                            YearOfPublication = new DateTime(1881, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BookStore.Services.BookAPI.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Nonfiction history books include any books that lay out the known facts about a particular, time, culture, or event in history.",
                            Name = "History"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Memoirs are one type of autobiography. In this type of book, the author puts emphasis on specific moments or events that brought about specific life lessons. ",
                            Name = "Memoir"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Political nonfiction books can include books written by career politicians, books that explore political systems, or books that discuss the politics of a certain period.",
                            Name = "Politics"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Self-help books aim to aid the reader in improving some part of her life. Common topics covered by self-help books include relationships, finances, and mental health. ",
                            Name = "Self-Help"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Thrillers are suspenseful stories, which makes a crime thriller a book that has a crime as its main subject while keeping readers on edge. The main characters are often fighting for justice.",
                            Name = "Crime Thriller"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Also known as Sci-Fi, science fiction deals with the imagined future in terms of science or technology advances. This genre includes things like time travel, outer space, and intelligent life.",
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 7,
                            Description = "The world can be a dark place at times, and we all need something light-hearted to entertain and distract us. Happily, there are a host of witty, satirical and downright hilarious books out there, waiting to put a smile back on our face.",
                            Name = "Humor"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Horror is a genre of literature, film, and television that is meant to scare, startle, shock, and even repulse audiences. The key focus of a horror novel, horror film, or horror TV show is to elicit a sense of dread in the reader through frightening images, themes, and situations.",
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 9,
                            Description = "A classic book can be simply defined as a book which has been recognized by critics and the public to be excellent, and a “must-read.” Traditionally, the term was only used to describe books originally written in Greek or Latin, but the definition has been expanded to include books written in all languages.",
                            Name = "Classic"
                        },
                        new
                        {
                            Id = 10,
                            Description = "A biography is simply the story of a real person's life. It could be about a person who is still alive, someone who lived centuries ago, someone who is globally famous, an unsung hero forgotten by history, or even a unique group of people.",
                            Name = "Biography"
                        });
                });

            modelBuilder.Entity("BookStore.Services.BookAPI.Models.Book", b =>
                {
                    b.HasOne("BookStore.Services.BookAPI.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BookStore.Services.BookAPI.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
