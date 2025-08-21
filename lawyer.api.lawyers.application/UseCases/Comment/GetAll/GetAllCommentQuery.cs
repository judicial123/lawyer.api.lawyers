using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Comment.GetAll;

public class GetAllCommentQuery : IRequest<List<CommentDto>>
{
}
