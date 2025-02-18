using MovieManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Domain.Entities
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        [StringLength(255)]
        public string? MovieName { get; set; }

        [Required]
        [StringLength(255)]
        public string? MovieAuthor { get; set; }

        [DataType(DataType.Date)]
        public DateTime? PublishDate { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
