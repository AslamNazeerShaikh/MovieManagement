using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Core.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // Navigation Property
        public ICollection<Movie>? Movies { get; set; }
    }
}
