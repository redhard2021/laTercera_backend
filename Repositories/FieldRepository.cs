using laTercera.Models;
using laTercera.Repositories.IRepositories;

namespace laTercera.Repositories;

public class FieldRepository: Repository<Models.Field>, IFieldRepository
{
    private readonly ApplicationDbContext db;


    public FieldRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        db = dbContext;
    }

    public async Task<Models.Field> Update(Models.Field entity)
    {
        db.Field?.Update(entity);
        await db.SaveChangesAsync();
        return entity;
    }
}