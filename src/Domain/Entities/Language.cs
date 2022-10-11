using System;
namespace Domain.Entities
{
    public class Language:BaseAuditibleEntity
    {
        public string Name { get; set; }
        public ICollection<BookLanguages> BookLanguages { get; set; }
    }
}

