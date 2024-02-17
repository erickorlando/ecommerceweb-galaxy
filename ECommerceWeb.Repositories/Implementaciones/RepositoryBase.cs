using ECommerceWeb.DataAccess.Data;
using ECommerceWeb.Entities;
using ECommerceWeb.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECommerceWeb.Repositories.Implementaciones;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
{
    protected readonly ECommerceDbContext Context;

    protected RepositoryBase(ECommerceDbContext context)
    {
        Context = context;
    }

    public async Task<ICollection<TEntity>> ListAsync()
    {
        return await Context.Set<TEntity>()
            .Where(p => p.Estado)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await Context.Set<TEntity>()
            .Where(predicate)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<TEntity?> FindAsync(int id)
    {
        return await Context.Set<TEntity>().FindAsync(id);
    }

    public virtual async Task AddAsync(TEntity entity)
    {
        await Context.Set<TEntity>().AddAsync(entity);
        await Context.SaveChangesAsync();
    }

    public async Task UpdateAsync()
    {
        await Context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var registro = await FindAsync(id);
        if (registro is not null)
        {
            registro.Estado = false;
            await UpdateAsync();
        }
    }
}