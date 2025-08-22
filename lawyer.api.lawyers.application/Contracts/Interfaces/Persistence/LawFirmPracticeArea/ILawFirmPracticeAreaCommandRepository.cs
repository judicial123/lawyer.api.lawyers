using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Common;
using domain = lawyer.api.lawyers.domain;

namespace lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirmPracticeArea;

public interface ILawFirmPracticeAreaCommandRepository : ICommandRepository<domain.LawFirmPracticeArea>
{
}

