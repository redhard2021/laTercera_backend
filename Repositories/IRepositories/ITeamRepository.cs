using laTercera.Models;

namespace laTercera.Repositories.IRepositories;

public interface ITeamRepository : IRepository<Team>
{
    Task<Team> Update(Team entity);
}