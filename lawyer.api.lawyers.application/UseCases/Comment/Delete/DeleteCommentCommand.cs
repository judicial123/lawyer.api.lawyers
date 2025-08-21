using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Comment.Delete;

public class DeleteCommentCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
