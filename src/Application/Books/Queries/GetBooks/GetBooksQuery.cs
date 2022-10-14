using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Application.Dtos.CategoryDtos;
using Microsoft.EntityFrameworkCore;
using Application.Dtos.BookDtos;

namespace BookShop.src.Application.Books.Queries.GetBooks;
public record GetBooksQuery : IRequest<IEnumerable<GetBookDto>>;

public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, IEnumerable<GetBookDto>>
{
    private readonly IBookRepository _repository;
    private readonly IMapper _mapper;

    public GetBooksQueryHandler(IBookRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<IEnumerable<GetBookDto>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
    {
        var books = await _repository.GetAllAsync();
        var booksDto = _mapper.Map<IEnumerable<GetBookDto>>(books);
        return booksDto;
    }
}