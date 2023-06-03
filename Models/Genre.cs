using System.ComponentModel.DataAnnotations;


namespace MovieList.Models
{
    public class Genre
    {
        // EF Core will configure the database to generate this value
        public string GenreId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;
    }
}
