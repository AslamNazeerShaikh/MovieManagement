using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation
{
    public class ActorRepository : GenericRepository<Actor> , IActorRepository
    {
        public ActorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
