using AutoMapper;
using AutoMapper.QueryableExtensions;

using MediatR;
using Application.Dtos.CategoryDtos;
using Microsoft.EntityFrameworkCore;

namespace Code.Application.Categories.Queries.GetCategories;
public record GetCategoriesQuery : IRequest<IEnumerable<GetCategoryDto>>;

public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, IEnumerable<GetCategoryDto>>
{
    private readonly ICategoryRepository _repository;
    private readonly IMapper _mapper;

    public GetCategoriesQueryHandler(ICategoryRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<IEnumerable<GetCategoryDto>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
    {
        var categories = await _repository.GetAllAsync();
        var categoriesDto = _mapper.Map<IEnumerable<GetCategoryDto>>(categories);
        return categoriesDto;
    }
}