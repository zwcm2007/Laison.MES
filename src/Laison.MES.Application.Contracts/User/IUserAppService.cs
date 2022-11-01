using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Laison.MES.Application.Contracts
{
    public interface IUserAppService : IApplicationService
    {
        Task<CurrentUser> GetCurrentUserAsync();
    }
}