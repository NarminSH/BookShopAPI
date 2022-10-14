using System;
using Application.Dtos.BookDtos;
using Application.Dtos.LanguageDtos;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Languages.Queries;
public record GetLanguagesQuery : IRequest<IEnumerable<GetLanguageDto>>;

public class GetLanguagesQueryHandler : IRequestHandler<GetLanguagesQuery, IEnumerable<GetLanguageDto>>
{
    private readonly ILanguageRepository _repository;
    private readonly IMapper _mapper;

    public GetLanguagesQueryHandler(ILanguageRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<IEnumerable<GetLanguageDto>> Handle(GetLanguagesQuery request, CancellationToken cancellationToken)
    {
        var languages = await _repository.GetAllAsync();

        var languagesDto = _mapper.Map<IEnumerable<GetLanguageDto>>(languages);
        return languagesDto;
    }
} 