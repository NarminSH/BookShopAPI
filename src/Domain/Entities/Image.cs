using System;
namespace Domain.Entities
{
    public class Image:BaseAuditibleEntity
    {
        public string ImageUrl { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}

