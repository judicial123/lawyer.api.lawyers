using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Comment;
using lawyer.api.lawyers.datastore.mssql.DatabaseContext;
using lawyer.api.lawyers.datastore.mssql.Model;
using lawyer.api.lawyers.datastore.mssql.Repositories.Common;

namespace lawyer.api.lawyers.datastore.mssql.Repositories.Comment;

public class CommentCommandRepository : CommandRepository<domain.Comment, CommentEntity>, ICommentCommandRepository
{
    private readonly IMapper _mapper;

    public CommentCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
