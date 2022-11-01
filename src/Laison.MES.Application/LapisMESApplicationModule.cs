using Laison.Lapis.Shared.Application;
using Microsoft.Extensions.DependencyInjection;
using Laison.MES.Application.Contracts;
using Laison.MES.Domain;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Laison.MES.Application
{
    [DependsOn(
        typeof(LapisMESDomainModule),
        typeof(LapisMESApplicationContractsModule),
        typeof(LapisSharedApplicationModule)
        )]
    public class LapisMESApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<LapisMESApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<LapisMESApplicationModule>(validate: true);
            });


            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                options.ConventionalControllers
                    .Create(typeof(LapisMESApplicationModule).Assembly, opts =>
                    {
                        opts.RootPath = "MES";
                    });
            });
        }
    }
}