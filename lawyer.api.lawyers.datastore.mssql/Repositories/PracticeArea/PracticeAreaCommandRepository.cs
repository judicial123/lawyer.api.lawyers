using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.PracticeArea;
using lawyer.api.lawyers.datastore.mssql.DatabaseContext;
using lawyer.api.lawyers.datastore.mssql.Model;
using lawyer.api.lawyers.datastore.mssql.Repositories.Common;
using domain = lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.datastore.mssql.Repositories.PracticeArea;

public class PracticeAreaCommandRepository : CommandRepository<domain.PracticeArea, PracticeAreaEntity>, IPracticeAreaCommandRepository
{
    private readonly IMapper _mapper;

    public PracticeAreaCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
