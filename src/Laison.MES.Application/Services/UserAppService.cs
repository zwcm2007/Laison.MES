using Laison.MES.Application.Contracts;
using Laison.MES.Domain;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Volo.Abp.Uow;
using Volo.Abp.Users;
using CurrentUser = Laison.MES.Application.Contracts.CurrentUser;

namespace Laison.MES.Application
{
    /// <summary>
    /// 用户应用服务
    /// </summary>
    public class UserAppService : MESAppServiceBase, IUserAppService
    {
        //private readonly IOrderRepository _orderRepository;

        private readonly HttpClient _httpClient;

        public UserAppService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CurrentUser> GetCurrentUserAsync()
        {
            return await _httpClient.GetFromJsonAsync<CurrentUser>("data/current_user.json");

        }


    }
}