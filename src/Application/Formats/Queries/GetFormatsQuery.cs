using Application.Dtos.FormatDtos;
using Application.Dtos.GenreDtos;
using AutoMapper;
using MediatR;

namespace Application.Formats.Queries;

public record GetFormatsQuery : IRequest<IEnumerable<GetFormatDto>>;

public class GetFormatsQueryHandler : IRequestHandler<GetFormatsQuery, IEnumerable<GetFormatDto>>
{
    private readonly IFormatRepository _repository;
    private readonly IMapper _mapper;

    public GetFormatsQueryHandler(IFormatRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<IEnumerable<GetFormatDto>> Handle(GetFormatsQuery request, CancellationToken cancellationToken)
    {
        var formats = await _repository.GetAllAsync();
        var formatsDto = _mapper.Map<IEnumerable<GetFormatDto>>(formats);
        return formatsDto;
    }
}


