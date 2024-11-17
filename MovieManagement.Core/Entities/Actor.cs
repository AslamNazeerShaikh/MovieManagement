using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
