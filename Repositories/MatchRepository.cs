using laTercera.Models;
using laTercera.Repositories.IRepositories;

namespace laTercera.Repositories;

public class MatchRepository: Repository<Match>, IMatchRepository
{
    private readonly ApplicationDbContext db;


    public MatchRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        db = dbContext;
    }
    
    public async Task<Match> Update(Match entity)
    {
        db.Match?.Update(entity);
        await db.SaveChangesAsync();
        return entity;
    }
}