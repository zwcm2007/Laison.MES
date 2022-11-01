using Microsoft.Extensions.DependencyInjection;
using Laison.MES.Application.Contracts;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Laison.MES.HttpApi
{
    [DependsOn(
        typeof(LapisMESApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class LapisMESHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(LapisMESHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}