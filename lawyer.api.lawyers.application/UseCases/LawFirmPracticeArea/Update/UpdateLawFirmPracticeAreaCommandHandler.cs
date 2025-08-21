using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirmPracticeArea;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.Update;

public class UpdateLawFirmPracticeAreaCommandHandler : IRequestHandler<UpdateLawFirmPracticeAreaCommand, Guid>
{
    private readonly ILawFirmPracticeAreaCommandRepository _command;
    private readonly ILawFirmPracticeAreaQueryRepository _query;
    private readonly IMapper _mapper;

    public UpdateLawFirmPracticeAreaCommandHandler(ILawFirmPracticeAreaCommandRepository command, ILawFirmPracticeAreaQueryRepository query, IMapper mapper)
    {
        _command = command;
        _query = query;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(UpdateLawFirmPracticeAreaCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        if (entity == null) return Guid.Empty;
        _mapper.Map(request, entity);
        await _command.UpdateAsync(entity);
        return entity.Id;
    }
}

