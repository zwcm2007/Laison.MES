using Microsoft.EntityFrameworkCore;
using Laison.MES.Domain;
using Laison.MES.Domain.Shared;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.MES.EntityFrameworkCore
{
    [ConnectionStringName(MESDbProperties.ConnectionStringName)]
    public interface IMESDbContext : IEfCoreDbContext
    {
        DbSet<Order> Orders { get; }
    }
}