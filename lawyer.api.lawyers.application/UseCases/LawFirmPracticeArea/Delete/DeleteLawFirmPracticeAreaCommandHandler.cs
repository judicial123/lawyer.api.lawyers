using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirmPracticeArea;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.LawFirmPracticeArea.Delete;

public class DeleteLawFirmPracticeAreaCommandHandler : IRequestHandler<DeleteLawFirmPracticeAreaCommand>
{
    private readonly ILawFirmPracticeAreaCommandRepository _command;
    private readonly ILawFirmPracticeAreaQueryRepository _query;
    private readonly IMapper _mapper;

    public DeleteLawFirmPracticeAreaCommandHandler(ILawFirmPracticeAreaCommandRepository command, ILawFirmPracticeAreaQueryRepository query, IMapper mapper)
    {
        _command = command;
        _query = query;
        _mapper = mapper;
    }

    public async Task Handle(DeleteLawFirmPracticeAreaCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        if (entity != null)
        {
            await _command.DeleteAsync(entity);
        }
    }
}

