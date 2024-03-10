using movie_tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace movie_tracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
                
        }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "Avatar", ReleaseYear = 2009, Genre = "Sci-fi" },
                new Movie { MovieId = 2, Title = "Avengers: Endgame", ReleaseYear = 2019, Genre = "Action" },
                new Movie { MovieId = 3, Title = "Avatar: The Way of Water", ReleaseYear = 2022, Genre = "Sci-fi" },
                new Movie { MovieId = 4, Title = "Titanic", ReleaseYear = 1997, Genre = "Romance" },
                new Movie { MovieId = 5, Title = "Star Wars: The Force Awakens", ReleaseYear = 2015, Genre = "Sci-fi" },
                new Movie { MovieId = 6, Title = "Avengers: Infinity War", ReleaseYear = 2018, Genre = "Action" },
                new Movie { MovieId = 7, Title = "Spider-Man: No Way Home", ReleaseYear = 2021, Genre = "Action" },
                new Movie { MovieId = 8, Title = "Jurassic World", ReleaseYear = 2015, Genre = "Action" },
                new Movie { MovieId = 9, Title = "The Lion King", ReleaseYear = 1994, Genre = "Animation" },
                new Movie { MovieId = 10, Title = "The Avengers", ReleaseYear = 2012, Genre = "Action" },
                new Movie { MovieId = 11, Title = "Sabi KO Sabi Ni Gelo", ReleaseYear = 2020, Genre = "Comedy" }
                );

        }

    }
}
