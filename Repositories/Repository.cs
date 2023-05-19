using System.Linq.Expressions;
using laTercera.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace laTercera.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext db;
    internal DbSet<T> dbSet;

    public Repository(ApplicationDbContext dbContext)
    {
        db = dbContext;
        dbSet = db.Set<T>(); 
    }
    
    public async Task Create(T entity)
    {
        await dbSet.AddAsync(entity);
        await Save();
    }

    public async Task Remove(T entity)
    {
        dbSet.Remove(entity);
        await Save();
    }

    public async Task Save()
    {
        await db.SaveChangesAsync();
    }

    public async Task<List<T>> GetAll()
    {
        return await dbSet.ToListAsync();
    }

    public async Task<T> Get(Expression<Func<T, bool>>? filter = null)
    {
        IQueryable<T> query = dbSet;
        if (filter != null)
            query = query.Where(filter);
        return await dbSet.FirstOrDefaultAsync() ?? throw new InvalidOperationException();
    }
}