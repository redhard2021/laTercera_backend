using laTercera.Models;

namespace laTercera.Repositories.IRepositories;

public interface IFieldRepository : IRepository<Field>
{
    Task<Field> Update(Field entity);
}