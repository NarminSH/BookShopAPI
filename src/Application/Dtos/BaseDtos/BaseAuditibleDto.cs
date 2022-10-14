using System;
using BookShop.src.Application.Common.Mappings;
using Domain.Common;

namespace Application.Dtos.BaseDtos
{
    public class BaseAuditibleDto : BaseEntityDto, IMapFrom<BaseAuditibleEntity>
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

