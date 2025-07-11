using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Lawyer;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Lawyer.Create;

public class CreateLawyerCommandHandler : IRequestHandler<CreateLawyerCommand, Guid>
{
    private readonly ILawyerCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateLawyerCommandHandler(
        ILawyerCommandRepository command,
        IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateLawyerCommand request, CancellationToken cancellationToken)
    {
        var lawyer = _mapper.Map<domain.Lawyer>(request);
        await _command.CreateAsync(lawyer);

        return lawyer.Id;
    }
}