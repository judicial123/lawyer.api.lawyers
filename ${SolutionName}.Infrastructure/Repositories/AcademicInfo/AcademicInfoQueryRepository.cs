using AutoMapper;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.AcademicInfo;
using ${SolutionName}.Infrastructure.DatabaseContext;
using ${SolutionName}.Infrastructure.Model;
using ${SolutionName}.Infrastructure.Repositories.Common;

namespace ${SolutionName}.Infrastructure.Repositories.AcademicInfo;

public class AcademicInfoQueryRepository : QueryRepository<domain.AcademicInfo, AcademicInfoEntity>, IAcademicInfoQueryRepository
{
    private readonly IMapper _mapper;

    public AcademicInfoQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}

