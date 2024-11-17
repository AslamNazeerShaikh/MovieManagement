using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Core.Entities
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [Required]
        public string? GenreName { get; set; }

        // Navigation Property
        public ICollection<Movie>? Movies { get; set; }
    }
}
