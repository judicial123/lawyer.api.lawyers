using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.AcademicInfo;
using MediatR;

namespace lawyer.api.shared.application.UseCases.AcademicInfo.Create;

public class CreateAcademicInfoCommandHandler : IRequestHandler<CreateAcademicInfoCommand, Guid>
{
    private readonly IAcademicInfoCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateAcademicInfoCommandHandler(
        IAcademicInfoCommandRepository command,
        IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateAcademicInfoCommand request, CancellationToken cancellationToken)
    {
        var info = _mapper.Map<domain.AcademicInfo>(request);
        await _command.CreateAsync(info);
        return info.Id;
    }
}

