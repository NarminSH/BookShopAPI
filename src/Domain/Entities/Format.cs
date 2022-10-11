using System;

namespace Domain.Entities
{
    public class Format: BaseAuditibleEntity
    {
        public string Name { get; set; }
        public ICollection<BookFormats> BookFormats { get; set; }
    }
}

