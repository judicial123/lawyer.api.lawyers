using ${SolutionName}.Domain.Common;

namespace ${SolutionName}.Application.Contracts.Interfaces.Persistence.Common;

public interface IQueryRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(Guid id, params string[] includes);
    Task<List<T>> GetAllAsync(params string[] includes);}