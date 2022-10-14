using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Application.Dtos.CategoryDtos;
using Microsoft.EntityFrameworkCore;
using Application.Dtos.CartItemDtos;

namespace BookShop.src.Application.CartItems.Queries.GetCartItems;

public record GetCartItemsQuery : IRequest<IEnumerable<GetCartItemDto>>;

public class GetCartItemsQueryHandler : IRequestHandler<GetCartItemsQuery, IEnumerable<GetCartItemDto>>
{
    private readonly ICartItemRepository _repository;
    private readonly IMapper _mapper;

    public GetCartItemsQueryHandler(ICartItemRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<IEnumerable<GetCartItemDto>> Handle(GetCartItemsQuery request, CancellationToken cancellationToken)
    {
        var categories = await _repository.GetAllAsync();
        var categoriesDto = _mapper.Map<IEnumerable<GetCartItemDto>>(categories);
        return categoriesDto;
    }
}