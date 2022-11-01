using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.MES.EntityFrameworkCore
{
    public class MESModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public MESModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}