using CorePackages.Domain.Comman;

namespace CorePackages.Application.Interfaces.Repository;

public interface IGenericRepositoryAsync<T> where T : BaseEntity
{
    Task<List<T>> GetAll();
    Task<T> GetById(Guid Id);
    Task<T> GetByDynamic();
}
