using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.shared.datastore.mssql.DatabaseContext;
using lawyer.api.shared.datastore.mssql.Model;
using lawyer.api.shared.datastore.mssql.Repositories.Common;

namespace lawyer.api.shared.datastore.mssql.Repositories.Example;

public class ExampleCommandRepository : CommandRepository<domain.Example, ExampleEntity>, IExampleCommandRepository
{
    private readonly IMapper _mapper;

    public ExampleCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
