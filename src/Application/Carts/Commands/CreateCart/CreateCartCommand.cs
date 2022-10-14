using AutoMapper;
using BookShop.src.Application.Common.Mappings;
using MediatR;

namespace BookShop.src.Application.Books.Commands.CreateBook;


public class CreateCartCommand : IRequest<bool>, IMapFrom<Cart>
{
    public decimal Subtotal { get; set; }
    //public ICollection<CartItem> cartItems { get; set; }
    public string? UserId { get; set; }
    public AppUser User { get; set; }

}

public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, bool>
{
    private readonly ICartRepository _repository;
    private readonly IMapper _mapper;
    public CreateCartCommandHandler(ICartRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<bool> Handle(CreateCartCommand request, CancellationToken cancellationToken)
    {

        var entity = _mapper.Map<Cart>(request);
        return await _repository.AddAsync(entity);

    }
}