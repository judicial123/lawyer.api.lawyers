using AutoMapper;
using lawyer.api.shared.application.Contracts.Interfaces.Persistence.LawFirm;
using lawyer.api.shared.datastore.mssql.DatabaseContext;
using lawyer.api.shared.datastore.mssql.Model;
using lawyer.api.shared.datastore.mssql.Repositories.Common;

namespace lawyer.api.shared.datastore.mssql.Repositories.LawFirm;

public class LawFirmQueryRepository : QueryRepository<domain.LawFirm, LawFirmEntity>, ILawFirmQueryRepository
{
    private readonly IMapper _mapper;

    public LawFirmQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
