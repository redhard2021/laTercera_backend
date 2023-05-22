using laTercera.Models;

namespace laTercera.Repositories.IRepositories;

public interface ITournamentRepository : IRepository<Tournament>
{
    Task<Tournament> Update(Tournament entity);
}