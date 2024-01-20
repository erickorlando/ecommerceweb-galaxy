using System.Linq.Expressions;
using ECommerceWeb.Entities;
using ECommerceWeb.Repositories.Interfaces;

namespace ECommerceWeb.Repositories.Implementaciones;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
{
    public Task<ICollection<TEntity>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<TEntity>> ListAsync(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity?> FindAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}