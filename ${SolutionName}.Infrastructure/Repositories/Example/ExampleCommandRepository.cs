using AutoMapper;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.Example;
using ${SolutionName}.Infrastructure.DatabaseContext;
using ${SolutionName}.Infrastructure.Model;
using ${SolutionName}.Infrastructure.Repositories.Common;

namespace ${SolutionName}.Infrastructure.Repositories.Example;

public class ExampleCommandRepository : CommandRepository<domain.Example, ExampleEntity>, IExampleCommandRepository
{
    private readonly IMapper _mapper;

    public ExampleCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
