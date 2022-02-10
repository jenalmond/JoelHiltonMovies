﻿// <auto-generated />
using JoelHiltonMovies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JoelHiltonMovies.Migrations
{
    [DbContext(typeof(AddMovieContext))]
    partial class AddMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("JoelHiltonMovies.Models.AddMovie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 3,
                            Director = "Chris Columbus",
                            Edited = false,
                            Rating = "PG",
                            Title = "Harry Potter and The Scorcere's Stone",
                            Year = "2001"
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 3,
                            Director = "Chris Columbus",
                            Edited = false,
                            Rating = "PG",
                            Title = "Harry Potter and The Chamber of Secrets",
                            Year = "2002"
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            Director = "Alfonso Cuaron",
                            Edited = false,
                            Rating = "PG",
                            Title = "Harry Potter and The Prisoner of Azkaban",
                            Year = "2004"
                        });
                });

            modelBuilder.Entity("JoelHiltonMovies.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Horror/Suspense"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Miscellaneous"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Television"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "VHS"
                        });
                });

            modelBuilder.Entity("JoelHiltonMovies.Models.AddMovie", b =>
                {
                    b.HasOne("JoelHiltonMovies.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
