using System;
using AutoMapper;
using BookShop.src.Application.Common.Mappings;
using MediatR;

namespace Application.Genres.Commands;
public class CreateGenreCommand : IRequest<bool>, IMapFrom<Genre>
{
    public string Name { get; set; }
}

public class CreateGenreCommandHandler : IRequestHandler<CreateGenreCommand, bool>
{
    private readonly IGenreRepository _repository;
    private readonly IMapper _mapper;
    public CreateGenreCommandHandler(IGenreRepository repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

    public async Task<bool> Handle(CreateGenreCommand request, CancellationToken cancellationToken)
    {

        var entity = _mapper.Map<Genre>(request);
        return await _repository.AddAsync(entity);

    }
}