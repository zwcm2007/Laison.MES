using System;
using System.Collections.Generic;
using System.Linq;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Laison.MES.Domain
{
    /// <summary>
    /// An order entity that is an aggregate root
    /// </summary>
    public class Order : AggregateRoot<Guid>, IHasCreationTime
    {
        /// <summary>
        /// customer id
        /// </summary>
        public Guid CustomerId { get; protected set; }

        /// <summary>
        /// amount of money
        /// </summary>
        public double TotalMoney { get; protected set; }

        /// <summary>
        /// create time
        /// </summary>
        public DateTime CreationTime { get; protected set; }

        /// <summary>
        /// sub-collecton of OrderLine
        /// </summary>
        public ICollection<OrderLine> OrderLines { get; protected set; }

        protected Order()
        {
        }

        public Order(Guid id, Guid customerId)
        {
            Id = id;
            CustomerId = customerId;
            OrderLines = new List<OrderLine>();
        }

        public void AddProduct(Guid productId, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentException("You can not add zero or negative count of products!", nameof(count));
            }

            var existingLine = OrderLines.FirstOrDefault(ol => ol.ProductId == productId);
            if (existingLine == null)
            {
                OrderLines.Add(new OrderLine(Id, productId, count));
            }
            else
            {
                existingLine.ChangeCount(existingLine.Count + count);
            }
        }
    }
}