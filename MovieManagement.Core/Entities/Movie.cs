using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Core.Entities
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string? MovieTitle { get; set; }
        public int GenreId { get; set; }

        // Navigation Properties
        public Genre? Genre { get; set; }
        public ICollection<Actor>? Actors { get; set; }
    }
}
