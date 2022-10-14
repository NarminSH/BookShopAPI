using System;
using Application.Dtos.BookDtos;
using Application.Dtos.FormatDtos;

namespace Application.Dtos.BookFormatDtos
{
    public class GetBookFormatDto: BaseAuditibleDto, IMapFrom<BookFormats>
    {
        public int BookId { get; set; }
        public GetBookDto Book { get; set; } 
        public int FormatId { get; set; }
        public GetFormatDto Format { get; set; }
    }
}

