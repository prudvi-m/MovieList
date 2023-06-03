using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        { }

        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Name = "Casablanca",
                    Year = 1942,
                    Rating = 5,
                    GenreId = "Action",
                    Language = "English"
                },
                new Movie
                {
                    MovieId = 2,
                    Name = "Wonder Woman",
                    Year = 2017,
                    Rating = 3,
                    GenreId = "Action",
                    Language = "English"
                },
                new Movie
                {
                    MovieId = 3,
                    Name = "Moonstruck",
                    Year = 1988,
                    Rating = 4,
                    GenreId = "Action",
                    Language = "English"
                }
            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    GenreId = "Action",
                    Name = "Action"
                },
                new Genre
                {
                    GenreId = "Comedy",
                    Name = "Comedy"
                },
                new Genre
                {
                    GenreId = "Drama",
                    Name = "Drama"
                }
            );
        }
    }
}
