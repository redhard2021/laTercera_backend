using laTercera.Models;

namespace laTercera.Repositories.IRepositories;

public interface IOrganizerRepository : IRepository<Organizer>
{
    Task<Organizer> Update(Organizer entity);
}