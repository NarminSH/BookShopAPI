using System;

namespace Domain.Entities
{
    public class BookLanguages
    {
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
        public int LanguageId { get; set; }
        public Language Language { get; set; } = null!;
    }
}

