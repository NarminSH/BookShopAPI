using AutoMapper;
using BookShop.src.Application.Common.Mappings;
//using Infrastructure.Persistence;
using MediatR;

namespace BookShop.src.Application.Categories.Commands.CreateCategory;


public class CreateCategoryCommand : IRequest<bool>, IMapFrom<Category>
{
    public string Name { get; set; } = null!;
    public int? ParentId { get; set; } 
}

public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, bool>
{
    private readonly ICategoryRepository _repository;
    private readonly IMapper _mapper;
    public CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {

        var entity = _mapper.Map<Category>(request);
        return await _repository.AddAsync(entity);
        

    }
}