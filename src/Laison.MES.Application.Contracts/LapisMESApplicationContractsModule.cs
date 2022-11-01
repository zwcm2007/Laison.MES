using Laison.MES.Domain.Shared;
using Volo.Abp.Modularity;

namespace Laison.MES.Application.Contracts
{
    [DependsOn(
        typeof(LapisMESDomainSharedModule)
        )]
    public class LapisMESApplicationContractsModule : AbpModule
    {
    }
}