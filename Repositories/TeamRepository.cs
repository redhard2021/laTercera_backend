using System.Linq.Expressions;
using laTercera.Models;
using laTercera.Repositories.IRepositories;

namespace laTercera.Repositories;

public class TeamRepository: Repository<Team>, ITeamRepository
{
    private readonly ApplicationDbContext db;


    public TeamRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        db = dbContext;
    }

    public async Task<Team> Update(Team entity)
    {
        db.Team?.Update(entity);
        await db.SaveChangesAsync();
        return entity;
    }
}