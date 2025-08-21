using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Common;
using domain = lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.PracticeArea;

public interface IPracticeAreaCommandRepository : ICommandRepository<domain.PracticeArea>
{
}
