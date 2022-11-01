using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Laison.MES.EntityFrameworkCore
{
    public class MESHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<MESHttpApiHostMigrationsDbContext>
    {
        public MESHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var connStr = configuration.GetConnectionString("MES");
            var builder = new DbContextOptionsBuilder<MESHttpApiHostMigrationsDbContext>()
                       .UseSqlServer(connStr);
                     //.UseMySql(connStr, ServerVersion.AutoDetect(connStr));


            return new MESHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}