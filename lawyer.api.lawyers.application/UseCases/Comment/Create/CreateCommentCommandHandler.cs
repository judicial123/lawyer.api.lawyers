using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Comment;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Comment.Create;

public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Guid>
{
    private readonly ICommentCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateCommentCommandHandler(ICommentCommandRepository command, IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.Comment>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}
