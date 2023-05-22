using laTercera.Models;
using laTercera.Repositories.IRepositories;

namespace laTercera.Repositories;

public class TournamentRepository: Repository<Tournament>, ITournamentRepository
{
    private readonly ApplicationDbContext db;


    public TournamentRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        db = dbContext;
    }

    public async Task<Tournament> Update(Tournament entity)
    {
        db.Tournament?.Update(entity);
        await db.SaveChangesAsync();
        return entity;
    }
}