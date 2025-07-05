using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Lawyer;

public interface ILawyerQueryRepository : IQueryRepository<domain.Lawyer>
{
}