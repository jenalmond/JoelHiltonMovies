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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddMovie>().HasData(
                new AddMovie
                {
                    MovieId = 1,
                    Category = "Fantasy",
                    Title = "Harry Potter and The Scorcere's Stone",
                    Year = "2001",
                    Director = "Chris Columbus",
                    Rating = "PG",
                    Edited = false
                },
                new AddMovie
                {
                    MovieId = 2,
                    Category = "Fantasy",
                    Title = "Harry Potter and The Chamber of Secrets",
                    Year = "2002",
                    Director = "Chris Columbus",
                    Rating = "PG",
                    Edited = false

                },
                new AddMovie
                {
                    MovieId = 3,
                    Category = "Fantasy",
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
