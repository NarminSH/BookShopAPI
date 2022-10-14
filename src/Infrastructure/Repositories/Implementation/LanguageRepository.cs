using System;

namespace Infrastructure.Repositories.Implementation
{
    public class LanguageRepository : GenericRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

