using lawyer.api.shared.domain.Common;

namespace lawyer.api.shared.application.Contracts.Interfaces.Persistence.Common;

public interface IQueryRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(Guid id, params string[] includes);
    Task<List<T>> GetAllAsync(params string[] includes);
}