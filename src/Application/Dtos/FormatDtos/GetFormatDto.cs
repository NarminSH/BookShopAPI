using System;
using Application.Dtos.BookFormatDtos;

namespace Application.Dtos.FormatDtos
{
    public class GetFormatDto: BaseAuditibleDto, IMapFrom<Format>
    {
        public string Name { get; set; }
        //public ICollection<GetBookFormatDto> BookFormats { get; set; }
    }
}

