using laTercera.Models;
using laTercera.Repositories.IRepositories;

namespace laTercera.Repositories;

public class OrganizerRepository: Repository<Organizer>, IOrganizerRepository
{
    private readonly ApplicationDbContext db;


    public OrganizerRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        db = dbContext;
    }
    
    public async Task<Organizer> Update(Organizer entity)
    {
        db.Organizer?.Update(entity);
        await db.SaveChangesAsync();
        return entity;
    }
}