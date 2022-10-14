using System;
namespace Domain.Entities
{
    public class Review:BaseAuditibleEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public double Rate { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}

