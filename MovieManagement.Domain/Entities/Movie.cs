using MovieManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Domain.Entities
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please provide a Movie Name.")]
        [StringLength(255)]
        public string? MovieName { get; set; }

        [Required(ErrorMessage = "Please provide the Author Name.")]
        [StringLength(255)]
        public string? MovieAuthor { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please provide the Publish Date.")]
        public DateTime? PublishDate { get; set; }

        [Required]
        [EnumDataType(typeof(Category), ErrorMessage = "Please select a Category.")]
        public Category Category { get; set; }
    }
}
