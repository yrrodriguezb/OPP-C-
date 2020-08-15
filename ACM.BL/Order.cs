using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        /// <summary>Retrieve one order</summary>
        public Order Retrieve(int customerId)
        {
            return new Order();
        }

        /// <summary>Retrieve all orders</summary>
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        /// <summary>Save the order customer</summary>
        public bool Save()
        {
            return true;
        }

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
