using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.lawyers.datastore.mssql.DatabaseContext;
using lawyer.api.lawyers.datastore.mssql.Model;
using lawyer.api.lawyers.datastore.mssql.Repositories.Common;

namespace lawyer.api.lawyers.datastore.mssql.Repositories.Example;

public class ExampleQueryRepository : QueryRepository<domain.Example, ExampleEntity>, IExampleQueryRepository
{
    private readonly IMapper _mapper;

    public ExampleQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
