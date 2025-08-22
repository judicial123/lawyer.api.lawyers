using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Comment.Update;

public class UpdateCommentCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public string CommentMessage { get; set; } = string.Empty;
    public int Stars { get; set; }
}
