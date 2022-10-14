using System;


namespace Infrastructure.Repositories.Implementation
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

