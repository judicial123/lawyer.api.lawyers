using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.AcademicInfo;
using lawyer.api.shared.datastore.mssql.DatabaseContext;
using lawyer.api.shared.datastore.mssql.Model;
using lawyer.api.shared.datastore.mssql.Repositories.Common;

namespace lawyer.api.shared.datastore.mssql.Repositories.AcademicInfo;

public class AcademicInfoQueryRepository : QueryRepository<domain.AcademicInfo, AcademicInfoEntity>, IAcademicInfoQueryRepository
{
    private readonly IMapper _mapper;

    public AcademicInfoQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}

