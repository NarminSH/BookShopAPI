using System;

namespace Infrastructure.Repositories.Implementation
{
    public class ShippingAddressRepository : GenericRepository<ShippingAddress>, IShippingAddressRepository
    {
        public ShippingAddressRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

