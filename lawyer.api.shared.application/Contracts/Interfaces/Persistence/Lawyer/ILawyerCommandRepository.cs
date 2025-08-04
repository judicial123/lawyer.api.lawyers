using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.shared.application.Contracts.Interfaces.Persistence.Lawyer;

public interface ILawyerCommandRepository : ICommandRepository<domain.Lawyer>
{
}