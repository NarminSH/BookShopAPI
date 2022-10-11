using System;

namespace Domain.Entities
{
    public class Category: BaseAuditibleEntity
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Children { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

