using laTercera.Models;

namespace laTercera.Repositories.IRepositories;

public interface IFieldRepository : IRepository<Models.Field>
{
    Task<Models.Field> Update(Models.Field entity);
}