using System;
namespace Domain.Entities
{
    public class Review:BaseAuditibleEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public double Rate { get; set; }
    }
}

