using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Core.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int GenreId { get; set; }

        // Navigation Properties
        public Genre? Genre { get; set; }
        public ICollection<Actor>? Actors { get; set; }
    }
}
