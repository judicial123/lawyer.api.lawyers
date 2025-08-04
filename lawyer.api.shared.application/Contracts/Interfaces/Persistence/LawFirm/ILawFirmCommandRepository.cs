using lawyer.api.shared.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.shared.application.Contracts.Interfaces.Persistence.LawFirm;

public interface ILawFirmCommandRepository : ICommandRepository<domain.LawFirm>
{
}
