using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Comment;
using lawyer.api.lawyers.datastore.mssql.DatabaseContext;
using lawyer.api.lawyers.datastore.mssql.Model;
using lawyer.api.lawyers.datastore.mssql.Repositories.Common;

namespace lawyer.api.lawyers.datastore.mssql.Repositories.Comment;

public class CommentQueryRepository : QueryRepository<domain.Comment, CommentEntity>, ICommentQueryRepository
{
    private readonly IMapper _mapper;

    public CommentQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
