using ECommerceWeb.DataAccess.Data;
using ECommerceWeb.Entities;
using ECommerceWeb.Entities.Infos;
using ECommerceWeb.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerceWeb.Repositories.Implementaciones;

public class ProductoRepository : RepositoryBase<Producto>, IProductoRepository
{
    public ProductoRepository(ECommerceDbContext context) 
        : base(context)
    {
    }

    public async Task<ICollection<ProductoInfo>> ListarAsync()
    {
        return await Context.Set<Producto>()
            .Where(p => p.Estado)
            .Select(x => new ProductoInfo
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Descripcion = x.Descripcion,
                Categoria = x.Categoria.Nombre,
                Marca = x.Marca.Nombre,
                PrecioUnitario = x.PrecioUnitario
            })
            .AsNoTracking()
            .ToListAsync();
    }
}