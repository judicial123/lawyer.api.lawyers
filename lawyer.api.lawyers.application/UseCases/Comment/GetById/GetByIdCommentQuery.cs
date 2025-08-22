using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Comment.GetById;

public class GetByIdCommentQuery : IRequest<CommentDto>
{
    public GetByIdCommentQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
