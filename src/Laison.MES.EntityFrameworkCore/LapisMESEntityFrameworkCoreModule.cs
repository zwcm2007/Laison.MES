using Laison.Lapis.Shared.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Laison.MES.Domain;
using Volo.Abp.Modularity;

namespace Laison.MES.EntityFrameworkCore
{
    [DependsOn(
        typeof(LapisMESDomainModule),
        typeof(LapisSharedEntityFrameworkCoreModule)
    )]
    public class LapisMESEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MESDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);

                // Add custom repositories
                options.AddRepository<Order, OrderRepository>();
            });
        }
    }
}