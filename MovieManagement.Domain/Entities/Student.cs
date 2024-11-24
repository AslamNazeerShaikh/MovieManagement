using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class Student : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
    }
}
