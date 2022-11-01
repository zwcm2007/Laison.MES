using Laison.MES.Domain.Shared;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Laison.MES.Domain
{
    [DependsOn(
        typeof(LapisMESDomainSharedModule)
    )]
    public class LapisMESDomainModule : AbpModule
    {

    }
}
