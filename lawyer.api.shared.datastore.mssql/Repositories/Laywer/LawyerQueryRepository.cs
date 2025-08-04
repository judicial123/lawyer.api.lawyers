using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Lawyer;
using lawyer.api.shared.datastore.mssql.DatabaseContext;
using lawyer.api.shared.datastore.mssql.Model;
using lawyer.api.shared.datastore.mssql.Repositories.Common;

namespace lawyer.api.shared.datastore.mssql.Repositories.Lawyer;

public class LawyerQueryRepository : QueryRepository<domain.Lawyer, LawyerEntity>, ILawyerQueryRepository
{
    private readonly IMapper _mapper;

    public LawyerQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}