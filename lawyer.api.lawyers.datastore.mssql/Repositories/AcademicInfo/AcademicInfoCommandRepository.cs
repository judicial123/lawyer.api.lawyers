using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.AcademicInfo;
using lawyer.api.lawyers.datastore.mssql.DatabaseContext;
using lawyer.api.lawyers.datastore.mssql.Model;
using lawyer.api.lawyers.datastore.mssql.Repositories.Common;

namespace lawyer.api.lawyers.datastore.mssql.Repositories.AcademicInfo;

public class AcademicInfoCommandRepository : CommandRepository<domain.AcademicInfo, AcademicInfoEntity>, IAcademicInfoCommandRepository
{
    private readonly IMapper _mapper;

    public AcademicInfoCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}

