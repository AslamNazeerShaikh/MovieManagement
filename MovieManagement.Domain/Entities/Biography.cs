using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities
{
    public class Biography
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int ActorId { get; set; }
        public Actor? Actor { get; set; }

    }
}
