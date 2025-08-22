using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Comment.Create;

public class CreateCommentCommand : IRequest<Guid>
{
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public string CommentMessage { get; set; } = string.Empty;
    public int Stars { get; set; }
}
