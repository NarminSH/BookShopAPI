using System;
using Application.Dtos.BookDtos;
using Application.Dtos.UserDtos;

namespace Application.Dtos.ReviewDtos
{
    public class GetReviewDto:BaseAuditibleDto, IMapFrom<Review>
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public double Rate { get; set; }
        public int BookId { get; set; }
        public GetBookDto Book { get; set; }
        public string UserId { get; set; }
        public GetUserDto User { get; set; }
    }
}

