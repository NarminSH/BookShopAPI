using System;

namespace Infrastructure.Repositories.Implementation
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

