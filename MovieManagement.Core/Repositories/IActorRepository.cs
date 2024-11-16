﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManagement.Core.Entities;

namespace MovieManagement.Core.Repositories
{
    public interface IActorRepository : IGenericRepository<Actor>
    {
        public Task<IEnumerable<Actor>> GetPopularActorsAsync();
    }
}
