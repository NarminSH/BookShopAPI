using System;

namespace Infrastructure.Repositories.Implementation
{
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

