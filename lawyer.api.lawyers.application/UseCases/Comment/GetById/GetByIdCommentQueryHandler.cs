using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Comment;
using lawyer.api.lawyers.application.DTO;
using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Comment.GetById;

public class GetByIdCommentQueryHandler : IRequestHandler<GetByIdCommentQuery, CommentDto>
{
    private readonly IMapper _mapper;
    private readonly ICommentQueryRepository _query;

    public GetByIdCommentQueryHandler(IMapper mapper, ICommentQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<CommentDto> Handle(GetByIdCommentQuery request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        return _mapper.Map<CommentDto>(entity);
    }
}
