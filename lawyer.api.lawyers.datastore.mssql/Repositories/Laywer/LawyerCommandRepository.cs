using AutoMapper;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Lawyer;
using lawyer.api.lawyers.datastore.mssql.DatabaseContext;
using lawyer.api.lawyers.datastore.mssql.Model;
using lawyer.api.lawyers.datastore.mssql.Repositories.Common;

namespace lawyer.api.lawyers.datastore.mssql.Repositories.Laywer;

public class LawyerCommandRepository : CommandRepository<domain.Lawyer, LawyerEntity>, ILawyerCommandRepository
{
    private readonly IMapper _mapper;

    public LawyerCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}