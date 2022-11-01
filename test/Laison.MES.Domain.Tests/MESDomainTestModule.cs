using Laison.MES.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.MES
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(MESEntityFrameworkCoreTestModule)
        )]
    public class MESDomainTestModule : AbpModule
    {
        
    }
}
