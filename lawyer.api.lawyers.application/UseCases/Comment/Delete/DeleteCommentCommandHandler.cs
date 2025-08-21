using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Comment;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Comment.Delete;

public class DeleteCommentCommandHandler : IRequestHandler<DeleteCommentCommand, Unit>
{
    private readonly ICommentCommandRepository _command;
    private readonly ICommentQueryRepository _query;

    public DeleteCommentCommandHandler(ICommentCommandRepository command, ICommentQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Unit> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        await _command.DeleteAsync(entity);
        return Unit.Value;
    }
}
