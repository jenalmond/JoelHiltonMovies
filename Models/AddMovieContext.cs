using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHiltonMovies.Models
{
    public class AddMovieContext : DbContext
    {
        public AddMovieContext (DbContextOptions<AddMovieContext> options) : base (options)
        {

        }

        public DbSet<AddMovie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Action/Adventure"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Fantasy"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Horror/Suspense"
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Miscellaneous"
                },
                new Category
                {
                    CategoryId = 8,
                    CategoryName = "Television"
                },
                new Category
                {
                    CategoryId = 9,
                    CategoryName = "VHS"
                }
                );

            mb.Entity<AddMovie>().HasData(
                new AddMovie
                {
                    MovieId = 1,
                    CategoryId = 3,
                    Title = "Harry Potter and The Scorcere's Stone",
                    Year = "2001",
                    Director = "Chris Columbus",
                    Rating = "PG",
                    Edited = false
                },
                new AddMovie
                {
                    MovieId = 2,
                    CategoryId = 3,
                    Title = "Harry Potter and The Chamber of Secrets",
                    Year = "2002",
                    Director = "Chris Columbus",
                    Rating = "PG",
                    Edited = false

                },
                new AddMovie
                {
                    MovieId = 3,
                    CategoryId = 3,
                    Title = "Harry Potter and The Prisoner of Azkaban",
                    Year = "2004",
                    Director = "Alfonso Cuaron",
                    Rating = "PG",
                    Edited = false

                }
                );
        }
    }
}
