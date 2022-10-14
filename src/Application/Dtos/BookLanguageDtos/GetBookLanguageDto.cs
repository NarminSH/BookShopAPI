using System;
using Application.Dtos.BookDtos;
using Application.Dtos.LanguageDtos;

namespace Application.Dtos.BookLanguageDtos
{
    public class GetBookLanguageDto : BaseAuditibleDto, IMapFrom<BookLanguages>
    {
        public int BookId { get; set; }
        public GetBookDto Book { get; set; } 
        public int LanguageId { get; set; }
        public GetLanguageDto Language { get; set; } 
    }
}

