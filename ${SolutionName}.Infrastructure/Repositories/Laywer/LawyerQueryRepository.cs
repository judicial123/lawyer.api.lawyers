using AutoMapper;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.Lawyer;
using ${SolutionName}.Infrastructure.DatabaseContext;
using ${SolutionName}.Infrastructure.Model;
using ${SolutionName}.Infrastructure.Repositories.Common;

namespace ${SolutionName}.Infrastructure.Repositories.Lawyer;

public class LawyerQueryRepository : QueryRepository<domain.Lawyer, LawyerEntity>, ILawyerQueryRepository
{
    private readonly IMapper _mapper;

    public LawyerQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}