using System;
namespace Domain.Entities
{
    public class CartItem: BaseAuditibleEntity
    {
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; } = null!;
    }
}

