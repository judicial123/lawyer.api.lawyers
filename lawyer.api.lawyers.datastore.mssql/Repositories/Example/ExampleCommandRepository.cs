using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.lawyers.datastore.mssql.DatabaseContext;
using lawyer.api.lawyers.datastore.mssql.Model;
using lawyer.api.lawyers.datastore.mssql.Repositories.Common;

namespace lawyer.api.lawyers.datastore.mssql.Repositories.Example;

public class ExampleCommandRepository : CommandRepository<domain.Example, ExampleEntity>, IExampleCommandRepository
{
    private readonly IMapper _mapper;

    public ExampleCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
