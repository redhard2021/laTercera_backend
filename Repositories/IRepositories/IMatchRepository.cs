using laTercera.Models;

namespace laTercera.Repositories.IRepositories;

public interface IMatchRepository : IRepository<Match>
{
    Task<Match> Update(Match entity);
}