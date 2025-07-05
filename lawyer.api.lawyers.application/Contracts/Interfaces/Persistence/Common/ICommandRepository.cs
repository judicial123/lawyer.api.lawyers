using lawyer.api.lawyers.domain.Common;

namespace lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Common;

public interface ICommandRepository<T> where T : BaseEntity
{
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}