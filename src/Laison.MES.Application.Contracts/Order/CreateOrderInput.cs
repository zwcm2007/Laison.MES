using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Laison.MES.Application.Contracts
{
    /// <summary>
    /// create order dto
    /// </summary>
    public class CreateOrderInput
    {
        /// <summary>
        /// key of buyer
        /// </summary>
        [Required]
        public Guid CustomerId { get; set; }

        /// <summary>
        /// collection of order details
        /// </summary>
        [Required]
        public ICollection<OrderLineDto> OrderLines { get; set; }
    }

    public class OrderLineDto
    {
        public Guid ProductId { get; set; }

        public int Count { get; set; }
    }
}