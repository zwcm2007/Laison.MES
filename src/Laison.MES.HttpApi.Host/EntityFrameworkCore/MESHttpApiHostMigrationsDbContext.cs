using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.MES.EntityFrameworkCore
{
    public class MESHttpApiHostMigrationsDbContext : AbpDbContext<MESHttpApiHostMigrationsDbContext>
    {
        public MESHttpApiHostMigrationsDbContext(DbContextOptions<MESHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureMES();
        }
    }
}
