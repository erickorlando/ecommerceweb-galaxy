using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerceWeb.DataAccess.Data;

public class ECommerceDbContext : IdentityDbContext<IdentityUserECommerce>
{
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
        :base(options)
    {
        
    }

    // Por aca van los DbSet

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ECommerceDbContext).Assembly);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);

        configurationBuilder.Properties<string>()
            .HaveMaxLength(100);
    }
}