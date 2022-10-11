using System;
namespace Domain.Entities
{
    public class Genre : BaseAuditibleEntity
    {
        public string Name { get; set; }
        public ICollection<BookGenres> BookGenres { get; set; }
    }
}

