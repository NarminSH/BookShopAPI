using System;
using Application.Dtos.BookLanguageDtos;
using BookShop.src.Application.Common.Mappings;

namespace Application.Dtos.LanguageDtos
{
    public class GetLanguageDto:BaseAuditibleDto, IMapFrom<Language>
    {
        public string Name { get; set; }
        //public ICollection<GetBookLanguageDto> BookLanguages { get; set; }
    }
}

