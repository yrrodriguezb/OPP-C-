using System;
using System.Collections.Generic;

namespace ACM.BL
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

        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        /// <summary>Validates the order data</summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (IsNull(OrderDate))
                isValid = false;

            return isValid;
        }

        private bool IsNullOrWhiteSpace(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        private bool IsNull(DateTimeOffset? date)
        {
            return date == null;
        }
    }
}
