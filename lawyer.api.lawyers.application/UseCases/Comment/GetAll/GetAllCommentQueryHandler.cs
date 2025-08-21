using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Comment;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Comment.GetAll;

public class GetAllCommentQueryHandler : IRequestHandler<GetAllCommentQuery, List<CommentDto>>
{
    private readonly ICommentQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllCommentQueryHandler(IMapper mapper, ICommentQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<CommentDto>> Handle(GetAllCommentQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync();
        return _mapper.Map<List<CommentDto>>(entities);
    }
}
