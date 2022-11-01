using Laison.Lapis.Shared.Host;
using Laison.MES.Application;
using Laison.MES.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Laison.MES
{
    [DependsOn(
        typeof(LapisMESApplicationModule),
        typeof(LapisMESEntityFrameworkCoreModule),
        //typeof(LapisMESHttpApiModule),
        typeof(LapisSharedHostModule)
        )]
    public class MESHttpApiHostModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAlwaysAllowAuthorization(); // 总是允许授权
        }
    }
}