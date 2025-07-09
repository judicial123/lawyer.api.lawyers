using AutoMapper;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.Example;
using ${SolutionName}.Infrastructure.DatabaseContext;
using ${SolutionName}.Infrastructure.Model;
using ${SolutionName}.Infrastructure.Repositories.Common;

namespace ${SolutionName}.Infrastructure.Repositories.Example;

public class ExampleQueryRepository : QueryRepository<domain.Example, ExampleEntity>, IExampleQueryRepository
{
    private readonly IMapper _mapper;

    public ExampleQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
