using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.PracticeArea;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.PracticeArea.Update;

public class UpdatePracticeAreaCommandHandler : IRequestHandler<UpdatePracticeAreaCommand, Guid>
{
    private readonly IPracticeAreaCommandRepository _command;
    private readonly IPracticeAreaQueryRepository _query;
    private readonly IMapper _mapper;

    public UpdatePracticeAreaCommandHandler(IPracticeAreaCommandRepository command, IPracticeAreaQueryRepository query, IMapper mapper)
    {
        _command = command;
        _query = query;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(UpdatePracticeAreaCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        if (entity == null) return Guid.Empty;
        _mapper.Map(request, entity);
        await _command.UpdateAsync(entity);
        return entity.Id;
    }
}
