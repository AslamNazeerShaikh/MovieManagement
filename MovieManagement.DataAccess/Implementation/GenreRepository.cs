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
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
