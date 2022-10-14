using System;
using Application.Dtos.BookGenreDtos;

namespace Application.Dtos.GenreDtos
{
    public class GetGenreDto: BaseAuditibleDto, IMapFrom<Genre>
    {
        public string Name { get; set; }
        //public ICollection<GetBookGenreDto> BookGenres { get; set; }
    }
}

