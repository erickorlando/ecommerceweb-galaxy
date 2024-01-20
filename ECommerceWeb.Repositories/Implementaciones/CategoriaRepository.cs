using ECommerceWeb.DataAccess.Data;
using ECommerceWeb.Entities;
using ECommerceWeb.Repositories.Interfaces;

namespace ECommerceWeb.Repositories.Implementaciones;
public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
{
    public CategoriaRepository(ECommerceDbContext context) 
        : base(context)
    {
    }
}
