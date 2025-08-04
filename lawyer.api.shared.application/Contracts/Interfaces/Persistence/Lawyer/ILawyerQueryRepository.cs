using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.shared.application.Contracts.Interfaces.Persistence.Lawyer;

public interface ILawyerQueryRepository : IQueryRepository<domain.Lawyer>
{
}