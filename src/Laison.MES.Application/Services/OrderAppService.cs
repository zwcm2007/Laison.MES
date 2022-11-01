using Laison.MES.Application.Contracts;
using Laison.MES.Domain;
using System;
using System.Threading.Tasks;
using Volo.Abp.Uow;

namespace Laison.MES.Application
{
    /// <summary>
    /// Order Application Service
    /// </summary>
    public class OrderAppService : MESAppServiceBase, IOrderAppService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderAppService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [UnitOfWork]
        public async Task CreateOrderAsync(CreateOrderInput input)
        {
            var order = new Order(GuidGenerator.Create(), input.CustomerId);

            foreach (var item in input.OrderLines)
            {
                order.AddProduct(item.ProductId, item.Count);
            }
            await _orderRepository.InsertAsync(order);
        }

        public Task<OrderDto> GetOrderDetailsAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}