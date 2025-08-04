using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.LawFirm;
using MediatR;

namespace lawyer.api.shared.application.UseCases.LawFirm.Create;

public class CreateLawFirmCommandHandler : IRequestHandler<CreateLawFirmCommand, Guid>
{
    private readonly ILawFirmCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateLawFirmCommandHandler(
        ILawFirmCommandRepository command,
        IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateLawFirmCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.LawFirm>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}
