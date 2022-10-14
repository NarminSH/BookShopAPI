using System;
using Application.Dtos.BookDtos;
using Application.Dtos.GenreDtos;
using AutoMapper;
using MediatR;

namespace Application.Genres.Queries;
public record GetGenresQuery : IRequest<IEnumerable<GetGenreDto>>;

public class GetGenresQueryHandler : IRequestHandler<GetGenresQuery, IEnumerable<GetGenreDto>>
{
    private readonly IGenreRepository _repository;
    private readonly IMapper _mapper;

    public GetGenresQueryHandler(IGenreRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<IEnumerable<GetGenreDto>> Handle(GetGenresQuery request, CancellationToken cancellationToken)
    {
        var genres = await _repository.GetAllAsync();
        var genresDto = _mapper.Map<IEnumerable<GetGenreDto>>(genres);
        return genresDto;
    }
}
