using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirm;

public interface ILawFirmCommandRepository : ICommandRepository<domain.LawFirm>
{
}
