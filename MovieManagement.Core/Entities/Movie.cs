﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
