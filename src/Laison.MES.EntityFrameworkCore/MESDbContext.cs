using Microsoft.EntityFrameworkCore;
using Laison.MES.Domain;
using Laison.MES.Domain.Shared;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.MES.EntityFrameworkCore
{
    [ConnectionStringName(MESDbProperties.ConnectionStringName)]
    public class MESDbContext : AbpDbContext<MESDbContext>, IMESDbContext
    {
        public DbSet<Order> Orders { get; set; }

        public MESDbContext(DbContextOptions<MESDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureMES();
        }
    }
}