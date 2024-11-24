using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = "System";
        public DateTime? LastUpdatedOn { get; set; }
        public string? LastUpdatedBy { get; set; }
    }
}
