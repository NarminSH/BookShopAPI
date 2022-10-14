using System;
using Domain.Enums;

namespace Domain.Entities
{
    public class DiscountPrice: BaseAuditibleEntity
    {
        public DiscountType Type { get; set; }
        public int Amount { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<Book> Books { get; set; }

    }
}

