using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.shared.application.Contracts.Interfaces.Persistence.Example;

public interface IExampleCommandRepository : ICommandRepository<domain.Example>
{
}
