using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Example;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Example.Create;

public class CreateExampleCommandHandler : IRequestHandler<CreateExampleCommand, Guid>
{
    private readonly IExampleCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateExampleCommandHandler(
        IExampleCommandRepository command,
        IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateExampleCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.Example>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}
