using System;
using Application.Dtos.BookDtos;
using Application.Dtos.GenreDtos;

namespace Application.Dtos.BookGenreDtos
{
    public class GetBookGenreDto: BaseAuditibleDto, IMapFrom<BookGenres>
    {
        public int BookId { get; set; }
        public GetBookDto Book { get; set; } 
        public int GenreId { get; set; }
        public GetGenreDto Genre { get; set; } 
    }
}

