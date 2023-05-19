using System.Linq.Expressions;

namespace laTercera.Repositories.IRepositories;

public interface IRepository<T> where T : class
{
    Task Create(T entity);
    Task Remove(T entity);
    Task Save();
    Task<List<T>> GetAll();
    Task<T> Get(Expression<Func<T, bool>>? filter = null);
}