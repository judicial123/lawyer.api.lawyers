using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirmPracticeArea;
using lawyer.api.lawyers.datastore.mssql.DatabaseContext;
using lawyer.api.lawyers.datastore.mssql.Model;
using lawyer.api.lawyers.datastore.mssql.Repositories.Common;
using domain = lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.datastore.mssql.Repositories.LawFirmPracticeArea;

public class LawFirmPracticeAreaQueryRepository : QueryRepository<domain.LawFirmPracticeArea, LawFirmPracticeAreaEntity>, ILawFirmPracticeAreaQueryRepository
{
    private readonly IMapper _mapper;

    public LawFirmPracticeAreaQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}

