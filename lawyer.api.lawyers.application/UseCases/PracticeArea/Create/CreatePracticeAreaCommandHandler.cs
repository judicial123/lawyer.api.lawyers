using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.PracticeArea;
using MediatR;
using domain = lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.application.UseCases.PracticeArea.Create;

public class CreatePracticeAreaCommandHandler : IRequestHandler<CreatePracticeAreaCommand, Guid>
{
    private readonly IPracticeAreaCommandRepository _command;
    private readonly IMapper _mapper;

    public CreatePracticeAreaCommandHandler(IPracticeAreaCommandRepository command, IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreatePracticeAreaCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.PracticeArea>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}
