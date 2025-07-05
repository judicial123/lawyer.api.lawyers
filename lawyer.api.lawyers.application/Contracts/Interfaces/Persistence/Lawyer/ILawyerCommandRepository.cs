using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Lawyer;

public interface ILawyerCommandRepository : ICommandRepository<domain.Lawyer>
{
}