using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManagement.Application.DTOs
{
    public class StudentDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TeacherId { get; set; }
    }
}
