﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookStore.Services.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230320203254_CategoryWasRenamedOnGenre")]
    partial class CategoryWasRenamedOnGenre
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookStore.Services.ProductAPI.Models.Book", b =>
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
                });

            modelBuilder.Entity("BookStore.Services.ProductAPI.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                            Description = "",
                            Name = "History"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Memoir"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Politics"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Name = "Self-Help"
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Name = "Crime Thriller"
                        },
                        new
                        {
                            Id = 6,
                            Description = "",
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 7,
                            Description = "",
                            Name = "Humor"
                        },
                        new
                        {
                            Id = 8,
                            Description = "",
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 9,
                            Description = "",
                            Name = "Classic"
                        },
                        new
                        {
                            Id = 10,
                            Description = "",
                            Name = "Biography"
                        });
                });

            modelBuilder.Entity("BookStore.Services.ProductAPI.Models.Book", b =>
                {
                    b.HasOne("BookStore.Services.ProductAPI.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BookStore.Services.ProductAPI.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
