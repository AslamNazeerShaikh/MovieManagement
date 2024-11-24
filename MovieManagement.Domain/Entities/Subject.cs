using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class Subject : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
