using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Example;

public interface IExampleCommandRepository : ICommandRepository<domain.Example>
{
}
