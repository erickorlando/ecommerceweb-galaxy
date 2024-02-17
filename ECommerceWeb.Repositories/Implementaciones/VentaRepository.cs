using ECommerceWeb.DataAccess.Data;
using ECommerceWeb.Entities;
using ECommerceWeb.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ECommerceWeb.Repositories.Implementaciones
{
    public class VentaRepository : RepositoryBase<Venta>, IVentaRepository
    {
        public VentaRepository(ECommerceDbContext context) 
            : base(context)
        {
        }

        public override async Task AddAsync(Venta entity)
        {
            await Context.AddAsync(entity);
        }

        public async Task ConfirmarTransaccionAsync()
        {
            await Context.Database.CommitTransactionAsync();
            await Context.SaveChangesAsync();
        }

        public async Task CrearTransaccionAsync()
        {
            await Context.Database.BeginTransactionAsync(IsolationLevel.Serializable);
        }

        public Task<Dashboard> MostrarDashboard()
        {
            throw new NotImplementedException();
        }

        public async Task ResetearTransaccionAsync()
        {
            await Context.Database.RollbackTransactionAsync();
        }
    }
}
