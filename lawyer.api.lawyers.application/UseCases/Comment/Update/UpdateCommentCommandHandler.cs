using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Comment;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Comment.Update;

public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand, Guid>
{
    private readonly ICommentCommandRepository _command;
    private readonly ICommentQueryRepository _query;

    public UpdateCommentCommandHandler(ICommentCommandRepository command, ICommentQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Guid> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        if (entity == null) throw new KeyNotFoundException($"The comment with ID {request.Id} does not exist.");

        entity.IdUser = request.IdUser;
        entity.IdLawFirm = request.IdLawFirm;
        entity.CommentMessage = request.CommentMessage;
        entity.Stars = request.Stars;
        entity.DateModified = DateTime.UtcNow;

        await _command.UpdateAsync(entity);
        return entity.Id;
    }
}
