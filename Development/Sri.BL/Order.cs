
using System;
using System.Collections.Generic;

namespace Sri.BL
{
    public class Order
    {
        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        /// <summary>
        /// 
        /// </summary>
        public int OrderId { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTimeOffset? OrderDate { get; set; }

        public int CustomerId { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public int ShippingAddressId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
