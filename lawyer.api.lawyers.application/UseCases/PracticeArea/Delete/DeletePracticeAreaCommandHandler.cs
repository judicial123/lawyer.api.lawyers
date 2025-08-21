using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.PracticeArea;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.PracticeArea.Delete;

public class DeletePracticeAreaCommandHandler : IRequestHandler<DeletePracticeAreaCommand>
{
    private readonly IPracticeAreaCommandRepository _command;
    private readonly IPracticeAreaQueryRepository _query;
    private readonly IMapper _mapper;

    public DeletePracticeAreaCommandHandler(IPracticeAreaCommandRepository command, IPracticeAreaQueryRepository query, IMapper mapper)
    {
        _command = command;
        _query = query;
        _mapper = mapper;
    }

    public async Task Handle(DeletePracticeAreaCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        if (entity != null)
        {
            await _command.DeleteAsync(entity);
        }
    }
}
