using Laison.Lapis.Shared.Application;
using Laison.Lapis.Shared.EntityFrameworkCore;
using Laison.MES.Domain.Shared;
using Laison.MES.EntityFrameworkCore;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Laison.MES.Application
{
    public abstract class MESAppServiceBase : LapisAppService
    {
        protected MESAppServiceBase()
        {
            ObjectMapperContext = typeof(LapisMESApplicationModule);
            LocalizationResource = typeof(MESResource);
        }
    }

    public abstract class MESCrudAppServiceBase<TEntity, TEntityDto, TKey, TGetListInput, TCreateInput, TUpdateInput> : MESCrudAppServiceBase<TEntity, TEntityDto, TEntityDto, TKey, TGetListInput, TCreateInput, TUpdateInput>
        where TEntity : class, IEntity<TKey>
        where TEntityDto : IEntityDto<TKey>
    {
        protected MESCrudAppServiceBase(IRepository<TEntity, TKey> repository)
            : base(repository)
        {

        }
    }

    public abstract class MESCrudAppServiceBase<TEntity, TGetOutputDto, TGetListOutputDto, TKey, TGetListInput, TCreateInput, TUpdateInput> : LapisCrudAppService<TEntity, TGetOutputDto, TGetListOutputDto, TKey, TGetListInput, TCreateInput, TUpdateInput>
          where TEntity : class, IEntity<TKey>
          where TGetOutputDto : IEntityDto<TKey>
          where TGetListOutputDto : IEntityDto<TKey>
    {
        protected ISqlExecuter<IMESDbContext> SqlExecuter => LazyServiceProvider.LazyGetRequiredService<ISqlExecuter<IMESDbContext>>();

        protected MESCrudAppServiceBase(IRepository<TEntity, TKey> repository)
           : base(repository)
        {
            ObjectMapperContext = typeof(LapisMESApplicationModule);
            LocalizationResource = typeof(MESResource);
        }
    }
}
