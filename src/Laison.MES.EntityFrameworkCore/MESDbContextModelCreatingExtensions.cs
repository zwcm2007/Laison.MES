using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using Volo.Abp;

namespace Laison.MES.EntityFrameworkCore
{
    public static class MESDbContextModelCreatingExtensions
    {
        public static void ConfigureMES(
            this ModelBuilder builder,
            Action<MESModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //var options = new MESModelBuilderConfigurationOptions(
            //    MESDbProperties.DbTablePrefix,
            //    MESDbProperties.DbSchema
            //);

            //optionsAction?.Invoke(options);
        }
    }
}