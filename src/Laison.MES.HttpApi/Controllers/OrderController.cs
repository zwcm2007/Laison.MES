using Microsoft.AspNetCore.Mvc;
using Laison.MES.Application.Contracts;
using System;
using System.Threading.Tasks;
using Volo.Abp;

namespace Laison.MES.HttpApi
{
    [RemoteService]
    [Route("api/MES/order")]
    public class OrderController : MESControllerBase, IOrderAppService
    {
        private readonly IOrderAppService _orderAppService;

        public OrderController(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }

        [HttpGet]
        public Task<OrderDto> GetOrderDetailsAsync([FromQuery] Guid id)
        {
            return _orderAppService.GetOrderDetailsAsync(id);
        }

        [HttpPost]
        public Task CreateOrderAsync(CreateOrderInput input)
        {
            return _orderAppService.CreateOrderAsync(input);
        }
    }
}