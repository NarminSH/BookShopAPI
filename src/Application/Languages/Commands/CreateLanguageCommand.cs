using System;
using AutoMapper;
using BookShop.src.Application.Common.Mappings;
using MediatR;

namespace Application.Languages.Commands;

public class CreateLanguageCommand : IRequest<bool>, IMapFrom<Language>
{
    public string Name { get; set; } = null!;
}

public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageCommand, bool>
{
    private readonly ILanguageRepository _repository;
    private readonly IMapper _mapper;
    public CreateLanguageCommandHandler(ILanguageRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<bool> Handle(CreateLanguageCommand request, CancellationToken cancellationToken)
    {

        var entity = _mapper.Map<Language>(request);
        return await _repository.AddAsync(entity);

    }
}
