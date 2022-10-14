using System;
using Application.Dtos.BookDtos;

namespace Application.Dtos.CategoryDtos
{
    public class GetCategoryDto:BaseAuditibleDto, IMapFrom<Category>
    {
        public string Name { get; set; } = null!;
        public int? ParentId { get; set; }
        public virtual IEnumerable<GetCategoryDto> Children { get; set; }
        public IEnumerable<GetBookDto> Books { get; set; }
    }
}

