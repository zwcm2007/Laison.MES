using System;
using Volo.Abp.Domain.Entities;

namespace Laison.MES.Domain
{
    /// <summary>
    /// An entity which belongs to Order arregate
    /// </summary>
    public class OrderLine : Entity
    {
        /// <summary>
        /// an order primary key
        /// </summary>
        /// </summary>
        public Guid OrderId { get; protected set; }

        /// <summary>
        /// Navigation property
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// a product primary key
        /// </summary>
        public Guid ProductId { get; protected set; }

        /// <summary>
        /// count of product
        /// </summary>
        public virtual int Count { get; protected set; }

        protected OrderLine()
        {
        }

        internal OrderLine(Guid orderId, Guid productId, int count)
        {
            OrderId = orderId;
            ProductId = productId;
            Count = count;
        }

        /// <summary>
        /// change product count
        /// </summary>
        internal void ChangeCount(int count)
        {
            Count = count;
        }

        public override object[] GetKeys()
        {
            return new object[] { OrderId, ProductId };
        }
    }
}