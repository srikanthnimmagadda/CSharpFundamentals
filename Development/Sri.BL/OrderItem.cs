
using System;

namespace Sri.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        /// <summary>
        /// 
        /// </summary>
        public int OrderItemId { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public decimal? PurchacePrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0 || ProductId <= 0 || PurchacePrice == null) isValid = false;
            return isValid;
        }
    }
}
