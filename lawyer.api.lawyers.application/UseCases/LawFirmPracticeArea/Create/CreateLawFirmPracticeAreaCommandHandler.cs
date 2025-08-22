using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirmPracticeArea;
using MediatR;
using domain = lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.Create;

public class CreateLawFirmPracticeAreaCommandHandler : IRequestHandler<CreateLawFirmPracticeAreaCommand, Guid>
{
    private readonly ILawFirmPracticeAreaCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateLawFirmPracticeAreaCommandHandler(ILawFirmPracticeAreaCommandRepository command, IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateLawFirmPracticeAreaCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.LawFirmPracticeArea>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}

