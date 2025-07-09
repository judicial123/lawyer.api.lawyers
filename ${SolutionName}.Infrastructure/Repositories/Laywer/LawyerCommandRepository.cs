using AutoMapper;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.Lawyer;
using ${SolutionName}.Infrastructure.DatabaseContext;
using ${SolutionName}.Infrastructure.Model;
using ${SolutionName}.Infrastructure.Repositories.Common;

namespace ${SolutionName}.Infrastructure.Repositories.Laywer;

public class LawyerCommandRepository : CommandRepository<domain.Lawyer, LawyerEntity>, ILawyerCommandRepository
{
    private readonly IMapper _mapper;

    public LawyerCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }}