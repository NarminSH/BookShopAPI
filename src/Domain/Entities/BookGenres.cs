using System;
namespace Domain.Entities
{
    public class BookGenres : BaseAuditibleEntity
    {
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
        public int GenreId { get; set; }
        public Genre Genre { get; set; } = null!;
    }
}

