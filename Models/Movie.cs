using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{
    public class Movie
    {
        // EF Core will configure the database to generate this value
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1889, 2999, ErrorMessage = "Year must be after 1889.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        public int? Rating { get; set; }

        
        public string GenreId {set;get;}

        public Genre Genre { set => new Genre { Name = GenreId , GenreId = GenreId}; }
        
        [Required(ErrorMessage = "Please enter a Lanaguage.")]
        public string Language {set;get;}
        
    }
}
