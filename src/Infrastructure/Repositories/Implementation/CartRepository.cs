using System;
namespace Infrastructure.Repositories.Implementation
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

