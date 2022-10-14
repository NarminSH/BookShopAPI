using AutoMapper;
using BookShop.src.Application.Common.Mappings;
using MediatR;

namespace BookShop.src.Application.Categories.Commands.CreateCategory;


public class CreateCartItemCommand : IRequest<bool>, IMapFrom<CartItem>
{
    public int Count { get; set; }
    public decimal Price { get; set; }
    public decimal Total { get; set; }
    public int BookId { get; set; }
    public string? UserId { get; set; }
    public int CartId { get; set; }
}

public class CreateCartItemCommandHandler : IRequestHandler<CreateCartItemCommand, bool>
{
    private readonly ICartItemRepository _repository;
    private readonly IMapper _mapper;
    public CreateCartItemCommandHandler(ICartItemRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<bool> Handle(CreateCartItemCommand request, CancellationToken cancellationToken)
    {

        var entity = _mapper.Map<CartItem>(request);
        return await _repository.AddAsync(entity);

    }
}