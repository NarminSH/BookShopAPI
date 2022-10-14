using System;

namespace Infrastructure.Repositories.Implementation
{
    public class FormatRepository : GenericRepository<Format>, IFormatRepository
    {
        public FormatRepository(ApplicationDbContext context) : base(context)
        {
        } 
    }
}

