using Laison.MES.Application;
using Volo.Abp.Modularity;

namespace Laison.MES
{
    [DependsOn(
        typeof(LapisMESApplicationModule),
        typeof(MESDomainTestModule)
        )]
    public class MESApplicationTestModule : AbpModule
    {

    }
}
