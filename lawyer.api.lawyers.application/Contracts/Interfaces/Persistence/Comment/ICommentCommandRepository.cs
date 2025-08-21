using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Common;

namespace lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Comment;

public interface ICommentCommandRepository : ICommandRepository<domain.Comment>
{
}
