using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
