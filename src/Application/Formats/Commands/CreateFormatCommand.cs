using System;
using AutoMapper;
using BookShop.src.Application.Common.Mappings;
using MediatR;

namespace Application.Formats.Commands;
public class CreateFormatCommand : IRequest<bool>, IMapFrom<Format>
{
public string Name { get; set; }
}

public class CreateFormatCommandHandler : IRequestHandler<CreateFormatCommand, bool>
{
private readonly IFormatRepository _repository;
private readonly IMapper _mapper;
public CreateFormatCommandHandler(IFormatRepository repository, IMapper mapper)
{
    this._repository = repository;
    this._mapper = mapper;
}

public async Task<bool> Handle(CreateFormatCommand request, CancellationToken cancellationToken)
{

    var entity = _mapper.Map<Format>(request);
    return await _repository.AddAsync(entity);

}
}

