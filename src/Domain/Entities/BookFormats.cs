using System;
namespace Domain.Entities
{
    public class BookFormats
    {
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
        public int FormatId { get; set; }
        public Format Format { get; set; } = null!;
    }
}

