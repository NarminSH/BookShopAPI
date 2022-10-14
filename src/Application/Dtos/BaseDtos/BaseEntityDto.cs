using System;
using BookShop.src.Application.Common.Mappings;
using Domain.Common;

namespace Application.Dtos.BaseDtos
{
    public class BaseEntityDto : IMapFrom<BaseEntity>
    {
        public int Id { get; set; }
    }
}

