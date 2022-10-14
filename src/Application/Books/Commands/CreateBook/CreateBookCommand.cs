using AutoMapper;
using BookShop.src.Application.Common.Mappings;
using MediatR;

namespace BookShop.src.Application.Books.Commands.CreateBook;


public class CreateBookCommand : IRequest<bool>, IMapFrom<Book>
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Author { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal DiscountPrice { get; set; }
    public int Quantity { get; set; }
    public string? UserId { get; set; }
    public double Rate { get; set; }
    public int CategoryId { get; set; }
}

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, bool>
{
    private readonly IBookRepository _repository;
    private readonly IMapper _mapper;
    public CreateBookCommandHandler(IBookRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<bool> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {

        var entity = _mapper.Map<Book>(request);
        return await _repository.AddAsync(entity);

    }
}