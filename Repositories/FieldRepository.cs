﻿using laTercera.Models;
using laTercera.Repositories.IRepositories;

namespace laTercera.Repositories;

public class FieldRepository: Repository<Field>, IFieldRepository
{
    private readonly ApplicationDbContext db;


    public FieldRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        db = dbContext;
    }

    public async Task<Field> Update(Field entity)
    {
        db.Field?.Update(entity);
        await db.SaveChangesAsync();
        return entity;
    }
}