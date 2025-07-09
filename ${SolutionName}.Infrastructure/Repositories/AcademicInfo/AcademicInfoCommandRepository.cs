using AutoMapper;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.AcademicInfo;
using ${SolutionName}.Infrastructure.DatabaseContext;
using ${SolutionName}.Infrastructure.Model;
using ${SolutionName}.Infrastructure.Repositories.Common;

namespace ${SolutionName}.Infrastructure.Repositories.AcademicInfo;

public class AcademicInfoCommandRepository : CommandRepository<domain.AcademicInfo, AcademicInfoEntity>, IAcademicInfoCommandRepository
{
    private readonly IMapper _mapper;

    public AcademicInfoCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}

