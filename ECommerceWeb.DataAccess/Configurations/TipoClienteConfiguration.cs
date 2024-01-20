using ECommerceWeb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceWeb.DataAccess.Configurations;

public class TipoClienteConfiguration : IEntityTypeConfiguration<TipoCliente>
{
    public void Configure(EntityTypeBuilder<TipoCliente> builder)
    {
        // Data Seeding
        // Aca especificamos data inicial para esta tabla, ya que no requiere un CRUD
        builder.HasData(new List<TipoCliente>()
        {
            new() { Id = 1, Descripcion = "Cliente Normal" },
            new() { Id = 2, Descripcion = "Cliente Especial" },
        });
    }
}