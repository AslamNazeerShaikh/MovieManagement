using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Core.Entities
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Required]
        public string? ActorName { get; set; }

        // Navigation Property
        public ICollection<Movie>? Movies { get; set; }
    }
}
